using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PickyApi.Controllers
{
    public class MensagensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Enviar(MensagemDto dto)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var mensagemToSend = new MensagemToSend(dto.Telefone, dto.Mensagem);
            string json = JsonConvert.SerializeObject(mensagemToSend, Formatting.Indented);

            var httpContent = new StringContent(json);  
            
            var response = await client.PostAsync("https://pickyassist.com/app/api/v2/push", httpContent );
            return RedirectToAction("Index");
        }
    }
}