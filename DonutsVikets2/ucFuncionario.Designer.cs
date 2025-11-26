namespace DonutsVikets2.UI
{
    partial class ucFuncionario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgFuncionario = new Guna.UI2.WinForms.Guna2DataGridView();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtContato = new TextBox();
            label = new Label();
            label2 = new Label();
            label3 = new Label();
            Cargo = new Label();
            txtCargo = new TextBox();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgFuncionario).BeginInit();
            SuspendLayout();
            // 
            // dgFuncionario
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgFuncionario.ColumnHeadersHeight = 4;
            dgFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            dgFuncionario.GridColor = Color.FromArgb(231, 229, 255);
            dgFuncionario.Location = new Point(218, 76);
            dgFuncionario.Name = "dgFuncionario";
            dgFuncionario.RowHeadersVisible = false;
            dgFuncionario.Size = new Size(364, 258);
            dgFuncionario.TabIndex = 0;
            dgFuncionario.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgFuncionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgFuncionario.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgFuncionario.ThemeStyle.BackColor = Color.White;
            dgFuncionario.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgFuncionario.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgFuncionario.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgFuncionario.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgFuncionario.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgFuncionario.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgFuncionario.ThemeStyle.HeaderStyle.Height = 4;
            dgFuncionario.ThemeStyle.ReadOnly = false;
            dgFuncionario.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgFuncionario.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgFuncionario.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgFuncionario.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgFuncionario.ThemeStyle.RowsStyle.Height = 25;
            dgFuncionario.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgFuncionario.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgFuncionario.CellContentClick += dgFuncionario_CellContentClick;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(13, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(13, 94);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(13, 150);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(100, 23);
            txtContato.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(13, 22);
            label.Name = "label";
            label.Size = new Size(40, 15);
            label.TabIndex = 2;
            label.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 76);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 132);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Contato";
            // 
            // Cargo
            // 
            Cargo.AutoSize = true;
            Cargo.Location = new Point(14, 186);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(39, 15);
            Cargo.TabIndex = 2;
            Cargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(13, 214);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(3, 297);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(60, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += this.btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(69, 297);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(60, 23);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(493, 39);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(135, 297);
            button1.Name = "button1";
            button1.Size = new Size(58, 23);
            button1.TabIndex = 3;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // ucFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(Cargo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(txtCargo);
            Controls.Add(txtContato);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(dgFuncionario);
            Name = "ucFuncionario";
            Size = new Size(604, 353);
            Load += ucFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgFuncionario;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtContato;
        private Label label;
        private Label label2;
        private Label label3;
        private Label Cargo;
        private TextBox txtCargo;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button button3;
        private TextBox textBox1;
        private Button button1;
    }
}
