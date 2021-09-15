using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class CandidatePositionInfo
    {
        public int Id { get; set; }
        public int TtuTestQuestionIndexId { get; set; }
        public string Position { get; set; }
        public string Text { get; set; }
        public int? SplitIndex { get; set; }
        public DateTime? TaskCreateTime { get; set; }
    }
}
