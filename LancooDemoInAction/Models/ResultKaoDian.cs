using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class ResultKaoDian
    {
        public int Id { get; set; }
        public int TtuTestQuestionIndexId { get; set; }
        public string SubSubject { get; set; }
        public string Topic { get; set; }
        public string Theme { get; set; }
        public string KnowledgeName { get; set; }
        public string KnowledgeCode { get; set; }
        public string KnowledgeUniqueCode { get; set; }
        public string KnowledgeType { get; set; }
        public int KaoDianTypeId { get; set; }
        public int KaoDianOriginTypeId { get; set; }
        public int StatusKaoDianId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? TaskCreateTime { get; set; }
        public string ExampleText { get; set; }
        public string KnowledgeVersion { get; set; }
    }
}
