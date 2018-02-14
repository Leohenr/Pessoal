using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Burger_Manager
{
    public partial class frmCProduto : Form
    {
        public frmCProduto()
        {
            InitializeComponent();
        }

        Produto oProduto = new Produto();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ValidarPreenchimento()
        {
            string strMensagem = string.Empty;


            if (txtNome.Text == string.Empty)
            {
                strMensagem += "Campo Produto em Branco. \n";
            }
            else
            {
                int intAux = oProduto.intCodigo;
                oProduto.intCodigo = 0;
                oProduto.strNome = string.Empty;
                oProduto.strNome = txtNome.Text;
                oProduto.Consultar(1);
                if (oProduto.intCodigo != 0 && oProduto.intCodigo != intAux)
                {
                    strMensagem += "Produto ja Cadastrado.\n";

                }
                oProduto.intCodigo = intAux;
            }
            if (txtVenda.Text == string.Empty)
            {
                strMensagem += "Campo Preço de Venda em Branco. \n";
            }
            if (cbxCategoria.Text == string.Empty)
            {
                strMensagem += "Campo Categoria em Branco. \n";
            }
            return strMensagem;
        }

        private void LimparCampos()
        {
            txtVenda.Text = string.Empty;
            txtNome.Text = string.Empty;
            cbxCategoria.Text = string.Empty;

            oProduto = null;
            oProduto = new Produto();
        }

        private void PreencherForm()
        {
            txtCodigo.Text = oProduto.intCodigo.ToString();
            txtVenda.Text = oProduto.strPreco.ToString();
            txtNome.Text = oProduto.strNome;
            cbxCategoria.Text = oProduto.strCategoria;
        }

        private void PreencherClasse()
        {
            if (txtCodigo.Text == string.Empty)
            {
                oProduto.intCodigo = 0;
            }
            else
            {
                oProduto.intCodigo = Convert.ToInt32(txtCodigo.Text);
            }
            oProduto.strPreco = txtVenda.Text;
            oProduto.strNome = txtNome.Text;
            oProduto.intCatCodigo = Convert.ToInt32(cbxCategoria.SelectedValue);
        }
        
        private void PreencherCombo()
        {
            try
            {
                cbxCategoria.DataSource = Global.ConsultarCategoria();
                cbxCategoria.DisplayMember = "cat_categoria";
                cbxCategoria.ValueMember = "cat_codigo";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void frmCProduto_Load(object sender, EventArgs e)
        {
            PreencherCombo();
            if (cbxCategoria.Tag != null)
            {
                cbxCategoria.SelectedIndex = cbxCategoria.FindStringExact(cbxCategoria.Tag.ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                PreencherClasse();
                string strMsgErro = ValidarPreenchimento();

                if (strMsgErro != string.Empty)
                {
                    MessageBox.Show(strMsgErro, "Burger Manager - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Focus();
                }
                else
                {
                    PreencherClasse();
                    oProduto.Gravar();

                    MessageBox.Show("Produto Cadastrado/Alterado com Sucesso.", "Burger Manager - NOVO CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    this.Close();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Burger Manager - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.Tag == null)
            {
                if (cbxCategoria.SelectedIndex == 0)
                {
                    txtNome.Text = "Pão: ";
                }
                else if (cbxCategoria.SelectedIndex == 1)
                {
                    txtNome.Text = "Burger: ";
                }
                else if (cbxCategoria.SelectedIndex == 7)
                {
                    txtNome.Text = "Ponto: ";
                }
                else if (cbxCategoria.SelectedIndex == 2)
                {
                    txtNome.Text = "Queijo: ";
                }
                else if (cbxCategoria.SelectedIndex == 3)
                {
                    txtNome.Text = "Ing: ";
                }
                else if (cbxCategoria.SelectedIndex == 4)
                {
                    txtNome.Text = "Molho: ";
                }
                else if (cbxCategoria.SelectedIndex == 5)
                {
                    txtNome.Text = "Acomp: ";
                }
                else if (cbxCategoria.SelectedIndex == 6)
                {
                    txtNome.Text = "Bebida: ";
                }
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVenda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVenda_Leave(object sender, EventArgs e)
        {
            txtVenda.Text = txtVenda.Text.Replace((","), ("."));
        }
    }
}
