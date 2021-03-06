﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PickyApi.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("Weebhook ready");
        }

        [HttpPost]
        public IActionResult WebHook([FromBody] InputMessage mensagem)
        {
            Resposta retorno = null;

            if (mensagem.Message.ToLower() == "menu") // solicitação de menu
            {
                retorno = new Resposta { MessageOut = "Menu \n\r 1-Enviar receita \n\r 2-Meus pedidos \n\r 9-Dizer algo", Delay = "0", Type = "1" };
                return Ok(retorno);
            }
            

            if (mensagem.Message == "1") // solicitação de envio de imagem
            {
                retorno = new Resposta { MessageOut = "Por favor usar o link https://pickyapi20200130112213.azurewebsites.net/Upload para enviar a sua receita",  Delay = "0", Type = "1" };
                return Ok(retorno);
            }

                        
            retorno = new Resposta { MessageOut = "Mensagem recebida: seu numero é:" + mensagem.Number , Delay = "0", Type = "1" };
            return Ok(retorno);
        }
    }
}