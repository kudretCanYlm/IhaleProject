using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using IhaleProject.Authorization.Roles;
using IhaleProject.Authorization.Users;
using IhaleProject.MultiTenancy;

namespace IhaleProject.EntityFrameworkCore
{
    public class IhaleProjectDbContext : AbpZeroDbContext<Tenant, Role, User, IhaleProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public IhaleProjectDbContext(DbContextOptions<IhaleProjectDbContext> options)
            : base(options)
        {
        }
    }
}
