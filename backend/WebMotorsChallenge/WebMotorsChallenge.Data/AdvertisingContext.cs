using Microsoft.EntityFrameworkCore;
using WebMotorsChallenge.Data.Configuration;
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
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AdversitingConfiguration());
        }
    }
}
