﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rental_House_Management_System.Data;

#nullable disable

namespace Rental_House_Management_System.Migrations.ElectricBillDb
{
    [DbContext(typeof(ElectricBillDbContext))]
    [Migration("20220508072807_electricbills")]
    partial class electricbills
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Rental_House_Management_System.Models.ElectricBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Electric_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Electric_Number")
                        .HasColumnType("int");

                    b.Property<string>("RoomId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("electricbills", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
