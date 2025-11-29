using DonutsVikets.DAL;
using DonutsVikets.DTO;

namespace DonutsVikets.BLL
{
   public class ProdutosBLL
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
            public List<ProdutosDTO> ListarProduto() => Database.Produtos;

            public ProdutosDTO GetbyID(int ID)
            {
                return _produto.FirstOrDefault(produto => produto.Id == ID);
            }




        }

        public void AtualizarProduto(ProdutosDTO produtoDTO)
        {
            var produtoExistente = Database.Produtos.FirstOrDefault(produto => produto.Id == produtoDTO.Id);

            if (produtoExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }


            if (string.IsNullOrWhiteSpace(produtoDTO.Nome))
            {
                throw new Exception("Nome é obrigatório.");

            }

            produtoExistente.Nome = produtoDTO.Nome;
            produtoExistente.Preco = produtoDTO.Preco;
            produtoExistente.Descricao = produtoDTO.Descricao;
            produtoExistente.Categoria = produtoDTO.Categoria;
            produtoExistente.Disponivel = produtoDTO.Disponivel;
            produtoExistente.TempoPreparo = produtoDTO.TempoPreparo;
            produtoExistente.DataCadastro = produtoDTO.DataCadastro;
            

        }

        public void RemoverProduto(int id)
        {
            var produto = Database.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
            {
                throw new Exception("Produto não encontrado");
            }

            Database.Produtos.Remove(produto);
        }

        public List<ProdutosDTO> ListarProduto()
        {
            throw new NotImplementedException();
        }

        public void CadastrarProduto(object funcionario)
        {
            throw new NotImplementedException();
        }
    }
}




