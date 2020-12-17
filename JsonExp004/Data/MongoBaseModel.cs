using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonExp004.Models
{
    public abstract class MongoBaseModel
    {
        public ObjectId Id { get; set; }
    }
}
