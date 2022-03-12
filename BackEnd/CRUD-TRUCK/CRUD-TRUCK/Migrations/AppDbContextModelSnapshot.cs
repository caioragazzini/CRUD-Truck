﻿// <auto-generated />
using CRUD_TRUCK.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_TRUCK.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("CRUD_TRUCK.Models.Truck", b =>
                {
                    b.Property<int>("TruckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameTruck")
                        .HasColumnType("longtext");

                    b.Property<int>("TruckModelId")
                        .HasColumnType("int");

                    b.Property<int>("YearModel")
                        .HasColumnType("int");

                    b.Property<int>("YearOfManufacture")
                        .HasColumnType("int");

                    b.HasKey("TruckId");

                    b.HasIndex("TruckModelId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("CRUD_TRUCK.Models.TruckModel", b =>
                {
                    b.Property<int>("TruckModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TruckModelType")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.HasKey("TruckModelId");

                    b.ToTable("TruckModel");
                });

            modelBuilder.Entity("CRUD_TRUCK.Models.Truck", b =>
                {
                    b.HasOne("CRUD_TRUCK.Models.TruckModel", "TruckModels")
                        .WithMany("Trucks")
                        .HasForeignKey("TruckModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TruckModels");
                });

            modelBuilder.Entity("CRUD_TRUCK.Models.TruckModel", b =>
                {
                    b.Navigation("Trucks");
                });
#pragma warning restore 612, 618
        }
    }
}
