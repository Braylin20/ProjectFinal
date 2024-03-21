﻿// <auto-generated />
using System;
using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240321035123_Otra2")]
    partial class Otra2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemandasUsuarios", b =>
                {
                    b.Property<int>("DemandaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DemandaId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DemandasUsuarios");
                });

            modelBuilder.Entity("Shared.Models.Abogados", b =>
                {
                    b.Property<int>("AbogadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbogadoId"));

                    b.Property<int?>("ColegioAbogadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AbogadoId");

                    b.ToTable("Abogados");

                    b.HasData(
                        new
                        {
                            AbogadoId = 1,
                            Nombre = "Juan Perez"
                        },
                        new
                        {
                            AbogadoId = 2,
                            Nombre = "Elizabeth Mata"
                        },
                        new
                        {
                            AbogadoId = 3,
                            Nombre = "Palito De Coco"
                        });
                });

            modelBuilder.Entity("Shared.Models.Audiencias", b =>
                {
                    b.Property<int>("AudienciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AudienciaId"));

                    b.Property<int>("DemandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAudiencia")
                        .HasColumnType("datetime2");

                    b.HasKey("AudienciaId");

                    b.ToTable("Audiencias");
                });

            modelBuilder.Entity("Shared.Models.Demandas", b =>
                {
                    b.Property<int>("DemandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DemandaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("SentenciaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DemandaId");

                    b.ToTable("Demandas");
                });

            modelBuilder.Entity("Shared.Models.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoId"));

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Shared.Models.Expedientes", b =>
                {
                    b.Property<int>("ExpedienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpedienteId"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaEntrada")
                        .HasColumnType("datetime2");

                    b.Property<int>("SentenciaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ExpedienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Expedientes");
                });

            modelBuilder.Entity("Shared.Models.Niños", b =>
                {
                    b.Property<int>("NinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NinoId"));

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.Property<string>("NombreMadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("NinoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Niños");
                });

            modelBuilder.Entity("Shared.Models.Sentencias", b =>
                {
                    b.Property<int>("SentenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SentenciaId"));

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreMinisterio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SentenciaId");

                    b.ToTable("Sentencias");
                });

            modelBuilder.Entity("Shared.Models.TiposDemandas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DemandaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreDemanda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DemandaId");

                    b.ToTable("TiposDemandas");
                });

            modelBuilder.Entity("Shared.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DemandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SentenciaId")
                        .HasColumnType("int");

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DemandasUsuarios", b =>
                {
                    b.HasOne("Shared.Models.Demandas", null)
                        .WithMany()
                        .HasForeignKey("DemandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Models.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Expedientes", b =>
                {
                    b.HasOne("Shared.Models.Usuarios", null)
                        .WithMany("Expedientes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Niños", b =>
                {
                    b.HasOne("Shared.Models.Usuarios", null)
                        .WithMany("Niños")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.TiposDemandas", b =>
                {
                    b.HasOne("Shared.Models.Demandas", null)
                        .WithMany("TiposDemandas")
                        .HasForeignKey("DemandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Demandas", b =>
                {
                    b.Navigation("TiposDemandas");
                });

            modelBuilder.Entity("Shared.Models.Usuarios", b =>
                {
                    b.Navigation("Expedientes");

                    b.Navigation("Niños");
                });
#pragma warning restore 612, 618
        }
    }
}
