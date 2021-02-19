using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIProjectOne
{
    class MarketStackCallManager:ICallManager
    {
        public string Response { get; set; }
        public string Status { get; set; }

        public MarketStackCallManager()
        {
            var client = new RestClient(AppConfigReader.baseUrl);
            var request = new RestRequest();
            request.AddParameter("access_key", AppConfigReader.apiKey);   
            var response = client.Execute(request, Method.GET);
            Response = response.Content;
            Status = response.StatusCode.ToString();
        }
    }
}
