﻿// <auto-generated />
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst.Migrations
{
    [DbContext(typeof(EmpDbContext))]
    [Migration("20250112090430_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirst.Models.Department", b =>
                {
                    b.Property<int>("DeptNo")
                        .HasColumnType("int")
                        .HasColumnName("DeptNo");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DeptName");

                    b.HasKey("DeptNo");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CodeFirst.Models.Employee", b =>
                {
                    b.Property<int>("EmpNo")
                        .HasColumnType("int")
                        .HasColumnName("EmpNo");

                    b.Property<decimal>("Basic")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Basic");

                    b.Property<int>("DeptNo")
                        .HasColumnType("int")
                        .HasColumnName("DeptNo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("EmpNo");

                    b.HasIndex("DeptNo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CodeFirst.Models.Employee", b =>
                {
                    b.HasOne("CodeFirst.Models.Department", "DeptNoNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("DeptNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeptNoNavigation");
                });

            modelBuilder.Entity("CodeFirst.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
