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
    public partial class frmPFuncionario : Form
    {
        public frmPFuncionario()
        {
            InitializeComponent();
        }
        Funcionario oFuncionario = new Funcionario();


        private void btnIFuncionario_Click(object sender, EventArgs e)
        {
            frmCFuncionarios ofrmCFuncionarios = new frmCFuncionarios();
            
            ofrmCFuncionarios.ShowDialog();
            CarregarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmPFuncionario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            cbxTipo.SelectedIndex = 0;
            cbxCategoria.SelectedIndex = 0;
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.Text.ToUpper() == "CPF")
            {
                oFuncionario.strCPF = txtPesquisa.Text;
                oFuncionario.strNome = string.Empty;
                oFuncionario.strUsuario = string.Empty;
                oFuncionario.intCodigo = 0;
            }
            else if (cbxCategoria.Text.ToUpper() == "NOME")
            {
                oFuncionario.strNome = txtPesquisa.Text;
                oFuncionario.strCPF = string.Empty;
                oFuncionario.strUsuario = string.Empty;
                oFuncionario.intCodigo = 0;
            }
            else if (cbxCategoria.Text.ToUpper() == "USUARIO")
            {
                oFuncionario.strUsuario = txtPesquisa.Text;
                oFuncionario.strCPF = string.Empty;
                oFuncionario.strNome = string.Empty;
                oFuncionario.intCodigo = 0;
            }
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                int intPesq = cbxTipo.SelectedIndex;
                grdFuncionarios.DataSource = oFuncionario.Consultar(intPesq);

                grdFuncionarios.Columns[0].Visible = false;
                grdFuncionarios.Columns[9].Visible = false;
                grdFuncionarios.Columns[10].Visible = false;
                grdFuncionarios.Columns[14].Visible = false;
                grdFuncionarios.Columns[15].Visible = false;
                grdFuncionarios.Columns[12].Visible = false;
                
                grdFuncionarios.Columns[1].Width = 100;
                grdFuncionarios.Columns[2].Width = 200;
                grdFuncionarios.Columns[3].Width = 200;
                grdFuncionarios.Columns[4].Width = 100;
                grdFuncionarios.Columns[5].Width = 200;
                grdFuncionarios.Columns[6].Width = 200;
                grdFuncionarios.Columns[7].Width = 100;
                grdFuncionarios.Columns[8].Width = 100;
                grdFuncionarios.Columns[11].Width = 200;
                grdFuncionarios.Columns[13].Width = 50;
                grdFuncionarios.Columns[16].Width = 200;
                
                grdFuncionarios.Columns[1].HeaderText = "CPF";
                grdFuncionarios.Columns[2].HeaderText = "NOME";
                grdFuncionarios.Columns[3].HeaderText = "ENDEREÇO";
                grdFuncionarios.Columns[4].HeaderText = "NUMERO";
                grdFuncionarios.Columns[5].HeaderText = "COMPLEMENTO";
                grdFuncionarios.Columns[6].HeaderText = "BAIRRO";
                grdFuncionarios.Columns[7].HeaderText = "CEP";
                grdFuncionarios.Columns[8].HeaderText = "TELEFONE";
                grdFuncionarios.Columns[11].HeaderText = "USUARIO";
                grdFuncionarios.Columns[13].HeaderText = "ATIVO";
                grdFuncionarios.Columns[16].HeaderText = "FUNÇÃO";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Burger Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void grdFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grdFuncionarios.SelectedCells.Count != 0)
            {
                frmCFuncionarios ofrmCFuncionario = new frmCFuncionarios();

                if (grdFuncionarios.SelectedCells[13].Value == null)
                {
                    if (Convert.ToBoolean(grdFuncionarios.SelectedCells[13].Value))
                    {
                        ofrmCFuncionario.rdbAtivo.Checked = true;
                    }
                    else
                    {
                        ofrmCFuncionario.rdbInativo.Checked = true;
                    }
                }
                    
                oFuncionario.intCodigo = Convert.ToInt32(grdFuncionarios.SelectedCells[0].Value);
                ofrmCFuncionario.txtNome.Text = grdFuncionarios.SelectedCells[2].Value.ToString();
                ofrmCFuncionario.txtCPF.Text = grdFuncionarios.SelectedCells[1].Value.ToString();
                ofrmCFuncionario.txtCEP.Text = grdFuncionarios.SelectedCells[7].Value.ToString();
                ofrmCFuncionario.txtTelefone.Text = grdFuncionarios.SelectedCells[8].Value.ToString();
                ofrmCFuncionario.txtBairro.Text = grdFuncionarios.SelectedCells[6].Value.ToString();
                ofrmCFuncionario.txtEndereco.Text = grdFuncionarios.SelectedCells[3].Value.ToString();
                ofrmCFuncionario.txtNumero.Text = grdFuncionarios.SelectedCells[4].Value.ToString();
                ofrmCFuncionario.txtComplemento.Text = grdFuncionarios.SelectedCells[5].Value.ToString();
                ofrmCFuncionario.cbxFuncao.Tag = grdFuncionarios.SelectedCells[16].Value.ToString();
                
                oFuncionario.Consultar(0);

                if (oFuncionario.intFuncao == 1 || oFuncionario.intFuncao == 4)
                {
                    ofrmCFuncionario.txtUsuario.Text = grdFuncionarios.SelectedCells[11].Value.ToString();
                    ofrmCFuncionario.txtSenha.Text = grdFuncionarios.SelectedCells[12].Value.ToString();
                    ofrmCFuncionario.txtConfirmacao.Text = grdFuncionarios.SelectedCells[12].Value.ToString();
                }
               

                ofrmCFuncionario.txtCodigo.Text = oFuncionario.intCodigo.ToString();

                ofrmCFuncionario.ShowDialog();
                oFuncionario = null;
                oFuncionario = new Funcionario();
                CarregarGrid();
            }
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (("NOME|USUARIO").IndexOf(cbxCategoria.Text) != -1)
            {
                cbxTipo.SelectedIndex = 0;
                cbxTipo.Enabled = true;

            }
            else if (("CPF").IndexOf(cbxCategoria.Text) != -1)
            {
                cbxTipo.SelectedIndex = 1;
                cbxTipo.Enabled = false;

            }

            oFuncionario = null;
            oFuncionario = new Funcionario();

            txtPesquisa.Text = string.Empty;
            CarregarGrid();
        }

        private void grdFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            btnAlterar.PerformClick();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
