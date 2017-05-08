namespace PetClinic.WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "PetId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "PetId", c => c.Int(nullable: false));
        }
    }
}
