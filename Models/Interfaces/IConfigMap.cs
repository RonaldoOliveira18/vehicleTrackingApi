using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleTrackingApi.Models
{
    public interface IConfigMap
    {
        string VehicleCollectionName { get; set; }
        string VehicleHistoryCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        public string AddressAPI { get; set; }
        public string AddressAPIKey { get; set; }
    }
}
