using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Models
{
    public class LogModel : BaseModel
    {
        public string nombre { get; set; }
        public int valor1 { get; set; }
        public int valor2 { get; set; }

    }
}
