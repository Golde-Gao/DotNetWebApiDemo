using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class StatisticsTtuTestQuestionRecRelationKnowledgeLose
    {
        public int Id { get; set; }
        public int SknowledgeId { get; set; }
        public int TtuRecId { get; set; }
        public int LoseCode { get; set; }
    }
}
