namespace BitBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "Religion", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "Birthday", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "Birthday", c => c.String());
            AlterColumn("dbo.Profiles", "Religion", c => c.String());
            AlterColumn("dbo.Profiles", "Country", c => c.String());
        }
    }
}
