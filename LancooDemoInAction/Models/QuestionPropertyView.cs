using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class QuestionPropertyView
    {
        public int GroupId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string VersionCode { get; set; }
        public string VersionName { get; set; }
        public string QuestionTypeCode { get; set; }
        public string QuestionTypeName { get; set; }
        public string GenreCode { get; set; }
        public string GenreName { get; set; }
    }
}
