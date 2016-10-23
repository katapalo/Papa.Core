using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Repositories
{
    public interface IRepository1<T> where T : class
    {

        /// <summary>
        /// Modifica el id de la entidad con el id generado
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Add(T entity);
        IEnumerable<T> GetAll();
        T Get(int id);
        void Remove(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Update(T entity);
        void Save(T entity);

    }
}
