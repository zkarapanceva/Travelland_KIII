using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Travelland.Domain.DomainModels;
using Travelland.Domain.Identity;

namespace Travelland.Repository
{
    public class ApplicationDbContext : IdentityDbContext<TravellandApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<UserReservations> UserReservations { get; set; }
        public virtual DbSet<OfferInUserReservations> OfferInUserReservations { get; set; }
        public virtual DbSet<OfferInReservation> OfferInReservations { get; set;}
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<EmailMessage> EmailMessages { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Offer>()
                .Property(z => z.id)
                .ValueGeneratedOnAdd();

            builder.Entity<UserReservations>()
                .Property(z => z.ReservationsId)
                .ValueGeneratedOnAdd();

            //builder.Entity<OfferInUserReservations>()
            //    .HasKey(z => new { z.id, z.UserReservationsId });

            builder.Entity<UserReservations>()
                .HasKey(z => z.ReservationsId);


            builder.Entity<OfferInUserReservations>()
                .HasOne(z => z.Offer)
                .WithMany(z => z.UserReservations)
                .HasForeignKey(z => z.id);

            builder.Entity<OfferInUserReservations>()
                .HasOne(z => z.UserReservations)
                .WithMany(z => z.OfferInUserReservations)
                .HasForeignKey(z => z.UserReservationsId);

            builder.Entity<UserReservations>()
                .HasOne<TravellandApplicationUser>(z => z.Client)
                .WithOne(z => z.UserReservations)
                .HasForeignKey<UserReservations>(z => z.ClientId);

            //builder.Entity<OfferInReservation>()
            //    .HasKey(z => new { z.id, z.ReservationId });

            builder.Entity<OfferInReservation>()
                .HasOne(z => z.SelectedOffer)
                .WithMany(z => z.Reservations)
                .HasForeignKey(z => z.id);

            builder.Entity<OfferInReservation>()
                .HasOne(z => z.ClientReservation)
                .WithMany(z => z.Offers)
                .HasForeignKey(z => z.ReservationId);
        }
    }
}
