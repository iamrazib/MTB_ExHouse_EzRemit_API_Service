using EzRemitService.EzRemitServiceReference;
using EzRemitService.Global;
using EzRemitService.Manager;
using EzRemitService.ModelClass;
using EzRemitService.ResponseClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Serialization;

namespace EzRemitService
{
    
    public class EzRemitServiceClass : IEzRemitService
    {
        // Initialization for Log purpose
        LogManager LogObj = new LogManager();
        string RequestCode = null;
        int LogID = 0;
        int isAuthenticated = 0;
        // end 

        EzRemitserviceClient client = new EzRemitserviceClient();


        public CashTxnDetails CashReceivePayment(string securityCode, string SecurityNumber)
        {
            string AgentCode = Global.Definitions.credValue.AgentCode;
            string Username = Global.Definitions.credValue.Username;
            string HashedPassword = Global.Definitions.credValue.HashedPassword;
            
            CashTxnDetails cashTxn = new CashTxnDetails();

            LogID = 0;
            isAuthenticated = 0;
            string exHouseName = Global.Definitions.ExHName.ezr;

            try
            {
                RequestCode = "SecurityCode:" + securityCode;
                LogID = LogObj.RQRSLogger(LogID, exHouseName, Definitions.EzRServiceClassValue.GetTransaction, isAuthenticated, RequestCode, "", "");

                if (string.Equals(securityCode, Definitions.secValue.AccessCode))
                {
                    isAuthenticated = 1;
                    RequestCode = "SecurityCode:Passed";
                    LogID = LogObj.RQRSLogger(LogID, exHouseName, Definitions.EzRServiceClassValue.GetTransaction, isAuthenticated, RequestCode, "", "");

                    EzCredential ezcred = new EzCredential();
                    ezcred.AgentCode = AgentCode;
                    ezcred.Username = Username;
                    ezcred.HashedPassword = HashedPassword;

                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

                    EzTransaction ezTran = client.GetTransaction(ezcred, SecurityNumber, "EZCASH", "");

                    cashTxn.ResponseCode = "000";
                    cashTxn.ResponseMessage = "FETCH_SUCCESS";
                    cashTxn.SecurityNumber = SecurityNumber;

                    cashTxn.SendingCustomer = new SendingCustomer();
                    cashTxn.SendingCustomer.BranchAddress = ezTran.SendingCustomer.BranchAddress;
                    cashTxn.SendingCustomer.ContactPerson = ezTran.SendingCustomer.ContactPerson;
                    cashTxn.SendingCustomer.CustBankBranchName = ezTran.SendingCustomer.CustBankBranchName;
                    cashTxn.SendingCustomer.CustBankName = ezTran.SendingCustomer.CustBankName;
                    cashTxn.SendingCustomer.CustCountry = ezTran.SendingCustomer.CustCountry;
                    cashTxn.SendingCustomer.CustCountryCode = ezTran.SendingCustomer.CustCountryCode;
                    cashTxn.SendingCustomer.CustID = ezTran.SendingCustomer.CustID;
                    cashTxn.SendingCustomer.CustIDType = ezTran.SendingCustomer.CustIDType;
                    cashTxn.SendingCustomer.CustMobileNumber = ezTran.SendingCustomer.CustMobileNumber;
                    cashTxn.SendingCustomer.CustNationality = ezTran.SendingCustomer.CustNationality;
                    cashTxn.SendingCustomer.CustTelephoneNumber = ezTran.SendingCustomer.CustTelephoneNumber;
                    cashTxn.SendingCustomer.CustomerAddress = ezTran.SendingCustomer.CustomerAddress;
                    cashTxn.SendingCustomer.CustomerName = ezTran.SendingCustomer.CustomerName;
                    cashTxn.SendingCustomer.Relationship = ezTran.SendingCustomer.Relationship;

                    cashTxn.TransactionBeneficiary = new TransactionBeneficiary();
                    cashTxn.TransactionBeneficiary.AccountNumber = ezTran.TransactionBeneficiary.AccountNumber;
                    cashTxn.TransactionBeneficiary.Address = ezTran.TransactionBeneficiary.Address;
                    cashTxn.TransactionBeneficiary.BankName = ezTran.TransactionBeneficiary.BankName;
                    cashTxn.TransactionBeneficiary.BankShortName = ezTran.TransactionBeneficiary.BankShortName;
                    cashTxn.TransactionBeneficiary.BenCountry = ezTran.TransactionBeneficiary.BenCountry;
                    cashTxn.TransactionBeneficiary.BenID = ezTran.TransactionBeneficiary.BenID;
                    cashTxn.TransactionBeneficiary.BranchAddress = ezTran.TransactionBeneficiary.BranchAddress;
                    cashTxn.TransactionBeneficiary.BranchName = ezTran.TransactionBeneficiary.BranchName;
                    cashTxn.TransactionBeneficiary.ContactPerson = ezTran.TransactionBeneficiary.ContactPerson;
                    cashTxn.TransactionBeneficiary.ContactTelephoneNo = ezTran.TransactionBeneficiary.ContactTelephoneNo;
                    cashTxn.TransactionBeneficiary.FundSource = ezTran.TransactionBeneficiary.FundSource;
                    cashTxn.TransactionBeneficiary.IdNumber = ezTran.TransactionBeneficiary.IdNumber;
                    cashTxn.TransactionBeneficiary.Idtype = ezTran.TransactionBeneficiary.Idtype;
                    cashTxn.TransactionBeneficiary.MobileNumber = ezTran.TransactionBeneficiary.MobileNumber;
                    cashTxn.TransactionBeneficiary.Name = ezTran.TransactionBeneficiary.Name;
                    cashTxn.TransactionBeneficiary.Nationality = ezTran.TransactionBeneficiary.Nationality;
                    cashTxn.TransactionBeneficiary.PaymentAgentCode = ezTran.TransactionBeneficiary.PaymentAgentCode;
                    cashTxn.TransactionBeneficiary.PaymentAgentCountryCode = ezTran.TransactionBeneficiary.PaymentAgentCountryCode;
                    cashTxn.TransactionBeneficiary.Purpose = ezTran.TransactionBeneficiary.Purpose;
                    cashTxn.TransactionBeneficiary.RecipientName = ezTran.TransactionBeneficiary.RecipientName;
                    cashTxn.TransactionBeneficiary.TelephoneNumber = ezTran.TransactionBeneficiary.TelephoneNumber;
                    cashTxn.TransactionBeneficiary.TypeOfTransaction = ezTran.TransactionBeneficiary.TypeOfTransaction;
                    cashTxn.TransactionBeneficiary.RecipientMessage = ezTran.TransactionBeneficiary.RecipientMessage;

                    cashTxn.TransactionPaymentDetails = new TransactionPaymentDetails();
                    cashTxn.TransactionPaymentDetails.FxAmount = ezTran.TransactionPaymentDetails.FxAmount;
                    cashTxn.TransactionPaymentDetails.FxCurrencyCode = ezTran.TransactionPaymentDetails.FxCurrencyCode;
                    cashTxn.TransactionPaymentDetails.LocalAmount = ezTran.TransactionPaymentDetails.LocalAmount;
                    cashTxn.TransactionPaymentDetails.LocalCurrencyCode = ezTran.TransactionPaymentDetails.LocalCurrencyCode;
                    cashTxn.TransactionPaymentDetails.MktRate = ezTran.TransactionPaymentDetails.MktRate;
                    cashTxn.TransactionPaymentDetails.Rate = ezTran.TransactionPaymentDetails.Rate;
                    cashTxn.TransactionPaymentDetails.TotalLocalAmount = ezTran.TransactionPaymentDetails.TotalLocalAmount;

                    cashTxn.TransactionDate = ezTran.TransactionDate;
                    cashTxn.TransactionNumber = ezTran.TransactionNumber;
                    cashTxn.TransactionStatus = ezTran.TransactionStatus;
                    cashTxn.TypeOfTransaction = ezTran.TypeOfTransaction;
                                        
                    LogID = LogObj.RQRSLogger(LogID, exHouseName, Definitions.EzRServiceClassValue.GetTransaction, isAuthenticated, RequestCode, SecurityNumber, cashTxn.toString());

                } // END (string.Equals(securityCode, secValue.AccessCode))

            } //try End
            catch (Exception exc)
            {
                cashTxn.SecurityNumber = SecurityNumber;
                cashTxn.ResponseCode = "999";
                cashTxn.ResponseMessage = exc.Message;

               
                string rsp = "SecurityNumber=" + SecurityNumber + ", ResponseCode=999, ResponseMessage=" + exc.Message;
                LogID = LogObj.RQRSLogger(LogID, exHouseName, Definitions.EzRServiceClassValue.GetTransaction, isAuthenticated, RequestCode, SecurityNumber, rsp);

                string errorCode = "E003 : Fetch Error: EzRemit";
                string errorMsg = exc.Message;
                string errorStackTrace = exc.StackTrace;
                LogObj.InsertIntoExHouseAPIErrorLog(SecurityNumber, errorCode, errorMsg, errorStackTrace);
            }

            return cashTxn;
        }
        
        public PayoutResponse CashPayout(string securityCode, string SecurityNumber, string BenficairyIDNumber, string BenficairyTelno, string BenficiaryIDType)
        {
            string AgentCode = Global.Definitions.credValue.AgentCode;
            string Username = Global.Definitions.credValue.Username;
            string HashedPassword = Global.Definitions.credValue.HashedPassword;

            PayoutResponse payResp = new PayoutResponse();

            LogID = 0;
            isAuthenticated = 0;
            string exHouseName = Global.Definitions.ExHName.ezr;

            try
            {
                RequestCode = "SecurityCode:" + securityCode;
                LogID = LogObj.RQRSLogger(LogID, exHouseName, Definitions.EzRServiceClassValue.Payout, isAuthenticated, RequestCode, "", "");

                if (string.Equals(securityCode, Definitions.secValue.AccessCode))
                {
                    isAuthenticated = 1;
                    RequestCode = "SecurityCode:Passed";
                    LogID = LogObj.RQRSLogger(LogID, exHouseName, Definitions.EzRServiceClassValue.Payout, isAuthenticated, RequestCode, "", "");

                    EzCredential ezcred = new EzCredential();
                    ezcred.AgentCode = AgentCode;
                    ezcred.Username = Username;
                    ezcred.HashedPassword = HashedPassword;

                    PayoutRequest payreq = new PayoutRequest();
                    payreq.BenficairyIDNumber = BenficairyIDNumber;
                    payreq.BenficairyTelno = BenficairyTelno;
                    payreq.BenficiaryIDType = BenficiaryIDType;
                    payreq.ChangeReason = "";
                    payreq.NewState = "PAID";
                    payreq.SecurityNO = SecurityNumber;
                    payreq.TransactionType = "EZCASH";

                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

                    try
                    {
                        EzResponse ezResponse = client.Payout(ezcred, payreq, "A");

                        payResp.Message = ezResponse.Message;
                        payResp.SecurityCode = SecurityNumber;
                        payResp.EzremitResponseCode = ezResponse.EzremitResponseCode.ToString();
                        
                        if (payResp.EzremitResponseCode.ToUpper().Equals("OK"))
                        {
                            payResp.ResponseCode = "000";
                        }
                        else
                        {
                            payResp.ResponseCode = "999";
                        }

                        string payreqs = "SecurityNo=" + SecurityNumber + ", IDType=" + BenficiaryIDType + ", IDNumber=" + BenficairyIDNumber + ", BenTelno=" + BenficairyTelno;
                        LogID = LogObj.RQRSLogger(LogID, exHouseName, Definitions.EzRServiceClassValue.Payout, isAuthenticated, RequestCode, payreqs, payResp.toString());
                    
                    }
                    catch (Exception ex)
                    {
                        //This Transaction is for Other Agent pool,please Contact Call center
                        // if same PIN payout again:   Transaction has already been paid.

                        payResp.ResponseCode = "999";
                        payResp.EzremitResponseCode = "";
                        payResp.Message = ex.Message;
                        payResp.SecurityCode = SecurityNumber;

                        LogObj.InsertIntoExHouseAPIErrorLog(SecurityNumber, payResp.ResponseCode, payResp.Message, ex.StackTrace);
                    }

                }
            }
            catch (Exception exc)
            {
                payResp.ResponseCode = "999";
                payResp.SecurityCode = SecurityNumber;
                payResp.EzremitResponseCode = "999";
                payResp.Message = exc.Message;

                string errorCode = "E004 : Payout Error : EzRemit";
                string errorMsg = exc.Message;
                string errorStackTrace = exc.StackTrace;
                LogObj.InsertIntoExHouseAPIErrorLog(SecurityNumber, errorCode, errorMsg, errorStackTrace);
            }

            return payResp;
        }

        
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
