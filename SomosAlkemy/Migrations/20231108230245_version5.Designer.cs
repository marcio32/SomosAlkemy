﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SomosAlkemy.DataAccess;

#nullable disable

namespace SomosAlkemy.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20231108230245_version5")]
    partial class version5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SomosAlkemy.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("user_DNI");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("user_email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("user_firstName");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("user_isDeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("user_lastName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("user_password");

                    b.Property<bool>("Role")
                        .HasColumnType("bit")
                        .HasColumnName("user_role");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DNI = "40073892",
                            Email = "Marcio@gmail.com",
                            FirstName = "Marcio",
                            IsDeleted = false,
                            LastName = "Abriola",
                            Password = "1234",
                            Role = false
                        },
                        new
                        {
                            Id = 2,
                            DNI = "40073894",
                            Email = "Pepe@gmail.com",
                            FirstName = "Pepe",
                            IsDeleted = false,
                            LastName = "Abriola",
                            Password = "1234",
                            Role = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
