namespace SocialMedia.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReply : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "ReplyComment_CommentId", "dbo.Comment");
            DropIndex("dbo.Comment", new[] { "ReplyComment_CommentId" });
            DropColumn("dbo.Comment", "ReplyComment_CommentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comment", "ReplyComment_CommentId", c => c.Int());
            CreateIndex("dbo.Comment", "ReplyComment_CommentId");
            AddForeignKey("dbo.Comment", "ReplyComment_CommentId", "dbo.Comment", "CommentId");
        }
    }
}
