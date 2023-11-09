﻿// <auto-generated />
using EcommerceProductAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceProductAPI.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    [Migration("20231109164807_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceProductAPI.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "tenis",
                            Genero = 2,
                            ImagemUrl = "/assets/VANS.webp",
                            Nome = "VANS Preto",
                            Preco = 199.99m,
                            Tamanho = ""
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "tenis",
                            Genero = 2,
                            ImagemUrl = "/assets/aaaaa.jpg",
                            Nome = "Adidas Gold",
                            Preco = 199.99m,
                            Tamanho = ""
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "tenis",
                            Genero = 2,
                            ImagemUrl = "/assets/MaxRosa.webp",
                            Nome = "Air max rosa",
                            Preco = 199.99m,
                            Tamanho = ""
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "tenis",
                            Genero = 2,
                            ImagemUrl = "/assets/tenis-nike-downshifter-11-feminino-img.jpg",
                            Nome = "Nike Purple Run",
                            Preco = 199.99m,
                            Tamanho = ""
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "tenis",
                            Genero = 1,
                            ImagemUrl = "/assets/tenisPuma.webp",
                            Nome = "Puma Branco",
                            Preco = 289.99m,
                            Tamanho = ""
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "tenis",
                            Genero = 1,
                            ImagemUrl = "/assets/ct0978-060_4.jpg",
                            Nome = "Nike Air Jordan",
                            Preco = 289.99m,
                            Tamanho = ""
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "tenis",
                            Genero = 1,
                            ImagemUrl = "/assets/1011B004_300_SR_RT_GLB_PNG_1280x1280-JPG.webp",
                            Nome = " Asics Verde",
                            Preco = 249.99m,
                            Tamanho = ""
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "tenis",
                            Genero = 1,
                            ImagemUrl = "/assets/MaxColorido.webp",
                            Nome = "Air Max Colorido",
                            Preco = 349.99m,
                            Tamanho = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
