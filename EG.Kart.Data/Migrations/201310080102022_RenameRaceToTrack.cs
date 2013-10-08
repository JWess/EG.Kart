namespace EG.Kart.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RenameRaceToTrack : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Track",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Race");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Race",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Trackname = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Track");
        }
    }
}
