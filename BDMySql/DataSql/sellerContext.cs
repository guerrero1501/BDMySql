﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BDMySql.DataSql
{
    public partial class sellerContext : DbContext
    {
        public sellerContext()
        {
        }

        public sellerContext(DbContextOptions<sellerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=190.146.25.236;Initial Catalog=seller;User ID=sa;Password=Dna9201,,,;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategId)
                    .HasColumnName("Categ Id")
                    .HasMaxLength(255);

                entity.Property(e => e.CategName)
                    .HasColumnName("Categ Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CategSlug)
                    .HasColumnName("Categ Slug")
                    .HasMaxLength(255);

                entity.Property(e => e.IdAttribute)
                    .HasColumnName("Id_Attribute")
                    .HasMaxLength(255);

                entity.Property(e => e.IdValue)
                    .HasColumnName("ID_Value")
                    .HasMaxLength(255);

                entity.Property(e => e.NameAttribute)
                    .HasColumnName("Name_Attribute")
                    .HasMaxLength(255);

                entity.Property(e => e.NameValue)
                    .HasColumnName("Name_Value")
                    .HasMaxLength(255);

                entity.Property(e => e.Nivel).HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent Id")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
