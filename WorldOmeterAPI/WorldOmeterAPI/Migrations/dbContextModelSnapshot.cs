﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldOmeterAPI.Models;

namespace WorldOmeterAPI.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldOmeterAPI.Models.CountryView", b =>
                {
                    b.Property<int>("CvID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("activeCases")
                        .HasColumnType("int");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("newCases")
                        .HasColumnType("int");

                    b.Property<int>("newDeaths")
                        .HasColumnType("int");

                    b.Property<int>("totalCases")
                        .HasColumnType("int");

                    b.Property<int>("totalDeaths")
                        .HasColumnType("int");

                    b.Property<int>("totalRecovered")
                        .HasColumnType("int");

                    b.HasKey("CvID");

                    b.ToTable("countryViews");
                });

            modelBuilder.Entity("WorldOmeterAPI.Models.SummaryTotal", b =>
                {
                    b.Property<int>("StID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeathCases")
                        .HasColumnType("int");

                    b.Property<int>("RecoveredCases")
                        .HasColumnType("int");

                    b.Property<int>("TotalCases")
                        .HasColumnType("int");

                    b.HasKey("StID");

                    b.ToTable("summaryTotals");
                });

            modelBuilder.Entity("WorldOmeterAPI.Models.SummmaryCases", b =>
                {
                    b.Property<int>("ScID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("activeInfected")
                        .HasColumnType("int");

                    b.Property<int>("activeMild")
                        .HasColumnType("int");

                    b.Property<int>("activeSerious")
                        .HasColumnType("int");

                    b.Property<int>("deaths")
                        .HasColumnType("int");

                    b.Property<int>("outcomeClosed")
                        .HasColumnType("int");

                    b.Property<int>("recovered")
                        .HasColumnType("int");

                    b.HasKey("ScID");

                    b.ToTable("summaryCases");
                });
#pragma warning restore 612, 618
        }
    }
}
