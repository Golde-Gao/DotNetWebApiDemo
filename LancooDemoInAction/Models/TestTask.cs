using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TestTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ConfSubjectId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ParentTaskId { get; set; }
        public int StatusTaskId { get; set; }
        public int ConfTaskTypeId { get; set; }
        public int TaskStrategyId { get; set; }
        public string Memo { get; set; }
        public int AutoChaYiSum { get; set; }
        public string AutoChaYi { get; set; }
        public int AssignCount { get; set; }
        public DateTime? AutoUpdateTime { get; set; }
        public int? AutoCount { get; set; }
    }
}
