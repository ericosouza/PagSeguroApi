using PagSeguroApi.Model;

namespace PagSeguroApi.Services.Interface
{
    interface IPaymentService
    {
        string CreditCardCheckout(CreditCardRequest creditCardRequest);
        string BoletoCheckout(BoletoRequest boletoRequest);
        string DebitoOnlineCheckout(DebitoOnlineRequest debitoOnlineRequest);
    }
}
