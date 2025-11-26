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

namespace DonutsVikets2.UI
{
    public partial class frmLoginFix : Form
    {
        private readonly UsuarioBLL usuarioBLL = new();
        public frmLoginFix()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = usuarioBLL.Login(txtUsuario.Text, txtSenha.Text);
                Session.UsuarioLogado = usuario;
                // mdEntrar.ShadowColor = Color.#ffbcd9;
                // mdEntrar.Show($"Bem vindo(a) {Session.UsuarioLogado.Nome}");

                frmAdm principal = new();
                principal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadUsuario obj = new();
            obj.ShowDialog();
        }


        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    // Se a senha estiver vazia, muda o foco
                    txtSenha.Focus();
                }
                else
                {
                    // Se já tiver senha, tenta logar
                    btnEntrar.PerformClick();
                }

                // Impede o beep padrão do Enter
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
