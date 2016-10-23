using Papa.Core.Domain.Entities;
using Papa.Core.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Repositories
{
    public class Repository1<T> : IRepository1<T> where T : class
    {
        public ApplicationDbContext db { get; set; }
        public Repository1()
        {
            db = new ApplicationDbContext();
        }
        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();            
        }
        public T Get(int id)
        {            
            return db.Set<T>().Find(id);            
        }

        public void Remove(string id)
        {
            
        }
        public void Update(T entity)
        {

        }
        public void Save(T entity)
        {
            
            db.SaveChanges();
        }
        public IList<LogCambioHead> GetBooksByPage(int page, int itemsPerPage)
        {
            return db.LogCambioHead.Skip(itemsPerPage * (page - 1)).Take(itemsPerPage).ToList();
        }

    }
}
