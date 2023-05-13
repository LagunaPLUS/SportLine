using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Identity.Client;

namespace BlazorShop.Api.Entites
{
    public class CarrinhoItem
    {
        public int Id { get; set; }
        public int ProdutoID { get; set; }
        public int CarrinhoID { get; set; }
        public int Quantidade { get; set; }

        public Carrinho? Carrinho { get; set; }
        public Produto? Produto { get; set; }
    }
}
