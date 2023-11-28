using EzRemitService.ResponseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

/*
 * Author: Sk. Razibul Islam
 * NRB Division
 * 25-Apr-2022
 */

namespace EzRemitService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEzRemitService
    {
        [OperationContract]
        CashTxnDetails CashReceivePayment(string securityCode, string SecurityNumber);

        [OperationContract]
        PayoutResponse CashPayout(string securityCode, string SecurityNumber, string BenficairyIDNumber, string BenficairyTelno, string BenficiaryIDType);

          
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
