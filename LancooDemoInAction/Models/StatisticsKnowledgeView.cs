using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class StatisticsKnowledgeView
    {
        public int Id { get; set; }
        public int GloBalId { get; set; }
        public string KnowledgeName { get; set; }
        public string KnowledgeType { get; set; }
        public int? PushCount { get; set; }
        public int? WrongCount { get; set; }
        public int? LoseCount { get; set; }
        public int? Total { get; set; }
    }
}
