using DonutsVikets.DAL;
using DonutsVikets.DTO;

namespace DonutsVikets.BLL
{
    public class UsuarioBLL : PessoaDTO
    {
        public void CadastrarUsuario(UsuarioDTO usuario)
        {
            

            var usuarios = Database.Usuarios;

            // Verifica duplicidade de login (case-insensitive)
            if (usuarios.Any(u => u.Login.Equals(usuario.Login, StringComparison.OrdinalIgnoreCase)))
                throw new Exception("Este login já está em uso.");

            // Gera um novo ID incremental
            usuario.Id = usuarios.Count > 0 ? usuarios.Max(u => u.Id) + 1 : 1;

            usuarios.Add(usuario);
            Database.Usuarios = usuarios; // Salva no JSON
        }



        public UsuarioDTO Login(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
                throw new Exception("Informe o login e a senha.");

            var usuario = Database.Usuarios
                .FirstOrDefault(u =>
                    u.Login.Equals(login, StringComparison.OrdinalIgnoreCase) &&
                    u.Senha == senha);

            if (usuario == null)
                throw new Exception("Usuário ou senha inválidos.");

            return usuario;
        }




        public void AtulizarUsuario(UsuarioDTO usuarioDTO)
        {

        }
        public void AtualizadoUsuario(UsuarioDTO UsuarioDTO)
        {
            var UsuarioExistente = Database.Usuarios.FirstOrDefault(usuario => usuario.Id == UsuarioDTO.Id);

            if (UsuarioExistente == null)

                throw new Exception("Aluno não encontrado.");

            if (string.IsNullOrWhiteSpace(UsuarioDTO.Nome))
            {
                throw new Exception("Nome é obrigadorio.");
            }


            UsuarioExistente.Id = UsuarioDTO.Id;
            UsuarioExistente.Nome = UsuarioDTO.Nome;
            UsuarioExistente.Login = UsuarioDTO.Login;
            UsuarioExistente.Senha = UsuarioDTO.Senha;
        }


    }

}






