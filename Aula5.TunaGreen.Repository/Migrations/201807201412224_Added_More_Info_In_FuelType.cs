namespace Aula5.TunaGreen.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_More_Info_In_FuelType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FuelTypes", "Available", c => c.Int());
            AddColumn("dbo.FuelTypes", "Liters", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FuelTypes", "Liters");
            DropColumn("dbo.FuelTypes", "Available");
        }
    }
}
