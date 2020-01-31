using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickyApi
{
    public class InputMessage
    {
        public string Number { get; set; }
        [JsonProperty("message-in")]
        public string Message { get; set; }
        public string Type { get; set; }
        public string Application { get; set; }
        [JsonProperty("unique-id")]
        public string UniqueId { get; set; }
        [JsonProperty("project-id")]
        public string ProjectId { get; set; }
        [JsonProperty("media-url")]
        public string MediaUrl { get; set; }
        [JsonProperty("custom-variable")]
        public string CustomVariable { get; set; }

    }
}
