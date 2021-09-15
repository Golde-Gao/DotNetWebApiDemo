using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TaskAndUserView
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string ParentTaskName { get; set; }
        public int? ParentTaskId { get; set; }
        public DateTime? Createtime { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int ConfSubjectid { get; set; }
        public string TaskTypeName { get; set; }
        public int ConfTasktypeid { get; set; }
        public string StatusName { get; set; }
        public int Statustaskid { get; set; }
        public int TaskStrategyId { get; set; }
        public string TaskStrategyName { get; set; }
        public int AutoChaYiSum { get; set; }
        public string Memo { get; set; }
        public int TotalCount { get; set; }
        public int TaskAndUserId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int TaskAndUserStatusId { get; set; }
        public string TaskAndUserStatusName { get; set; }
    }
}
