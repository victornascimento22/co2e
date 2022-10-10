using AutoMapper;
using co2e.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.DataObjectTransfer
{
    
    public class ConstituentGasesDTO
    {
     
        public int Id_ConstituentGases { get; set; }
       
        public double co2e_total { get; set; }
    
        public string co2e_other { get; set; }
   
        public double co2 { get; set; }
     
        public double ch4 { get; set; }
       
        public double n2o { get; set; }

    }
}
