using Microsoft.AspNetCore.Mvc;
using PagSeguroApi.Model;
using PagSeguroApi.Services.Impl;
using PagSeguroApi.Services.Interface;
using System;
using System.Threading.Tasks;

namespace PagSeguroApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private ISessionService sessionService;

        public SessionController()
        {
            sessionService = new SessionService();
        }

        [HttpPost]
        public async Task<IActionResult> Obter([FromBody] SessionRequest sessionRequest)
        {
            try
            {
                SessionResponse retorno = await sessionService.Obter(sessionRequest);
                return new ObjectResult(retorno);
            }
            catch (Exception e)
            {
                return BadRequest(new { Mensagem = e.Message, Error = true });
            }
            
        }
    }
}