using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger_Manager
{
    public partial class frmPCliente : Form
    {
        public frmPCliente()
        {
            InitializeComponent();
        }
        Cliente oCliente = new Cliente();


        string strValorTelefone;

        private void btnICliente_Click(object sender, EventArgs e)
        {
            frmCCliente ofrmCCliente = new frmCCliente();
            ofrmCCliente.ShowDialog();
            CarregarGrid();
            CarregarGridTel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void CarregarGridTel()
        {
            try
            {
                grdTelefone.DataSource = oCliente.ConsultarTel();

                grdTelefone.Columns[0].Visible = false;

                grdTelefone.Columns[1].Width = 100;
                grdTelefone.Columns[2].Width = 80;

                grdTelefone.Columns[1].HeaderText = "NOME";
                grdTelefone.Columns[2].HeaderText = "TELEFONES";

                



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CarregarGrid()
        {
            try
            {

                int intPesq = cbxTipo.SelectedIndex;

                grdCliente.DataSource = oCliente.Consultar(intPesq);

                grdCliente.Columns[0].Visible = false;

                grdCliente.Columns[1].Width = 100;
                grdCliente.Columns[2].Width = 100;
                grdCliente.Columns[3].Width = 200;
                grdCliente.Columns[4].Width = 80;
                grdCliente.Columns[5].Width = 200;
                grdCliente.Columns[6].Width = 80;
                grdCliente.Columns[7].Width = 200;
                grdCliente.Columns[8].Width = 200;
                grdCliente.Columns[9].Width = 100;
                grdCliente.Columns[10].Width = 50;
                grdCliente.Columns[11].Width = 30;


                grdCliente.Columns[0].HeaderText = "CODIGO";
                grdCliente.Columns[1].HeaderText = "CPF";
                grdCliente.Columns[2].HeaderText = "CNPJ";
                grdCliente.Columns[3].HeaderText = "Nome";
                grdCliente.Columns[4].HeaderText = "CEP";
                grdCliente.Columns[5].HeaderText = "Endereço";
                grdCliente.Columns[6].HeaderText = "Número";
                grdCliente.Columns[7].HeaderText = "Complemento";
                grdCliente.Columns[8].HeaderText = "Bairro";
                grdCliente.Columns[9].HeaderText = "Cidade";
                grdCliente.Columns[10].HeaderText = "Estado";
                grdCliente.Columns[11].HeaderText = "PF";
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Burger Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPCliente_Load(object sender, EventArgs e)
        {
            CarregarGridTel();
            CarregarGrid();
            
            cbxTipo.SelectedIndex = 0;
            cbxCategoria.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grdCliente.SelectedCells.Count != 0)
            {
                frmCCliente ofrmCCliente = new frmCCliente();

                if (Convert.ToBoolean(grdCliente.SelectedCells[11].Value))
                {
                    ofrmCCliente.rdbPF.Checked = true;
                }
                else
                {
                    ofrmCCliente.rdbPJ.Checked = true;
                }
               

                if (ofrmCCliente.rdbPF.Checked)
                {
                    ofrmCCliente.txtCPF.Text = grdCliente.SelectedCells[1].Value.ToString();
                }
                else
                {
                    ofrmCCliente.txtCNPJ.Text = grdCliente.SelectedCells[2].Value.ToString();
                }

                oCliente.intCodigo = Convert.ToInt32(grdCliente.SelectedCells[0].Value);
                ofrmCCliente.txtNome.Text = grdCliente.SelectedCells[3].Value.ToString();
                ofrmCCliente.txtCEP.Text = grdCliente.SelectedCells[4].Value.ToString();
                ofrmCCliente.txtEndereco.Text = grdCliente.SelectedCells[5].Value.ToString();
                ofrmCCliente.txtNumero.Text = grdCliente.SelectedCells[6].Value.ToString();
                ofrmCCliente.txtComplemento.Text = grdCliente.SelectedCells[7].Value.ToString();
                ofrmCCliente.txtBairro.Text = grdCliente.SelectedCells[8].Value.ToString();
                ofrmCCliente.txtCidade.Text = grdCliente.SelectedCells[9].Value.ToString();
                ofrmCCliente.txtUF.Text = grdCliente.SelectedCells[10].Value.ToString();

                
                oCliente.ConsultarTel();

                ofrmCCliente.txtCodigo.Text = oCliente.intCodigo.ToString();
                
                foreach (string tel in oCliente.strTelefones)
                {
                    ofrmCCliente.lstTelefones.Items.Add(tel);
                }

                ofrmCCliente.ShowDialog();
                oCliente = null;
                oCliente = new Cliente();
                CarregarGrid();
            }
           
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.Text.ToUpper() == "CPF")
            {
                oCliente.strCPF = txtPesquisa.Text;
                oCliente.strCNPJ = string.Empty;
                oCliente.strNome = string.Empty;
                oCliente.strBairro = string.Empty;
                oCliente.strTelefones.Clear();
                oCliente.intCodigo = 0;
            }
            else if (cbxCategoria.Text.ToUpper() == "NOME")
            {
                oCliente.strNome = txtPesquisa.Text;
                oCliente.strCNPJ = string.Empty;
                oCliente.strBairro = string.Empty;
                oCliente.strTelefones.Clear();
                oCliente.intCodigo = 0; 
            }
            else if (cbxCategoria.Text.ToUpper() == "CNPJ")
            {
                oCliente.strCNPJ = txtPesquisa.Text;
                oCliente.strNome = string.Empty;
                oCliente.strBairro = string.Empty;
                oCliente.strTelefones.Clear();
                oCliente.intCodigo = 0;
            }
            CarregarGrid();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (("NOME|TELEFONE|BAIRRO").IndexOf(cbxCategoria.Text) != -1)
            {
                cbxTipo.SelectedIndex = 0;
                cbxTipo.Enabled = true;
            }
            else if (("CPF|CNPJ").IndexOf(cbxCategoria.Text) != -1)
            {
                cbxTipo.SelectedIndex = 1;
                cbxTipo.Enabled = false;
            }

            oCliente = null;
            oCliente = new Cliente();
            txtPesquisa.Text = string.Empty;
            CarregarGrid();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            oCliente.strTelefone = txtPTelefone.Text;
            oCliente.intCodigo = 0;
            
            if(txtPTelefone.Text == string.Empty)
            {
                oCliente = null;
                oCliente = new Cliente();
                
            }

            CarregarGridTel();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtPTelefone.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


         
        //.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
        }

        private void txtGRV_TextChanged(object sender, EventArgs e)
        {
            oCliente.intCodigo = Convert.ToInt32(txtGRV.Text);
        }

        private void grdTelefone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.grdTelefone.Rows[e.RowIndex].Cells[0].Value != null)
            {
                strValorTelefone = grdTelefone.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtGRV.Text = strValorTelefone;
            }

            for (int intCont = 0; intCont < grdCliente.Rows.Count; intCont++)
            {
                grdCliente.Rows[intCont].Selected = true;
                if (grdCliente.SelectedCells[0].Value.ToString() == txtGRV.Text)
                {
                    break;
                }
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            btnAlterar.PerformClick();
        }

        private void grdTelefone_DoubleClick(object sender, EventArgs e)
        {
            btnAlterar.PerformClick();
        }
    }
}
