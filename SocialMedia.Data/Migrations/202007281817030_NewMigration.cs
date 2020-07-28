namespace SocialMedia.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "ReplyId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comment", "ReplyId");
        }
    }
}
