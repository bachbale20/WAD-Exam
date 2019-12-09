namespace WAD_Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initializedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        ExamSubject = c.String(unicode: false),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        ExamDate = c.DateTime(nullable: false, precision: 0),
                        ExamDuration = c.DateTime(nullable: false, precision: 0),
                        Room = c.String(unicode: false),
                        Faculty = c.String(unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
