﻿// <auto-generated />
using System;
using API_Projeto_Integrador.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Projeto_Integrador.Migrations
{
    [DbContext(typeof(API_Pojeto_IntegradorContext))]
    [Migration("20241029232231_PopulaLojistas")]
    partial class PopulaLojistas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API_Projeto_Integrador.Models.Empreendimento", b =>
                {
                    b.Property<int>("EmpreendimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<int>("Tipo_EmpreendimentoID")
                        .HasColumnType("int");

                    b.HasKey("EmpreendimentoId");

                    b.HasIndex("EnderecoID");

                    b.HasIndex("Tipo_EmpreendimentoID");

                    b.ToTable("Empreendimentos");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Logadrouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Lojista", b =>
                {
                    b.Property<int>("LojistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmpreendimentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("LojistaId");

                    b.HasIndex("EmpreendimentoId");

                    b.ToTable("Lojistas");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Registro", b =>
                {
                    b.Property<int>("RegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EmpreendimentoId")
                        .HasColumnType("int");

                    b.Property<int>("LojistaId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_RegistroId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor_Registro")
                        .HasColumnType("decimal(10, 3)");

                    b.HasKey("RegistroId");

                    b.HasIndex("EmpreendimentoId");

                    b.HasIndex("LojistaId");

                    b.HasIndex("Tipo_RegistroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Tipo_Empreendimento", b =>
                {
                    b.Property<int>("Tipo_EmpreendimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Tipo_EmpreendimentoId");

                    b.ToTable("tipo_Empreendimentos");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Tipo_Registro", b =>
                {
                    b.Property<int>("Tipo_RegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Tipo_RegistroId");

                    b.ToTable("tipo_Registros");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Empreendimento", b =>
                {
                    b.HasOne("API_Projeto_Integrador.Models.Endereco", "Endereco")
                        .WithMany("Empreendimentos")
                        .HasForeignKey("EnderecoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Projeto_Integrador.Models.Tipo_Empreendimento", "Tipo_Empreendimento")
                        .WithMany("Empreendimentos")
                        .HasForeignKey("Tipo_EmpreendimentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Tipo_Empreendimento");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Lojista", b =>
                {
                    b.HasOne("API_Projeto_Integrador.Models.Empreendimento", "Empreendimento")
                        .WithMany("Lojistas")
                        .HasForeignKey("EmpreendimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empreendimento");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Registro", b =>
                {
                    b.HasOne("API_Projeto_Integrador.Models.Empreendimento", "Empreendimento")
                        .WithMany()
                        .HasForeignKey("EmpreendimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Projeto_Integrador.Models.Lojista", "Lojista")
                        .WithMany()
                        .HasForeignKey("LojistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Projeto_Integrador.Models.Tipo_Registro", "Tipo_Registro")
                        .WithMany("Registros")
                        .HasForeignKey("Tipo_RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Projeto_Integrador.Models.Usuario", "Usuario")
                        .WithMany("registros")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empreendimento");

                    b.Navigation("Lojista");

                    b.Navigation("Tipo_Registro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Empreendimento", b =>
                {
                    b.Navigation("Lojistas");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Endereco", b =>
                {
                    b.Navigation("Empreendimentos");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Tipo_Empreendimento", b =>
                {
                    b.Navigation("Empreendimentos");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Tipo_Registro", b =>
                {
                    b.Navigation("Registros");
                });

            modelBuilder.Entity("API_Projeto_Integrador.Models.Usuario", b =>
                {
                    b.Navigation("registros");
                });
#pragma warning restore 612, 618
        }
    }
}
