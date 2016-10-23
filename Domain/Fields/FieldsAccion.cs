using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Fields
{
    public abstract class FieldsAccion : Bases.EntityBase, IAccion
    {        
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCampana { get; set; }
    }
    public interface FieldsAccion1
    {
        [Key]
        int Id { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
    }
}
