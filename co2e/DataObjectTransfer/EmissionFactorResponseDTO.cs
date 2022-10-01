using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.DataObjectTransfer
{
    public class EmissionFactorResponseDTO
    {

        public string activity_id { get; set; }
        public string uuid { get; set; }
        public string id { get; set; }
        public string access_type { get; set; }
        public string source { get; set; }
        public string year { get; set; }
        public string region { get; set; }
        public string category { get; set; }
        public string lca_activity { get; set; }
        public List<object> data_quality_flags { get; set; }


    }
}
