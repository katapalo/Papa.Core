using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Bases
{
    public interface IEntityBase
    {
        int Id { get; set; }
        int ClientId { get; set; }
    }
    public abstract class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public EntityBase()
        {
            ClientId = 1;
        }
    }
}
