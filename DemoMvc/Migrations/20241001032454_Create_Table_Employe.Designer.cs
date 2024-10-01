﻿// <auto-generated />
using DemoMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001032454_Create_Table_Employe")]
    partial class Create_Table_Employe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DemoMvc.Models.Person", b =>
                {
                    b.Property<string>("cancuoccongdan")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("hoten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("quequan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("cancuoccongdan");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("PTPMQL.Models.Employee", b =>
                {
                    b.Property<string>("StudenID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudenID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("PTPMQL.Employe", b =>
                {
                    b.HasBaseType("DemoMvc.Models.Person");

                    b.HasDiscriminator().HasValue("Employe");
                });
#pragma warning restore 612, 618
        }
    }
}
