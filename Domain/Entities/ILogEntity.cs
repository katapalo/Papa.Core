using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Interfaces
{
    public interface ILogEntity
    {
        DateTime FechaModificacionEntidad { get; set; }
        int IdUserCreate { get; set; }
        int IdUserUpdate { get; set; } 
    }
}
