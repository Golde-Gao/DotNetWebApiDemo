using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancooDemoInAction.ViewModelParameter
{
    public class TestTaskViewModelParameter
    {
        public string TaskName { get; set; }
        public string SubjectName { get; set; }
        public string Memo { get; set; }
        public int PageSize { get; set; } = 20;
        public int PageIndex { get; set; } = 1;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
