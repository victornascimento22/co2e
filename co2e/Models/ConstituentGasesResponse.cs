using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.Models
{
    public class ConstituentGasesResponse
    {
        public double co2e_total { get; set; }
        public object co2e_other { get; set; }
        public double co2 { get; set; }
        public double ch4 { get; set; }
        public double n2o { get; set; }
    }

}
