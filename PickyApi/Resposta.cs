using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickyApi
{
    public class Resposta
    {
        [JsonProperty("message-out")]
        public string MessageOut { get; set; }
        public string Delay { get; set; }
        public string Type { get; set; }
    }
}
