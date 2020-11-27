using MongoDB.Driver;
using System;
using System.Collections.Generic;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;

namespace vehicleTrackingApi.Repository
{
    public class VehicleHistoryRepository : IVehicleHistoryRepository
    {
        public readonly IMongoCollection<VehiclesHistory> _vehiclesHistory;

        public VehicleHistoryRepository(IConfigMap settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _vehiclesHistory = database.GetCollection<VehiclesHistory>(settings.VehicleHistoryCollectionName);
        }

        public void insert(VehiclesHistory history) => _vehiclesHistory.InsertOneAsync(history);
        public List<VehiclesHistory> -(DateTime VehicleIdentificationIn, DateTime VehicleIdentificationUntil) =>
   _vehiclesHistory.Find<VehiclesHistory>(car => car.DateLocalization >= VehicleIdentificationIn && car.DateLocalization<= VehicleIdentificationUntil).ToList();

        public List<VehiclesHistory> Get(string VehicleIdentification) =>
       _vehiclesHistory.Find<VehiclesHistory>(car => car.VehicleIdentification == VehicleIdentification).ToList();
    }
}
