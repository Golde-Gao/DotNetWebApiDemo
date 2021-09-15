using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TaskJoinView
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string ParentTaskName { get; set; }
        public int? ParentTaskId { get; set; }
        public DateTime? Createtime { get; set; }
        public int ConfSubjectid { get; set; }
        public int ConfTasktypeid { get; set; }
        public int StatusTaskId { get; set; }
        public int TaskStrategyId { get; set; }
        public int AutoChaYiSum { get; set; }
        public string AutoChaYi { get; set; }
        public string Memo { get; set; }
    }
}
