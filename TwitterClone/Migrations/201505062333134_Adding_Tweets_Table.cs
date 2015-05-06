namespace TwitterClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adding_Tweets_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tweets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tweets", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tweets", new[] { "User_Id" });
            DropTable("dbo.Tweets");
        }
    }
}
