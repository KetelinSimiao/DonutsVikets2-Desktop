using DonutsVikets.DAL;
using DonutsVikets.DTO;

namespace DonutsVikets.BLL
{
    class ProdutosBLL
    {

        public class ProdutoBLL
        {
            private List<ProdutosDTO> _produto = Database.Produtos;

            public void CadastrarProduto(ProdutosDTO produtoDTO)
            {
                if (string.IsNullOrWhiteSpace(produtoDTO.Nome))
                    throw new Exception("Nome é obrigatório");

                Database.Produtos.Add(produtoDTO);

            }
            public List<ProdutosDTO> ListarCursos() => Database.Produtos;

            public ProdutosDTO GetbyID(int ID)
            {
                return _produto.FirstOrDefault(produto => produto.Id == ID);
            }




        }


    }
}




