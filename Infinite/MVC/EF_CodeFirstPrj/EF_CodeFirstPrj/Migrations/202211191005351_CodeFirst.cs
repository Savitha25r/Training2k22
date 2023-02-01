namespace EF_CodeFirstPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodeFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarNo = c.Int(nullable: false, identity: true),
                        CarName = c.String(),
                        CarModel = c.String(),
                    })
                .PrimaryKey(t => t.CarNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
