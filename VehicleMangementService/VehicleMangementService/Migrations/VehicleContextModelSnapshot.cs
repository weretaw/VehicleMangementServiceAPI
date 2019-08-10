﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleMangementService.Models;

namespace VehicleMangementService.Migrations
{
    [DbContext(typeof(VehicleContext))]
    partial class VehicleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleMangementService.Models.Vehicle", b =>
                {
                    b.Property<int?>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CO2Emissions");

                    b.Property<string>("Cylinders");

                    b.Property<string>("Drivertrain");

                    b.Property<double>("EngineSize");

                    b.Property<string>("EuroEmissStand");

                    b.Property<string>("FuelType");

                    b.Property<string>("GearBox");

                    b.Property<double>("Height");

                    b.Property<double>("Length");

                    b.Property<string>("LicenseNumber");

                    b.Property<string>("MilesPerTank");

                    b.Property<string>("Model");

                    b.Property<string>("Owner");

                    b.Property<string>("Power");

                    b.Property<string>("TopSpeed");

                    b.Property<string>("Torque");

                    b.Property<string>("Transmission");

                    b.Property<string>("TurningCircile");

                    b.Property<string>("Valves");

                    b.Property<string>("Wheelbase");

                    b.Property<string>("Year");

                    b.Property<int>("kmPerHour");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
