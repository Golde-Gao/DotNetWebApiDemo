using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class TiXingGenreCountConfig
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ConfSubjectQuestionTypeGenreId { get; set; }
        public int Count { get; set; }
    }
}
