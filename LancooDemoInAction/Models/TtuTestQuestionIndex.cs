using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TtuTestQuestionIndex
    {
        public int Id { get; set; }
        public int TtuTestQuestionRecId { get; set; }
        public string IndexTitle { get; set; }
        public int InnerIndex { get; set; }
        public DateTime? TaskCreateTime { get; set; }
    }
}
