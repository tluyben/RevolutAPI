using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using RevolutAPI.Helpers;
using RevolutAPI.Models.Exchange;

namespace RevolutAPI.OutCalls
{
    public class ExchangeApiClient
    {
        private readonly IRevolutApiClient _apiClient;

        public ExchangeApiClient(IRevolutApiClient client)
        {
            _apiClient = client;
        }

        public async Task<RateResp> Rate(RateReq rateReq)
        {
          
            string endpoint = $"/rate?from={rateReq.From}&to={rateReq.To}&amount={rateReq.Amount}";
            return await _apiClient.Get<RateResp>(endpoint);
        }

        public async Task<Result<ExchangeResp>> Exchange(ExchangeReq req)
        {
            string endpoint = "/exchange";
            return await _apiClient.Post<ExchangeResp>(endpoint, req);
        }
    }
}
