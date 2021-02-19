using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIProjectOne
{
    public class StockExchangeDTO
    {
        public MarketStackResponseModel StockExchange { get; set; }

        public void DeserializedResponse(string response) {
            StockExchange = JsonConvert.DeserializeObject<MarketStackResponseModel>(response);
        }
    }
}
