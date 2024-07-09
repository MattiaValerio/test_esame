﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240709063317_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Birth")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            Birth = new DateOnly(2002, 11, 19),
                            LastName = "Valerio",
                            Name = "Mattia"
                        },
                        new
                        {
                            Id = 2,
                            Age = 33,
                            Birth = new DateOnly(1991, 1, 1),
                            LastName = "Rossi",
                            Name = "Mario"
                        },
                        new
                        {
                            Id = 3,
                            Age = 28,
                            Birth = new DateOnly(1996, 5, 5),
                            LastName = "Bianchi",
                            Name = "Luca"
                        },
                        new
                        {
                            Id = 4,
                            Age = 43,
                            Birth = new DateOnly(1981, 2, 2),
                            LastName = "Verdi",
                            Name = "Luca"
                        },
                        new
                        {
                            Id = 5,
                            Age = 28,
                            Birth = new DateOnly(1996, 10, 10),
                            LastName = "Doe",
                            Name = "John"
                        },
                        new
                        {
                            Id = 6,
                            Age = 25,
                            Birth = new DateOnly(1999, 5, 5),
                            LastName = "Doe",
                            Name = "Jane"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
