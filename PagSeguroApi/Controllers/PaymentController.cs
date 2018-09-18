using Microsoft.AspNetCore.Mvc;
using PagSeguroApi.Model;
using PagSeguroApi.Services;
using PagSeguroApi.Services.Interface;
using System;

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
        public string CreditCard([FromBody] CreditCardRequest creditCardRequest)
        {
            try
            {
                paymentService.CreditCardCheckout(creditCardRequest);
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }

        [HttpPost]
        public string Boleto([FromBody] BoletoRequest boletoRequest)
        {
            try
            {
                paymentService.BoletoCheckout(boletoRequest);
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }

        [HttpPost]
        public string DebitoOnline([FromBody] DebitoOnlineRequest debitoOnlineRequest)
        {
            try
            {
                paymentService.DebitoOnlineCheckout(debitoOnlineRequest);
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
    }
}