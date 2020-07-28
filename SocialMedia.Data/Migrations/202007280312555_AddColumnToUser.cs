namespace SocialMedia.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUser", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationUser", "Name");
        }
    }
}
