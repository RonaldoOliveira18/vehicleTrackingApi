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
    }
}
