namespace DonutsVikets.DTO
{
    public class ProdutosDTO
    {
       public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataValidade { get; set; }
        public double Preco {  get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque {  get; set; }
        public string Sabor {  get; set; }
        public DateTime DataFabricacao {  get; set; }

    }
}
