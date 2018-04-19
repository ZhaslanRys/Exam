namespace Exam
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class MapContext : DbContext
    {
        public MapContext()
            : base("name=MapContext")
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cargo> Cargoes { get; set; }
        public DbSet<Company> Comapnies { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Marker> Markers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}