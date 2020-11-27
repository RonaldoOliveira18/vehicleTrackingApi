using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;

namespace vehicleTrackingApi.Repository
{
    public class AddressCordinatesRepository : IAddressCordinatesRepository
    {
        public readonly IMongoCollection<AddressCordinates> _addressCordinates;

        public AddressCordinatesRepository(IConfigMap settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _addressCordinates = database.GetCollection<AddressCordinates>(settings.AddressCordinatesCollectionName);
        }

        public void insert(AddressCordinates addressCordinates) => _addressCordinates.InsertOneAsync(addressCordinates);

        public AddressCordinates Get(decimal lat, decimal longi) =>
       _addressCordinates.Find<AddressCordinates>(add => add.Latitude == lat && add.Longitude == longi).FirstOrDefault();
    }
}
