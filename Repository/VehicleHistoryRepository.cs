using MongoDB.Driver;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;

namespace vehicleTrackingApi.Repository
{
    public class VehicleHistoryRepository : IVehicleHistoryRepository
    {
        public readonly IMongoCollection<VehiclesHistory> _vehiclesHistory;

        public VehicleHistoryRepository(IVehicleDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _vehiclesHistory = database.GetCollection<VehiclesHistory>(settings.VehicleHistoryCollectionName);
        }

        public void insert(VehiclesHistory history) => _vehiclesHistory.InsertOneAsync(history);
    }
}
