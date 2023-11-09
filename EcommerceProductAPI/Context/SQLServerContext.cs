﻿using EcommerceProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProductAPI.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }
        public DbSet<Produto> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "VANS Preto",
                Descricao = "tenis",
                Preco = 199.99m,
                ImagemUrl = "/assets/VANS.webp",
                Genero = EGenero.Feminino,
                Tamanho= string.Empty
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 2,
                Nome = "Adidas Gold",
                Descricao = "tenis",
                Preco = 199.99m,
                ImagemUrl = "/assets/aaaaa.jpg",
                Genero = EGenero.Feminino,
               Tamanho = string.Empty
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 3,
                Nome = "Air max rosa",
                Descricao = "tenis",
                Preco = 199.99m,
                ImagemUrl = "/assets/MaxRosa.webp",
                Genero = EGenero.Feminino,
                Tamanho= string.Empty

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 4,
                Nome = "Nike Purple Run",
                Descricao = "tenis",
                Preco = 199.99m,
                ImagemUrl = "/assets/tenis-nike-downshifter-11-feminino-img.jpg",
                Genero = EGenero.Feminino,
                Tamanho= string.Empty

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 5,
                Nome = "Puma Branco",
                Descricao = "tenis",
                Preco = 289.99m,
                ImagemUrl = "/assets/tenisPuma.webp",
                Genero = EGenero.Masculino,
                Tamanho= string.Empty

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 6,
                Nome = "Nike Air Jordan",
                Descricao = "tenis",
                Preco = 289.99m,
                ImagemUrl = "/assets/ct0978-060_4.jpg",
                Genero = EGenero.Masculino,
                Tamanho= string.Empty

            }); modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 7,
                Nome = " Asics Verde",
                Descricao = "tenis",
                Preco = 249.99m,
                ImagemUrl = "/assets/1011B004_300_SR_RT_GLB_PNG_1280x1280-JPG.webp",
                Genero = EGenero.Masculino,
                Tamanho= string.Empty

            }); modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 9,
                Nome = "Air Max Colorido",
                Descricao = "tenis",
                Preco = 349.99m,
                ImagemUrl = "/assets/MaxColorido.webp",
                Genero = EGenero.Masculino,
                Tamanho= string.Empty

            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
