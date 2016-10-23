using Papa.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Fields
{
    public abstract class FieldsCampana : Bases.EntityBase, ICampana
    {
      //  public int Id { get; set; }
        public int IdAccion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }   
        public ICollection<IAccion> Acciones { get; set; }
           
    }
}
