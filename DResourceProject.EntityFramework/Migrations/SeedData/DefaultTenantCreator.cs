using System.Linq;
using DResourceProject.EntityFramework;
using DResourceProject.MultiTenancy;

namespace DResourceProject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly DResourceProjectDbContext _context;

        public DefaultTenantCreator(DResourceProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
