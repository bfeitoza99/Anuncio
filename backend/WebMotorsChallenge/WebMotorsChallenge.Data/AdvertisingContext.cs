using Microsoft.EntityFrameworkCore;
using WebMotorsChallenge.Domain.Entities;

namespace WebMotorsChallenge.Data
{
    public class AdvertisingContext : DbContext
    {

        public AdvertisingContext(DbContextOptions<AdvertisingContext> options) : base(options)
        {

        }


        public DbSet<Adversiting> Adversiting { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Adversiting>().ToTable("tb_AnuncioWebmotors");

            modelBuilder.Entity<Adversiting>()
                .Property(p => p.Mark)
                .HasColumnName("marca")
                .IsRequired()
                .HasMaxLength(45);

            modelBuilder.Entity<Adversiting>()
                .Property(p => p.Model)
                .HasColumnName("modelo")
                .IsRequired()
                .HasMaxLength(45);


            modelBuilder.Entity<Adversiting>()
                .Property(p => p.Version)
                .HasColumnName("versao")
                .IsRequired()
                .HasMaxLength(45);


            modelBuilder.Entity<Adversiting>()
                .Property(p => p.Year)
                .HasColumnName("ano")
                .IsRequired();


            modelBuilder.Entity<Adversiting>()
                .Property(p => p.Mileage)
                .HasColumnName("quilometragem")
                .IsRequired();


            modelBuilder.Entity<Adversiting>()
                .Property(p => p.Note)
                .HasColumnName("observacao")
                .HasColumnType("Text")
                .IsRequired();





            base.OnModelCreating(modelBuilder);
        }
    }
}
