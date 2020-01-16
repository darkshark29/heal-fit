﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using heal_fit.Models;

namespace heal_fit.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("heal_fit.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pseudo")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("heal_fit.Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("heal_fit.Models.Profile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("heal_fit.Models.Trait", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Trait");
                });

            modelBuilder.Entity("heal_fit.Models.Plan", b =>
                {
                    b.HasOne("heal_fit.Models.Profile", null)
                        .WithMany("Plans")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("heal_fit.Models.Profile", b =>
                {
                    b.HasOne("heal_fit.Models.Account", null)
                        .WithMany("Profiles")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("heal_fit.Models.Trait", b =>
                {
                    b.HasOne("heal_fit.Models.Profile", null)
                        .WithMany("Traits")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
