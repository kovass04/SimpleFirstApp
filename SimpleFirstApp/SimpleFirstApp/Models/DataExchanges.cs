using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFirstApp.Models
{
    public class DataExchanges
    {
        public Exchanges[] data { get; set; }
        public long timestamp { get; set; }
    }

    public class Exchanges
    {
        public string exchangeId { get; set; }
        public string name { get; set; }
        public string rank { get; set; }
        public string percentTotalVolume { get; set; }
        public string volumeUsd { get; set; }
        public string tradingPairs { get; set; }
        public bool? socket { get; set; }
        public string exchangeUrl { get; set; }
        public long updated { get; set; }
    }
}
