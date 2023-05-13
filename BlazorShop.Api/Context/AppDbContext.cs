using BlazorShop.Api.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BlazorShop.Api.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions <AppDbContext> options) 
        :base(options) 

    { 
    }

    public DbSet<Carrinho>? Carrinhos { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<CarrinhoItem>? CarrinhoItens { get; set; } 
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 1,
            Nome = "Beleza",
            IconCSS = "fas fa-spa"

        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 1,
            Nome = "Camisa",
            Descricao = "Camisa esportiva NIKE",
            ImagemUrl = "/imagem/camisa/camisa1.png",
            Preco = 100,
            Quantidade = 100,
            CategoriaId = 1,

        });
        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 1,
            NomeUsuario = "Pedro",
            

        });
    }
    
        

 }
