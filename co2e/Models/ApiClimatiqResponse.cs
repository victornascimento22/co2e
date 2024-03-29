﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.Models
{
    public class ApiClimatiqResponse
    {

        public int Id_ApiClimatiqResponse { get; set; }

        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public EmissionFactor EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ConstituentGases ConstituentGases { get; set; }





    }
}
