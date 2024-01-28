﻿// <auto-generated />
using System;
using HotelWEBAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelWEBAPI.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20240128224519_Update-1")]
    partial class Update1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelWEBAPI.Models.Cliente", b =>
                {
                    b.Property<int>("CodCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodCliente"));

                    b.Property<string>("EmailCliente")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EndCliente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NacioCliente")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelCliente")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("CodCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.Filial", b =>
                {
                    b.Property<int>("CodFilial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFilial"));

                    b.Property<string>("EndFilial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Estrelas")
                        .HasColumnType("int");

                    b.Property<string>("NomeFilial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodFilial");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.FilialQuarto", b =>
                {
                    b.Property<int>("FkFilialCodFilial")
                        .HasColumnType("int");

                    b.Property<int>("FkQuartoNumQuarto")
                        .HasColumnType("int");

                    b.HasKey("FkFilialCodFilial");

                    b.HasIndex("FkQuartoNumQuarto");

                    b.ToTable("FiliaisQuartos");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.Funcionario", b =>
                {
                    b.Property<int>("CodFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFuncionario"));

                    b.Property<string>("CargoFuncionario")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("FkFilialCodFilial")
                        .HasColumnType("int");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelFuncionario")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("CodFuncionario");

                    b.HasIndex("FkFilialCodFilial");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.Prato", b =>
                {
                    b.Property<int>("CodPrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodPrato"));

                    b.Property<string>("NomePrato")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("ValorPrato")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("CodPrato");

                    b.ToTable("Pratos");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.PratoConta", b =>
                {
                    b.Property<int>("FkPratoCodPrato")
                        .HasColumnType("int");

                    b.Property<int>("FkReservaContaCodReserva")
                        .HasColumnType("int");

                    b.HasKey("FkPratoCodPrato");

                    b.HasIndex("FkReservaContaCodReserva");

                    b.ToTable("PratosContas");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.Produto", b =>
                {
                    b.Property<int>("CodProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodProduto"));

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("PrecoProduto")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("CodProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.ProdutoConta", b =>
                {
                    b.Property<int>("FkProdutoCodProduto")
                        .HasColumnType("int");

                    b.Property<int>("FkReservaContaCodReserva")
                        .HasColumnType("int");

                    b.HasKey("FkProdutoCodProduto");

                    b.HasIndex("FkReservaContaCodReserva");

                    b.ToTable("ProdutosContas");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.Quarto", b =>
                {
                    b.Property<int>("NumQuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumQuarto"));

                    b.Property<bool>("Adaptado")
                        .HasColumnType("bit");

                    b.Property<int>("CapacidadeQuarto")
                        .HasColumnType("int");

                    b.Property<string>("TipoQuarto")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("ValorQuarto")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("NumQuarto");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.ReservaConta", b =>
                {
                    b.Property<int>("CodReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodReserva"));

                    b.Property<bool>("CamaAdicional")
                        .HasColumnType("bit");

                    b.Property<int>("CodConta")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCheckin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCheckout")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkClienteCodCliente")
                        .HasColumnType("int");

                    b.Property<int>("FkFuncionarioCodFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("FkQuartoNumQuarto")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusReserva")
                        .HasColumnType("bit");

                    b.Property<string>("TipoPagamento")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CodReserva");

                    b.HasIndex("FkClienteCodCliente");

                    b.HasIndex("FkFuncionarioCodFuncionario");

                    b.HasIndex("FkQuartoNumQuarto");

                    b.ToTable("ReservasContas");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.Servico", b =>
                {
                    b.Property<int>("CodServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodServico"));

                    b.Property<string>("DescServico")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("ValorServico")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("CodServico");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.ServicoConta", b =>
                {
                    b.Property<int>("FkServicoCodServico")
                        .HasColumnType("int");

                    b.Property<int>("FkReservaContaCodReserva")
                        .HasColumnType("int");

                    b.HasKey("FkServicoCodServico");

                    b.HasIndex("FkReservaContaCodReserva");

                    b.ToTable("ServicosContas");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.FilialQuarto", b =>
                {
                    b.HasOne("HotelWEBAPI.Models.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FkFilialCodFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWEBAPI.Models.Quarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("FkQuartoNumQuarto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");

                    b.Navigation("Quarto");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.Funcionario", b =>
                {
                    b.HasOne("HotelWEBAPI.Models.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FkFilialCodFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.PratoConta", b =>
                {
                    b.HasOne("HotelWEBAPI.Models.Prato", "Prato")
                        .WithMany()
                        .HasForeignKey("FkPratoCodPrato")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWEBAPI.Models.ReservaConta", "ReservaConta")
                        .WithMany()
                        .HasForeignKey("FkReservaContaCodReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prato");

                    b.Navigation("ReservaConta");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.ProdutoConta", b =>
                {
                    b.HasOne("HotelWEBAPI.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("FkProdutoCodProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWEBAPI.Models.ReservaConta", "ReservaConta")
                        .WithMany()
                        .HasForeignKey("FkReservaContaCodReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("ReservaConta");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.ReservaConta", b =>
                {
                    b.HasOne("HotelWEBAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("FkClienteCodCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWEBAPI.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FkFuncionarioCodFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWEBAPI.Models.Quarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("FkQuartoNumQuarto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");

                    b.Navigation("Quarto");
                });

            modelBuilder.Entity("HotelWEBAPI.Models.ServicoConta", b =>
                {
                    b.HasOne("HotelWEBAPI.Models.ReservaConta", "ReservaConta")
                        .WithMany()
                        .HasForeignKey("FkReservaContaCodReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWEBAPI.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("FkServicoCodServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReservaConta");

                    b.Navigation("Servico");
                });
#pragma warning restore 612, 618
        }
    }
}