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
                Response response = new Response
                {
                    Status = "success",
                    Message = "ID da sessão obtido com sucesso",
                    Error = false,
                    Data = retorno
                };

                return new ObjectResult(response);
            }
            catch (Exception e)
            {
                Response response = new Response
                {
                    Status = "error",
                    Message = e.Message,
                    Error = true,
                    Data = null

                };
                //return StatusCode(500, response);
                return BadRequest(response);
            }
            
        }
    }
}