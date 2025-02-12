﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieWebApp.Models;

#nullable disable

namespace MovieWebApp.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieWebApp.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Price = 7.99m,
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            ID = 2,
                            Price = 8.99m,
                            Title = "The Godfather"
                        },
                        new
                        {
                            ID = 3,
                            Price = 9.99m,
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            ID = 4,
                            Price = 10.99m,
                            Title = "The Lord of the Rings: The Return of the King"
                        },
                        new
                        {
                            ID = 5,
                            Price = 6.99m,
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            ID = 6,
                            Price = 7.99m,
                            Title = "Schindler's List"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
