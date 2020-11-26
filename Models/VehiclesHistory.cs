using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleTrackingApi.Models
{
    public class VehiclesHistory
    {
        public string VehicleIdentification { get; set; }
        public string VehicleName { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public DateTime DateLocalization { get; set; }
    }
}
