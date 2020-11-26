using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;

namespace vehicleTrackingApi.Repository.Interfaces
{
    public interface IVehicleRepository
    {
        public Vehicles Get(string VehicleIdentification);
        public void insert(Vehicles vehicle);
        public void update(Vehicles vehicle);
    }
}
