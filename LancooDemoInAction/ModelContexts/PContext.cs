using LancooDemoInAction.Models;
using Microsoft.EntityFrameworkCore;

namespace LancooDemoInAction.ModelContexts
{
    public partial class PContext : DbContext
    {
        public PContext()
        {
        }

        public PContext(DbContextOptions<PContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CandidatePositionInfo> CandidatePositionInfo { get; set; }
        public virtual DbSet<CandidateResultZhiShiDian> CandidateResultZhiShiDian { get; set; }
        public virtual DbSet<CandidateResultZhiShiDianPosition> CandidateResultZhiShiDianPosition { get; set; }
        public virtual DbSet<CheckType> CheckType { get; set; }
        public virtual DbSet<ConfGenre> ConfGenre { get; set; }
        public virtual DbSet<ConfKaoDianOriginType> ConfKaoDianOriginType { get; set; }
        public virtual DbSet<ConfKaoDianType> ConfKaoDianType { get; set; }
        public virtual DbSet<ConfQuestionType> ConfQuestionType { get; set; }
        public virtual DbSet<ConfShiTiCategory> ConfShiTiCategory { get; set; }
        public virtual DbSet<ConfShiTiCategoryTtuTestQuestion> ConfShiTiCategoryTtuTestQuestion { get; set; }
        public virtual DbSet<ConfShiTiCategoryView> ConfShiTiCategoryView { get; set; }
        public virtual DbSet<ConfStage> ConfStage { get; set; }
        public virtual DbSet<ConfStatusKaoChaLeiXing> ConfStatusKaoChaLeiXing { get; set; }
        public virtual DbSet<ConfStatusKaoDian> ConfStatusKaoDian { get; set; }
        public virtual DbSet<ConfStatusQuestion> ConfStatusQuestion { get; set; }
        public virtual DbSet<ConfStatusTask> ConfStatusTask { get; set; }
        public virtual DbSet<ConfStatusZhuTi> ConfStatusZhuTi { get; set; }
        public virtual DbSet<ConfSubject> ConfSubject { get; set; }
        public virtual DbSet<ConfSubjectQuestionTypeGenre> ConfSubjectQuestionTypeGenre { get; set; }
        public virtual DbSet<ConfTaskType> ConfTaskType { get; set; }
        public virtual DbSet<ConfVersion> ConfVersion { get; set; }
        public virtual DbSet<ConfZhuTiOriginType> ConfZhuTiOriginType { get; set; }
        public virtual DbSet<FullTestContentEntityView> FullTestContentEntityView { get; set; }
        public virtual DbSet<IssueRecord> IssueRecord { get; set; }
        public virtual DbSet<IssueRecordView> IssueRecordView { get; set; }
        public virtual DbSet<IssueType> IssueType { get; set; }
        public virtual DbSet<KnowledgeType> KnowledgeType { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PositionInfo> PositionInfo { get; set; }
        public virtual DbSet<QuestionPropertyView> QuestionPropertyView { get; set; }
        public virtual DbSet<ResultAnalysis> ResultAnalysis { get; set; }
        public virtual DbSet<ResultKaoChaLeiXing> ResultKaoChaLeiXing { get; set; }
        public virtual DbSet<ResultKaoDian> ResultKaoDian { get; set; }
        public virtual DbSet<ResultZhuTi> ResultZhuTi { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SolveType> SolveType { get; set; }
        public virtual DbSet<StatisticsAnalysisType> StatisticsAnalysisType { get; set; }
        public virtual DbSet<StatisticsGlobal> StatisticsGlobal { get; set; }
        public virtual DbSet<StatisticsGlobalLineChartView> StatisticsGlobalLineChartView { get; set; }
        public virtual DbSet<StatisticsKnowledge> StatisticsKnowledge { get; set; }
        public virtual DbSet<StatisticsKnowledgeView> StatisticsKnowledgeView { get; set; }
        public virtual DbSet<StatisticsQuestionType> StatisticsQuestionType { get; set; }
        public virtual DbSet<StatisticsQuestionTypeAnalysisView> StatisticsQuestionTypeAnalysisView { get; set; }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationKnowledgeLose>
            StatisticsTtuTestQuestionRecRelationKnowledgeLose { get; set; }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationKnowledgeWrong>
            StatisticsTtuTestQuestionRecRelationKnowledgeWrong { get; set; }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationType> StatisticsTtuTestQuestionRecRelationType
        {
            get;
            set;
        }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationTypeKnowledgeTypeLose>
            StatisticsTtuTestQuestionRecRelationTypeKnowledgeTypeLose { get; set; }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationTypeKnowledgeTypeWrong>
            StatisticsTtuTestQuestionRecRelationTypeKnowledgeTypeWrong { get; set; }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationTypeLoseView>
            StatisticsTtuTestQuestionRecRelationTypeLoseView { get; set; }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationTypeView> StatisticsTtuTestQuestionRecRelationTypeView
        {
            get;
            set;
        }

        public virtual DbSet<StatisticsTtuTestQuestionRecRelationTypeWrongView>
            StatisticsTtuTestQuestionRecRelationTypeWrongView { get; set; }

        public virtual DbSet<TaskAndUserView> TaskAndUserView { get; set; }
        public virtual DbSet<TaskDontRepeatConfig> TaskDontRepeatConfig { get; set; }
        public virtual DbSet<TaskJoinView> TaskJoinView { get; set; }
        public virtual DbSet<TaskStrategy> TaskStrategy { get; set; }
        public virtual DbSet<TaskView> TaskView { get; set; }
        public virtual DbSet<TestContentEntity> TestContentEntity { get; set; }
        public virtual DbSet<TestTask> TestTask { get; set; }
        public virtual DbSet<TestTaskAndUser> TestTaskAndUser { get; set; }
        public virtual DbSet<TiXingGenreCountConfig> TiXingGenreCountConfig { get; set; }
        public virtual DbSet<TtuTestQuestion> TtuTestQuestion { get; set; }
        public virtual DbSet<TtuTestQuestionIndex> TtuTestQuestionIndex { get; set; }
        public virtual DbSet<TtuTestQuestionRec> TtuTestQuestionRec { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http: //go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(
                    "server=127.0.0.1;initial catalog=AllSubjectTest;user id=sa;password=UJM@asd09;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidatePositionInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 10,000,000");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("文本位置信息，题干、材料、答案、解析、选项等");

                entity.Property(e => e.TaskCreateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .HasMaxLength(3000)
                    .HasComment("文本内容");

                entity.Property(e => e.TtuTestQuestionIndexId).HasColumnName("TTU_TestQuestionIndexID");
            });

            modelBuilder.Entity<CandidateResultZhiShiDian>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100,000,000");

                entity.Property(e => e.KnowledgeCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.KnowledgeFeature).HasMaxLength(2000);

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.KnowledgeType).HasMaxLength(200);

                entity.Property(e => e.SubSubject).HasMaxLength(200);

                entity.Property(e => e.TaskCreateTime).HasColumnType("datetime");

                entity.Property(e => e.Theme).HasMaxLength(200);

                entity.Property(e => e.Topic).HasMaxLength(200);

                entity.Property(e => e.TtuTestQuestionIndexId).HasColumnName("TTU_TestQuestionIndexID");

                entity.Property(e => e.Version).HasMaxLength(50);
            });

            modelBuilder.Entity<CandidateResultZhiShiDianPosition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidatePositionInfoId).HasColumnName("CandidatePositionInfoID");

                entity.Property(e => e.KnowledgeCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.KnowledgeFeature).HasMaxLength(2000);

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.KnowledgeType).HasMaxLength(20);

                entity.Property(e => e.SubSubject).HasMaxLength(20);

                entity.Property(e => e.TaskCreateTime).HasColumnType("datetime");

                entity.Property(e => e.Theme).HasMaxLength(20);

                entity.Property(e => e.Topic).HasMaxLength(20);

                entity.Property(e => e.Version).HasMaxLength(20);
            });

            modelBuilder.Entity<CheckType>(entity =>
            {
                entity.ToTable("CheckType", "TestReply");

                entity.HasComment("英语考点测试反馈问题记录表-问题复核类型");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfGenre>(entity =>
            {
                entity.ToTable("Conf_Genre");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ConfKaoDianOriginType>(entity =>
            {
                entity.ToTable("Conf_KaoDianOriginType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ConfKaoDianType>(entity =>
            {
                entity.ToTable("Conf_KaoDianType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ConfQuestionType>(entity =>
            {
                entity.ToTable("Conf_QuestionType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ConfShiTiCategory>(entity =>
            {
                entity.ToTable("Conf_ShiTiCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ConfShiTiCategoryTtuTestQuestion>(entity =>
            {
                entity.ToTable("Conf_ShiTiCategoryTTU_TestQuestion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfShiTiCategoryId).HasColumnName("Conf_ShiTiCategoryID");

                entity.Property(e => e.TtuTestQuestionId).HasColumnName("TTU_TestQuestionID");
            });

            modelBuilder.Entity<ConfShiTiCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Conf_ShiTiCategoryView");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ConfShiTiCategoryId).HasColumnName("Conf_ShiTiCategoryID");

                entity.Property(e => e.ConfShiTiCategoryTtuTestQuestionId)
                    .HasColumnName("Conf_ShiTiCategoryTTU_TestQuestionID");

                entity.Property(e => e.TtuTestQuestionId).HasColumnName("TTU_TestQuestionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ConfStage>(entity =>
            {
                entity.ToTable("Conf_Stage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ConfStatusKaoChaLeiXing>(entity =>
            {
                entity.ToTable("Conf_StatusKaoChaLeiXing");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ConfStatusKaoDian>(entity =>
            {
                entity.ToTable("Conf_StatusKaoDian");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ConfStatusQuestion>(entity =>
            {
                entity.ToTable("Conf_StatusQuestion");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<ConfStatusTask>(entity =>
            {
                entity.ToTable("Conf_StatusTask");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<ConfStatusZhuTi>(entity =>
            {
                entity.ToTable("Conf_StatusZhuTi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ConfSubject>(entity =>
            {
                entity.ToTable("Conf_Subject");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<ConfSubjectQuestionTypeGenre>(entity =>
            {
                entity.ToTable("Conf_SubjectQuestionTypeGenre");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("id property,auto-increment start start from 10,000");

                entity.Property(e => e.GenreId)
                    .HasColumnName("GenreID")
                    .HasComment("体裁缺省时，值为0");

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<ConfTaskType>(entity =>
            {
                entity.ToTable("Conf_TaskType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ConfVersion>(entity =>
            {
                entity.ToTable("Conf_Version");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ConfZhuTiOriginType>(entity =>
            {
                entity.ToTable("Conf_ZhuTiOriginType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FullTestContentEntityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FullTestContentEntityView");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.EntityXml)
                    .HasColumnName("EntityXML")
                    .HasColumnType("xml");

                entity.Property(e => e.FilePath).HasMaxLength(200);

                entity.Property(e => e.GenreCode).HasMaxLength(10);

                entity.Property(e => e.GenreName).HasMaxLength(60);

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.QuestionTypeCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.QuestionTypeName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SourceDbconnectionText)
                    .IsRequired()
                    .HasColumnName("SourceDBConnectionText")
                    .HasMaxLength(1000);

                entity.Property(e => e.SourceDbkeyField)
                    .HasColumnName("SourceDBKeyField")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceDbkeyValue)
                    .HasColumnName("SourceDBKeyValue")
                    .HasMaxLength(300);

                entity.Property(e => e.SourceDbquery)
                    .IsRequired()
                    .HasColumnName("SourceDBQuery")
                    .HasMaxLength(1000);

                entity.Property(e => e.SubjectCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.TiKuTableId)
                    .HasColumnName("TiKuTableID")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IssueRecord>(entity =>
            {
                entity.ToTable("IssueRecord", "TestReply");

                entity.HasComment("英语考点测试反馈问题记录表");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckReply).HasMaxLength(600);

                entity.Property(e => e.CheckTypeId).HasColumnName("CheckTypeID");

                entity.Property(e => e.IssueTypeId).HasColumnName("IssueTypeID");

                entity.Property(e => e.Knowledge).HasMaxLength(600);

                entity.Property(e => e.KnowledgeMemo).HasMaxLength(600);

                entity.Property(e => e.KnowledgeTypeId).HasColumnName("KnowledgeTypeID");

                entity.Property(e => e.ReportAccountId).HasColumnName("ReportAccountID");

                entity.Property(e => e.ReportTime).HasColumnType("datetime");

                entity.Property(e => e.SolveAccountId).HasColumnName("SolveAccountID");

                entity.Property(e => e.SolveTime).HasColumnType("datetime");

                entity.Property(e => e.SolveTypeId).HasColumnName("SolveTypeID");

                entity.Property(e => e.TestEntityId).HasColumnName("TestEntityID");
            });

            modelBuilder.Entity<IssueRecordView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IssueRecordView", "TestReply");

                entity.Property(e => e.CheckReply).HasMaxLength(600);

                entity.Property(e => e.CheckTypeId).HasColumnName("CheckTypeID");

                entity.Property(e => e.CheckTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EntityXml).HasColumnType("xml");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.IssueTypeId).HasColumnName("IssueTypeID");

                entity.Property(e => e.IssueTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Knowledge).HasMaxLength(600);

                entity.Property(e => e.KnowledgeMemo).HasMaxLength(600);

                entity.Property(e => e.KnowledgeTypeId).HasColumnName("KnowledgeTypeID");

                entity.Property(e => e.KnowledgeTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OldPlatFromId).HasColumnName("OldPlatFromID");

                entity.Property(e => e.ReportAccountId).HasColumnName("ReportAccountID");

                entity.Property(e => e.ReportAccountName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReportTime).HasColumnType("datetime");

                entity.Property(e => e.SolveAccountId).HasColumnName("SolveAccountID");

                entity.Property(e => e.SolveAccountName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SolveTime).HasColumnType("datetime");

                entity.Property(e => e.SolveTypeId).HasColumnName("SolveTypeID");

                entity.Property(e => e.SolveTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TestEntityId).HasColumnName("TestEntityID");
            });

            modelBuilder.Entity<IssueType>(entity =>
            {
                entity.ToTable("IssueType", "TestReply");

                entity.HasComment("英语考点测试反馈问题记录表-反馈问题类型");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KnowledgeType>(entity =>
            {
                entity.ToTable("KnowledgeType", "TestReply");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100");

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Permission id property,auto-increment start from 10,000");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("权限名称");

                entity.Property(e => e.Permission1)
                    .IsRequired()
                    .HasColumnName("Permission")
                    .HasMaxLength(200)
                    .HasComment("权限字符串，e.g role:create,role:update");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("角色表ID 关联表Role");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .HasComment("前端资源路径");
            });

            modelBuilder.Entity<PositionInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 10,000,000");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasComment("题干、答案、解析、选项、材料等");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.Property(e => e.TtuTestQuestionIndexId).HasColumnName("TTU_TestQuestionIndexID");
            });

            modelBuilder.Entity<QuestionPropertyView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QuestionPropertyView");

                entity.Property(e => e.GenreCode).HasMaxLength(10);

                entity.Property(e => e.GenreName).HasMaxLength(60);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.QuestionTypeCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.QuestionTypeName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SubjectCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ResultAnalysis>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.QuestionType).HasMaxLength(200);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ZhengQueYouYiLouCount).HasColumnName("ZhengQue_YouYiLouCount");
            });

            modelBuilder.Entity<ResultKaoChaLeiXing>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 1,000,000");

                entity.Property(e => e.KaoChaLeiXingCondition).HasMaxLength(3000);

                entity.Property(e => e.KaoChaLeiXingName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.StatusKaoChaLeiXingId)
                    .HasColumnName("StatusKaoChaLeiXingID")
                    .HasComment("考查类型识别状态,与Conf_StatusKaoChaLeiXing表对应");

                entity.Property(e => e.TtuTestQuestionIndexId).HasColumnName("TTU_TestQuestionIndexID");
            });

            modelBuilder.Entity<ResultKaoDian>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100,000,000");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExampleText).HasMaxLength(1000);

                entity.Property(e => e.KaoDianOriginTypeId).HasColumnName("KaoDianOriginTypeID");

                entity.Property(e => e.KaoDianTypeId).HasColumnName("KaoDianTypeID");

                entity.Property(e => e.KnowledgeCode).HasMaxLength(1000);

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.KnowledgeType).HasMaxLength(50);

                entity.Property(e => e.KnowledgeUniqueCode).HasMaxLength(1000);

                entity.Property(e => e.KnowledgeVersion).HasMaxLength(200);

                entity.Property(e => e.StatusKaoDianId)
                    .HasColumnName("StatusKaoDianID")
                    .HasComment("标记的考点的识别状态，因为相同考点名称只显示一个考点，因此这里对一个“考点名称”的审核即影响所有此名称的不同专主题的考点，关联表：Conf_StatusKaoDian");

                entity.Property(e => e.SubSubject).HasMaxLength(200);

                entity.Property(e => e.TaskCreateTime).HasColumnType("datetime");

                entity.Property(e => e.Theme).HasMaxLength(200);

                entity.Property(e => e.Topic).HasMaxLength(200);

                entity.Property(e => e.TtuTestQuestionIndexId).HasColumnName("TTU_TestQuestionIndexID");
            });

            modelBuilder.Entity<ResultZhuTi>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.KnowledgeCode).HasMaxLength(200);

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.KnowledgeType).HasMaxLength(200);

                entity.Property(e => e.KnowledgeUniqueCode).HasMaxLength(200);

                entity.Property(e => e.StatusZhuTiId).HasColumnName("StatusZhuTiID");

                entity.Property(e => e.SubSubject).HasMaxLength(200);

                entity.Property(e => e.Theme).HasMaxLength(200);

                entity.Property(e => e.Topic).HasMaxLength(200);

                entity.Property(e => e.TtuTestQuestionIndexId).HasColumnName("TTU_TestQuestionIndexID");

                entity.Property(e => e.ZhuTiOriginTypeId).HasColumnName("ZhuTiOriginTypeID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("role id property,auto-increment from 100");

                entity.Property(e => e.Available).HasComment("是否可用（0表示不可用，1表示可用），如果不可用将不会赋予给用户");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SolveType>(entity =>
            {
                entity.ToTable("SolveType", "TestReply");

                entity.HasComment("英语考点测试反馈问题记录表-问题解决类型");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StatisticsAnalysisType>(entity =>
            {
                entity.ToTable("Statistics_AnalysisType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<StatisticsGlobal>(entity =>
            {
                entity.ToTable("Statistics_Global");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalysisTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SubjectName).HasMaxLength(100);

                entity.Property(e => e.VersionName).HasMaxLength(100);
            });

            modelBuilder.Entity<StatisticsGlobalLineChartView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Statistics_GlobalLineChartView");

                entity.Property(e => e.GloBalId).HasColumnName("GloBalID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<StatisticsKnowledge>(entity =>
            {
                entity.ToTable("Statistics_Knowledge");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GloBalId).HasColumnName("GloBalID");

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.KnowledgeType).HasMaxLength(100);
            });

            modelBuilder.Entity<StatisticsKnowledgeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Statistics_KnowledgeView");

                entity.Property(e => e.GloBalId).HasColumnName("GloBalID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.KnowledgeType).HasMaxLength(100);
            });

            modelBuilder.Entity<StatisticsQuestionType>(entity =>
            {
                entity.ToTable("Statistics_QuestionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GloBalId).HasColumnName("GloBalID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<StatisticsQuestionTypeAnalysisView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Statistics_QuestionTypeAnalysisView");

                entity.Property(e => e.GloBalId).HasColumnName("GloBalID");

                entity.Property(e => e.ShiTiName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.StatisticsQuestionTypeId).HasColumnName("Statistics_QuestionTypeID");
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationKnowledgeLose>(entity =>
            {
                entity.ToTable("Statistics_TTU_TestQuestionRecRelationKnowledgeLose");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SknowledgeId).HasColumnName("SKnowledgeID");

                entity.Property(e => e.TtuRecId).HasColumnName("TTU_RecID");
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationKnowledgeWrong>(entity =>
            {
                entity.ToTable("Statistics_TTU_TestQuestionRecRelationKnowledgeWrong");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SknowledgeId).HasColumnName("SKnowledgeID");

                entity.Property(e => e.TtuRecId).HasColumnName("TTU_RecID");
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationType>(entity =>
            {
                entity.ToTable("Statistics_TTU_TestQuestionRecRelationType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalysisTypeId).HasColumnName("AnalysisTypeID");

                entity.Property(e => e.SquestionTypeId).HasColumnName("SQuestionTypeID");

                entity.Property(e => e.TestEntityId).HasColumnName("TestEntityID");

                entity.Property(e => e.TtuRecId).HasColumnName("TTU_RecID");
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationTypeKnowledgeTypeLose>(entity =>
            {
                entity.ToTable("Statistics_TTU_TestQuestionRecRelationTypeKnowledgeTypeLose");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.KnowledgeType).HasMaxLength(100);

                entity.Property(e => e.StatisticsTtuTestQuestionRecRelationTypeId)
                    .HasColumnName("Statistics_TTU_TestQuestionRecRelationTypeID");
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationTypeKnowledgeTypeWrong>(entity =>
            {
                entity.ToTable("Statistics_TTU_TestQuestionRecRelationTypeKnowledgeTypeWrong");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KnowledgeName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.KnowledgeType).HasMaxLength(100);

                entity.Property(e => e.StatisticsTtuTestQuestionRecRelationTypeId)
                    .HasColumnName("Statistics_TTU_TestQuestionRecRelationTypeID");
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationTypeLoseView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Statistics_TTU_TestQuestionRecRelationTypeLoseView");

                entity.Property(e => e.AnalysisTypeId).HasColumnName("AnalysisTypeID");

                entity.Property(e => e.KnowledgeType).HasMaxLength(100);

                entity.Property(e => e.SquestionTypeId).HasColumnName("SQuestionTypeID");

                entity.Property(e => e.StatisticsTtuTestQuestionRecRelationTypeId)
                    .HasColumnName("Statistics_TTU_TestQuestionRecRelationTypeID");

                entity.Property(e => e.TestEntityId).HasColumnName("TestEntityID");

                entity.Property(e => e.TtuRecId).HasColumnName("TTU_RecID");
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationTypeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Statistics_TTU_TestQuestionRecRelationTypeView");

                entity.Property(e => e.AnalysisTypeId).HasColumnName("AnalysisTypeID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LoseState)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SquestionTypeId).HasColumnName("SQuestionTypeID");

                entity.Property(e => e.TestEntityId).HasColumnName("TestEntityID");

                entity.Property(e => e.TtuRecId).HasColumnName("TTU_RecID");

                entity.Property(e => e.WrongState)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatisticsTtuTestQuestionRecRelationTypeWrongView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Statistics_TTU_TestQuestionRecRelationTypeWrongView");

                entity.Property(e => e.AnalysisTypeId).HasColumnName("AnalysisTypeID");

                entity.Property(e => e.KnowledgeType).HasMaxLength(100);

                entity.Property(e => e.SquestionTypeId).HasColumnName("SQuestionTypeID");

                entity.Property(e => e.StatisticsTtuTestQuestionRecRelationTypeId)
                    .HasColumnName("Statistics_TTU_TestQuestionRecRelationTypeID");

                entity.Property(e => e.TestEntityId).HasColumnName("TestEntityID");

                entity.Property(e => e.TtuRecId).HasColumnName("TTU_RecID");
            });

            modelBuilder.Entity<TaskAndUserView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TaskAndUserView");

                entity.Property(e => e.ConfSubjectid).HasColumnName("conf_subjectid");

                entity.Property(e => e.ConfTasktypeid).HasColumnName("conf_tasktypeid");

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.ParentTaskId).HasColumnName("ParentTaskID");

                entity.Property(e => e.ParentTaskName).HasMaxLength(60);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Statustaskid).HasColumnName("statustaskid");

                entity.Property(e => e.SubjectCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.TaskAndUserId).HasColumnName("TaskAndUserID");

                entity.Property(e => e.TaskAndUserStatusName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TaskStrategyId).HasColumnName("TaskStrategyID");

                entity.Property(e => e.TaskStrategyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TaskTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TaskDontRepeatConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DontRepeatTaskId).HasColumnName("DontRepeatTaskID");

                entity.Property(e => e.OriginTaskId).HasColumnName("OriginTaskID");
            });

            modelBuilder.Entity<TaskJoinView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TaskJoinView");

                entity.Property(e => e.AutoChaYi)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.ConfSubjectid).HasColumnName("conf_subjectid");

                entity.Property(e => e.ConfTasktypeid).HasColumnName("conf_tasktypeid");

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.ParentTaskId).HasColumnName("ParentTaskID");

                entity.Property(e => e.ParentTaskName).HasMaxLength(60);

                entity.Property(e => e.StatusTaskId).HasColumnName("StatusTaskID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TaskStrategyId).HasColumnName("TaskStrategyID");
            });

            modelBuilder.Entity<TaskStrategy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TaskView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TaskView");

                entity.Property(e => e.AutoChaYi)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.ConfSubjectid).HasColumnName("conf_subjectid");

                entity.Property(e => e.ConfTasktypeid).HasColumnName("conf_tasktypeid");

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.ParentTaskId).HasColumnName("ParentTaskID");

                entity.Property(e => e.ParentTaskName).HasMaxLength(60);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Statustaskid).HasColumnName("statustaskid");

                entity.Property(e => e.SubjectCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TaskStrategyId).HasColumnName("TaskStrategyID");

                entity.Property(e => e.TaskStrategyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TaskTypeName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TestContentEntity>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("id property,auto-increment start start from 100,000,000");

                entity.Property(e => e.AllStem)
                    .HasComment("把试题XML拆分，这里是拆得的所有Stem字段文本内容，且是经过相关处理，取出一些格式后的文本。其他几个ALLXXXX的字段于此一样");

                entity.Property(e => e.ConfSubjectQuestionTypeGenreId)
                    .HasColumnName("Conf_SubjectQuestionTypeGenreID")
                    .HasComment("学科-题型-体裁-学习阶段，配置信息表，对应此题的四个固有属性");

                entity.Property(e => e.EntityXml)
                    .HasColumnName("EntityXML")
                    .HasColumnType("xml")
                    .HasComment("the whole test XML text");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(2000)
                    .HasComment("试题可能包含视频，音频文件，这个是存储的相对路径");

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.OldPlatFromId).HasColumnName("OldPlatFromID");

                entity.Property(e => e.SourceDbconnectionText)
                    .IsRequired()
                    .HasColumnName("SourceDBConnectionText")
                    .HasMaxLength(1000)
                    .HasComment("试题是从题库查询更新过来的，这个表示对应数据库的链接字符串");

                entity.Property(e => e.SourceDbkeyField)
                    .HasColumnName("SourceDBKeyField")
                    .HasMaxLength(200)
                    .HasComment("试题是从题库查询更新过来的，这个表示对应的查询条件字段");

                entity.Property(e => e.SourceDbkeyValue)
                    .HasColumnName("SourceDBKeyValue")
                    .HasMaxLength(300);

                entity.Property(e => e.SourceDbquery)
                    .IsRequired()
                    .HasColumnName("SourceDBQuery")
                    .HasMaxLength(1000)
                    .HasComment("试题是从题库查询更新过来的，这个表示对应的查询语句");

                entity.Property(e => e.TiKuTableId)
                    .HasColumnName("TiKuTableID")
                    .HasMaxLength(200)
                    .HasComment("题库试题记录存的ID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TestTask>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto increment start from 1,000,000");

                entity.Property(e => e.AutoChaYi)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.AutoUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ConfSubjectId)
                    .HasColumnName("Conf_SubjectID")
                    .HasComment("状态id，指示任务当前状态，关联任务状态表Conf_StatusTask");

                entity.Property(e => e.ConfTaskTypeId)
                    .HasColumnName("Conf_TaskTypeID")
                    .HasComment("人物类型id，指示任务类型，关联任务类型表Conf_TaskType");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("when task created, some tables separate operation also the base on it.");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasComment(
                        "任务名称是不能重复的，测试人不存在分学科的问题，因为任务页自然是不分学科的，但是实际测题的时候，是不提供不同学科同时测试的。所有的任务名字不能存在重复！！！！就只这么粗暴，请起名字的时候注意，这里在实现的时候也要加唯一性验证");

                entity.Property(e => e.ParentTaskId)
                    .HasColumnName("ParentTaskID")
                    .HasComment("一些个重新识别之类的操作，重新识别后生成一个新任务，原任务就是新任务的ParentTask");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("when the request to recongize start.");

                entity.Property(e => e.StatusTaskId)
                    .HasColumnName("StatusTaskID")
                    .HasComment("学科ID，关联学科信息");

                entity.Property(e => e.TaskStrategyId).HasColumnName("TaskStrategyID");
            });

            modelBuilder.Entity<TestTaskAndUser>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("role id property,auto-increment start start from 100000");

                entity.Property(e => e.StatusTaskId)
                    .HasColumnName("StatusTaskID")
                    .HasComment("关联Conf_StatusTask表");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TiXingGenreCountConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfSubjectQuestionTypeGenreId).HasColumnName("Conf_SubjectQuestionTypeGenreID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<TtuTestQuestion>(entity =>
            {
                entity.ToTable("TTU_TestQuestion");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("role id property,auto-increment start start from 100,000,000");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.TaskCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TestEntityId)
                    .HasColumnName("TestEntityID")
                    .HasComment("related to table TestContentEntity");

                entity.Property(e => e.Ttuid)
                    .HasColumnName("TTUID")
                    .HasComment("related to table TestTaskAndUser");
            });

            modelBuilder.Entity<TtuTestQuestionIndex>(entity =>
            {
                entity.ToTable("TTU_TestQuestionIndex");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("auto-increment start from 100,000,000");

                entity.Property(e => e.IndexTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment(
                        "小题信息，此处0即代表整个试题。1,2,3,4,5... ...表示一级小题划分；1-0，表示一级小题的整体，1-1表示一级小题的第一子小题；其他情况以此推至第n题的第n级子小题，当然，此处可能用到的最多估计也就是一级小题了，防止后续有更细致的划分方式，此处做如此设计。");

                entity.Property(e => e.InnerIndex)
                    .HasComment("配合index，给这个TTU_TestQuestionIndex排序用的。Index字段只是代表题号的文本信息，无法用作排序");

                entity.Property(e => e.TaskCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TtuTestQuestionRecId).HasColumnName("TTU_TestQuestionRecID");
            });

            modelBuilder.Entity<TtuTestQuestionRec>(entity =>
            {
                entity.ToTable("TTU_TestQuestionRec");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.CreateByClick).HasComment("0表示通过批量识别获得，初次抽题或者任务重测；1表示手动点击重新识别的结果");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.StatusQuestionId).HasColumnName("StatusQuestionID");

                entity.Property(e => e.TaskCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TtuTestQuestionId).HasColumnName("TTU_TestQuestionID");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("id,auto increment start from 1000");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("related to the table Role s ID property. ");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}