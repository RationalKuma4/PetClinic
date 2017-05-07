namespace PetClinic.WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoRelationwOwner : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "VeterinarianId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "VeterinarianId", c => c.Int(nullable: false));
        }
    }
}
