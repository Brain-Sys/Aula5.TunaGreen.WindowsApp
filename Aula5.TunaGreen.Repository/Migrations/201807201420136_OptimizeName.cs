namespace Aula5.TunaGreen.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OptimizeName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FuelTypes", "Name", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FuelTypes", "Name", c => c.String());
        }
    }
}
