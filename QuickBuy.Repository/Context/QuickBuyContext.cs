using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repository.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {
        public QuickBuyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
    }
}
