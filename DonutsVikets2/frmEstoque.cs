using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonutsVikets.BLL;
using DonutsVikets.DAL;
using DonutsVikets.DTO;
using DonutsVikets2.BLL;
using DonutsVikets2.DTO;
using static DonutsVikets.BLL.ProdutosBLL;

namespace DonutsVikets2.UI
{
    public partial class frmEstoque : Form
    {
        private EstoqueBLL estoqueBLL = new();
        private object txtQuantidade;

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgEstoque.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um produto na tabela.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgEstoque.CurrentRow.Cells["Id"].Value);

                string diretorio = Path.Combine(Application.StartupPath, "ImagensUsuarios");
                if (!Directory.Exists(diretorio))
                    Directory.CreateDirectory(diretorio);

                // Gera novo nome de imagem
                string nomeImg = $"{id} - {txtNome.Text}.jpg";
                string caminhoImagem = Path.Combine(diretorio, nomeImg);


                EstoqueDTO estoque
                    = new EstoqueDTO
                    {
                        Id = id,
                        Nome = txtNome.Text.Trim(),
                        Quantidade = Convert.ToInt32(txtQuantidade2.Text),
                        DataAtualizacao = dtpData.Value,
                    };

                estoqueBLL.AtualizarEstoque(estoque);

                MessageBox.Show("Estoque atualizado com sucesso!", "sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid(); // recarrega a grid com imagem real
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            var estoque = new EstoqueDTO()
            {
                Id = Database.Usuarios.Count + 1,
                Nome = txtNome.Text,
                Quantidade = Convert.ToInt32(txtQuantidade2.Text),
                DataAtualizacao = dtpData.Value
               
            };

            estoqueBLL.CadastrarEstoque(estoque);

            MessageBox.Show($"Estoque {estoque.Nome} cadastrado com sucesso!");

            txtNome.Text = string.Empty;
            datetimeAtualicao.Text = string.Empty;
            datetimeAtualicao.Text = string.Empty;
            

        }



        public frmEstoque()
        {
            InitializeComponent();
        }

    }
}

