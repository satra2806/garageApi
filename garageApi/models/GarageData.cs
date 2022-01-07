using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace garageApi
{
    public class GarageData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("cars")]
        public object cars { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("location")]
        public object location { get; set; }

    }


}
