using Papa.Core.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Papa.Core.Domain.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
        //, Bases.IEntityBase
    {
        internal DbSet<TEntity> dbSet;
        internal ApplicationDbContext db { get; set; }
        
        public Repository(IDbContextFactory context)
        {
            // this.context = context.GetDbContext();
            this.db = context.GetDbContext();
            
            this.dbSet = this.db.Set<TEntity>();                        
        }
        public IQueryable<TEntity> Where(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }
        public TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        private int Insert(TEntity entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
            return (entity as Bases.EntityBase).Id;
        }
        public void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(TEntity entityToDelete)
        {
            if (db.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }
        private void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            db.Entry(entityToUpdate).State = EntityState.Modified;
            db.SaveChanges();
        }
        public int Save(TEntity entityToUpdate)
        {
            var entity = entityToUpdate as Bases.EntityBase;
            int Id = entity.Id;       
            if (entity.Id == 0) Id = Insert(entityToUpdate);
            else Update(entityToUpdate);
            return Id;
        }

        //public IList<LogCambioHead> GetBooksByPage(int page, int itemsPerPage)
        //{
        //    return db.LogCambioHead.Skip(itemsPerPage * (page - 1)).Take(itemsPerPage).ToList();
        //}
    }
}
