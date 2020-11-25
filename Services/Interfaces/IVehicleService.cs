using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;

namespace vehicleTrackingApi.Services
{
    public interface IVehicleService
    {
        public Vehicles Get(string id);
    }
}
