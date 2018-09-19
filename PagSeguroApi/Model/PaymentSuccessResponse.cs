using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PagSeguroApi.Model
{
    [Serializable()]
    [XmlRoot("transaction")]
    public class PaymentSuccessResponse
    {
        [XmlElement("date")]
        public string Date { get; set; }

        [XmlElement("lastEventDate")]
        public string LastEventDate { get; set; }

        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("reference")]
        public string Reference { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("paymentMethod")]
        public PaymentMethod PaymentMethod { get; set; }

        [XmlElement("paymentLink")]
        public string PaymentLink { get; set; }

        [XmlElement("grossAmount")]
        public string GrossAmount { get; set; }

        [XmlElement("discountAmount")]
        public string DiscountAmount { get; set; }

        [XmlElement("feeAmount")]
        public string FeeAmount { get; set; }

        [XmlElement("netAmount")]
        public string NetAmount { get; set; }

        [XmlElement("extraAmount")]
        public string ExtraAmount { get; set; }

        [XmlElement("installmentCount")]
        public string InstallmentCount { get; set; }

        [XmlElement("itemCount")]
        public string ItemCount { get; set; }

        [XmlElement("items")]
        public List<Item> Items { get; set; }

        [XmlElement("sender")]
        public Sender Sender { get; set; }

        [XmlElement("shipping")]
        public Shipping Shipping { get; set; }
    }


    [XmlRoot("paymentMethod")]
    public class PaymentMethod
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("code")]
        public string Code { get; set; }
    }

    [XmlRoot("item")]
    public class Item
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("quantity")]
        public string Quantity { get; set; }

        [XmlElement("amount")]
        public string Amount { get; set; }
    }

    [XmlRoot("sender")]
    public class Sender
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("phone")]
        public Phone Phone { get; set; }
    }

    [XmlRoot("phone")]
    public class Phone
    {
        [XmlElement("areaCode")]
        public string AreaCode { get; set; }

        [XmlElement("number")]
        public string Number { get; set; }
    }

    [XmlRoot("shipping")]
    public class Shipping
    {
        [XmlElement("address")]
        public Address Address { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("cost")]
        public string Cost { get; set; }
    }

    [XmlRoot("address")]
    public class Address
    {
        [XmlElement("street")]
        public string Street { get; set; }

        [XmlElement("number")]
        public string Number { get; set; }

        [XmlElement("complement")]
        public string Complement { get; set; }

        [XmlElement("district")]
        public string District { get; set; }

        [XmlElement("postalCode")]
        public string PostalCode { get; set; }

        [XmlElement("city")]
        public string City { get; set; }

        [XmlElement("state")]
        public string State { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }
    }
}
