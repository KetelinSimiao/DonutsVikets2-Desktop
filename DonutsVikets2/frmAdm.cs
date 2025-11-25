using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmCadUsuario frmCadUsuario = new();
            frmCadUsuario.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new();  
            frmCadProdutos.Show();
        }
    }
}
