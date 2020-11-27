using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleTrackingApi.Models
{
    public class ConfigMap : IConfigMap
    {
        public string VehicleCollectionName { get; set; }
        public string VehicleHistoryCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string AddressAPI { get; set; }
        public string AddressAPIKey { get; set; }
        public string AddressCordinatesCollectionName { get; set; }
    }
}
