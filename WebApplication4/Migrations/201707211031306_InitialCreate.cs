namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Traning",
                c => new
                    {
                        Id_traning = c.Int(nullable: false, identity: true),
                        DST = c.String(),
                        TM = c.String(),
                        AVG = c.String(),
                        MAX = c.String(),
                        KM1 = c.String(),
                        DATE = c.String(),
                        TEMP = c.String(),
                        WEATHER = c.String(),
                        ENDMNDO = c.String(),
                    })
                .PrimaryKey(t => t.Id_traning);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Traning");
        }
    }
}
