using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace vehicleTrackingApi.Models
{
    public class Vehicles
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public int Id { get; set; }

        //[BsonElement("Name")]
        //public string Name { get; set; }

        //public string Model { get; set; }

        //public string identification { get; set; }

        //public Vehicles()
        //{
        //    vehicles = new List<Vehicle>().Cast<object>().ToArray();
        //}


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string VehicleIdentification { get; set; }
        public string VehicleName { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal LastLongitude { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal LastLatitude { get; set; }
    }
}
