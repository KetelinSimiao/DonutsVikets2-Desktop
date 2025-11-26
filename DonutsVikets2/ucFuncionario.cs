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
    public partial class ucFuncionario : UserControl
    {
        private int? usuarioSelecionadoId = null;
        public ucFuncionario()
        {
            InitializeComponent();
        }




        private void dgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgFuncionario.Rows[e.RowIndex];

                usuarioSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtCPF.Text = row.Cells["Nome"].Value.ToString();
                .Text = row.Cells["Nome"].Value.ToString();


                btnAtualizar.Enabled = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
