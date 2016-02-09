namespace MyMVCForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModels1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "PostText", c => c.String(nullable: false));
            AlterColumn("dbo.Topics", "TopicName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Topics", "TopicName", c => c.String());
            AlterColumn("dbo.Posts", "PostText", c => c.String());
        }
    }
}
