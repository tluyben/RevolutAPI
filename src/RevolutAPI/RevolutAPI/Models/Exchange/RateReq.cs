using System;
using System.ComponentModel.DataAnnotations;

namespace RevolutAPI.Models.Exchange
{
    public class RateReq
    {
        [Required(AllowEmptyStrings = false)]
        public string From { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string To { get; set; }

        public decimal Amount { get; set;  }
    }
}
