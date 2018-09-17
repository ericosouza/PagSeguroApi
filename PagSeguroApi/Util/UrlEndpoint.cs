namespace PagSeguroApi.Util
{
    public class UrlEndpoint
    {
        public const string URL_WS_DEV_PAGSEGURO = "https://ws.sandbox.pagseguro.uol.com.br";
        public const string URL_WS_PROD_PAGSEGURO = "https://ws.pagseguro.uol.com.br";

        public const string PATH_SESSIONS = "/v2/sessions";
        public const string PATH_PAYMENT = "/v2/checkout/payment.html?code=";
        public const string PATH_TRANSACTIONS = "/v2/transactions";
    }
}
