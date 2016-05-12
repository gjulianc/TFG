namespace EFData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateAccess : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DateAccess", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "DateAccess");
        }
    }
}
