using DonutsVikets.BLL;
using DonutsVikets.DAL;
using DonutsVikets.DTO;

namespace DonutsVikets2.UI
{
    public partial class frmCadFuncionario : Form
    {
        private readonly FuncionarioBLL funcionarioBLL = new();
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {

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
                Nome = txtNomeFun.Text,
                CPF = int.Parse(txtCPF.Text),
                DataNascimento = dtpDataNascimento.Value,
                Contato = txtContato.Text,
                Cargo = txtCargo.Text


            };

            funcionarioBLL.CadastrarFuncionario(funcionario);

            MessageBox.Show($"Funcionario {funcionario.Nome} cadastrado com sucesso!");

       txtNomeFun.Text = string.Empty;
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
    }
}
