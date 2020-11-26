using MongoDB.Driver;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;

namespace vehicleTrackingApi.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IMongoCollection<Vehicles> _vehicles;
        public VehicleRepository(IConfigMap settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _vehicles = database.GetCollection<Vehicles>(settings.VehicleCollectionName);
        }

        public Vehicles Get(string VehicleIdentification) =>
           _vehicles.Find<Vehicles>(car => car.VehicleIdentification == VehicleIdentification).FirstOrDefault();

        public void insert(Vehicles vehicle) => _vehicles.InsertOneAsync(vehicle);
        public void update(Vehicles vehicle) => _vehicles.ReplaceOneAsync(car => car.Id == vehicle.Id, vehicle);

    }
}
