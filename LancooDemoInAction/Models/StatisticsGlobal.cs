using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class StatisticsGlobal
    {
        public int Id { get; set; }
        public DateTime? AnalysisTime { get; set; }
        public double? KeShiBieLv { get; set; }
        public double? ShiBieZhunQueLv { get; set; }
        public string Memo { get; set; }
        public bool? Finished { get; set; }
        public string SubjectName { get; set; }
        public string VersionName { get; set; }
    }
}
