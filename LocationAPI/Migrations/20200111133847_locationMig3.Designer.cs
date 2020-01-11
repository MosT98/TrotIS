﻿// <auto-generated />
using System;
using LocationAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LocationAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200111133847_locationMig3")]
    partial class locationMig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("LocationAPI.Data.Location", b =>
                {
                    b.Property<Guid>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("numeric");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationID = new Guid("c23f0569-c10f-4eed-9180-b710af6e057a"),
                            Comment = "Prima dupa colt",
                            Latitude = 42.8731m,
                            Longitude = 12.3121m
                        });
                });

            modelBuilder.Entity("LocationAPI.Data.LocationsToScooters", b =>
                {
                    b.Property<Guid>("LocationID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ScooterInstanceID")
                        .HasColumnType("uuid");

                    b.HasKey("LocationID", "ScooterInstanceID");

                    b.ToTable("LinkLocationsToScooterInstances");

                    b.HasData(
                        new
                        {
                            LocationID = new Guid("c23f0569-c10f-4eed-9180-b710af6e057a"),
                            ScooterInstanceID = new Guid("65a1ecd5-5ac1-434b-8c35-1bedcee04dd4")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}