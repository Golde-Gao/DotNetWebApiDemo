using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class CandidateResultZhiShiDianPosition
    {
        public int Id { get; set; }
        public int CandidatePositionInfoId { get; set; }
        public string KnowledgeName { get; set; }
        public string KnowledgeCode { get; set; }
        public string SubSubject { get; set; }
        public string Topic { get; set; }
        public string Theme { get; set; }
        public string Version { get; set; }
        public string KnowledgeType { get; set; }
        public DateTime? TaskCreateTime { get; set; }
        public string KnowledgeFeature { get; set; }
    }
}
