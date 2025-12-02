using DonutsVikets.DAL;
using DonutsVikets.DTO;
using DonutsVikets2.DTO;

namespace DonutsVikets2.BLL
{
    public class EstoqueBLL
    {
        public class EstoquesBLL
        {
            private List<EstoqueDTO> _estoque = Database.Estoque;

            public void CadastrarEstoque(EstoqueDTO estoqueDTO)
            {
                if (string.IsNullOrWhiteSpace(estoqueDTO.Nome))
                    throw new Exception("Nome é obrigatório");

                Database.Estoque.Add(estoqueDTO);

            }
            public List<EstoqueDTO> ListarProduto() => Database.Estoque;

            public EstoqueDTO GetbyID(int ID)
            {
                return _estoque.FirstOrDefault(estoque => estoque.Id == ID);
            }




        }

        public void AtualizarEstoque(EstoqueDTO estoqueDTO)
        {
            var estoqueExistente = Database.Estoque.FirstOrDefault(estoque => estoque.Id == estoqueDTO.Id);

            if (estoqueExistente == null)
            {
                throw new Exception("Produto não encontrado no estoque.");
            }


            if (string.IsNullOrWhiteSpace(estoqueDTO.Nome))
            {
                throw new Exception("Nome é obrigatório.");

            }

            estoqueExistente.Nome = estoqueDTO.Nome;
            estoqueExistente.DataAtualizacao = estoqueDTO.DataAtualizacao;
            estoqueExistente.Quantidade = estoqueDTO.Quantidade;
            
           


        }

        public void RemoverEstoque(int id)
        {
            var estoque = Database.Produtos.FirstOrDefault(e => e.Id == id);

            if (estoque == null)
            {
                throw new Exception("Produto não encontrado no estoque.");
            }

            Database.Produtos.Remove(estoque);
        }

        public List<EstoqueDTO> ListarEstoque()
        {
            throw new NotImplementedException();
        }

        public void CadastrarEstoque(object estoque)
        {
            throw new NotImplementedException();
        }
    }
}
