using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;

namespace vehicleTrackingApi.Repository.Interfaces
{
    public interface IVehicleHistoryRepository
    {
        void insert(VehiclesHistory history);
        public List<VehiclesHistory> GetVehicleHistoryBetweenPeriod(DateTime VehicleIdentificationIn, DateTime VehicleIdentificationUntil);
        public List<VehiclesHistory> Get(string VehicleIdentification);

    }
}
