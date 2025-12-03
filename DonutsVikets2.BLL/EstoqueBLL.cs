using DonutsVikets2.DAL;
using DonutsVikets2.DTO;
using DonutsVikets2.DTO;

namespace DonutsVikets2.BLL
{
    public class EstoqueBLL
    {
        public class EstoquesBLL
        {
            // Remova esta linha - não precisa duplicar a lista aqui
            // public static List<EstoqueDTO> Estoque { get; set; } = new List<EstoqueDTO>();

            public void CadastrarEstoque(EstoqueDTO estoqueDTO)
            {
                // Validações
                if (estoqueDTO == null)
                    throw new Exception("Estoque não pode ser nulo");

                if (string.IsNullOrWhiteSpace(estoqueDTO.Nome))
                    throw new Exception("Nome é obrigatório");

                if (estoqueDTO.Quantidade < 0)
                    throw new Exception("Quantidade não pode ser negativa");

                // Adiciona na lista do Database
                Database.Estoque.Add(estoqueDTO);
            }

            public EstoqueDTO GetById(int id)
            {
                // Acessa diretamente do Database, não da variável local
                return Database.Estoque.FirstOrDefault(estoque => estoque.Id == id);
            }

            public List<EstoqueDTO> ListarTodos()
            {
                return Database.Estoque;
            }

            public void AtualizarEstoque(EstoqueDTO estoqueDTO)
            {
                var estoqueExistente = GetById(estoqueDTO.Id);

                if (estoqueExistente == null)
                    throw new Exception("Estoque não encontrado");

                estoqueExistente.Nome = estoqueDTO.Nome;
                estoqueExistente.Quantidade = estoqueDTO.Quantidade;
                estoqueExistente.DataAtualizacao = estoqueDTO.DataAtualizacao;
            }

            public void DeletarEstoque(int id)
            {
                var estoque = GetById(id);

                if (estoque == null)
                    throw new Exception("Estoque não encontrado");

                Database.Estoque.Remove(estoque);
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
