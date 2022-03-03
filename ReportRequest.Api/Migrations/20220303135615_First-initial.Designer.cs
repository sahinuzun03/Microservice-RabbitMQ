﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReportRequest.Api.Infrastructure.Context;

namespace ReportRequest.Api.Migrations
{
    [DbContext(typeof(ReportRequestDbContext))]
    [Migration("20220303135615_First-initial")]
    partial class Firstinitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReportRequest.Api.Entities.ReportDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("date");

                    b.Property<string>("ReportResult")
                        .HasColumnType("nvarchar");

                    b.Property<int>("ReportStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReportDetails");
                });
#pragma warning restore 612, 618
        }
    }
}