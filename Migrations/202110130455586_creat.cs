namespace Finance_WebForm_OIL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PersonCode = c.Int(nullable: false),
                        HourPay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employes");
        }
    }
}
