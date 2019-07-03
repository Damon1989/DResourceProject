using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using DResourceProject.EntityFramework;

namespace DResourceProject.Migrator
{
    [DependsOn(typeof(DResourceProjectDataModule))]
    public class DResourceProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<DResourceProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}