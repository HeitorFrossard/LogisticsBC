namespace LogisticsBCApp.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LogisticsBCEntities : DbContext
    {
        public LogisticsBCEntities()
            : base("name=LogisticsBCConnection")
        {
        }
        
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .Property(e => e.AreaName)
                .IsFixedLength();

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverName)
                .IsFixedLength();

            modelBuilder.Entity<Package>()
                .Property(e => e.CustomerName)
                .IsFixedLength();

            modelBuilder.Entity<Package>()
                .Property(e => e.Address)
                .IsFixedLength();
        }
    }
}
