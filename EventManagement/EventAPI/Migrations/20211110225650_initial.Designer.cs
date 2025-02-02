﻿// <auto-generated />
using System;
using EventAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventAPI.Migrations
{
    [DbContext(typeof(EventCatalogContext))]
    [Migration("20211110225650_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventAPI.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EventAPI.Domain.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormatId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnlineEvent")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaidEvent")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MaxOccupancy")
                        .HasColumnType("int");

                    b.Property<int>("MaxTicketsPerUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormatId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("EventCatalog");
                });

            modelBuilder.Entity("EventAPI.Domain.Format", b =>
                {
                    b.Property<int>("FormatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FormatName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FormatId");

                    b.ToTable("Formats");
                });

            modelBuilder.Entity("EventAPI.Domain.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("EventAPI.Domain.Organization", b =>
                {
                    b.Property<int>("OrganizerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrganizerId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("EventAPI.Domain.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("EventAPI.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EventAPI.Domain.Event", b =>
                {
                    b.HasOne("EventAPI.Domain.Format", "Format")
                        .WithMany()
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventAPI.Domain.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventAPI.Domain.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventAPI.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Format");

                    b.Navigation("Location");

                    b.Navigation("SubCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventAPI.Domain.Organization", b =>
                {
                    b.HasOne("EventAPI.Domain.User", "User")
                        .WithOne("Organization")
                        .HasForeignKey("EventAPI.Domain.Organization", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventAPI.Domain.SubCategory", b =>
                {
                    b.HasOne("EventAPI.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EventAPI.Domain.User", b =>
                {
                    b.Navigation("Organization");
                });
#pragma warning restore 612, 618
        }
    }
}
