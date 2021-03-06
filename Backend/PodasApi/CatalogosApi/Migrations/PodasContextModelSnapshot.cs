﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PodasApi.Catalogo.Data;

namespace PodasApi.Catalogo.Migrations
{
    [DbContext(typeof(PodasContext))]
    partial class PodasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PodasApi.Entities.Tables.Arbol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<float>("Altura")
                        .HasColumnName("altura");

                    b.Property<int>("Codigo1")
                        .HasColumnName("codigo1");

                    b.Property<string>("Codigo2")
                        .HasColumnName("codigo2");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<int>("IdBarrio")
                        .HasColumnName("id_barrio");

                    b.Property<int>("IdCategoria")
                        .HasColumnName("id_categoria");

                    b.Property<int>("IdEspecie")
                        .HasColumnName("id_especie");

                    b.Property<int>("IdFamilia")
                        .HasColumnName("id_familia");

                    b.Property<int>("IdLocalidad")
                        .HasColumnName("id_localidad");

                    b.Property<int>("IdMunicipio")
                        .HasColumnName("id_municipio");

                    b.Property<int>("IdTipoEmplazamiento")
                        .HasColumnName("id_tipo_emplazamiento");

                    b.Property<double>("Latitud")
                        .HasColumnName("latitud");

                    b.Property<double>("Longitud")
                        .HasColumnName("longitud");

                    b.Property<string>("UsuarioCreacion");

                    b.Property<string>("UsuarioModificacion");

                    b.HasKey("Id");

                    b.ToTable("arbol");
                });
#pragma warning restore 612, 618
        }
    }
}
