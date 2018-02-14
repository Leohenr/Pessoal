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
    public partial class frmCCliente : Form
    {
        public frmCCliente()
        {
            InitializeComponent();
        }

        Cliente oCliente = new Cliente();

        private string ValidarPreenchimento()
        {
            string strMensagem = string.Empty;


            if (txtCodigo.Text == string.Empty || txtCodigo.Text == "0")
            {
                if (rdbPF.Checked)
                {
                    if (txtCPF.Text == string.Empty)
                    {
                        strMensagem = "Campo CPF em Branco. \n";
                    }
                    else
                    {
                        int intAux = oCliente.intCodigo;
                        oCliente.intCodigo = 0;
                        oCliente.strNome = string.Empty;
                        oCliente.strCPF = txtCPF.Text;
                        oCliente.Consultar(1);
                        if (oCliente.intCodigo != 0 && oCliente.intCodigo != intAux)
                        {
                            strMensagem += "CPF indisponível.\n";

                        }
                        oCliente.intCodigo = intAux;
                    }
                }
                if (rdbPJ.Checked)
                {
                    if (txtCNPJ.Text == string.Empty)
                    {
                        strMensagem = "Campo CNPJ em Branco. \n";
                    }
                    else
                    {
                        int intAux = oCliente.intCodigo;
                        oCliente.intCodigo = 0;
                        oCliente.strNome = string.Empty;
                        oCliente.strCNPJ = txtCNPJ.Text;
                        oCliente.Consultar(1);
                        if (oCliente.intCodigo != 0 && oCliente.intCodigo != intAux)
                        {
                            strMensagem += "CNPJ indisponível.\n";

                        }
                        oCliente.intCodigo = intAux;
                    }
                }


                if (txtNome.Text == string.Empty)
                {
                    strMensagem += "Campo Nome em Branco. \n";
                }
                if (txtEndereco.Text == string.Empty)
                {
                    strMensagem += "Campo Endereço em Branco. \n";
                }
                if (txtNumero.Text == string.Empty)
                {
                    strMensagem += "Campo Numero em Branco. \n";
                }
                if (txtBairro.Text == string.Empty)
                {
                    strMensagem += "Campo Bairro em Branco. \n";
                }
                if (txtCidade.Text == string.Empty)
                {
                    strMensagem += "Campo Cidade em Branco. \n";
                }
                if (txtCEP.Text == string.Empty)
                {
                    strMensagem += "Campo CEP em Branco. \n";
                }
                if (txtUF.Text == string.Empty)
                {
                    strMensagem += "Campo Estado em Branco. \n";
                }
                if (lstTelefones.Items.Count == 0)
                {
                    strMensagem += "Nenhum Telefone Informado. \n";
                }
                return strMensagem;
            }
            else
            {
                if (rdbPF.Checked)
                {
                    if (txtCPF.Text == string.Empty)
                    {
                        strMensagem = "Campo CPF em Branco. \n";
                    }
                }
                if (rdbPJ.Checked)
                {
                    if (txtCNPJ.Text == string.Empty)
                    {
                        strMensagem = "Campo CNPJ em Branco. \n";
                    }
                }

                if (txtNome.Text == string.Empty)
                {
                    strMensagem += "Campo Nome em Branco. \n";
                }
                if (txtEndereco.Text == string.Empty)
                {
                    strMensagem += "Campo Endereço em Branco. \n";
                }
                if (txtNumero.Text == string.Empty)
                {
                    strMensagem += "Campo Numero em Branco. \n";
                }
                if (txtBairro.Text == string.Empty)
                {
                    strMensagem += "Campo Bairro em Branco. \n";
                }
                if (txtCidade.Text == string.Empty)
                {
                    strMensagem += "Campo Cidade em Branco. \n";
                }
                if (txtCEP.Text == string.Empty)
                {
                    strMensagem += "Campo CEP em Branco. \n";
                }
                if (txtUF.Text == string.Empty)
                {
                    strMensagem += "Campo Estado em Branco. \n";
                }
                if (lstTelefones.Items.Count == 0)
                {
                    strMensagem += "Nenhum Telefone Informado. \n";
                }
                return strMensagem;
            }
        }


        private void LimparCampos()
        {
            txtCPF.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            lstTelefones.Items.Clear();

            oCliente = null;
            oCliente = new Cliente();
        }

        private void PreencherForm()
        {
            txtCodigo.Text = oCliente.intCodigo.ToString();
            txtCPF.Text = oCliente.strCPF;
            txtCNPJ.Text = oCliente.strCNPJ;
            txtNome.Text = oCliente.strNome;
            txtEndereco.Text = oCliente.strEndereco;
            txtNumero.Text = oCliente.strNumero;
            txtComplemento.Text = oCliente.strComplemento;
            txtBairro.Text = oCliente.strBairro;
            txtCidade.Text = oCliente.strCidade;
            txtCEP.Text = oCliente.strCEP;
            txtUF.Text = oCliente.strEstado;
            foreach (string tel in oCliente.strTelefones)
            {
                lstTelefones.Items.Add(tel);
            }
        }

        private void PreencherClasse()
        {
            if (txtCodigo.Text == string.Empty)
            {
                oCliente.intCodigo = 0;
            }
            else
            {
                oCliente.intCodigo = Convert.ToInt32(txtCodigo.Text);
            }
            oCliente.strCPF = txtCPF.Text;
            oCliente.strCNPJ = txtCNPJ.Text;
            oCliente.strNome = txtNome.Text;
            oCliente.strEndereco = txtEndereco.Text;
            oCliente.strNumero = txtNumero.Text;
            oCliente.strComplemento = txtComplemento.Text;
            oCliente.strBairro = txtBairro.Text;
            oCliente.strCidade = txtCidade.Text;
            oCliente.strCEP = txtCEP.Text;
            oCliente.strEstado = txtUF.Text;

            oCliente.strTelefones.Clear();
            foreach (string tel in lstTelefones.Items)
            {
                oCliente.strTelefones.Add(tel);
            }

            if (rdbPF.Checked)
            {
                oCliente.blnPF = rdbPF.Checked;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string endereco = string.Empty;
            string bairro = string.Empty;
            string cidade = string.Empty;
            string uf = string.Empty;
            string retorno = webBrowser1.Document.Body.InnerText;

            if (retorno.IndexOf("CEP não encontrado") == -1)
            {
                uf = retorno.Substring(retorno.IndexOf("<state>") + 7, 2);
                cidade = retorno.Substring(retorno.IndexOf("<city>") + 6);
                cidade = cidade.Substring(0, cidade.IndexOf("</city>"));
                bairro = retorno.Substring(retorno.IndexOf("<district>") + 10);
                bairro = bairro.Substring(0, bairro.IndexOf("</district>"));
                endereco = retorno.Substring(retorno.IndexOf("<address>") + 9);
                endereco = endereco.Substring(0, endereco.IndexOf("</address>"));

                txtEndereco.Text = endereco;
                txtBairro.Text = bairro;
                txtCidade.Text = cidade;
                txtUF.Text = uf;
            }
            else
            {
                MessageBox.Show("CEP NÃO ENCONTRADO.");
            }
        }
        private void BuscarCEP()
        {
            string url = String.Format("http://apps.widenet.com.br/busca-cep/api/cep/{0}.xml", txtCEP.Text);
            webBrowser1.Navigate(url);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string strMsgErro = ValidarPreenchimento();

                if (strMsgErro != string.Empty)
                {
                    MessageBox.Show(strMsgErro, "Burger Manager - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Focus();
                }
                else
                {
                    PreencherClasse();
                    oCliente.Gravar();

                    MessageBox.Show("Cliente Cadastrado/Alterado com Sucesso.", "Burger Manager - NOVO CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    this.Close();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Burger Manager - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text != string.Empty)
            {
                lstTelefones.Items.Add(txtTelefone.Text);
                txtTelefone.Text = string.Empty;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstTelefones.SelectedIndex != -1)
            {
                lstTelefones.Items.RemoveAt(lstTelefones.SelectedIndex);
            }
        }

        private void rdbPF_CheckedChanged(object sender, EventArgs e)
        {
            lblCPF.Text = "CPF";
            txtCNPJ.Visible = false;

        }

        private void rdbPJ_CheckedChanged(object sender, EventArgs e)
        {

            lblCPF.Text = "CNPJ";
            txtCNPJ.Visible = true;

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCCliente_Leave(object sender, EventArgs e)
        {
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {

        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {

        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
