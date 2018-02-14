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
    public partial class frmPesquisaClientes : Form
    {
        public frmPesquisaClientes()
        {
            InitializeComponent();
        }

        bool filtro = true;
        Cliente oCliente = new Cliente();
        private void pbxFiltro_Click(object sender, EventArgs e)
        {
                if (filtro == true)
                {
                    tbxFiltro.Clear();
                    rbtnNome.Checked = true;
                    
                }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmEditarCliente ofrmEditarCliente = new frmEditarCliente();
            ofrmEditarCliente.ShowDialog();
            CarregarGrid();
        }

        private void frmPesquisaClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            try
            {

                dgvClientes.DataSource = oCliente.Consultar();

                dgvClientes.Columns[0].Visible = false;
                dgvClientes.Columns[14].Visible = false;
                dgvClientes.Columns[15].Visible = false;

                dgvClientes.Columns[1].Width = 100;
                dgvClientes.Columns[2].Width = 130;
                dgvClientes.Columns[3].Width = 200;
                dgvClientes.Columns[4].Width = 200;
                dgvClientes.Columns[5].Width = 100;
                dgvClientes.Columns[6].Width = 250;
                dgvClientes.Columns[7].Width = 50;
                dgvClientes.Columns[8].Width = 170;
                dgvClientes.Columns[9].Width = 100;
                dgvClientes.Columns[10].Width = 100;
                dgvClientes.Columns[11].Width = 70;
                dgvClientes.Columns[12].Width = 100;
                dgvClientes.Columns[13].Width = 100;


                dgvClientes.Columns[0].HeaderText = "CODIGO";
                dgvClientes.Columns[1].HeaderText = "CPF";
                dgvClientes.Columns[2].HeaderText = "CNPJ";
                dgvClientes.Columns[3].HeaderText = "Nome";
                dgvClientes.Columns[4].HeaderText = "Email";
                dgvClientes.Columns[5].HeaderText = "CEP";
                dgvClientes.Columns[6].HeaderText = "Endereço";
                dgvClientes.Columns[7].HeaderText = "Número";
                dgvClientes.Columns[8].HeaderText = "Complemento";
                dgvClientes.Columns[9].HeaderText = "Bairro";
                dgvClientes.Columns[10].HeaderText = "Cidade";
                dgvClientes.Columns[11].HeaderText = "Estado";
                dgvClientes.Columns[12].HeaderText = "Telefone 1";
                dgvClientes.Columns[13].HeaderText = "Telefone 2";
                dgvClientes.Columns[14].HeaderText = "Pessoa";
                dgvClientes.Columns[15].HeaderText = "TelCel";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Studio Mink'a",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (rbtnNome.Checked == true)
            {
                oCliente.strNome = tbxFiltro.Text;
                oCliente.strCPF = string.Empty;
                oCliente.strCNPJ = string.Empty;
                oCliente.strEndereco = string.Empty;
                oCliente.strEmail = string.Empty;
                oCliente.strTelefone = string.Empty;
                oCliente.strTelefone2 = string.Empty;
                oCliente.intCodigo = 0;
            }
            else if (rbtnCPF.Checked == true)
            {
                oCliente.strCPF = tbxFiltro.Text;
                oCliente.strNome = string.Empty;
                oCliente.strCNPJ = string.Empty;
                oCliente.strEndereco = string.Empty;
                oCliente.strEmail = string.Empty;
                oCliente.strTelefone = string.Empty;
                oCliente.strTelefone2 = string.Empty;
                oCliente.intCodigo = 0;
            }
            else if (rbtnCNPJ.Checked == true)
            {
                oCliente.strCNPJ = tbxFiltro.Text;
                oCliente.strCPF = string.Empty;
                oCliente.strNome = string.Empty;
                oCliente.strEndereco = string.Empty;
                oCliente.strEmail = string.Empty;
                oCliente.strTelefone = string.Empty;
                oCliente.strTelefone2 = string.Empty;
                oCliente.intCodigo = 0;
            }
            else if (rbtnEndereco.Checked == true)
            {
                oCliente.strEndereco = tbxFiltro.Text;
                oCliente.strCPF = string.Empty;
                oCliente.strCNPJ = string.Empty;
                oCliente.strNome = string.Empty;
                oCliente.strEmail = string.Empty;
                oCliente.strTelefone = string.Empty;
                oCliente.strTelefone2 = string.Empty;
                oCliente.intCodigo = 0;
            }
            else if (rbtnEmail.Checked == true)
            {
                oCliente.strEmail = tbxFiltro.Text;
                oCliente.strCPF = string.Empty;
                oCliente.strCNPJ = string.Empty;
                oCliente.strEndereco = string.Empty;
                oCliente.strNome = string.Empty;
                oCliente.strTelefone = string.Empty;
                oCliente.strTelefone2 = string.Empty;
                oCliente.intCodigo = 0;
            }
            else if (rbtnTelefone.Checked == true)
            {
                oCliente.strTelefone = tbxFiltro.Text;
                oCliente.strTelefone2 = tbxFiltro.Text;
                oCliente.strCPF = string.Empty;
                oCliente.strCNPJ = string.Empty;
                oCliente.strEndereco = string.Empty;
                oCliente.strNome = string.Empty;
                oCliente.intCodigo = 0;
            }
            CarregarGrid();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedCells.Count != 0)
            {
                frmEditarCliente ofrmEditarCliente = new frmEditarCliente();

                if (Convert.ToBoolean(dgvClientes.SelectedCells[14].Value))
                {
                    ofrmEditarCliente.rbtnPF.Checked = true;
                }
                else
                {
                    ofrmEditarCliente.rbtnPJ.Checked = true;
                }


                if (ofrmEditarCliente.rbtnPF.Checked)
                {
                    ofrmEditarCliente.mtbxCPF.Text = dgvClientes.SelectedCells[1].Value.ToString();
                }
                else
                {
                    ofrmEditarCliente.mtbxCPF.Text = dgvClientes.SelectedCells[2].Value.ToString();
                }

                oCliente.intCodigo = Convert.ToInt32(dgvClientes.SelectedCells[0].Value);
                ofrmEditarCliente.tbxNome.Text = dgvClientes.SelectedCells[3].Value.ToString();
                ofrmEditarCliente.tbxEmail.Text = dgvClientes.SelectedCells[4].Value.ToString();
                ofrmEditarCliente.tbxCEP.Text = dgvClientes.SelectedCells[5].Value.ToString();
                ofrmEditarCliente.tbxEndereco.Text = dgvClientes.SelectedCells[6].Value.ToString();
                ofrmEditarCliente.tbxNumero.Text = dgvClientes.SelectedCells[7].Value.ToString();
                ofrmEditarCliente.tbxComplemento.Text = dgvClientes.SelectedCells[8].Value.ToString();
                ofrmEditarCliente.tbxBairro.Text = dgvClientes.SelectedCells[9].Value.ToString();
                ofrmEditarCliente.tbxCidade.Text = dgvClientes.SelectedCells[10].Value.ToString();
                ofrmEditarCliente.tbxUF.Text = dgvClientes.SelectedCells[11].Value.ToString();
                ofrmEditarCliente.mtbxTelefone.Text = dgvClientes.SelectedCells[12].Value.ToString();
                ofrmEditarCliente.mtbxTelefone2.Text = dgvClientes.SelectedCells[13].Value.ToString();
                

                ofrmEditarCliente.cbxTelCel.Tag = dgvClientes.SelectedCells[15].Value.ToString();


                ofrmEditarCliente.tbxCodigo.Text = oCliente.intCodigo.ToString();

                ofrmEditarCliente.ShowDialog();
                oCliente = null;
                oCliente = new Cliente();
                CarregarGrid();
            }

        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            btnEditarCliente.PerformClick();
        }
    }
}
