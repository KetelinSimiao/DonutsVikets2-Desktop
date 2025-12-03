using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonutsVikets2.BLL;
using DonutsVikets2.DAL;
using DonutsVikets2.DTO;

namespace DonutsVikets2.UI
{
    public partial class frmCadProdutos : Form
    {
        private ProdutosBLL produtoBLL = new();

        ProdutosBLL produtosBLL = new();

        private int? produtoSelecionadoId = null;

        public frmCadProdutos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastarProduto_Click(object sender, EventArgs e)
        {
            var produto = new ProdutosDTO()
            {
                Id = Database.Usuarios.Count + 1,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Preco = txtPreco.Text.Trim(),
                Categoria = txtCategoria.Text.Trim(),
                Disponivel = txtDisponivel.Text.Trim(),
                TempoPreparo = txtTempoPreparo.Text.Trim(),
                DataCadastro = txtDataCadastro.Text.Trim(),



            };

            produtosBLL.CadastrarProduto(produto);

            MessageBox.Show($"Produto {produto.Nome} cadastrado com sucesso!");

            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtDisponivel.Text = string.Empty;
            txtTempoPreparo.Text = string.Empty;
            txtDataCadastro.Text = string.Empty;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFabricação_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarGrid()
        {
            dgProduto.Columns.Clear();
            dgProduto.AutoGenerateColumns = false;
            dgProduto.RowTemplate.Height = 60;
            dgProduto.AllowUserToAddRows = false;

            var colFoto = new DataGridViewImageColumn
            {
                HeaderText = "Foto",
                Name = "Foto",
                DataPropertyName = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            dgProduto.Columns.Add(colFoto);

            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id" });
            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Name = "Nome" });
            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preco", Name = "Preco" });
            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descricao", Name = "Descricao" });
            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria", Name = "Categoria" });
            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Disponivel", HeaderText = "Disponivel", Name = "Disponivel" });
            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TempoPreparo", HeaderText = "TempoPreparo", Name = "TempoPreparo" });
            dgProduto.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DataCadastro", HeaderText = "DataCadastro", Name = "DataCadastro" });

            var produto = produtoBLL.ListarProduto();

            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Preco", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("Categoria", typeof(string));
            dt.Columns.Add("Disponivel", typeof(string));
            dt.Columns.Add("TempoPreparo", typeof(string));
            dt.Columns.Add("DataCadastro", typeof(string));
        }

        //                         foreach (var u in produto)
        //                        {
        //                             Image? img = null;

        //                             if (!string.IsNullOrEmpty(u.UrlFoto) && File.Exists(u.UrlFoto))
        //                             { 
        //                                 try
        //                                 {
        //                                     using (var fs = new FileStream(u.UrlFoto, FileMode.Open, FileAccess.Read))
        //                                     {
        //                                         img = Image.FromStream(fs);
        //                                     }
        //}
        //                                 catch (Exception)
        //                                 {
        //    img = null;
        //}

        //                             }
        //                             dt.Rows.Add(img, u.Id, u.Nome, u.Usuario, u.Senha, u.UrlFoto);
        //                         }
        //                        dgFuncionario.DataSource = dt;

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgProduto.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um usuário na tabela.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgProduto.CurrentRow.Cells["Id"].Value);

                string diretorio = Path.Combine(Application.StartupPath, "ImagensUsuarios");
                if (!Directory.Exists(diretorio))
                    Directory.CreateDirectory(diretorio);

                // Gera novo nome de imagem
                string nomeImg = $"{id} - {txtNome.Text}.jpg";
                string caminhoImagem = Path.Combine(diretorio, nomeImg);

                // Salva a imagem do PictureBox no diretório
                //if (pbFoto.Image != null)
                //pbFoto.Image.Save(caminhoImagem);

                // Atualiza o usuário
                ProdutosDTO produtos
                    = new ProdutosDTO
                    {
                        Id = id,
                        Nome = txtNome.Text.Trim(),
                        Descricao = txtDescricao.Text.Trim(),
                        Preco = txtPreco.Text.Trim(),
                        Categoria = txtCategoria.Text.Trim(),
                        Disponivel = txtDisponivel.Text.Trim(),
                        TempoPreparo = txtTempoPreparo.Text.Trim(),
                        DataCadastro = txtDataCadastro.Text.Trim(),

                    };

                produtosBLL.AtualizarProduto(produtos);

                MessageBox.Show("Produto atualizado com sucesso!", "sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid(); // recarrega a grid com imagem real
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dgProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionario para excluir");
                return;
            }

            int id = dgProduto.SelectedRows[0].Cells["Id"]
                .Value.GetHashCode();

            string nome = dgProduto.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o funcionario {nome}?",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                produtoBLL.RemoverProduto(id);
                MessageBox.Show($"Aluno(a) {nome} removido com sucesso!");
                AtualizarGrid();
            }
        }

        private void BuscarProduto()
        {
            string termo = txtPesquisar.Text.Trim().ToLower();

            var filtrados = produtosBLL.ListarProduto()
                                    .Where(produto => produto.Nome.ToLower().Contains(termo))
                                    .Select(produto => new
                                    {
                                        produto.Id,
                                        produto.Nome,
                                        produto.Descricao,
                                        produto.Preco,
                                        produto.Categoria,
                                        produto.Disponivel,
                                        produto.TempoPreparo,
                                        produto.DataCadastro

                                    }).ToList();

            dgProduto.DataSource = filtrados;
        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgProduto
                    .Rows[e.RowIndex];

                produtoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtPreco.Text = row.Cells["Nome"].Value.ToString();
                txtDescricao.Text = row.Cells["Nome"].Value.ToString();
                txtCategoria.Text = row.Cells["Nome"].Value.ToString();
                txtDisponivel.Text = row.Cells["Nome"].Value.ToString();
                txtTempoPreparo.Text = row.Cells["Nome"].Value.ToString();
                txtDataCadastro.Text = row.Cells["Nome"].Value.ToString();



                btnAtualizar.Enabled = true;
            }
        }

        private void txtDataCadastro_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

