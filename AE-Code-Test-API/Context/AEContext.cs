using AE_Code_Test_API.Entities;
using AE_Code_Test_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AE_Code_Test_API.Context
{
    public class AEContext : DbContext
    {
        public AEContext(DbContextOptions<AEContext> options) : base(options)
        {
        }

        public AEContext() 
        {
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (var entry in entries)
            {
                var auditableEntity = entry.Entity as BaseTable;

                if (auditableEntity != null)
                {
                    auditableEntity.ModifyDate = DateTime.Now;
                    if (entry.State.Equals(EntityState.Added))
                        auditableEntity.CreateDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            List<Port> portList = new List<Port>();
            for (int i = 1; i < 100; i++)
            {
                double Lat = RandomWithRange(GeoLocationHelper.MAX_LAT, GeoLocationHelper.MIN_LAT);
                double Lon = RandomWithRange(GeoLocationHelper.MAX_LON, GeoLocationHelper.MIN_LON);

                portList.Add(new Port
                {
                    PortId = i,
                    Name = "Port" + i.ToString(),
                    Latitude = Lat,
                    Longitude = Lon
                }
                    );
            }
            modelBuilder.Entity<Port>().HasData(portList);
        }
        private Double RandomWithRange(double Max, double Min)
        {
            Random rand = new Random();
            return (rand.NextDouble() * (Max - Min)) + Min;
        }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Port> Ports { get; set; }
    }
}
