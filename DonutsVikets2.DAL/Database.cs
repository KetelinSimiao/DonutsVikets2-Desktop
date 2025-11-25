using DonutsVikets.DTO;

namespace DonutsVikets.DAL
{
    public static class Database
    {
        public static List<FuncionarioDTO> Funcionarios
        {
            get => jsonDatabase.Ler<FuncionarioDTO>("Funcionario.json");
            set => jsonDatabase.salvar("Funcionario.json", value);

        }




        public static List<ProdutosDTO> Produtos
        {
            get => jsonDatabase.Ler<ProdutosDTO>("Produto.json");
            set => jsonDatabase.salvar("Produto.json", value);


        }
        public static List<UsuarioDTO> Usuarios

        {
            get => jsonDatabase.Ler<UsuarioDTO>("Usuarios.json");
            set => jsonDatabase.salvar("Usuarios.json", value);
        }
    }

}
