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
    [Migration("20190205121609_mebers")]
    partial class mebers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garage_2._0_MPT.Models.Members", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .HasMaxLength(25);

                    b.Property<byte[]>("PassWord");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

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

                    b.Property<string>("Where");

                    b.HasKey("Id");

                    b.HasIndex("VehicleTypId");

                    b.ToTable("ParkedVehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 4, 11, 13, 4, 937, DateTimeKind.Local).AddTicks(6571),
                            RegNr = "abc123",
                            VehicleBrand = "Ferrari",
                            VehicleColor = "Green",
                            VehicleModel = "okänd",
                            VehicleTypId = 1
                        },
                        new
                        {
                            Id = 2,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 3, 11, 13, 4, 937, DateTimeKind.Local).AddTicks(7332),
                            RegNr = "abc234",
                            VehicleBrand = "Volvo",
                            VehicleColor = "Red",
                            VehicleModel = "okänd",
                            VehicleTypId = 2
                        },
                        new
                        {
                            Id = 3,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 1, 11, 13, 4, 937, DateTimeKind.Local).AddTicks(7342),
                            ParkOutDate = new DateTime(2019, 2, 3, 10, 15, 23, 937, DateTimeKind.Local).AddTicks(7346),
                            RegNr = "abc345",
                            VehicleBrand = "Saab",
                            VehicleColor = "Blue",
                            VehicleModel = "okänd",
                            VehicleTypId = 5
                        },
                        new
                        {
                            Id = 4,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 4, 10, 13, 4, 937, DateTimeKind.Local).AddTicks(7398),
                            RegNr = "abc456",
                            VehicleBrand = "Ferrari",
                            VehicleColor = "Green",
                            VehicleModel = "okänd",
                            VehicleTypId = 1
                        },
                        new
                        {
                            Id = 5,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 3, 10, 13, 4, 937, DateTimeKind.Local).AddTicks(7405),
                            RegNr = "abc567",
                            VehicleBrand = "Volvo",
                            VehicleColor = "Red",
                            VehicleModel = "okänd",
                            VehicleTypId = 2
                        },
                        new
                        {
                            Id = 6,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 1, 11, 13, 4, 937, DateTimeKind.Local).AddTicks(7412),
                            RegNr = "abc678",
                            VehicleBrand = "Saab",
                            VehicleColor = "Black",
                            VehicleModel = "okänd",
                            VehicleTypId = 5
                        },
                        new
                        {
                            Id = 7,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 4, 11, 13, 3, 937, DateTimeKind.Local).AddTicks(7418),
                            RegNr = "Rymdopera",
                            VehicleBrand = "Ferrari",
                            VehicleColor = "Green",
                            VehicleModel = "okänd",
                            VehicleTypId = 1
                        },
                        new
                        {
                            Id = 8,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 3, 11, 13, 2, 937, DateTimeKind.Local).AddTicks(7425),
                            RegNr = "abc987",
                            VehicleBrand = "Volvo",
                            VehicleColor = "Red",
                            VehicleModel = "okänd",
                            VehicleTypId = 2
                        },
                        new
                        {
                            Id = 9,
                            NumberOfWheels = 4,
                            ParkInDate = new DateTime(2019, 2, 1, 11, 13, 1, 937, DateTimeKind.Local).AddTicks(7432),
                            RegNr = "Biffen",
                            VehicleBrand = "Bmv",
                            VehicleColor = "Black",
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

                    b.Property<int>("SpacesNeeded");

                    b.HasKey("VehicleTypId");

                    b.ToTable("VehicleTyp");

                    b.HasData(
                        new
                        {
                            VehicleTypId = 1,
                            CostPerHour = 100,
                            Name = "Car",
                            SpacesNeeded = 1
                        },
                        new
                        {
                            VehicleTypId = 2,
                            CostPerHour = 300,
                            Name = "Bus",
                            SpacesNeeded = 3
                        },
                        new
                        {
                            VehicleTypId = 3,
                            CostPerHour = 50,
                            Name = "Motorbike",
                            SpacesNeeded = -3
                        },
                        new
                        {
                            VehicleTypId = 4,
                            CostPerHour = 150,
                            Name = "Caravan",
                            SpacesNeeded = 1
                        },
                        new
                        {
                            VehicleTypId = 5,
                            CostPerHour = 200,
                            Name = "RV",
                            SpacesNeeded = 2
                        },
                        new
                        {
                            VehicleTypId = 6,
                            CostPerHour = 200,
                            Name = "Truck",
                            SpacesNeeded = 2
                        });
                });

            modelBuilder.Entity("Garage_2._0_MPT.Models.Members", b =>
                {
                    b.OwnsOne("Garage_2._0_MPT.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("MembersId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasMaxLength(20);

                            b1.Property<string>("Street")
                                .HasMaxLength(35);

                            b1.Property<string>("ZipCode")
                                .HasMaxLength(8);

                            b1.HasKey("MembersId");

                            b1.ToTable("Members");

                            b1.HasOne("Garage_2._0_MPT.Models.Members")
                                .WithOne("Address")
                                .HasForeignKey("Garage_2._0_MPT.Models.Address", "MembersId")
                                .OnDelete(DeleteBehavior.Cascade);
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
