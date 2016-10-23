using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Papa.Core.Domain.Entities
{
    public class LogCambioDetail : Bases.EntityBase
    {
     //   public int Id { get; set; }
        public string NombreCampo { get; set; }        
        public string ValorAnterior { get; set; }
        public string ValorActual { get; set; }

        public int LogCambioHeadId { get; set; }
        public virtual LogCambioHead LogCambioHead { get; set; }

    }
}
