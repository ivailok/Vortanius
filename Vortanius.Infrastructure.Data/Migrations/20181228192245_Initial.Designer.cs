﻿// <auto-generated />
using System;
using Vortanius.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Vortanius.Infrastructure.Data.Migrations
{
    [DbContext(typeof(VortaniusDbContext))]
    [Migration("20181228192245_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Vortanius.Core.Domain.Entities.Data.Dbo.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });
#pragma warning restore 612, 618
        }
    }
}
