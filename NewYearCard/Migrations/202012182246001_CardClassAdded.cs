namespace NewYearCard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(nullable: false, maxLength: 20),
                        SenderName = c.String(),
                        MessageLine1 = c.String(nullable: false, maxLength: 200),
                        MessageLine2 = c.String(),
                        MessageLine3 = c.String(),
                        PictureName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cards");
        }
    }
}
