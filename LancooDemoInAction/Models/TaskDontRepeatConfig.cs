using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TaskDontRepeatConfig
    {
        public int Id { get; set; }
        public int OriginTaskId { get; set; }
        public int DontRepeatTaskId { get; set; }
    }
}
