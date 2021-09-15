using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class StatisticsGlobalLineChartView
    {
        public int GloBalId { get; set; }
        public string TypeName { get; set; }
        public double? KeShiBieLv { get; set; }
        public double? ShiBieZhunQueLv { get; set; }
    }
}
