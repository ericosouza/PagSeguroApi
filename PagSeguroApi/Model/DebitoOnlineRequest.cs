using System.Collections.Generic;

namespace PagSeguroApi.Model
{
    public class DebitoOnlineRequest
    {
        public string PaymentMode { get; set; }
        public string PaymentMethod { get; set; }
        public string BankName { get; set; }
        public string ReceiverEmail { get; set; }
        public string Currency { get; set; }
        public string ExtraAmount { get; set; }
        public string NotificationURL { get; set; }
        public string Reference { get; set; }
        public string SenderName { get; set; }
        public string SenderCPF { get; set; }
        public int SenderAreaCode { get; set; }
        public int SenderPhone { get; set; }
        public string SenderEmail { get; set; }
        public string SenderHash { get; set; }
        public string ShippingAddressStreet { get; set; }
        public string ShippingAddressNumber { get; set; }
        public string ShippingAddressComplement { get; set; }
        public string ShippingAddressDistrict { get; set; }
        public int ShippingAddressPostalCode { get; set; }
        public string ShippingAddressCity { get; set; }
        public string ShippingAddressState { get; set; }
        public string ShippingAddressCountry { get; set; }
        public int ShippingType { get; set; }
        public decimal ShippingCost { get; set; }
        public List<Product> Products { get; set; }
    }
}
