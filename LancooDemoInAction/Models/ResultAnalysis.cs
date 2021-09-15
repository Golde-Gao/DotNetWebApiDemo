using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LancooDemoInAction.Models
{
    public partial class ResultAnalysis
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int? UserId { get; set; }
        public string QuestionType { get; set; }
        public int? Total { get; set; }
        public int? KaoDianFeiKongCount { get; set; }
        public double? RecJieGuoLv { get; set; }
        public int? KaoDianZhengQueCount { get; set; }
        public double? ZhunQueLv { get; set; }
        public double? HouXuanZhunQueLv1 { get; set; }
        public int? WanQuanZhengQueCount { get; set; }
        public double? HouXuanZhunQueLv2 { get; set; }
        public double? KeShiBieLv { get; set; }
        public int? ZhengQueYouYiLouCount { get; set; }
        public double? YiLouLv { get; set; }
        public int? CunZaiCuoShiBieCount { get; set; }
        public double? CuoShiBieLv { get; set; }
        public double? WeiShiBieLv { get; set; }
        public double? CunZaiLouShiBieLv { get; set; }
        public double? CunZaiCuoShiBieLv { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? AnaType { get; set; }
        public string Memo { get; set; }
    }
}
