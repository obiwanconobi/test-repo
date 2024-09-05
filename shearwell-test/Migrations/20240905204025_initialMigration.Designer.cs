﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shearwell_test.DataAccess;

#nullable disable

namespace shearwelltest.Migrations
{
    [DbContext(typeof(UnitOfWork))]
    [Migration("20240905204025_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("shearwell_test.Models.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("shearwell_test.Models.AnimalGroupRel", b =>
                {
                    b.Property<Guid>("AnimalId")
                        .HasColumnType("TEXT")
                        .HasColumnName("AnimalId");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("TEXT")
                        .HasColumnName("GroupId");

                    b.HasKey("AnimalId", "GroupId");

                    b.ToTable("AnimalGroupRel", (string)null);
                });

            modelBuilder.Entity("shearwell_test.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
