using System;
using System.Xml.Serialization;

namespace PagSeguroApi.Model
{
    [Serializable()]
    [XmlRoot("error")]
    public class PaymentErrorResponse
    {
        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("message")]
        public string Message { get; set; }

        public override string ToString()
        {
            return "CODE: " + Code + ", MESSAGE: " + Message;
        }
    }
}
