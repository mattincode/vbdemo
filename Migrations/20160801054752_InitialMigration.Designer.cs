using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using VBdemo.Models;

namespace VBdemo.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20160801054752_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("VBdemo.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Start");

                    b.HasKey("BookingId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("VBdemo.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("VBdemo.Models.Booking", b =>
                {
                    b.HasOne("VBdemo.Models.Employee")
                        .WithMany("Bookings")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
