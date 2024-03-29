﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi_Control_Production.Connection;

#nullable disable

namespace WebApiContrlProduction2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApi_Control_Production.Models.Production", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<decimal>("cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("horaInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nivelFinal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("responsable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tanque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("productions");
                });
#pragma warning restore 612, 618
        }
    }
}
