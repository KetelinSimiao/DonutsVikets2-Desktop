using DonutsVikets.BLL;
using DonutsVikets.DAL;
using DonutsVikets.DTO;
using DonutsVikets2.UI;

namespace DonutsVikets2
{
    public partial class frmLogin2 : Form
    {

        private readonly UsuarioBLL usuarioBLL = new();
        private object txtNome;

        public frmLogin2()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {


        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadUsuario telaDeCadastro = new frmCadUsuario();
            telaDeCadastro.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            frmCadUsuario telaCadastro = new();
            telaCadastro.Show();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            mdEntrar = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(287, 401);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(97, 17);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(255, 188, 217);
            txtUsuario.BorderRadius = 20;
            txtUsuario.CustomizableEdges = customizableEdges10;
            txtUsuario.DefaultText = "Login";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FillColor = Color.FromArgb(255, 188, 217);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(330, 176);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtUsuario.Size = new Size(139, 42);
            txtUsuario.TabIndex = 6;
            txtUsuario.TextChanged += txtUsuario_TextChanged_1;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(255, 188, 217);
            txtSenha.BorderRadius = 20;
            txtSenha.CustomizableEdges = customizableEdges12;
            txtSenha.DefaultText = "Senha";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FillColor = Color.FromArgb(255, 188, 217);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(342, 269);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges13;
            txtSenha.Size = new Size(139, 42);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(255, 188, 217);
            btnEntrar.BorderRadius = 20;
            btnEntrar.CustomizableEdges = customizableEdges14;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.FromArgb(92, 176, 186);
            btnEntrar.Font = new Font("Segoe UI", 9F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(318, 331);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges15;
            btnEntrar.Size = new Size(80, 33);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(255, 188, 217);
            btnCadastrar.BorderRadius = 20;
            btnCadastrar.CustomizableEdges = customizableEdges16;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.DarkRed;
            btnCadastrar.Font = new Font("Segoe UI", 9F);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(414, 331);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges17;
            btnCadastrar.Size = new Size(78, 33);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click_2;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(255, 188, 217);
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.DarkRed;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(535, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 24);
            btnFechar.TabIndex = 8;
            btnFechar.Text = " X";
            btnFechar.Click += guna2CircleButton1_Click;
            // 
            // mdEntrar
            // 
            mdEntrar.BorderRadius = 20;
            mdEntrar.ContainerControl = this;
            mdEntrar.DockIndicatorTransparencyValue = 0.6D;
            mdEntrar.TransparentWhileDrag = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = UI.Properties.Resources.Pink_Aesthetic_Linktree_Background__5_;
            pictureBox2.Location = new Point(-2, -10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(590, 422);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // frmLogin2
            // 
            ClientSize = new Size(585, 401);
            Controls.Add(btnFechar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
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

        private void btnCadastrar_Click_2(object sender, EventArgs e)
        {
            frmCadUsuario obj = new();
            obj.ShowDialog();
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
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }





        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

