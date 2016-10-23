using Papa.Core.Domain.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Entities
{
    public class Accion : FieldsAccion, ISoftDelete
    {
        public bool isDeleted { get; set; }
       
    }

    //public class Accion : FieldsAccion1
    //{

    //}
}
