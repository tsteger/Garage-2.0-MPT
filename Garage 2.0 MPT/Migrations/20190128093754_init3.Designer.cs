﻿// <auto-generated />
using System;
using Garage_2._0_MPT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Garage_2._0_MPT.Migrations
{
    [DbContext(typeof(Garage_2_0_MPTContext))]
    [Migration("20190128093754_init3")]
    partial class init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garage_2._0_MPT.Models.ParkedVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfWheels");

                    b.Property<DateTime>("ParkInDate");

                    b.Property<DateTime?>("ParkOutDate");

                    b.Property<string>("RegNr");

                    b.Property<string>("VehicleBrand");

                    b.Property<string>("VehicleColor");

                    b.Property<string>("VehicleModel");

                    b.Property<int>("VehicleTypId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleTypId");

                    b.ToTable("ParkedVehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 1, 27, 8, 34, 49, 841, DateTimeKind.Local).AddTicks(280),
                            RegNr = "Rymdopera",
                            VehicleBrand = "Ferrari",
                            VehicleColor = "Green",
                            VehicleModel = "okänd",
                            VehicleTypId = 1
                        },
                        new
                        {
                            Id = 2,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 1, 26, 8, 34, 49, 841, DateTimeKind.Local).AddTicks(1181),
                            RegNr = "abc 123",
                            VehicleBrand = "Volvo",
                            VehicleColor = "Red",
                            VehicleModel = "okänd",
                            VehicleTypId = 2
                        },
                        new
                        {
                            Id = 3,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 1, 24, 8, 34, 49, 841, DateTimeKind.Local).AddTicks(1198),
                            ParkOutDate = new DateTime(2019, 1, 26, 7, 37, 8, 841, DateTimeKind.Local).AddTicks(1201),
                            RegNr = "acc 123",
                            VehicleBrand = "Saab",
                            VehicleColor = "Blue",
                            VehicleModel = "okänd",
                            VehicleTypId = 5
                        });
                });

            modelBuilder.Entity("Garage_2._0_MPT.Models.VehicleTyp", b =>
                {
                    b.Property<int>("VehicleTypId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CostPerHour");

                    b.Property<string>("Name");

                    b.HasKey("VehicleTypId");

                    b.ToTable("VehicleTyp");

                    b.HasData(
                        new
                        {
                            VehicleTypId = 1,
                            CostPerHour = 100,
                            Name = "Car"
                        },
                        new
                        {
                            VehicleTypId = 2,
                            CostPerHour = 300,
                            Name = "Bus"
                        },
                        new
                        {
                            VehicleTypId = 3,
                            CostPerHour = 50,
                            Name = "Motorbike"
                        },
                        new
                        {
                            VehicleTypId = 4,
                            CostPerHour = 150,
                            Name = "Caravan"
                        },
                        new
                        {
                            VehicleTypId = 5,
                            CostPerHour = 200,
                            Name = "RV"
                        },
                        new
                        {
                            VehicleTypId = 6,
                            CostPerHour = 200,
                            Name = "Truck"
                        });
                });

            modelBuilder.Entity("Garage_2._0_MPT.Models.ParkedVehicle", b =>
                {
                    b.HasOne("Garage_2._0_MPT.Models.VehicleTyp", "VehicleTyp")
                        .WithMany("ParkedVehicle")
                        .HasForeignKey("VehicleTypId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
