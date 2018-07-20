namespace Aula5.TunaGreen.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FuelTypes", newName: "TIPI_CARBURANTI");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TIPI_CARBURANTI", newName: "FuelTypes");
        }
    }
}
