namespace MyMVCForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateModels7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "AuthorPostId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "AuthorPostId");
            AddForeignKey("dbo.Posts", "AuthorPostId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "AuthorPostId", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "AuthorPostId" });
            DropColumn("dbo.Posts", "AuthorPostId");
        }
    }
}
