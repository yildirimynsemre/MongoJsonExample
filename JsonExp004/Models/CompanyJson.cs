using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonExp004.Models
{
    public class CompanyJson : MongoBaseModel
    {
        [JsonProperty]
        public string Companies { get; set; }

    }
}
