using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioMinka
{
    public partial class frmCadastros : Form
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmPesquisaClientes ofrmPesquisaClientes = new frmPesquisaClientes();
            ofrmPesquisaClientes.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmPesquisaFuncionarios ofrmPesquisaFuncionarios = new frmPesquisaFuncionarios();
            ofrmPesquisaFuncionarios.ShowDialog();
        }
    }
}
