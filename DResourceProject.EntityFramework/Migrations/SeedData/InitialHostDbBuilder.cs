using DResourceProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace DResourceProject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly DResourceProjectDbContext _context;

        public InitialHostDbBuilder(DResourceProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
