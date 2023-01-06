﻿using System;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Abp.AspNetCore;
using Abp.AspNetCore.Mvc.Antiforgery;
using Abp.Castle.Logging.Log4Net;
using IhaleProject.Authentication.JwtBearer;
using IhaleProject.Configuration;
using IhaleProject.Identity;
using IhaleProject.Web.Resources;
using Abp.AspNetCore.SignalR.Hubs;
using Abp.Dependency;
using Abp.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;
using Newtonsoft.Json.Serialization;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Application.Contracts.AlimTuru;

namespace IhaleProject.Web.Startup
{
	public class Startup
	{
		private readonly IWebHostEnvironment _hostingEnvironment;
		private readonly IConfigurationRoot _appConfiguration;

		public Startup(IWebHostEnvironment env)
		{
			_hostingEnvironment = env;
			_appConfiguration = env.GetAppConfiguration();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			// MVC
			services.AddControllersWithViews(
					options =>
					{
						options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
						options.Filters.Add(new AbpAutoValidateAntiforgeryTokenAttribute());
					}
				)
				.AddRazorRuntimeCompilation()
				.AddNewtonsoftJson(options =>
				{
					options.SerializerSettings.ContractResolver = new AbpMvcContractResolver(IocManager.Instance)
					{
						NamingStrategy = new CamelCaseNamingStrategy()
					};
				});

			services.AddFluentValidation(fv
				=> fv.RegisterValidatorsFromAssemblyContaining<CreateBirimDtoValidator>());

			services.AddFluentValidation(fv
				=> fv.RegisterValidatorsFromAssemblyContaining<UpdateBirimDtoValidator>());
			
			services.AddFluentValidation(fv
				=> fv.RegisterValidatorsFromAssemblyContaining<CreateAlimTuruDTOValidator>());
			
			services.AddFluentValidation(fv
				=> fv.RegisterValidatorsFromAssemblyContaining<UpdateAlimTuruDTOValidator>());


			IdentityRegistrar.Register(services);
			AuthConfigurer.Configure(services, _appConfiguration);

			services.Configure<WebEncoderOptions>(options =>
			{
				options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
			});

			services.AddScoped<IWebResourceManager, WebResourceManager>();

			services.AddSignalR();

			// Configure Abp and Dependency Injection
			services.AddAbpWithoutCreatingServiceProvider<IhaleProjectWebMvcModule>(
				// Configure Log4Net logging
				options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
					f => f.UseAbpLog4Net().WithConfig(
						_hostingEnvironment.IsDevelopment()
							? "log4net.config"
							: "log4net.Production.config"
						)
				)
			);
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
		{
			app.UseAbp(); // Initializes ABP framework.

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();

			app.UseJwtTokenMiddleware();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapHub<AbpCommonHub>("/signalr");
				endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapControllerRoute("defaultWithArea", "{area}/{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
