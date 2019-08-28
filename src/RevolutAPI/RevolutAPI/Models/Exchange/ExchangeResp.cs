using System;
namespace RevolutAPI.Models.Exchange
{
    public class ExchangeResp
    {
        public string Id { get; set; }
        public string State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedAt { get; set; }
    }
}
