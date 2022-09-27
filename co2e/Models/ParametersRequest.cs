using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.Models
{
    public class ParametersRequest
    {
        public int weight { get; set; }
        public string weight_unit { get; set; }
        public int distance { get; set; }
        public string distance_unit { get; set; }
    }

}
