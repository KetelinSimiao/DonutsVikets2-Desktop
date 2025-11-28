using System.Data;
using DonutsVikets.BLL;
using DonutsVikets.DAL;
using DonutsVikets.DTO;

namespace DonutsVikets2.UI
{
    public partial class frmCadFuncionario : Form
    {
        private readonly FuncionarioBLL funcionarioBLL = new();

        private int? usuarioSelecionadoId = null;

        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
        AtualizarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void texCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFucionario_Click(object sender, EventArgs e)
        {

            var funcionario = new FuncionarioDTO()
            {
                Id = Database.Usuarios.Count + 1,
                Nome = txtNome.Text,
                CPF = int.Parse(txtCPF.Text),
                DataNascimento = dtpDataNascimento.Value,
                Contato = txtContato.Text,
                Cargo = txtCargo.Text


            };

            funcionarioBLL.CadastrarFuncionario(funcionario);

            MessageBox.Show($"Funcionario {funcionario.Nome} cadastrado com sucesso!");

            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtContato.Text = string.Empty;
            txtCargo.Text = string.Empty;
            dtpDataNascimento.Text = string.Empty;

        }




        private void txtNomeFun_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void AtualizarGrid()
        {
            dgFuncionario.Columns.Clear();
            dgFuncionario.AutoGenerateColumns = false;
            dgFuncionario.RowTemplate.Height = 60;
            dgFuncionario.AllowUserToAddRows = false;

            var colFoto = new DataGridViewImageColumn
            {
                HeaderText = "Foto",
                Name = "Foto",
                DataPropertyName = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            dgFuncionario.Columns.Add(colFoto);

            dgFuncionario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id" });
            dgFuncionario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Name = "Nome" });
            dgFuncionario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF", Name = "CPF" });
            dgFuncionario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Contato", HeaderText = "Contato", Name = "Contato" });
            dgFuncionario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo", Name = "Cargo" });

            var funcionario = funcionarioBLL.ListarFuncionario();

            var dt = new DataTable();
           
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("Contato", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));
        }

//         foreach (var u in funcionario)
//        {
//             Image? img = null;

//             if (!string.IsNullOrEmpty(u.UrlFoto) && File.Exists(u.UrlFoto))
//             { 
//                 try
//                 {
//                     using (var fs = new FileStream(u.UrlFoto, FileMode.Open, FileAccess.Read))
//                     {
//                         img = Image.FromStream(fs);
//                     }
//}
//                 catch (Exception)
//                 {
//    img = null;
//}

//             }
//             dt.Rows.Add(img, u.Id, u.Nome, u.Usuario, u.Senha, u.UrlFoto);
//         }
//        dgFuncionario.DataSource = dt;
private void dgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgFuncionario
                    .Rows[e.RowIndex];

                usuarioSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtCPF.Text = row.Cells["Nome"].Value.ToString();
                txtContato.Text = row.Cells["Nome"].Value.ToString();
                txtCargo.Text = row.Cells["Nome"].Value.ToString();



                btnAtualizar.Enabled = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgFuncionario.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um usuário na tabela.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgFuncionario.CurrentRow.Cells["Id"].Value);

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
                FuncionarioDTO funcionario
                    = new FuncionarioDTO
                    {
                        Id = id,
                        Nome = txtNome.Text.Trim(),
                        Contato = txtContato.Text.Trim(),
                        Cargo = txtCargo.Text.Trim(),

                    };

                funcionarioBLL.AtualizarFuncionario(funcionario);

                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid(); // recarrega a grid com imagem real
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }
        private void BuscarFuncionario()
        {
            string termo = txtPesquisar.Text.Trim().ToLower();

            var filtrados = funcionarioBLL.ListarFuncionario()
                                    .Where(funcionario => funcionario.Nome.ToLower().Contains(termo))
                                    .Select(funcionario => new
                                    {
                                        funcionario.Id,
                                        funcionario.Nome,
                                        funcionario.CPF,
                                        funcionario.Contato,
                                        funcionario.Cargo,
                                        
                                    }).ToList();

            dgFuncionario.DataSource = filtrados;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgFuncionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionario para excluir");
                return;
            }

            int id = dgFuncionario.SelectedRows[0].Cells["Id"]
                .Value.GetHashCode();

            string nome = dgFuncionario.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o funcionario {nome}?",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                funcionarioBLL.RemoverFuncionario(id);
                MessageBox.Show($"Aluno(a) {nome} removido com sucesso!");
                AtualizarGrid();
            }

        }
    }
}
