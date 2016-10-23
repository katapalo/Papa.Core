using Papa.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Repositories
{
    public class RepositoryLogHead : Repository<Entities.LogCambioHead>        
    {
        public RepositoryLogHead(IDbContextFactory context) : base(context)
        {

        }
        public IList<LogModel> GetLogs()
        {            
            var res = (from a in db.LogCambioHead
                       join b in db.LogCambiosDetail on a.Id equals b.Id
                       group a by b.LogCambioHeadId into g
                       select new LogModel()
                       {
                           Id = g.Key,
                           valor1 = g.Count(),
                           valor2 = g.Sum(g1 => g1.Id)
                       }).ToList<LogModel>();
            return res;
        }
    }
}
