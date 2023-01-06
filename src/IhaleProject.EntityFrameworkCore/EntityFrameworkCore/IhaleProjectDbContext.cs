using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using IhaleProject.Authorization.Roles;
using IhaleProject.Authorization.Users;
using IhaleProject.MultiTenancy;
using IhaleProject.Domain.Birim;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Ihale;
using IhaleProject.Domain.Email;

namespace IhaleProject.EntityFrameworkCore
{
    public class IhaleProjectDbContext : AbpZeroDbContext<Tenant, Role, User, IhaleProjectDbContext>
    {
		/* Define a DbSet for each entity of the application */
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            //will add table names
			base.OnModelCreating(modelBuilder);
            
		}
		public DbSet<BirimEntity> Birim { get; set; }
        public DbSet<AlimTuruEntity> AlimTuru { get; set; }
        public DbSet<AlimUsuluEntity> AlimUsulu { get; set; }
        public DbSet<IhaleEntity> Ihale { get; set; }
        public DbSet<EmailEntity> Email { get; set; }
        
        public IhaleProjectDbContext(DbContextOptions<IhaleProjectDbContext> options)
            : base(options)
        {
        }
    }
}
