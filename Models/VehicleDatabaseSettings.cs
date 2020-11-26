using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleTrackingApi.Models
{
    public class VehicleDatabaseSettings : IVehicleDatabaseSettings
    {
        public string VehicleCollectionName { get; set; }
        public string VehicleHistoryCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
