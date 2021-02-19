using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIProjectOne
{
    public class Service
    {
        StockExchangeDTO stockExchangeDTO { get; set; } = new StockExchangeDTO();
        ICallManager CallManager { get; set; }
        public string Status { get; set; }
        public string Response { get; set; }
        public JObject JsonResponse { get; set; }

        public Service(ICallManager callManager) {
            CallManager = callManager;
            Status = callManager.Status;
            Response = callManager.Response;
            JsonResponse = JObject.Parse(Response);
            DeserialiseResponse();
        }

        private void DeserialiseResponse()
        {
            stockExchangeDTO.DeserializedResponse(Response);
        }

    }


}
