using System;
using System.Collections.Generic;
using System.Text;

namespace APIProjectOne
{
    public class MarketStackResponseModel{}

    public class Rootobject
    {
        public Pagination pagination { get; set; }
        public Datum[] data { get; set; }
    }

    public class Pagination
    {
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public int total { get; set; }
    }

    public class Datum
    {
        public string name { get; set; }
        public string symbol { get; set; }
        public bool has_intraday { get; set; }
        public bool has_eod { get; set; }
        public object country { get; set; }
        public Stock_Exchange stock_exchange { get; set; }
    }

    public class Stock_Exchange
    {
        public string name { get; set; }
        public string acronym { get; set; }
        public string mic { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string city { get; set; }
        public string website { get; set; }
    }


}
