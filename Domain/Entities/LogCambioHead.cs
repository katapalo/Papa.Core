using Papa.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Papa.Core.Domain.Entities
{
    public class LogCambioHead : Bases.EntityBase
    {
        
       // public int Id { get; set; }
        public string Entidad { get; set; }
        public DateTime FechaCambio { get; set; }
        public string TipoCambio { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public int IdEntidad { get; set; }

        public virtual ICollection<LogCambioDetail> LogCambioDetail { get; set; } = new Collection<LogCambioDetail>();
    }
}
