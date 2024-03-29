﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pet911_backend.Helpers;

#nullable disable

namespace pet911_backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230612233345_Sponsor")]
    partial class Sponsor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("pet911_backend.Models.Pet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Allergies")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Race")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("Primary");

                    b.HasIndex("Id")
                        .HasDatabaseName("FK_IndexIdPet");

                    b.HasIndex("IdUser");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("pet911_backend.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("Primary");

                    b.HasIndex("Id")
                        .HasDatabaseName("FK_IndexIdRole");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("pet911_backend.Models.Service", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Catalogue")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<TimeOnly?>("ClosingTime")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly?>("OpeningTime")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<bool?>("Sponsored")
                        .IsRequired()
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("Primary");

                    b.HasIndex("Id")
                        .HasDatabaseName("FK_IndexIdService");

                    b.HasIndex("IdUser");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("pet911_backend.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36)");

                    b.Property<DateOnly?>("Birthdate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IdRole")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("blob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("blob");

                    b.HasKey("Id")
                        .HasName("Primary");

                    b.HasIndex("Id")
                        .HasDatabaseName("FK_IndexIdUser");

                    b.HasIndex("IdRole");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("pet911_backend.Models.Pet", b =>
                {
                    b.HasOne("pet911_backend.Models.User", "user")
                        .WithMany("pets")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("pet911_backend.Models.Service", b =>
                {
                    b.HasOne("pet911_backend.Models.User", "user")
                        .WithMany("services")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("pet911_backend.Models.User", b =>
                {
                    b.HasOne("pet911_backend.Models.Role", "Role")
                        .WithMany("users")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("pet911_backend.Models.Role", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("pet911_backend.Models.User", b =>
                {
                    b.Navigation("pets");

                    b.Navigation("services");
                });
#pragma warning restore 612, 618
        }
    }
}
