namespace N1Project.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Give_it_a_name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cariler", "IskontoOrani", c => c.Decimal(precision: 5, scale: 2));
            AlterColumn("dbo.Cariler", "RiskLimiti", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Fisler", "IskontoOrani", c => c.Decimal(precision: 5, scale: 2));
            AlterColumn("dbo.Fisler", "IskontoTutar", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Fisler", "ToplamTutar", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.KasaHareketleri", "Tutar", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.StokHareketleri", "Miktar", c => c.Decimal(precision: 12, scale: 3));
            AlterColumn("dbo.StokHareketleri", "BirimFiyati", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.StokHareketleri", "IndirimOrani", c => c.Decimal(precision: 5, scale: 2));
            AlterColumn("dbo.StokHareketleri", "IndirimTutari", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.StokHareketleri", "ToplamTutar", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "AlisFiyati1", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "AlisFiyati2", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "AlisFiyati3", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "SatisFiyati1", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "SatisFiyati2", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "SatisFiyati3", c => c.Decimal(precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "MinStokMiktari", c => c.Decimal(precision: 12, scale: 3));
            AlterColumn("dbo.Stoklar", "MaxStokMiktari", c => c.Decimal(precision: 12, scale: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stoklar", "MaxStokMiktari", c => c.Decimal(nullable: false, precision: 12, scale: 3));
            AlterColumn("dbo.Stoklar", "MinStokMiktari", c => c.Decimal(nullable: false, precision: 12, scale: 3));
            AlterColumn("dbo.Stoklar", "SatisFiyati3", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "SatisFiyati2", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "SatisFiyati1", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "AlisFiyati3", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "AlisFiyati2", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Stoklar", "AlisFiyati1", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.StokHareketleri", "ToplamTutar", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.StokHareketleri", "IndirimTutari", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.StokHareketleri", "IndirimOrani", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AlterColumn("dbo.StokHareketleri", "BirimFiyati", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.StokHareketleri", "Miktar", c => c.Decimal(nullable: false, precision: 12, scale: 3));
            AlterColumn("dbo.KasaHareketleri", "Tutar", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Fisler", "ToplamTutar", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Fisler", "IskontoTutar", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Fisler", "IskontoOrani", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AlterColumn("dbo.Cariler", "RiskLimiti", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.Cariler", "IskontoOrani", c => c.Decimal(nullable: false, precision: 5, scale: 2));
        }
    }
}
