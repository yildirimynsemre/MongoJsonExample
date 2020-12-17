using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonExp004.Models
{
    public class Company : MongoBaseModel
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("VKN")]
        public int VKN { get; set; }
        [BsonElement("Address")]
        public string Address { get; set; }
    }
}
