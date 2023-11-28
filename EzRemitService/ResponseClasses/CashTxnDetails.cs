using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EzRemitService.ResponseClasses
{
    public class CashTxnDetails
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string SecurityNumber { get; set; }
        public SendingCustomer SendingCustomer { get; set; }
        public TransactionBeneficiary TransactionBeneficiary { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionNumber { get; set; }
        public TransactionPaymentDetails TransactionPaymentDetails { get; set; }
        public string TransactionStatus { get; set; }
        public string TypeOfTransaction { get; set; }


        public string toString()
        {
            //string retVal= "CashTxnDetails[ SecurityNumber=" + SecurityNumber + ", ResponseCode=" + ResponseCode + ", ResponseMessage=" + ResponseMessage
            //    + ", TransactionStatus=" + TransactionStatus == null ? "" : TransactionStatus + ", TypeOfTransaction=" + TypeOfTransaction == null ? "" : TypeOfTransaction
            //    + ", SendingCustomer[" + SendingCustomer == null ? "" : SendingCustomer.toString() + "]"
            //    + ", TransactionBeneficiary[" + TransactionBeneficiary == null ? "" : TransactionBeneficiary.toString() + "]"
            //    + ", PaymentDetails[" + TransactionPaymentDetails == null ? "" : TransactionPaymentDetails.toString() + "]" + "]";

            string sendCustInfo = this.SendingCustomer.toString();
            string beneCustInfo = this.TransactionBeneficiary.toString();
            string payDetl = this.TransactionPaymentDetails.toString();

            string retVal = "CashTxnDetails[SecurityNumber=" + this.SecurityNumber + ", RespCode=" + this.ResponseCode + ", RespMessage=" + this.ResponseMessage
                + ", TranStatus=" + this.TransactionStatus + ", TranType=" + this.TypeOfTransaction
                + ", SendingCustomer[" + sendCustInfo + "]" + ", TransactionBeneficiary[" + beneCustInfo + "]" + ", PaymentDetails[" + payDetl + "]" + "]";

            return retVal;
        }
    }

    public class SendingCustomer
    {
        public string BranchAddress { get; set; }
        public string ContactPerson { get; set; }
        public string ContactTelephoneNo { get; set; }
        public string CustBankBranchName { get; set; }
        public string CustBankBranchcode { get; set; }
        public string CustBankBranchshortname { get; set; }
        public string CustBankName { get; set; }
        public string CustBankShortname { get; set; }
        public string CustBankcode { get; set; }
        public string CustCountry { get; set; }
        public string CustCountryCode { get; set; }
        public string CustEmail { get; set; }
        public string CustID { get; set; }
        public string CustIDExpiryDate { get; set; }
        public string CustIDType { get; set; }
        public string CustMessage { get; set; }
        public string CustMobileNumber { get; set; }
        public string CustNationality { get; set; }
        public string CustOccupation { get; set; }
        public string CustTelephoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerArabicName { get; set; }
        public string CustomerCardNumber { get; set; }
        public string CustomerName { get; set; }
        public string Relationship { get; set; }
        public string CustDOB { get; set; }

        public string toString()
        {
            string sendCustVal = " CustomerName=" + CustomerName + ", CustomerAddress=" + CustomerAddress + ", CustTelephoneNumber=" + CustTelephoneNumber
                + ", CustNationality=" + CustNationality + ", CustMobileNumber=" + CustMobileNumber + ", CustCountry=" + CustCountry + ", CustBankName=" + CustBankName
                + ", CustBankBranchName=" + CustBankBranchName + ", BranchAddress=" + BranchAddress + ", ContactPerson=" + ContactPerson;
            
            return sendCustVal;
        }
    }

    public class TransactionBeneficiary
    {
        public string AccountNumber { get; set; }
        public string Address { get; set; }
        public string ArabicName { get; set; }
        public string BankName { get; set; }
        public string BankShortName { get; set; }
        public string BenBankBranchName { get; set; }
        public string BenBankName { get; set; }
        public string BenCountry { get; set; }
        public string BenID { get; set; }
        public string BranchAddress { get; set; }
        public string BranchName { get; set; }
        public string BranchShortName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactTelephoneNo { get; set; }
        public string FundSource { get; set; }
        public string IBAddress { get; set; }
        public string IBBank { get; set; }
        public string IBBankAccountno { get; set; }
        public string IBBankDiffernt { get; set; }
        public string IBBranch { get; set; }
        public string IBClearingNumber { get; set; }
        public string IBClearingType { get; set; }
        public string IBSwiftCode { get; set; }
        public string IdNumber { get; set; }
        public string Idtype { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string PaymentAgentCode { get; set; }
        public string PaymentAgentCountryCode { get; set; }
        public string PaymentAgentLocationCode { get; set; }
        public string Pin { get; set; }
        public string Purpose { get; set; }
        public string ReceiverComm { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientMessage { get; set; }
        public string RecipientName { get; set; }
        public string RecipientTelephone { get; set; }
        public string SwiftCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string TypeOfTransaction { get; set; }

        public string toString()
        {
            string beneCustVal = " Name=" + Name + ", Nationality=" + Nationality + ", Address=" + Address + ", BenCountry=" + BenCountry
                + ", ContactPerson=" + ContactPerson + ", FundSource=" + FundSource + ", Idtype=" + Idtype + ", IdNumber=" + IdNumber
                + ", Purpose=" + Purpose + ", TelephoneNumber=" + TelephoneNumber + ", TypeOfTransaction=" + TypeOfTransaction;

            return beneCustVal;
        }
    }

    public class TransactionPaymentDetails
    {
        public string CommissionAmount { get; set; }
        public decimal FxAmount { get; set; }
        public string FxCurrencyCode { get; set; }
        public decimal LocalAmount { get; set; }
        public string LocalCurrencyCode { get; set; }
        public decimal LocalTaxAmount { get; set; }
        public decimal MktRate { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalLocalAmount { get; set; }

        public string toString()
        {
            string payDetl = " FxAmount=" + FxAmount + ", FxCurrencyCode=" + FxCurrencyCode + ", LocalAmount=" + LocalAmount + ", LocalCurrencyCode=" + LocalCurrencyCode
                + ", MktRate=" + MktRate + ", Rate=" + Rate + ", TotalLocalAmount=" + TotalLocalAmount;

            return payDetl;
        }
    }

    
}