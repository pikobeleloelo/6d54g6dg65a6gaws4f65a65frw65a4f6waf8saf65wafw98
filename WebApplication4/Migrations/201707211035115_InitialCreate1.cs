namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Traning", "AVG", c => c.String());
            AlterColumn("dbo.Traning", "MAX", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Traning", "MAX", c => c.Single(nullable: false));
            AlterColumn("dbo.Traning", "AVG", c => c.Single(nullable: false));
        }
    }
}
