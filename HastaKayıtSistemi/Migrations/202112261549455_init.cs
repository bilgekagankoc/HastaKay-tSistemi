namespace HastaKayıtSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AileHekimleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HekimAdi = c.String(nullable: false, maxLength: 50),
                        HekimSoyadi = c.String(nullable: false, maxLength: 50),
                        DiplomaNo = c.String(nullable: false, maxLength: 10),
                        TCKN = c.String(nullable: false, maxLength: 11),
                        Aktif = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        OlusturanKullaniciID = c.Int(nullable: false),
                        GuncelleyenKullaniciID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hastalar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HastaAdi = c.String(nullable: false, maxLength: 50),
                        HastaSoyadi = c.String(nullable: false, maxLength: 50),
                        TCKN = c.String(nullable: false, maxLength: 11),
                        DogumTarihi = c.DateTime(nullable: false),
                        Adres = c.String(),
                        AileHekimID = c.Int(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        OlusturanKullaniciID = c.Int(nullable: false),
                        GuncelleyenKullaniciID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AileHekimleri", t => t.AileHekimID, cascadeDelete: true)
                .Index(t => t.AileHekimID);
            
            CreateTable(
                "dbo.Muayeneler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MuayeneTarihi = c.DateTime(nullable: false),
                        HastaID = c.Int(nullable: false),
                        AileHekimID = c.Int(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        OlusturanKullaniciID = c.Int(nullable: false),
                        GuncelleyenKullaniciID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AileHekimleri", t => t.AileHekimID, cascadeDelete: true)
                .ForeignKey("dbo.Hastalar", t => t.HastaID, cascadeDelete: false)
                .Index(t => t.HastaID)
                .Index(t => t.AileHekimID);
            
            CreateTable(
                "dbo.MuayeneHastalik",
                c => new
                    {
                        MuayeneID = c.Int(nullable: false),
                        HastalikID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MuayeneID, t.HastalikID })
                .ForeignKey("dbo.Hastaliklar", t => t.HastalikID, cascadeDelete: true)
                .ForeignKey("dbo.Muayeneler", t => t.MuayeneID, cascadeDelete: false)
                .Index(t => t.MuayeneID)
                .Index(t => t.HastalikID);
            
            CreateTable(
                "dbo.Hastaliklar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HastalikAdi = c.String(nullable: false, maxLength: 50),
                        ICD10 = c.String(nullable: false, maxLength: 7),
                        Aktif = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        OlusturanKullaniciID = c.Int(nullable: false),
                        GuncelleyenKullaniciID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Receteler",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ReceteNo = c.String(nullable: false, maxLength: 8),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Muayeneler", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.ReceteIlac",
                c => new
                    {
                        ReceteID = c.Int(nullable: false),
                        IlacID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReceteID, t.IlacID })
                .ForeignKey("dbo.Ilaclar", t => t.IlacID, cascadeDelete: true)
                .ForeignKey("dbo.Receteler", t => t.ReceteID, cascadeDelete: true)
                .Index(t => t.ReceteID)
                .Index(t => t.IlacID);
            
            CreateTable(
                "dbo.Ilaclar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IlacAdi = c.String(nullable: false, maxLength: 50),
                        IlacKodu = c.String(nullable: false, maxLength: 20),
                        Aktif = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        OlusturanKullaniciID = c.Int(nullable: false),
                        GuncelleyenKullaniciID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReceteIlac", "ReceteID", "dbo.Receteler");
            DropForeignKey("dbo.ReceteIlac", "IlacID", "dbo.Ilaclar");
            DropForeignKey("dbo.Receteler", "ID", "dbo.Muayeneler");
            DropForeignKey("dbo.MuayeneHastalik", "MuayeneID", "dbo.Muayeneler");
            DropForeignKey("dbo.MuayeneHastalik", "HastalikID", "dbo.Hastaliklar");
            DropForeignKey("dbo.Muayeneler", "HastaID", "dbo.Hastalar");
            DropForeignKey("dbo.Muayeneler", "AileHekimID", "dbo.AileHekimleri");
            DropForeignKey("dbo.Hastalar", "AileHekimID", "dbo.AileHekimleri");
            DropIndex("dbo.ReceteIlac", new[] { "IlacID" });
            DropIndex("dbo.ReceteIlac", new[] { "ReceteID" });
            DropIndex("dbo.Receteler", new[] { "ID" });
            DropIndex("dbo.MuayeneHastalik", new[] { "HastalikID" });
            DropIndex("dbo.MuayeneHastalik", new[] { "MuayeneID" });
            DropIndex("dbo.Muayeneler", new[] { "AileHekimID" });
            DropIndex("dbo.Muayeneler", new[] { "HastaID" });
            DropIndex("dbo.Hastalar", new[] { "AileHekimID" });
            DropTable("dbo.Ilaclar");
            DropTable("dbo.ReceteIlac");
            DropTable("dbo.Receteler");
            DropTable("dbo.Hastaliklar");
            DropTable("dbo.MuayeneHastalik");
            DropTable("dbo.Muayeneler");
            DropTable("dbo.Hastalar");
            DropTable("dbo.AileHekimleri");
        }
    }
}
