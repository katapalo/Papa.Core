using Papa.Core.Domain.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Entities
{
    public class Campana : FieldsCampana
    {
        [ForeignKey("IdAccion")]
        public virtual Accion FkAccion { get; set; }        
    }
}
