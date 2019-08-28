using System;
namespace RevolutAPI.Models.Exchange
{
    public class ExchangeReq
    {
        public class FromData
        {
            public string AccountId { get; set; }
            public string Currency { get; set; }
            public decimal Amount { get; set; }
        }

        public class ToData
        {
            public string AccountId { get; set; }
            public string Currency { get; set; }
        }

        public FromData From { get; set; }
        public ToData To { get; set; }
        public string Reference { get; set; }
        public string RequestId { get; set; }
    }
}
