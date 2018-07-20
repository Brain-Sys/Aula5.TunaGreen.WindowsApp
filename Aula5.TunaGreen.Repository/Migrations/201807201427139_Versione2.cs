namespace Aula5.TunaGreen.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versione2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.TIPI_CARBURANTI", "Station_ID", c => c.Int());
            CreateIndex("dbo.TIPI_CARBURANTI", "Station_ID");
            AddForeignKey("dbo.TIPI_CARBURANTI", "Station_ID", "dbo.Stations", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TIPI_CARBURANTI", "Station_ID", "dbo.Stations");
            DropIndex("dbo.TIPI_CARBURANTI", new[] { "Station_ID" });
            DropColumn("dbo.TIPI_CARBURANTI", "Station_ID");
            DropTable("dbo.Stations");
        }
    }
}
