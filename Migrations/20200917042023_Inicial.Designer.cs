﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registro_N.DAL;

namespace Registro_N.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200917042023_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Registro_N.Entidades.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha_Nacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<double>("Telefono")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}