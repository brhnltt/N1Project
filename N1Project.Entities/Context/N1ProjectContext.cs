using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1Project.Entities.Tables;

namespace N1Project.Entities.Context
{
    public class N1ProjectContext : DbContext
    {
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mapping.StokMap());
            modelBuilder.Configurations.Add(new Mapping.CariMap());
            modelBuilder.Configurations.Add(new Mapping.FisMap());
            modelBuilder.Configurations.Add(new Mapping.StokHareketMap());
            modelBuilder.Configurations.Add(new Mapping.KasaMap());
            modelBuilder.Configurations.Add(new Mapping.DepoMap());
            modelBuilder.Configurations.Add(new Mapping.OdemeTuruMap());
            modelBuilder.Configurations.Add(new Mapping.TanimMap());
            modelBuilder.Configurations.Add(new Mapping.KasaHareketMap());

        }
    }
}