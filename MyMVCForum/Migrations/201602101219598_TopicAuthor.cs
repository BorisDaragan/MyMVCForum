namespace MyMVCForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TopicAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "AuthorTopicId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Topics", "AuthorTopicId");
            AddForeignKey("dbo.Topics", "AuthorTopicId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Topics", "AuthorTopicId", "dbo.AspNetUsers");
            DropIndex("dbo.Topics", new[] { "AuthorTopicId" });
            DropColumn("dbo.Topics", "AuthorTopicId");
        }
    }
}
