using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFirstApp.Models
{

    public class DataAssetsMarkets
    {
        public AssetsMarkets[] data { get; set; }
        public long timestamp { get; set; }
    }

    public class AssetsMarkets
    {
        public string exchangeId { get; set; }
        public string baseId { get; set; }
        public string quoteId { get; set; }
        public string baseSymbol { get; set; }
        public string quoteSymbol { get; set; }
        public string volumeUsd24Hr { get; set; }
        public string priceUsd { get; set; }
        public string volumePercent { get; set; }
    }

}
