using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using N1Project.Entities.Context;
using N1Project.Entities.Tables;


namespace N1Project.Entities.Interfaces
{
    namespace N1Project.Entities.Interfaces
    {
        public interface IEntityRepositoryBase<TContext, TEntity>
            where TContext : DbContext, new()
            where TEntity : class, IEntity, new()



        {


            void AddOrUpdate(TContext context, TEntity entity);


            void Delete(TContext context, Expression<Func<TEntity, bool>> filter);


            void Save(TContext context);

        }
    }
}