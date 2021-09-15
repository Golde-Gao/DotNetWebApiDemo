using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TtuTestQuestion
    {
        public int Id { get; set; }
        public int Ttuid { get; set; }
        public int TestEntityId { get; set; }
        public string Memo { get; set; }
        public DateTime TaskCreateTime { get; set; }
    }
}
