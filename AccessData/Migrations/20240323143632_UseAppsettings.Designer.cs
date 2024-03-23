﻿// <auto-generated />
using System;
using AccessData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccessData.Migrations
{
    [DbContext(typeof(RetailStoreDBContext))]
    [Migration("20240323143632_UseAppsettings")]
    partial class UseAppsettings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccessData.Entities.SaleProduct", b =>
                {
                    b.Property<int>("SaleProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleProductId"));

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("SaleProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleProduct");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Tecnología y Electrónica"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Tecnología y Electrónica"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Tecnología y Electrónica"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Tecnología y Electrónica"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Tecnología y Electrónica"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Domain.Entities.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Subtotal")
                        .HasColumnType("float");

                    b.Property<double>("Taxes")
                        .HasColumnType("float");

                    b.Property<double>("TotalDiscount")
                        .HasColumnType("float");

                    b.Property<double>("TotalPay")
                        .HasColumnType("float");

                    b.HasKey("SaleId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("AccessData.Entities.SaleProduct", b =>
                {
                    b.HasOne("Domain.Entities.Product", null)
                        .WithMany("SaleProduct")
                        .HasForeignKey("ProductId");

                    b.HasOne("Domain.Entities.Sale", null)
                        .WithMany("SaleProduct")
                        .HasForeignKey("SaleId");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("SaleProduct");
                });

            modelBuilder.Entity("Domain.Entities.Sale", b =>
                {
                    b.Navigation("SaleProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
