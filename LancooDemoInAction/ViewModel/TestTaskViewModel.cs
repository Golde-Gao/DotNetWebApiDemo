﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancooDemoInAction.ViewModel
{
    public class TestTaskViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentTaskName { get; set; }  
        public DateTime? CreateTime { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }  
        public string TaskTypeName { get; set; }  
        public string StatusName { get; set; }  
        public string TaskStrategyName { get; set; }
        public int AutoChaYiSum { get; set; }
        public string AutoChaYi { get; set; }
        public string Memo { get; set; }
    }
}
