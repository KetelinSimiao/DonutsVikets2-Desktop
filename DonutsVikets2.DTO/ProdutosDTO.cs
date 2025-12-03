
namespace DonutsVikets2.DTO
{
    public class ProdutosDTO
    {
       public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Preco { get; set; }
        public string Categoria {  get; set; }
        public string Descricao { get; set; }
        public string Disponivel {  get; set; }
        public string TempoPreparo {  get; set; }
        public string DataCadastro {  get; set; }
        public int DataAtualizacao { get; set; }
        public string Quantidade { get; set; }

     
    }
}
