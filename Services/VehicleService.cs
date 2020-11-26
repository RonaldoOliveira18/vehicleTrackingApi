using ServiceStack;
using System;
using System.Collections.Generic;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;
namespace vehicleTrackingApi.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehiclesRepository;
        private readonly IVehicleHistoryRepository _vehiclesHistoryRepository;

        public VehicleService(IVehicleRepository vehiclesRepository, IVehicleHistoryRepository vehiclesHistoryRepository)
        {
            _vehiclesRepository = vehiclesRepository;
            _vehiclesHistoryRepository = vehiclesHistoryRepository;
        }
        public Vehicles Get(string VehicleIdentification) =>
           _vehiclesRepository.Get(VehicleIdentification);

        public List<VehiclesHistory> GetHistory(string VehicleIdentification) =>
            _vehiclesHistoryRepository.Get(VehicleIdentification);
        
        public List<VehiclesHistory> GetVehicleHistoryBetweenPeriod(DateTime VehicleIdentificationIn, DateTime VehicleIdentificationUntil) =>
               _vehiclesHistoryRepository.GetVehicleHistoryBetweenPeriod(VehicleIdentificationIn, VehicleIdentificationUntil);
        private void saveHistory(VehiclesHistory history)
        {
            history.DateLocalization = DateTime.Now;
            _vehiclesHistoryRepository.insert(history);
        }

        public Vehicles Tracking(Vehicles vehiclesParam)
        {
            VehiclesHistory history = new VehiclesHistory();
            history.Latitude = vehiclesParam.LastLatitude;
            history.Longitude = vehiclesParam.LastLongitude;

            var vehicle = _vehiclesRepository.Get(vehiclesParam?.VehicleIdentification);

            if (vehicle == null) {
                _vehiclesRepository.insert(vehiclesParam);             
                history.VehicleIdentification = vehiclesParam.VehicleIdentification;
                history.VehicleName = vehiclesParam.VehicleName;
                
                saveHistory(history);
            }
            else
            {
                vehicle.LastLatitude = vehiclesParam.LastLatitude;
                vehicle.LastLongitude = vehiclesParam.LastLongitude;
                _vehiclesRepository.update(vehicle);

                history.VehicleIdentification = vehicle.VehicleIdentification;
                history.VehicleName = vehicle.VehicleName;
                saveHistory(history);
            }           

            return vehicle;
        }        
    }
}
