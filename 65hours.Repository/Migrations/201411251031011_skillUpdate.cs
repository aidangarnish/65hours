namespace _65hours.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skillUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "Description");
        }
    }
}
