using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EzRemitService.ResponseClasses
{
    public class PayoutResponse
    {
        public string ResponseCode { get; set; }
        public string EzremitResponseCode { get; set; }
        public string Message { get; set; }
        public string SecurityCode { get; set; }
        public string TransactionId { get; set; }

        public string toString()
        {
            return "PayoutResponse[ SecurityCode=" + this.SecurityCode + ", ResponseCode=" + this.ResponseCode + ", EzremitResponseCode=" + this.EzremitResponseCode + ", Message=" + this.Message + "]";
        }
    }
}