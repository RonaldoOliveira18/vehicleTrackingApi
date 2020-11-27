using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleTrackingApi.Models
{
    public class AddressCordinates
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Address Address { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
