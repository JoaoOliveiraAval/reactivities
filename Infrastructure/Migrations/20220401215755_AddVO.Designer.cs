﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220401215755_AddVO")]
    partial class AddVO
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Avenue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Dates")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Activities", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("259c3963-6c21-4967-8199-155e999389af"),
                            Avenue = "Pub",
                            Category = "drinks",
                            City = "London",
                            Dates = new DateTime(2022, 2, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7528),
                            Description = "Activity 2 months ago",
                            Title = "Past Activity 1"
                        },
                        new
                        {
                            Id = new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2"),
                            Avenue = "Louvre",
                            Category = "culture",
                            City = "Paris",
                            Dates = new DateTime(2022, 3, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7582),
                            Description = "Activity 1 month ago",
                            Title = "Past Activity 2"
                        },
                        new
                        {
                            Id = new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68"),
                            Avenue = "Natural History Museum",
                            Category = "culture",
                            City = "London",
                            Dates = new DateTime(2022, 5, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7590),
                            Description = "Activity 1 month in future",
                            Title = "Future Activity 1"
                        },
                        new
                        {
                            Id = new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0"),
                            Avenue = "O2 Arena",
                            Category = "music",
                            City = "London",
                            Dates = new DateTime(2022, 6, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7594),
                            Description = "Activity 2 months in future",
                            Title = "Future Activity 2"
                        },
                        new
                        {
                            Id = new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c"),
                            Avenue = "Another pub",
                            Category = "drinks",
                            City = "London",
                            Dates = new DateTime(2022, 7, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7599),
                            Description = "Activity 3 months in future",
                            Title = "Future Activity 3"
                        },
                        new
                        {
                            Id = new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6"),
                            Avenue = "Yet another pub",
                            Category = "drinks",
                            City = "London",
                            Dates = new DateTime(2022, 8, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7604),
                            Description = "Activity 4 months in future",
                            Title = "Future Activity 4"
                        },
                        new
                        {
                            Id = new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe"),
                            Avenue = "Just another pub",
                            Category = "drinks",
                            City = "London",
                            Dates = new DateTime(2022, 9, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7607),
                            Description = "Activity 5 months in future",
                            Title = "Future Activity 5"
                        },
                        new
                        {
                            Id = new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3"),
                            Avenue = "Roundhouse Camden",
                            Category = "music",
                            City = "London",
                            Dates = new DateTime(2022, 10, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7611),
                            Description = "Activity 6 months in future",
                            Title = "Future Activity 6"
                        },
                        new
                        {
                            Id = new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac"),
                            Avenue = "Somewhere on the Thames",
                            Category = "travel",
                            City = "London",
                            Dates = new DateTime(2022, 11, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7614),
                            Description = "Activity 2 months ago",
                            Title = "Future Activity 7"
                        },
                        new
                        {
                            Id = new Guid("a5c4885c-4116-4583-87db-7a5c641510af"),
                            Avenue = "Cinema",
                            Category = "film",
                            City = "London",
                            Dates = new DateTime(2022, 12, 1, 18, 57, 54, 851, DateTimeKind.Local).AddTicks(7617),
                            Description = "Activity 8 months in future",
                            Title = "Future Activity 8"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
