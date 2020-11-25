using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;

namespace vehicleTrackingApi.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IMongoCollection<Vehicles> _vehicles;

        public VehicleService(IVehicleDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _vehicles = database.GetCollection<Vehicles>(settings.VehicleCollectionName);
        }
        public Vehicles Get(string id)
        {
            var serializer = new BsonArraySerializer();

            var x=   _vehicles.Find<Vehicles>(car => car.Id == id).FirstOrDefault();

            return x;

        }
    }
}
