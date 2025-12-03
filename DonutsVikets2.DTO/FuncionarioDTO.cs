using Microsoft.VisualBasic;

namespace DonutsVikets2.DTO
{
    public class FuncionarioDTO: PessoaDTO
    {
       
        public string Login { get; set; }
        public int Senha{ get; set; }
        public string  Cargo{ get; set; }

        public string Contato { get; set; }


    }
}
