using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class AdvertisementContext : DbContext
    {
        public DbSet<Advertisement> Advertisements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisement>().HasData(
                new Advertisement() { Id = 1, AdvertisementTitle = "Jr Net Core Developer",Location="İstanbul",JobType="Full time",JobDescription="5 Yıl deneyimli" },
                new Advertisement() { Id = 2, AdvertisementTitle = "Jr Angular Developer",Location="İzmir",JobType="Part time",JobDescription="3 Yıl deneyimli" },
                new Advertisement() { Id = 3, AdvertisementTitle = "Jr Ionic Developer",Location="İstanbul",JobType="Full time",JobDescription="2 Yıl deneyimli" }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=AdDb;trusted_connection=true;");
        }
    }
}