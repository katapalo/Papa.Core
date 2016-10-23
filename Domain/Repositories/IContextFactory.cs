using Papa.Core.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Repositories
{
    /// <summary>
    /// Creates instance of specific DbContext
    /// </summary>
    public interface IDbContextFactory //: IDisposable  //NOTE: Since UnitOfWork is disposable I am not sure if context factory has to be also...
    {
        ApplicationDbContext GetDbContext();
    }

    public class DbContextFactory : IDbContextFactory
    {
        private readonly ApplicationDbContext _context;

        public DbContextFactory()
        {
            // the context is new()ed up instead of being injected to avoid direct dependency on EF
            // not sure if this is good approach...but it removes direct dependency on EF from web tier
            _context = new EF.ApplicationDbContext();            
        }

        public ApplicationDbContext GetDbContext()
        {
            return _context;
        }

        // see comment in IDbContextFactory inteface...
        //public void Dispose()
        //{
        //    if (_context != null)
        //    {
        //        _context.Dispose();
        //        GC.SuppressFinalize(this);
        //    }
        //}
    }

}
