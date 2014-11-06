namespace _65hours.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        PaidToUserID = c.String(),
                        PaidByUSerID = c.String(),
                        Created = c.DateTime(nullable: false),
                        Minutes = c.Int(nullable: false),
                        Reason = c.String(),
                        Recommended = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID);
            
            CreateTable(
                "dbo.UserRequests",
                c => new
                    {
                        UserRequestID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        UserID = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserRequestID);
            
            CreateTable(
                "dbo.UserSkills",
                c => new
                    {
                        UserSkillID = c.Int(nullable: false, identity: true),
                        UserID = c.String(),
                        SkillID = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserSkillID);
            
            AddColumn("dbo.AspNetUsers", "Location", c => c.String());
            AddColumn("dbo.AspNetUsers", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Active");
            DropColumn("dbo.AspNetUsers", "Location");
            DropTable("dbo.UserSkills");
            DropTable("dbo.UserRequests");
            DropTable("dbo.Transactions");
        }
    }
}
