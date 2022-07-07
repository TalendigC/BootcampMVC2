﻿// <auto-generated />
using System;
using BootcamMVC2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BootcamMVC2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220701001223_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BootcamMVC2.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Masculino"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Femenino"
                        });
                });

            modelBuilder.Entity("BootcamMVC2.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            LastName = "Santos",
                            Name = "Gerson"
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 1,
                            LastName = "Arias",
                            Name = "Heger"
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 1,
                            LastName = "Dominguez",
                            Name = "Jose"
                        });
                });

            modelBuilder.Entity("BootcamMVC2.Models.Person", b =>
                {
                    b.HasOne("BootcamMVC2.Models.Genre", "Genre")
                        .WithMany("People")
                        .HasForeignKey("GenreId");
                });
#pragma warning restore 612, 618
        }
    }
}