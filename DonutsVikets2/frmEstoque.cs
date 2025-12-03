using System.Data;
using DonutsVikets2.BLL;
using DonutsVikets2.DAL;
using DonutsVikets2.BLL;
using DonutsVikets2.DTO;

namespace DonutsVikets2.UI
{
    public partial class frmEstoque : Form
    {
        private EstoqueBLL estoqueBLL = new();
        private object txtQuantidade;
        private int? produtoSelecionadoId = null;
        private object txtDataAtualizacao;

        private void AtualizarGrid()
        {
            dgEstoque.Columns.Clear();
            dgEstoque.AutoGenerateColumns = false;
            dgEstoque.RowTemplate.Height = 60;
            dgEstoque.AllowUserToAddRows = false;



            dgEstoque.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id" });
            dgEstoque.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Name = "Nome" });
            dgEstoque.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade", Name = "Quantidade" });
            dgEstoque.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DataAtualizacao", HeaderText = "DataAtualizacao", Name = "DataAtualizacao" });

            var produto = estoqueBLL.ListarEstoque();

            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("DataAtualizacao", typeof(string));

        }





        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgEstoque.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um estoque na tabela.", "Aviso",
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
                Id = Database.Estoque.Count + 1,
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um estoque para excluir");
                return;
            }

            int id = dgEstoque.SelectedRows[0].Cells["Id"]
                .Value.GetHashCode();

            string nome = dgEstoque.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o estoque do estoque {nome}?",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                estoqueBLL.RemoverEstoque(id);
                MessageBox.Show($"Aluno(a) {nome} removido com sucesso!");
                AtualizarGrid();
            }

        }

        private void dgEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgEstoque
                    .Rows[e.RowIndex];

                produtoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtQuantidade = Convert.ToInt32(row.Cells["Quantidade"].Value).ToString();
                txtDataAtualizacao = Convert.ToDateTime(row.Cells["DataAtualizacao"].Value).ToString("dd/MM/yyyy");



                btnAtualizar.Enabled = true;
            }
        }

        private void BuscarEstoque()
        {
            string termo = txtPesquisar.Text.Trim().ToLower();

            var filtrados = estoqueBLL.ListarEstoque()
                                    .Where(estoque => estoque.Nome.ToLower().Contains(termo))
                                    .Select(estoque => new
                                    {
                                        estoque.Id,
                                        estoque.Nome,
                                        estoque.Quantidade,
                                        estoque.DataAtualizacao,

                                    }).ToList();

            dgEstoque.DataSource = filtrados;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarEstoque();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

