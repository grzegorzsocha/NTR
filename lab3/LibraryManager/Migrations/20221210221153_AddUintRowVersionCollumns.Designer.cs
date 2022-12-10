﻿// <auto-generated />
using System;
using LibraryManager.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LibraryManager.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221210221153_AddUintRowVersionCollumns")]
    partial class AddUintRowVersionCollumns
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LibraryManager.Models.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Date")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Leased")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Reserved")
                        .HasColumnType("timestamp with time zone");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid")
                        .HasColumnName("xmin");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Jeremy Clarkson",
                            Date = 2020,
                            Publisher = "Penguin Random House UK",
                            RowVersion = 0u,
                            Title = "Can You Make This Thing Go Faster"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Jeremy Clarkson",
                            Date = 2020,
                            Publisher = "Penguin Random House UK",
                            RowVersion = 0u,
                            Title = "Diddly Squat - a Year on the Farm"
                        },
                        new
                        {
                            Id = 3,
                            Author = "F. Scott Fitzgerald",
                            Date = 1925,
                            Publisher = "Charles Scribner's Sons",
                            RowVersion = 0u,
                            Title = "The Great Gatsby"
                        });
                });

            modelBuilder.Entity("LibraryManager.Models.Entities.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid")
                        .HasColumnName("xmin");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "librarian",
                            IsAdmin = true,
                            Password = "123",
                            RowVersion = 0u
                        },
                        new
                        {
                            Username = "jeremy",
                            IsAdmin = false,
                            Password = "123",
                            RowVersion = 0u
                        },
                        new
                        {
                            Username = "james",
                            IsAdmin = false,
                            Password = "123",
                            RowVersion = 0u
                        });
                });

            modelBuilder.Entity("LibraryManager.Models.Entities.Book", b =>
                {
                    b.HasOne("LibraryManager.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("Username");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
