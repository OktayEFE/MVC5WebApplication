namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CountryInfoes",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        CountryName = c.String(maxLength: 20),
                        Capital = c.String(maxLength: 20),
                        CountryCode = c.String(maxLength: 8),
                        CurrencyUnit = c.String(maxLength: 8),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CountryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CountryInfoes");
        }
    }
}
