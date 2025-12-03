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

namespace DonutsVikets2.UI
{
    public partial class frmAdm : Form
    {
        public frmAdm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmCadFuncionario frmCadFuncionario = new();
            frmCadFuncionario.Show();
        }

        private void AbrirUserControl(UserControl uc)
        {

            panelconteudo.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelconteudo.Controls.Add(uc);
        }

        private void btnCadAcesso_Click(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new();
            frmCadProdutos.Show();
        }

        private void panelconteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        { }
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = panelConteudo2.Rows[e.RowIndex];

        //        usuarioSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
        //        txtNome.Text = row.Cells["Nome"].Value.ToString();
        //        txtUser.Text = row.Cells["Nome"].Value.ToString();
        //        txtSenha.Text = row.Cells["Nome"].Value.ToString();


        //        btnAtualizar.Enabled = true;
        //    }
        //}
        //private void AtualizarGrid()
        //{
        //    panelConteudo2.Columns.Clear();
        //    panelConteudo2.AutoGenerateColumns = false;
        //    panelConteudo2.RowTemplate.Height = 60;
        //    panelConteudo2.Height = 60;
        //    panelConteudo2.AllowUserToAddRows = false;

        //    var colFoto = new DataGridViewImageColumn
        //    {
        //        HeaderText = "Foto",
        //        Name = "Foto",
        //        DataPropertyName = "Foto",
        //        ImageLayout = DataGridViewImageCellLayout.Zoom
        //    };

        //    dgUsuario.Columns.Add(colFoto);

        //    dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id" });
        //    dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Name = "Nome" });
        //    dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Login", HeaderText = "User", Name = "Login" });
        //    dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Senha", HeaderText = "Senha", Name = "Senha" });
        //    dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UrlFoto", HeaderText = "UrlFoto", Name = "UrlFoto" });

        //    var usuarios = usuarioBLL.ListarUsuario();

        //    var dt = new DataTable();
        //    dt.Columns.Add("Foto", typeof(Image));
        //    dt.Columns.Add("Id", typeof(int));
        //    dt.Columns.Add("Nome", typeof(string));
        //    dt.Columns.Add("Login", typeof(string));
        //    dt.Columns.Add("Senha", typeof(string));
        //    dt.Columns.Add("UrlFoto", typeof(string));

        //    foreach (var u in usuarios)
        //    {
        //        Image? img = null;

        //        if (!string.IsNullOrEmpty(u.UrlFoto) && File.Exists(u.UrlFoto))
        //        {
        //            try
        //            {
        //                using (var fs = new FileStream(u.UrlFoto, FileMode.Open, FileAccess.Read))
        //                {
        //                    img = Image.FromStream(fs);
        //                }
        //            }
        //            catch (Exception)
        //            {
        //                img = null;
        //            }

        //        }
        //        dt.Rows.Add(img, u.Id, u.Nome, u.Usuario, u.Senha, u.UrlFoto);
        //    }
        //    dgUsuario.DataSource = dt;
        //}

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new();
            frmEstoque.Show();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
