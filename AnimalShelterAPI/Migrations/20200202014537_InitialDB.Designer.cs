﻿// <auto-generated />
using System;
using AnimalShelterAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelterAPI.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200202014537_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterAPI.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnimalName");

                    b.Property<string>("AnimalType");

                    b.Property<DateTime>("ArrivalDate");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            AnimalName = "Tom",
                            AnimalType = "Dog",
                            ArrivalDate = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AnimalId = 2,
                            AnimalName = "Jerry",
                            AnimalType = "Cat",
                            ArrivalDate = new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AnimalId = 3,
                            AnimalName = "Lessy",
                            AnimalType = "Cat",
                            ArrivalDate = new DateTime(2017, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AnimalId = 4,
                            AnimalName = "Jim",
                            AnimalType = "Dog",
                            ArrivalDate = new DateTime(2016, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AnimalId = 5,
                            AnimalName = "Trace",
                            AnimalType = "Cat",
                            ArrivalDate = new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
