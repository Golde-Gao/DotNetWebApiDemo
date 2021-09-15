using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TestTaskAndUser
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string TaskName { get; set; }
        public int StatusTaskId { get; set; }
        public int TotalCount { get; set; }
        public int AutoChaYiSum { get; set; }
    }
}
