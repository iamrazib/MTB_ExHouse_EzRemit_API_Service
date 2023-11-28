using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace EzRemitService.ModelClass
{
    public class GetTransactionResponses
    {
        [XmlRoot(ElementName = "Action", Namespace = "http://www.w3.org/2005/08/addressing")]
        public class Action
        {
            [XmlAttribute(AttributeName = "mustUnderstand", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public string MustUnderstand { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Header
        {
            [XmlElement(ElementName = "Action", Namespace = "http://www.w3.org/2005/08/addressing")]
            public Action Action { get; set; }
            [XmlElement(ElementName = "RelatesTo", Namespace = "http://www.w3.org/2005/08/addressing")]
            public string RelatesTo { get; set; }
        }

        [XmlRoot(ElementName = "Language", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class Language
        {
            [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Nil { get; set; }
        }

        [XmlRoot(ElementName = "Reserved", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class Reserved
        {
            [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Nil { get; set; }
        }

        [XmlRoot(ElementName = "Beneficiaries", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class Beneficiaries
        {
            [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Nil { get; set; }
        }

        [XmlRoot(ElementName = "SendingCustomer", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class SendingCustomer
        {
            [XmlElement(ElementName = "Beneficiaries", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public Beneficiaries Beneficiaries { get; set; }
            [XmlElement(ElementName = "BranchAddress", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BranchAddress { get; set; }
            [XmlElement(ElementName = "ContactPerson", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string ContactPerson { get; set; }
            [XmlElement(ElementName = "ContactTelephoneNo", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string ContactTelephoneNo { get; set; }
            [XmlElement(ElementName = "CustBankBranchName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustBankBranchName { get; set; }
            [XmlElement(ElementName = "CustBankBranchcode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustBankBranchcode { get; set; }
            [XmlElement(ElementName = "CustBankBranchshortname", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustBankBranchshortname { get; set; }
            [XmlElement(ElementName = "CustBankName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustBankName { get; set; }
            [XmlElement(ElementName = "CustBankShortname", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustBankShortname { get; set; }
            [XmlElement(ElementName = "CustBankcode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustBankcode { get; set; }
            [XmlElement(ElementName = "CustCountry", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustCountry { get; set; }
            [XmlElement(ElementName = "CustCountryCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustCountryCode { get; set; }
            [XmlElement(ElementName = "CustEmail", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustEmail { get; set; }
            [XmlElement(ElementName = "CustID", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustID { get; set; }
            [XmlElement(ElementName = "CustIDExpiryDate", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustIDExpiryDate { get; set; }
            [XmlElement(ElementName = "CustIDType", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustIDType { get; set; }
            [XmlElement(ElementName = "CustMessage", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustMessage { get; set; }
            [XmlElement(ElementName = "CustMobileNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustMobileNumber { get; set; }
            [XmlElement(ElementName = "CustNationality", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustNationality { get; set; }
            [XmlElement(ElementName = "CustOccupation", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustOccupation { get; set; }
            [XmlElement(ElementName = "CustTelephoneNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustTelephoneNumber { get; set; }
            [XmlElement(ElementName = "CustomerAddress", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustomerAddress { get; set; }
            [XmlElement(ElementName = "CustomerArabicName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustomerArabicName { get; set; }
            [XmlElement(ElementName = "CustomerCardNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustomerCardNumber { get; set; }
            [XmlElement(ElementName = "CustomerName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustomerName { get; set; }
            [XmlElement(ElementName = "Relationship", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Relationship { get; set; }
            [XmlElement(ElementName = "custDOB", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CustDOB { get; set; }
        }

        [XmlRoot(ElementName = "Source", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class Source
        {
            [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Nil { get; set; }
        }

        [XmlRoot(ElementName = "PartnerBankcode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class PartnerBankcode
        {
            [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Nil { get; set; }
        }

        [XmlRoot(ElementName = "PartnerBranchcode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class PartnerBranchcode
        {
            [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Nil { get; set; }
        }

        [XmlRoot(ElementName = "TransactionBeneficiary", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class TransactionBeneficiary
        {
            [XmlElement(ElementName = "AccountNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string AccountNumber { get; set; }
            [XmlElement(ElementName = "Address", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Address { get; set; }
            [XmlElement(ElementName = "ArabicName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string ArabicName { get; set; }
            [XmlElement(ElementName = "BankName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BankName { get; set; }
            [XmlElement(ElementName = "BankShortName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BankShortName { get; set; }
            [XmlElement(ElementName = "BenBankBranchName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BenBankBranchName { get; set; }
            [XmlElement(ElementName = "BenBankName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BenBankName { get; set; }
            [XmlElement(ElementName = "BenCountry", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BenCountry { get; set; }
            [XmlElement(ElementName = "BenID", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BenID { get; set; }
            [XmlElement(ElementName = "BranchAddress", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BranchAddress { get; set; }
            [XmlElement(ElementName = "BranchName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BranchName { get; set; }
            [XmlElement(ElementName = "BranchShortName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string BranchShortName { get; set; }
            [XmlElement(ElementName = "ContactPerson", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string ContactPerson { get; set; }
            [XmlElement(ElementName = "ContactTelephoneNo", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string ContactTelephoneNo { get; set; }
            [XmlElement(ElementName = "FundSource", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string FundSource { get; set; }
            [XmlElement(ElementName = "IBAddress", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBAddress { get; set; }
            [XmlElement(ElementName = "IBBank", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBBank { get; set; }
            [XmlElement(ElementName = "IBBankAccountno", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBBankAccountno { get; set; }
            [XmlElement(ElementName = "IBBankDiffernt", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBBankDiffernt { get; set; }
            [XmlElement(ElementName = "IBBranch", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBBranch { get; set; }
            [XmlElement(ElementName = "IBClearingNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBClearingNumber { get; set; }
            [XmlElement(ElementName = "IBClearingType", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBClearingType { get; set; }
            [XmlElement(ElementName = "IBSwiftCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IBSwiftCode { get; set; }
            [XmlElement(ElementName = "IdNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string IdNumber { get; set; }
            [XmlElement(ElementName = "Idtype", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Idtype { get; set; }
            [XmlElement(ElementName = "MobileNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string MobileNumber { get; set; }
            [XmlElement(ElementName = "Name", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Name { get; set; }
            [XmlElement(ElementName = "Nationality", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Nationality { get; set; }
            [XmlElement(ElementName = "PartnerBankcode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public PartnerBankcode PartnerBankcode { get; set; }
            [XmlElement(ElementName = "PartnerBranchcode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public PartnerBranchcode PartnerBranchcode { get; set; }
            [XmlElement(ElementName = "PaymentAgentCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string PaymentAgentCode { get; set; }
            [XmlElement(ElementName = "PaymentAgentCountryCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string PaymentAgentCountryCode { get; set; }
            [XmlElement(ElementName = "PaymentAgentLocationCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string PaymentAgentLocationCode { get; set; }
            [XmlElement(ElementName = "Pin", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Pin { get; set; }
            [XmlElement(ElementName = "Purpose", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Purpose { get; set; }
            [XmlElement(ElementName = "ReceiverComm", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string ReceiverComm { get; set; }
            [XmlElement(ElementName = "RecipientAddress", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string RecipientAddress { get; set; }
            [XmlElement(ElementName = "RecipientMessage", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string RecipientMessage { get; set; }
            [XmlElement(ElementName = "RecipientName", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string RecipientName { get; set; }
            [XmlElement(ElementName = "RecipientTelephone", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string RecipientTelephone { get; set; }
            [XmlElement(ElementName = "SwiftCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string SwiftCode { get; set; }
            [XmlElement(ElementName = "TelephoneNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string TelephoneNumber { get; set; }
            [XmlElement(ElementName = "TypeOfTransaction", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string TypeOfTransaction { get; set; }
        }

        [XmlRoot(ElementName = "TransactionPaymentDetails", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
        public class TransactionPaymentDetails
        {
            [XmlElement(ElementName = "CommissionAmount", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string CommissionAmount { get; set; }
            [XmlElement(ElementName = "FxAmount", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string FxAmount { get; set; }
            [XmlElement(ElementName = "FxCurrencyCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string FxCurrencyCode { get; set; }
            [XmlElement(ElementName = "LocalAmount", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string LocalAmount { get; set; }
            [XmlElement(ElementName = "LocalCurrencyCode", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string LocalCurrencyCode { get; set; }
            [XmlElement(ElementName = "LocalTaxAmount", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string LocalTaxAmount { get; set; }
            [XmlElement(ElementName = "MktRate", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string MktRate { get; set; }
            [XmlElement(ElementName = "Rate", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string Rate { get; set; }
            [XmlElement(ElementName = "TotalLocalAmount", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string TotalLocalAmount { get; set; }
        }

        [XmlRoot(ElementName = "GetTransactionResult", Namespace = "http://tempuri.org/")]
        public class GetTransactionResult
        {
            [XmlElement(ElementName = "Language", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public Language Language { get; set; }
            [XmlElement(ElementName = "Reserved", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public Reserved Reserved { get; set; }
            [XmlElement(ElementName = "SecurityNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string SecurityNumber { get; set; }
            [XmlElement(ElementName = "SendingCustomer", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public SendingCustomer SendingCustomer { get; set; }
            [XmlElement(ElementName = "Source", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public Source Source { get; set; }
            [XmlElement(ElementName = "TransactionBeneficiary", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public TransactionBeneficiary TransactionBeneficiary { get; set; }
            [XmlElement(ElementName = "TransactionDate", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string TransactionDate { get; set; }
            [XmlElement(ElementName = "TransactionNumber", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string TransactionNumber { get; set; }
            [XmlElement(ElementName = "TransactionPaymentDetails", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public TransactionPaymentDetails TransactionPaymentDetails { get; set; }
            [XmlElement(ElementName = "TransactionStatus", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string TransactionStatus { get; set; }
            [XmlElement(ElementName = "TypeOfTransaction", Namespace = "http://schemas.datacontract.org/2004/07/EzremitAPI.Entities")]
            public string TypeOfTransaction { get; set; }
            [XmlAttribute(AttributeName = "b", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string B { get; set; }
            [XmlAttribute(AttributeName = "i", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string I { get; set; }
        }

        [XmlRoot(ElementName = "GetTransactionResponse", Namespace = "http://tempuri.org/")]
        public class GetTransactionResponse
        {
            [XmlElement(ElementName = "GetTransactionResult", Namespace = "http://tempuri.org/")]
            public GetTransactionResult GetTransactionResult { get; set; }
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            [XmlElement(ElementName = "GetTransactionResponse", Namespace = "http://tempuri.org/")]
            public GetTransactionResponse GetTransactionResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            [XmlElement(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
            [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string S { get; set; }
            [XmlAttribute(AttributeName = "a", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string A { get; set; }
        }
    }
}