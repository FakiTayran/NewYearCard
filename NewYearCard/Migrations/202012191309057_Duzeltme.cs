namespace NewYearCard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Duzeltme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cards", "PictureNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Cards", "PictureName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cards", "PictureName", c => c.String(nullable: false));
            DropColumn("dbo.Cards", "PictureNumber");
        }
    }
}
