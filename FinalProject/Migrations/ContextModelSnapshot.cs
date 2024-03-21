﻿// <auto-generated />
using System;
using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("AbogadoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Abogados");
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

                    b.HasIndex("DemandaId");

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

                    b.HasIndex("SentenciaId");

                    b.HasIndex("UsuarioId");

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

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ExpedienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Expedientes");
                });

            modelBuilder.Entity("Shared.Models.Jueces", b =>
                {
                    b.Property<int>("JuezId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JuezId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SentenciaId")
                        .HasColumnType("int");

                    b.HasKey("JuezId");

                    b.HasIndex("SentenciaId");

                    b.ToTable("Jueces");
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

                    b.Property<int>("ExpedienteId")
                        .HasColumnType("int");

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

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Shared.Models.Abogados", b =>
                {
                    b.HasOne("Shared.Models.Usuarios", null)
                        .WithMany("Abogados")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Audiencias", b =>
                {
                    b.HasOne("Shared.Models.Demandas", null)
                        .WithMany("Audiencias")
                        .HasForeignKey("DemandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Demandas", b =>
                {
                    b.HasOne("Shared.Models.Sentencias", null)
                        .WithMany("Demandas")
                        .HasForeignKey("SentenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Models.Usuarios", null)
                        .WithMany("Demandas")
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

            modelBuilder.Entity("Shared.Models.Jueces", b =>
                {
                    b.HasOne("Shared.Models.Sentencias", null)
                        .WithMany("Jueces")
                        .HasForeignKey("SentenciaId")
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
                    b.Navigation("Audiencias");

                    b.Navigation("TiposDemandas");
                });

            modelBuilder.Entity("Shared.Models.Sentencias", b =>
                {
                    b.Navigation("Demandas");

                    b.Navigation("Jueces");
                });

            modelBuilder.Entity("Shared.Models.Usuarios", b =>
                {
                    b.Navigation("Abogados");

                    b.Navigation("Demandas");

                    b.Navigation("Expedientes");

                    b.Navigation("Niños");
                });
#pragma warning restore 612, 618
        }
    }
}
