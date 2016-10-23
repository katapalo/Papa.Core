using Papa.Core.Domain.Bases;
using Papa.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa.Core.Domain.Fields
{
    public class FieldsAB : IA, IB
    {
        public int a1 { get; set; }
        public int a2 { get; set; }
        public int b1 { get; set; }
        public int b2 { get; set; }
    }
}
