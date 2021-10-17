using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Entities;

namespace WebMotorsChallenge.Data.Configuration
{

    public class AdversitingConfiguration : IEntityTypeConfiguration<Adversiting>
    {
        public virtual void Configure(EntityTypeBuilder<Adversiting> builder)
        {
            builder.ToTable("tb_AnuncioWebmotors");

            builder.Property(p => p.Id)
                .HasColumnName("ID");
               

            builder.Property(p => p.Mark)
                .HasColumnName("marca")
                .IsRequired()
                .HasMaxLength(45);

            builder.Property(p => p.Model)
                .HasColumnName("modelo")
                .IsRequired()
                .HasMaxLength(45);


            builder.Property(p => p.Version)
                .HasColumnName("versao")
                .IsRequired()
                .HasMaxLength(45);


            builder.Property(p => p.Year)
                .HasColumnName("ano")
                .IsRequired();


            builder.Property(p => p.Mileage)
                .HasColumnName("quilometragem")
                .IsRequired();


            builder.Property(p => p.Note)
                .HasColumnName("observacao")
                .HasColumnType("Text")
                .IsRequired();

        }
    }
}
