﻿// <auto-generated />
using System;
using BELTEXAM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BELTEXAM.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190322154638_First1")]
    partial class First1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BELTEXAM.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoordinatorID");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DateOfEvent")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("Duration")
                        .IsRequired();

                    b.Property<string>("DurationUnit")
                        .IsRequired();

                    b.Property<DateTime?>("Time")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasIndex("CoordinatorID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BELTEXAM.Models.Participant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.HasIndex("UserID");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("BELTEXAM.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BELTEXAM.Models.Event", b =>
                {
                    b.HasOne("BELTEXAM.Models.User", "Coordinator")
                        .WithMany()
                        .HasForeignKey("CoordinatorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BELTEXAM.Models.Participant", b =>
                {
                    b.HasOne("BELTEXAM.Models.Event", "Event")
                        .WithMany("Participants")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BELTEXAM.Models.User", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
