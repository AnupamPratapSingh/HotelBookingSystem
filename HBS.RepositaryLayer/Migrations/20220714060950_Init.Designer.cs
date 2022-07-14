﻿// <auto-generated />
using System;
using HBS.RepositaryLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HBS.RepositaryLayer.Migrations
{
    [DbContext(typeof(HBMSDBContext))]
    [Migration("20220714060950_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HBS.DomainlLayer.Models.BookingDetails", b =>
                {
                    b.Property<int>("booking_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("booked_from")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("booked_to")
                        .HasColumnType("datetime2");

                    b.Property<int>("no_of_adults")
                        .HasColumnType("int");

                    b.Property<int>("no_of_children")
                        .HasColumnType("int");

                    b.Property<int>("room_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("booking_id");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("HBS.DomainlLayer.Models.Hotel", b =>
                {
                    b.Property<int>("hotel_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("avg_rate_per_nigh")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hotel_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone_no1")
                        .HasColumnType("int");

                    b.Property<int>("phone_no2")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("hotel_id");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("HBS.DomainlLayer.Models.RoomDetails", b =>
                {
                    b.Property<int>("room_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("availability")
                        .HasColumnType("bit");

                    b.Property<int>("hotel_id")
                        .HasColumnType("int");

                    b.Property<int>("per_night_rate")
                        .HasColumnType("int");

                    b.Property<string>("room_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("room_no");

                    b.ToTable("RoomDetails");
                });

            modelBuilder.Entity("HBS.DomainlLayer.Models.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mobile_num")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
