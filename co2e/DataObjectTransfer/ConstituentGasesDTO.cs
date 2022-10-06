using AutoMapper;
using co2e.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.DataObjectTransfer
{
    [AutoMap(typeof(ConstituentGases))]
    public class ConstituentGasesDTO
    {
        [SourceMember(nameof(ConstituentGases.Id_ConstituentGases))]
        public int Id_ConstituentGases { get; set; }
        [SourceMember(nameof(ConstituentGases.co2e_total))]
        public double co2e_total { get; set; }
        [SourceMember(nameof(ConstituentGases.co2e_other))]
        public string co2e_other { get; set; }
        [SourceMember(nameof(ConstituentGases.co2))]
        public double co2 { get; set; }
        [SourceMember(nameof(ConstituentGases.ch4))]
        public double ch4 { get; set; }
        [SourceMember(nameof(ConstituentGases.n2o))]
        public double n2o { get; set; }

    }
}
