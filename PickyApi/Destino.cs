using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickyApi
{
    public class Destino
    {
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
