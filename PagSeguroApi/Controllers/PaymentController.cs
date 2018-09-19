using Microsoft.AspNetCore.Mvc;
using PagSeguroApi.Model;
using PagSeguroApi.Services;
using PagSeguroApi.Services.Interface;
using PagSeguroApi.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PagSeguroApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private IPaymentService paymentService;

        public PaymentController()
        {
            paymentService = new PaymentService();
        }

        [HttpPost]
        public IActionResult CreditCard([FromBody] CreditCardRequest creditCardRequest)
        {
            try
            {
                string xmlTransaction = paymentService.CreditCardCheckout(creditCardRequest);

                Response response = new Response
                {
                    Status = Constants.SUCCESS,
                    Message = "Pagamento realizado com sucesso",
                    Error = false,
                    Data = xmlTransaction
                };

                return new ObjectResult(response);
            }
            catch (WebException e)
            {
                var exceptionResponse = (WebResponse)e.Response;
                StreamReader streamReader = new StreamReader(exceptionResponse.GetResponseStream());
                string returnValue = streamReader.ReadToEnd();
                XElement xElement = XElement.Parse(returnValue);
                string xml = xElement.ToString();

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<PaymentErrorResponse>), new XmlRootAttribute("errors"));
                StringReader stringReader = new StringReader(xml);
                List<PaymentErrorResponse> errorList = (List<PaymentErrorResponse>)xmlSerializer.Deserialize(stringReader);

                Response response = new Response
                {
                    Status = Constants.ERROR,
                    Message = e.Message,
                    Error = true,
                    Data = errorList
                };

                return BadRequest(response);
            }
            catch (Exception e)
            {
                Response response = new Response
                {
                    Status = Constants.ERROR,
                    Message = e.Message,
                    Error = true,
                    Data = null

                };
                //return StatusCode(500, response);
                return BadRequest(response);
            }

        }

        [HttpPost]
        public IActionResult Boleto([FromBody] BoletoRequest boletoRequest)
        {
            try
            {
                paymentService.BoletoCheckout(boletoRequest);

                Response response = new Response
                {
                    Status = Constants.SUCCESS,
                    Message = "Pagamento realizado com sucesso",
                    Error = false,
                    Data = null
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
                
                return BadRequest(response);
            }
        }

        [HttpPost]
        public IActionResult DebitoOnline([FromBody] DebitoOnlineRequest debitoOnlineRequest)
        {
            try
            {
                paymentService.DebitoOnlineCheckout(debitoOnlineRequest);

                Response response = new Response
                {
                    Status = Constants.SUCCESS,
                    Message = "Pagamento realizado com sucesso",
                    Error = false,
                    Data = null
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
                
                return BadRequest(response);
            }
        }
    }
}