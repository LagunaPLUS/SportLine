namespace BlazorShop.Api.Entites
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int UsuarioID { get; set; }

        public ICollection<CarrinhoItem> Itens { get; set; }
        = new List<CarrinhoItem>();
    }
}
