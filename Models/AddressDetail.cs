using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleTrackingApi.Models
{
    public class AddressDetail
    {
        public string road { get; set; }
        public string neighbourhood { get; set; }
        public string suburb { get; set; }
        public string city_district { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string state_district { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
    }
}
