namespace DonutsVikets.DTO
{
    public class ProdutosDTO
    {
       public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; }
        public string Preco {  get; set; }
        public string Descricao { get; set; }
        public string Disponivel {  get; set; }
        public string TempoPreparo {  get; set; }
        public string DataCadastro {  get; set; }

    }
}
