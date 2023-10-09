﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Processos.Models;

#nullable disable

namespace Processos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Processos.Models.AnexoProcesso", b =>
                {
                    b.Property<int>("codigoAnexo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigoAnexo"));

                    b.Property<int>("codigoProcesso")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("nomeAnexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoAnexo");

                    b.ToTable("ANEXO_PROCESSO");
                });

            modelBuilder.Entity("Processos.Models.Fluxo", b =>
                {
                    b.Property<int>("codigoFluxo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigoFluxo"));

                    b.Property<int>("codigoSetorDestino")
                        .HasColumnType("int");

                    b.Property<int>("codigoSetorOrigem")
                        .HasColumnType("int");

                    b.Property<int>("codigoTipoProcesso")
                        .HasColumnType("int");

                    b.HasKey("codigoFluxo");

                    b.ToTable("FLUXO");
                });

            modelBuilder.Entity("Processos.Models.Interessado", b =>
                {
                    b.Property<int>("codigoInteressado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigoInteressado"));

                    b.Property<string>("bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cpfCnpjInteressado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoInteressado");

                    b.ToTable("INTERESSADO");
                });

            modelBuilder.Entity("Processos.Models.Movimentacao", b =>
                {
                    b.Property<int>("codigoMovimentacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigoMovimentacao"));

                    b.Property<int>("codigoProcesso")
                        .HasColumnType("int");

                    b.Property<int>("codigoSetorLocalizacao")
                        .HasColumnType("int");

                    b.Property<string>("cpfUsuarioTramite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dataHora")
                        .HasColumnType("datetime2");

                    b.HasKey("codigoMovimentacao");

                    b.ToTable("MOVIMENTACAO");
                });

            modelBuilder.Entity("Processos.Models.Processo", b =>
                {
                    b.Property<int>("codigoProcesso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigoProcesso"));

                    b.Property<string>("assunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("codigoInteressado")
                        .HasColumnType("int");

                    b.Property<int>("codigoSetor")
                        .HasColumnType("int");

                    b.Property<int>("codigoTipoProcesso")
                        .HasColumnType("int");

                    b.Property<string>("cpfProtocolista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dataHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("resumo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoProcesso");

                    b.ToTable("PROCESSO");
                });

            modelBuilder.Entity("Processos.Models.Setor", b =>
                {
                    b.Property<int>("codigoSetor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigoSetor"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoSetor");

                    b.ToTable("SETOR");
                });

            modelBuilder.Entity("Processos.Models.SetoresUsuario", b =>
                {
                    b.Property<int>("sequencial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sequencial"));

                    b.Property<int>("codigoSetor")
                        .HasColumnType("int");

                    b.Property<string>("cpfUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sequencial");

                    b.ToTable("USUARIO_TEM_SETOR");
                });

            modelBuilder.Entity("Processos.Models.Tipo_Processo", b =>
                {
                    b.Property<int>("codigoTipoProcesso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigoTipoProcesso"));

                    b.Property<string>("nomeTipoProcesso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoTipoProcesso");

                    b.ToTable("TIPO_PROCESSO");
                });

            modelBuilder.Entity("Processos.Models.Usuario", b =>
                {
                    b.Property<string>("cpfUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("administrativo")
                        .HasColumnType("bit");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cpfUsuario");

                    b.ToTable("USUARIO");
                });
#pragma warning restore 612, 618
        }
    }
}
