using co2e.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e
{
    public class ApiResponseMapper
    {

        
        public double Co2e { get; set; }


        public string Co2eUnit { get; set; }


        public string Co2eCalculationMethod { get; set; }


        public string Co2eCalculationOrigin { get; set; }


        public EmissionFactorRequest EmissionFactor { get; set; }


        public ConstituentGasesResponse ConstituentGases { get; set; }

    }
}
