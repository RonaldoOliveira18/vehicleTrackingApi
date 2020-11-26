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
        public Vehicles Tracking(Vehicles vehicles);
        public List<VehiclesHistory> GetVehicleHistoryBetweenPeriod(DateTime VehicleIdentificationIn, DateTime VehicleIdentificationUntil);
        public List<VehiclesHistory> GetHistory(string VehicleIdentification);
    }
}
