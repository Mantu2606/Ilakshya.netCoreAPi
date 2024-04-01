﻿// <auto-generated />
using ILakshya.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ILakshya.Dal.Migrations
{
    [DbContext(typeof(WebPocHubDbContext))]
    partial class WebPocHubDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ILakshya.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleDescription = "Admin can be access data both",
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleDescription = "Student show our data",
                            RoleName = "Student"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleDescription = "Teacher can be update data",
                            RoleName = "Teacher"
                        });
                });

            modelBuilder.Entity("ILakshya.Model.Student", b =>
                {
                    b.Property<int>("StuEnrollNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StuEnrollNo"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("StuName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("StuEnrollNo");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StuEnrollNo = 1001,
                            Address = "Rampur Dullah",
                            Avatar = "/images/john-mark.png",
                            City = "Gorakhpur",
                            Country = "India",
                            Email = "Rohit@gmail.com",
                            Phone = "+044 73783783",
                            StuName = "Rohit Saini",
                            Zipcode = "473837"
                        },
                        new
                        {
                            StuEnrollNo = 1002,
                            Address = "Deoria",
                            Avatar = "/images/john-mark.png",
                            City = "Gorakhpur",
                            Country = "India",
                            Email = "Rohit@gmail.com",
                            Phone = "+044 73783783",
                            StuName = "Rahul Sharma",
                            Zipcode = "473837"
                        },
                        new
                        {
                            StuEnrollNo = 1003,
                            Address = "Mahuaadih",
                            Avatar = "/images/john-mark.png",
                            City = "Lucknow",
                            Country = "India",
                            Email = "Rohit@gmail.com",
                            Phone = "+044 73783783",
                            StuName = "Sunil Gupta",
                            Zipcode = "473837"
                        });
                });

            modelBuilder.Entity("ILakshya.Model.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");

                    b.HasData(
                        new
                        {
                            TeacherId = 201,
                            Address = "Gorakhpur",
                            Avatar = "/images/john-mark.png",
                            Country = "India",
                            Email = "Mohit@gmail.com",
                            Phone = "+6388978442",
                            Subject = "Hindi",
                            TeacherName = "Mohit Agrawal",
                            Zipcode = "420322"
                        },
                        new
                        {
                            TeacherId = 202,
                            Address = "Deoria",
                            Avatar = "/images/john-mark.png",
                            Country = "India",
                            Email = "Rupesh@gmail.com",
                            Phone = "+9876543219",
                            Subject = "Engish",
                            TeacherName = "Rupesh Patel",
                            Zipcode = "421303"
                        });
                });

            modelBuilder.Entity("ILakshya.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ILakshya.Model.User", b =>
                {
                    b.HasOne("ILakshya.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ILakshya.Model.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
