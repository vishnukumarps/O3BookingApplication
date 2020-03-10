using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApp.DataModel
{
    public class Service
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServiceName { get; set; }
        public float Prize { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
