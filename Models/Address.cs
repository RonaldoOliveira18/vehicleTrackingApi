using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleTrackingApi.Models
{
    public class Address
    {
        public string display_name { get; set; }
        public AddressDetail address { get; set; }
    }
}
