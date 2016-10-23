using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Entities
{
    public interface ISoftDelete
    {
        bool isDeleted { get; set; }
    }
}
