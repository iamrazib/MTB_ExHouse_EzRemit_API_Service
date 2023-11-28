using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EzRemitService.Global
{
    public class Definitions
    {
        public sealed class serviceUrlValue
        {
            public const string serviceUrl = "https://ezremitwcfapi.ezremit.com/EzremitWCF/EzRemitservice.svc/SSL";
            public const string ProxyHost = @"192.168.51.61";
            public const int ProxyPort = 80;
        }

        public sealed class credValue
        {
            public const string AgentCode = "MTB";
            public const string Username = "MTBCNT060";
            public const string HashedPassword = "$SBSS@58241";
        }

        public sealed class secValue
        {
            public const string AccessCode = "EZR@@#@#10042022";
        }

        public sealed class ExHName
        {
            public const string ezr = "EzRemit";
        }

        public sealed class EzRServiceClassValue
        {
            public const int GetTransaction = 1;
            public const int Payout = 2;
        }
    }


}