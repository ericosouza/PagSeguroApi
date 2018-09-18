using PagSeguroApi.Model;
using PagSeguroApi.Services.Interface;
using System;

namespace PagSeguroApi.Services
{
    public class PaymentService : IPaymentService
    {
        public string BoletoCheckout(BoletoRequest boletoRequest)
        {
            throw new NotImplementedException();
        }

        public string CreditCardCheckout(CreditCardRequest creditCardRequest)
        {
            throw new NotImplementedException();
        }

        public string DebitoOnlineCheckout(DebitoOnlineRequest debitoOnlineRequest)
        {
            throw new NotImplementedException();
        }
    }
}
