using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonutsVikets.DAL;
using DonutsVikets.DTO;

namespace DonutsVikets.BLL
{
    public class FuncionarioBLL
    {

        public void CadastrarFuncionario(FuncionarioDTO funcionario)
        {
           
            if (string.IsNullOrWhiteSpace(funcionario.Nome))
                throw new Exception("Nome é obrigatorio");

            Database.Funcionarios.Add(funcionario);
        }



        public List<FuncionarioDTO> ListarFuncionario() => Database.Funcionarios;
    }


}
