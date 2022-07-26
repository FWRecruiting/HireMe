﻿// <auto-generated />
using System;
using HireMeApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HireMeApi.Data.Migrations
{
    [DbContext(typeof(HireMeApiDbContext))]
    partial class HireMeApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("HireMeApi.Domain.Models.IotDevice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IotDevices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d96dd728-f987-4d0b-b070-15d5b51276f9"),
                            Description = "This is a very long description about device 1",
                            Name = "Device 1"
                        },
                        new
                        {
                            Id = new Guid("83682980-59b1-4784-97df-260ced1f8d5e"),
                            Description = "This is a very long description about device 2",
                            Name = "Device 2"
                        },
                        new
                        {
                            Id = new Guid("692d1515-ee4b-497c-8151-733e292dbe47"),
                            Description = "This is a very long description about device 3",
                            Name = "Device 3"
                        },
                        new
                        {
                            Id = new Guid("85a9f92e-1869-4a53-be14-17baeea0b3ca"),
                            Description = "This is a very long description about device 4",
                            Name = "Device 4"
                        },
                        new
                        {
                            Id = new Guid("fb6eca2d-878b-4828-abfc-83bb43609a40"),
                            Description = "This is a very long description about device 5",
                            Name = "Device 5"
                        },
                        new
                        {
                            Id = new Guid("c9994f3c-96e8-491a-b6ac-18150707c154"),
                            Description = "This is a very long description about device 6",
                            Name = "Device 6"
                        },
                        new
                        {
                            Id = new Guid("bafa65a7-1865-4478-9f18-836640e7395b"),
                            Description = "This is a very long description about device 7",
                            Name = "Device 7"
                        },
                        new
                        {
                            Id = new Guid("bedb5752-53c9-4723-9cb1-c68803e40f34"),
                            Description = "This is a very long description about device 8",
                            Name = "Device 8"
                        },
                        new
                        {
                            Id = new Guid("700e4109-d340-4316-9c39-8c0b64c60fd4"),
                            Description = "This is a very long description about device 9",
                            Name = "Device 9"
                        },
                        new
                        {
                            Id = new Guid("bb35d8af-352d-4387-9b3e-925e97506020"),
                            Description = "This is a very long description about device 10",
                            Name = "Device 10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
