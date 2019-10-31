using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DevApi.Models;

namespace DevApi.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
             builder.ToTable("Product");
             builder.HasKey(x => x.Id);
             builder.Property(x => x.CreateDate).IsRequired();
             builder.Property(x => x.Description).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
             builder.Property(x => x.Image).IsRequired().HasMaxLength(1024).HasColumnType("varchar(120)");
             builder.Property(x => x.LastUpdateDate).IsRequired();
             builder.Property(x => x.Price).IsRequired().HasColumnType("money");
             builder.Property(x => x.Title).IsRequired();
             builder.Property(x => x.Title).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
             builder.HasOne(x => x.Category).WithMany(x => x.Products);
            
       
        }
    }
}