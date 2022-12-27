﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlannerAPI.Data;

#nullable disable

namespace PlannerAPI.Migrations
{
    [DbContext(typeof(plannerAPIDbContext))]
    partial class plannerAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlannerAPI.Models.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("assignmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assignmentWeight")
                        .HasColumnType("int");

                    b.Property<string>("className")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dueDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planner");
                });
#pragma warning restore 612, 618
        }
    }
}