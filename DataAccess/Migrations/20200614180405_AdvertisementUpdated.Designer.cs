﻿// <auto-generated />
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(AdvertisementContext))]
    [Migration("20200614180405_AdvertisementUpdated")]
    partial class AdvertisementUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdvertisementTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Advertisements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdvertisementTitle = "Jr Net Core Developer",
                            JobDescription = "5 Yıl deneyimli",
                            JobType = "Full time",
                            Location = "İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            AdvertisementTitle = "Jr Angular Developer",
                            JobDescription = "3 Yıl deneyimli",
                            JobType = "Part time",
                            Location = "İzmir"
                        },
                        new
                        {
                            Id = 3,
                            AdvertisementTitle = "Jr Ionic Developer",
                            JobDescription = "2 Yıl deneyimli",
                            JobType = "Full time",
                            Location = "İstanbul"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
