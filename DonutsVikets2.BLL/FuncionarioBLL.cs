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
    
    public void AtualizarFuncionario(FuncionarioDTO funcionarioDTO)
        {
            var funcionarioExistente = Database.Funcionarios.FirstOrDefault(aluno => aluno.Id == funcionarioDTO.Id);

            if (funcionarioExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }


            if (string.IsNullOrWhiteSpace(funcionarioDTO.Nome))
            {
                throw new Exception("Nome é obrigatório.");

            }

            funcionarioExistente.Nome = funcionarioDTO.Nome;
            funcionarioExistente.CPF= funcionarioDTO.CPF;
            funcionarioExistente.Contato = funcionarioDTO.Contato;
            funcionarioExistente.Cargo = funcionarioDTO.Cargo;

        }
        public void RemoverFuncionario(int id)
        {
            var funcionario = Database.Funcionarios.FirstOrDefault(a => a.Id == id);

            if (funcionario == null)
            {
                throw new Exception("Aluno não encontrado");
            }

            Database.Funcionarios.Remove(funcionario);
        }

    }
}
