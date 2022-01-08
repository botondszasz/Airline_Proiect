namespace Proiect_MediiProg
{
    using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;


    public partial class AirlineEntitiesModel : DbContext
    {
        public AirlineEntitiesModel()
            : base("name=AirlineEntitiesModel")
        {
        }

        public virtual DbSet<BookedFlight> BookedFlights { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.BookedFlights)
                .WithOptional(e => e.Client)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Flight>()
                .Property(e => e.Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.Duration)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.Price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.BookedFlights)
                .WithOptional(e => e.Flight)
                .WillCascadeOnDelete();
        }
    }
}
