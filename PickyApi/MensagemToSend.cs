using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickyApi
{
    public class MensagemToSend
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("application")]
        public string Application { get; private set; }
        [JsonProperty("priority")]
        public string Priority { get; private set; }
        [JsonProperty("data")]
        public IList<Destino> Data { get; set; }

        public MensagemToSend(string telefone, string mensagem)
        {
            this.Token = "ebfb1d1e479810746a4a10842b8277bd31a18809";
            this.Application = "1";
            this.Priority = "0";
            Data = new List<Destino>();
            Data.Add(new Destino { Number = telefone, Message = mensagem });            
        }

        
    }
}
