using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PagSeguroApi.Model;
using PagSeguroApi.Services.Interface;
using PagSeguroApi.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace PagSeguroApi.Services.Impl
{
    public class SessionService : ISessionService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<SessionResponse> Obter(SessionRequest sessionRequest)
        {
            string url = UrlEndpoint.URL_WS_DEV_PAGSEGURO + UrlEndpoint.PATH_SESSIONS;

            var values = new Dictionary<string, string>
            {
                { "email", sessionRequest.Email },
                { "token", sessionRequest.Token }
            };

            var content = new FormUrlEncodedContent(values);

            try
            {
                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(responseString);

                string json = JsonConvert.SerializeXmlNode(doc);

                JObject j = JObject.Parse(json);
                SessionResponse session = JsonConvert.DeserializeObject<SessionResponse>(j.GetValue("session").ToString());
                return session;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
