using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class FullTestContentEntityView
    {
        public int EntityId { get; set; }
        public string EntityXml { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public string VersionName { get; set; }
        public string VersionCode { get; set; }
        public string QuestionTypeName { get; set; }
        public string QuestionTypeCode { get; set; }
        public string GenreName { get; set; }
        public string GenreCode { get; set; }
        public string AllStem { get; set; }
        public string AllAsk { get; set; }
        public string AllOption { get; set; }
        public string AllAnswer { get; set; }
        public string AllAnalysis { get; set; }
        public string AllBody { get; set; }
        public string AllArticle { get; set; }
        public string FilePath { get; set; }
        public string TiKuTableId { get; set; }
        public string SourceDbconnectionText { get; set; }
        public string SourceDbquery { get; set; }
        public string SourceDbkeyField { get; set; }
        public string SourceDbkeyValue { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
