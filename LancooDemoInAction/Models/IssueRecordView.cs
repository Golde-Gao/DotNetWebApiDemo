using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class IssueRecordView
    {
        public int IssueId { get; set; }
        public int TestEntityId { get; set; }
        public int? OldPlatFromId { get; set; }
        public string EntityXml { get; set; }
        public string AllStem { get; set; }
        public string AllAsk { get; set; }
        public string AllOption { get; set; }
        public string AllAnswer { get; set; }
        public string AllAnalysis { get; set; }
        public string AllBody { get; set; }
        public string AllArticle { get; set; }
        public string Sentence { get; set; }
        public string SentenceResult { get; set; }
        public int IssueTypeId { get; set; }
        public string IssueTypeName { get; set; }
        public int CheckTypeId { get; set; }
        public string CheckReply { get; set; }
        public string CheckTypeName { get; set; }
        public int ReportAccountId { get; set; }
        public string ReportAccountName { get; set; }
        public DateTime? ReportTime { get; set; }
        public string Knowledge { get; set; }
        public int? KnowledgeTypeId { get; set; }
        public string KnowledgeTypeName { get; set; }
        public string KnowledgeMemo { get; set; }
        public string KnowledgeReply { get; set; }
        public int SolveTypeId { get; set; }
        public string SolveTypeName { get; set; }
        public DateTime? SolveTime { get; set; }
        public int SolveAccountId { get; set; }
        public int? SuccessPush { get; set; }
        public string SolveAccountName { get; set; }
    }
}
