namespace MyMVCForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "DateTopic", c => c.DateTime(nullable: false));
            AddColumn("dbo.Topics", "DatePost", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Topics", "DatePost");
            DropColumn("dbo.Posts", "DateTopic");
        }
    }
}
