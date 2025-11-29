namespace DonutsVikets2.UI
{
    partial class frmAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            pictureBox1 = new PictureBox();
            btnFuncionario = new Guna.UI2.WinForms.Guna2Button();
            btnCozinha = new Guna.UI2.WinForms.Guna2Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnEstoque = new Guna.UI2.WinForms.Guna2Button();
            btnProduto = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = null;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            guna2MessageDialog1.Text = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(950, 529);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.FromArgb(92, 176, 186);
            btnFuncionario.BorderRadius = 20;
            btnFuncionario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btnFuncionario.CustomizableEdges = customizableEdges1;
            btnFuncionario.DisabledState.BorderColor = Color.DarkGray;
            btnFuncionario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFuncionario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFuncionario.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFuncionario.FillColor = Color.FromArgb(92, 176, 186);
            btnFuncionario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFuncionario.ForeColor = Color.White;
            btnFuncionario.Location = new Point(31, 50);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFuncionario.Size = new Size(176, 66);
            btnFuncionario.TabIndex = 2;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnCozinha
            // 
            btnCozinha.BackColor = Color.FromArgb(92, 176, 186);
            btnCozinha.BorderRadius = 20;
            btnCozinha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btnCozinha.CustomizableEdges = customizableEdges3;
            btnCozinha.DisabledState.BorderColor = Color.DarkGray;
            btnCozinha.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCozinha.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCozinha.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCozinha.FillColor = Color.FromArgb(92, 176, 186);
            btnCozinha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCozinha.ForeColor = Color.White;
            btnCozinha.Location = new Point(42, 146);
            btnCozinha.Name = "btnCozinha";
            btnCozinha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCozinha.Size = new Size(142, 52);
            btnCozinha.TabIndex = 2;
            btnCozinha.Text = "Cozinha";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // btnEstoque
            // 
            btnEstoque.CustomizableEdges = customizableEdges5;
            btnEstoque.DisabledState.BorderColor = Color.DarkGray;
            btnEstoque.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEstoque.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEstoque.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEstoque.FillColor = Color.FromArgb(92, 176, 186);
            btnEstoque.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Location = new Point(12, 240);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEstoque.Size = new Size(205, 47);
            btnEstoque.TabIndex = 3;
            btnEstoque.Text = "Estoque";
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(92, 176, 186);
            btnProduto.BorderRadius = 20;
            btnProduto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btnProduto.CustomizableEdges = customizableEdges7;
            btnProduto.DisabledState.BorderColor = Color.DarkGray;
            btnProduto.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProduto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProduto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProduto.FillColor = Color.FromArgb(92, 176, 186);
            btnProduto.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(31, 324);
            btnProduto.Name = "btnProduto";
            btnProduto.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnProduto.Size = new Size(191, 57);
            btnProduto.TabIndex = 2;
            btnProduto.Text = "Cad.Produto";
            btnProduto.Click += btnProduto_Click;
            // 
            // frmAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 529);
            Controls.Add(btnEstoque);
            Controls.Add(btnCozinha);
            Controls.Add(btnFuncionario);
            Controls.Add(btnProduto);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdm";
            Text = "Adm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnCozinha;
        private Guna.UI2.WinForms.Guna2Panel panelconteudo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button btnEstoque;
        private Guna.UI2.WinForms.Guna2Button btnProduto;
    }
}