using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFirstApp.Models
{
    public class DataCharts
    {
        public Charts[] data { get; set; }
        public long timestamp { get; set; }
    }

    public class Charts
    {
        public string priceUsd { get; set; }
        public long time { get; set; }
        public DateTime date { get; set; }
    }

}
