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
    public partial class frmPesquisaFuncionarios : Form
    {
        public frmPesquisaFuncionarios()
        {
            InitializeComponent();
        }
        bool filtro = true;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmEditaFuncionarios ofrmEditaFuncionarios = new frmEditaFuncionarios();
            ofrmEditaFuncionarios.ShowDialog();
        }

        private void pbxFiltro_Click(object sender, EventArgs e)
        {
            if (tbxFiltro.Text == "")
            {
                MessageBox.Show("Campo 'Texto' Vazio, por favor digite algum dado para filtrar!", "Studio Mink'a - Atenção: Campo Vazio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxFiltro.Focus();
            }
            else
            {
                if (filtro == true)
                {
                    pbxFiltro.Image = StudioMinka.Properties.Resources.limpa_filtro;
                    filtro = false;
                }
                else if (filtro == false)
                {
                    tbxFiltro.Clear();
                    rbtnNome.Checked = true;
                    pbxFiltro.Image = StudioMinka.Properties.Resources.filtro;
                    filtro = true;
                }
            }
        }
    }
}
