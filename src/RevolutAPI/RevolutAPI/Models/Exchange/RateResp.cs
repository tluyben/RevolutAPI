using System;
namespace RevolutAPI.Models.Exchange
{
    public class RateResp
    {
        public class AmountInfo
        {
            public decimal Amount { get; set; }
            public string Currency { get; set; }
        }

        public AmountInfo From { get; set; }
        public AmountInfo To { get; set;  }
        public decimal Rate { get; set; }
        public AmountInfo Fee { get; set; }
        public DateTime RateDate { get; set; }

    }
}
