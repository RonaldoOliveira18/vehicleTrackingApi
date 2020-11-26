using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;

namespace vehicleTrackingApi.Services.Interfaces
{
    public interface IAddressService
    {
        public Address getLocationVehicle(string VehicleIdentification);
    }
}
