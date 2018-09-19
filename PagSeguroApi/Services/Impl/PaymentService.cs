using PagSeguroApi.Model;
using PagSeguroApi.Services.Interface;
using PagSeguroApi.Util;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

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
            string url = UrlEndpoint.URL_WS_DEV_PAGSEGURO + UrlEndpoint.PATH_PAYMENT;

            NameValueCollection nameValueCollection = ResolverInformacao(creditCardRequest);

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
                catch(WebException e)
                {

                    throw;
                }
                catch (Exception e)
                {

                    throw;
                }
            }
        }

        public string DebitoOnlineCheckout(DebitoOnlineRequest debitoOnlineRequest)
        {
            throw new NotImplementedException();
        }

        private NameValueCollection ResolverInformacao(CreditCardRequest creditCardRequest)
        {
            throw new NotImplementedException();
        }
    }
}
