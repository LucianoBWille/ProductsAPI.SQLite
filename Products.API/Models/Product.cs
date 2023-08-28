namespace Products.API.Models
{
    public class ProductModel
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        public int Quantidade { get; set; }

        public ProductModel(int? id, string nome, float preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}