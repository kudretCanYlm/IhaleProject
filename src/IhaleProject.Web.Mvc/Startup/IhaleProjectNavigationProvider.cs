using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using IhaleProject.Authorization;
using Microsoft.AspNetCore.Rewrite;
using System.Drawing;

namespace IhaleProject.Web.Startup
{
	/// <summary>
	/// This class defines menus for the application.
	/// </summary>
	public class IhaleProjectNavigationProvider : NavigationProvider
	{
		public override void SetNavigation(INavigationProviderContext context)
		{
			context.Manager.MainMenu
                .AddItem(
                new MenuItemDefinition(
                    "Anasayfa",
                    L("Home"),
                    url: "Home/Index",
                    icon: "fa fa-square",
                    permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Home)
                    )
                )

                .AddItem(
				new MenuItemDefinition(
					"İhale İşlemleri",
					L("IhaleIslemleri"),
					icon: "fas fa-building"
					).AddItem(
				new MenuItemDefinition(
					PageNames.Ihale,
					L("Ihale"),
					url: "Ihale/Index",
					icon: "fa fa-square",
					permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Ihale)
					)
				).AddItem(
				new MenuItemDefinition(
					PageNames.Arsiv,
					L("Arsiv"),
					url: "Arsiv/Index",
					icon: "fa fa-square",
					permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Arsiv)
					)
				)
				.AddItem(
				new MenuItemDefinition(
					PageNames.TumYayinlar,
					L("TumYayinlar"),
					url: "TumYayinlar/Index",
					icon: "fa fa-square",
					permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_TumYayinlar)
					)
				)
				.AddItem(
				new MenuItemDefinition(
					PageNames.KaldirilmisYayinlar,
					L("KaldirilmisYayinlar"),
					url: "KaldirilmisYayinlar/Index",
					icon: "fa fa-square",
					permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_KaldirilmisYayinlar)
					)
				).AddItem(
				new MenuItemDefinition(
					PageNames.SuresiBitmisYayinlar,
					L("SuresiBitmisYayinlar"),
					url: "SuresiBitmisYayinlar/Index",
					icon: "fa fa-square",
					permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_SuresiBitmisYayinlar)
					)
				)
				)
				.AddItem(new MenuItemDefinition(
					"Parametreler",
					L("Parametreler"),
					icon: "fas fa-cubes"
					).AddItem(
					new MenuItemDefinition(
						PageNames.Birim,
						L("Birim"),
						url: "Birim/Index",
						icon: "fa fa-circle",
						permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Birim)
					)
					).AddItem(
					new MenuItemDefinition(
						PageNames.AlimTuru,
						L("AlimTuru"),
						url: "AlimTuru/Index",
						icon: "fa fa-circle",
						permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_AlimTuru)
					)
					).AddItem(
					new MenuItemDefinition(
						PageNames.AlimUsulu,
						L("AlimUsulu"),
						url: "AlimUsulu/Index",
						icon: "fa fa-circle",
						permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_AlimUsulu)
					)
				)
				)

				.AddItem(
					new MenuItemDefinition(
						PageNames.Roles,
						L("Roles"),
						url: "Roles/Index",
						icon: "fas fa-theater-masks",
						permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
					)
				)


				.AddItem(
					new MenuItemDefinition(
						PageNames.Users,
						L("Users"),
						url: "Users/Index",
						icon: "fas fa-users",
						permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
					)
				)

				.AddItem(
					new MenuItemDefinition(
						PageNames.Tenants,
						L("Tenants"),
						url: "Tenants",
						icon: "fas fa-building",
						permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenants)
					)
				)
				;
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, IhaleProjectConsts.LocalizationSourceName);
		}
	}
}