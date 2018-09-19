using PagSeguroApi.Model;
using PagSeguroApi.Services.Interface;
using PagSeguroApi.Util;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace PagSeguroApi.Services
{
    public class PaymentService : IPaymentService
    {
        public string BoletoCheckout(BoletoRequest boletoRequest)
        {
            return Checkout(ResolverInformacao(boletoRequest));
        }

        public string CreditCardCheckout(CreditCardRequest creditCardRequest)
        {
            return Checkout(ResolverInformacao(creditCardRequest));
        }

        public string DebitoOnlineCheckout(DebitoOnlineRequest debitoOnlineRequest)
        {
            return Checkout(ResolverInformacao(debitoOnlineRequest));
        }

        private string Checkout(NameValueCollection nameValueCollection)
        {
            string url = UrlEndpoint.URL_WS_DEV_PAGSEGURO + UrlEndpoint.PATH_PAYMENT;
            string retornoTransacao = null;

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers[HttpRequestHeader.ContentType] = Constants.APPLICATION_FORM_URLENCODED;

                dynamic result;

                try
                {
                    result = webClient.UploadValues(url, nameValueCollection);
                    retornoTransacao = Encoding.ASCII.GetString(result);
                    return retornoTransacao;
                }
                catch (WebException e)
                {

                    throw;
                }
                catch (Exception e)
                {

                    throw;
                }
            }
        }

        private NameValueCollection ResolverInformacao(BoletoRequest boletoRequest)
        {
            throw new NotImplementedException();
        }

        private NameValueCollection ResolverInformacao(CreditCardRequest creditCardRequest)
        {
            throw new NotImplementedException();
        }

        private NameValueCollection ResolverInformacao(DebitoOnlineRequest debitoOnlineRequest)
        {
            throw new NotImplementedException();
        }
    }
}
