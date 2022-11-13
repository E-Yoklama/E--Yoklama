using Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class YoklamaDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        { // entity framework ile veritabanı bağlantısı
            dbContextOptionsBuilder.UseSqlServer
                (@"Server=(localdb)\MSSQLLocalDB;Database=DbYoklama;Trusted_Connection=true");
        }

        public DbSet<Ders> DersTbl { get; set; }
        public DbSet<Ogrenci> OgrTbl { get; set; }
        public DbSet<Egitmen> AkademisyenTbl { get; set; }

    }
}