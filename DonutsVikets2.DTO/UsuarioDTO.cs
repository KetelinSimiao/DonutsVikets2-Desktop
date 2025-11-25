using System.ComponentModel;

namespace DonutsVikets.DTO
{
    public class UsuarioDTO : PessoaDTO
    {
        public string Login {  get; set; }
        public string Senha { get; set; }

        public int TipoUsuario { get; set; }
       
        public string Cargo {  get; set; }
    }



}
