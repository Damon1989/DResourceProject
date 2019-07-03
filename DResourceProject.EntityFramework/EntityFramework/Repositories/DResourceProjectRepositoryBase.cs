using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DResourceProject.EntityFramework.Repositories
{
    public abstract class DResourceProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DResourceProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DResourceProjectRepositoryBase(IDbContextProvider<DResourceProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DResourceProjectRepositoryBase<TEntity> : DResourceProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DResourceProjectRepositoryBase(IDbContextProvider<DResourceProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
