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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }
        Cliente oCliente = new Cliente();
        private void frmEditarCliente_Load(object sender, EventArgs e)
        {

            PreencherCombo();
            if (cbxTelCel.Tag != null)
            {
                cbxTelCel.SelectedIndex = cbxTelCel.FindStringExact(cbxTelCel.Tag.ToString());
            }
        }

        private void PreencherCombo()
        {
            try
            {
                cbxTelCel.DataSource = Global.ConsultarTelCel();
                cbxTelCel.DisplayMember = "tcl_nome";
                cbxTelCel.ValueMember = "tcl_codigo";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void rbtnPJ_CheckedChanged(object sender, EventArgs e)
        {
            lblCPF.Text = "CNPJ";
            lblNome.Text = "Nome Fantasia";
            tbxNome.Size = new Size(280, 20);
            tbxNome.Location = new Point(205, 26);
            mtbxCPF.Mask = "00.000.000/0000-00";
        }

        private void rbtnPF_CheckedChanged(object sender, EventArgs e)
        {
            lblCPF.Text = "CPF";
            lblNome.Text = "Nome";
            tbxNome.Size = new Size(323, 20);
            tbxNome.Location = new Point(162, 26);
            mtbxCPF.Mask = "000.000.000-00";
        }

        private void mtbxCPF_Leave(object sender, EventArgs e)
        {
            if (rbtnPF.Checked == true)
            {
                if (mtbxCPF.Mask == string.Empty & mtbxCPF.Text.Length == 11)
                    mtbxCPF.Mask = "000.000.000-00";
                else if (mtbxCPF.Mask != string.Empty)
                    mtbxCPF.Mask = "";
            }
            else if (rbtnPJ.Checked == true)
            {
                if (mtbxCPF.Mask == string.Empty & mtbxCPF.Text.Length == 14)
                    mtbxCPF.Mask = "00.000.000/0000-00";
                else if (mtbxCPF.Mask != string.Empty)
                    mtbxCPF.Mask = "";
            }
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            /*
            if (!tbxEmail.Text.Contains("@") || !tbxEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Email Invalido","Studio Mink'a Erro: Email Invalido!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                tbxEmail.Focus();
            }
            */
        }


        private void BuscarCEP()
        {
            string url = String.Format("http://apps.widenet.com.br/busca-cep/api/cep/{0}.xml", tbxCEP.Text);
            webBrowser1.Navigate(url);
        }
        private void tbxCEP_Leave(object sender, EventArgs e)
        {
            BuscarCEP();
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

                tbxEndereco.Text = endereco;
                tbxBairro.Text = bairro;
                tbxCidade.Text = cidade;
                tbxUF.Text = uf;
            }
            else
            {
                MessageBox.Show("CEP NÃO ENCONTRADO.");
            }
        }

        private string ValidarPreenchimento()
        {
            string strMensagem = string.Empty;

            
            if (tbxCodigo.Text == string.Empty || tbxCodigo.Text == "0")
            {
                if (rbtnPF.Checked)
                {
                    if (mtbxCPF.Text == string.Empty)
                    {
                        strMensagem = "Campo CPF em Branco. \n";
                    }
                    else
                    {
                        int intAux = oCliente.intCodigo;
                        oCliente.intCodigo = 0;
                        oCliente.strNome = string.Empty;
                        oCliente.strCPF = mtbxCPF.Text;
                        oCliente.Consultar();
                        if (oCliente.intCodigo != 0 && oCliente.intCodigo != intAux)
                        {
                            strMensagem += "CPF indisponível.\n";
                        }
                        oCliente.intCodigo = intAux;
                    }
                }
                if (rbtnPJ.Checked)
                {
                    if (mtbxCPF.Text == string.Empty)
                    {
                        strMensagem = "Campo CNPJ em Branco. \n";
                    }
                    else
                    {
                        int intAux = oCliente.intCodigo;
                        oCliente.intCodigo = 0;
                        oCliente.strNome = string.Empty;
                        oCliente.strCNPJ = mtbxCPF.Text;
                        oCliente.Consultar();
                        if (oCliente.intCodigo != 0 && oCliente.intCodigo != intAux)
                        {
                            strMensagem += "CNPJ indisponível.\n";
                        }
                        oCliente.intCodigo = intAux;
                    }
                }


                if (tbxNome.Text == string.Empty)
                {
                    strMensagem += "Campo Nome em Branco. \n";
                }
                if (mtbxTelefone.Text == string.Empty)
                {
                    strMensagem += "Campo Telefone em Branco. \n";
                }
                return strMensagem;
            }
            else
            {
                if (rbtnPF.Checked)
                {
                    if (mtbxCPF.Text == string.Empty)
                    {
                        strMensagem = "Campo CPF em Branco. \n";
                    }
                }
                if (rbtnPJ.Checked)
                {
                    if (mtbxCPF.Text == string.Empty)
                    {
                        strMensagem = "Campo CNPJ em Branco. \n";
                    }
                }

                if (tbxNome.Text == string.Empty)
                {
                    strMensagem += "Campo Nome em Branco. \n";
                }
                if (mtbxTelefone.Text == string.Empty)
                {
                    strMensagem += "Campo Telefone em Branco. \n";
                }
                return strMensagem;
            }
        }

        private void LimparCampos()
        {
            mtbxCPF.Text = string.Empty;
            tbxNome.Text = string.Empty;
            tbxEndereco.Text = string.Empty;
            tbxNumero.Text = string.Empty;
            tbxComplemento.Text = string.Empty;
            tbxBairro.Text = string.Empty;
            tbxCidade.Text = string.Empty;
            tbxCEP.Text = string.Empty;
            tbxUF.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            mtbxTelefone.Text = string.Empty;
            mtbxTelefone2.Text = string.Empty;
            cbxTelCel.SelectedIndex = 0;

            oCliente = null;
            oCliente = new Cliente();
        }

        private void PreencherForm()
        {
            tbxCodigo.Text = oCliente.intCodigo.ToString();

            if (rbtnPF.Checked == true)
            {
                mtbxCPF.Text = oCliente.strCPF;
            }
            else if (rbtnPJ.Checked == true)
            {
                mtbxCPF.Text = oCliente.strCNPJ;
            }
            tbxNome.Text = oCliente.strNome;
            tbxEndereco.Text = oCliente.strEndereco;
            tbxNumero.Text = oCliente.strNumero;
            tbxComplemento.Text = oCliente.strComplemento;
            tbxBairro.Text = oCliente.strBairro;
            tbxCidade.Text = oCliente.strCidade;
            tbxCEP.Text = oCliente.strCEP;
            tbxUF.Text = oCliente.strEstado;
            tbxEmail.Text = oCliente.strEmail;
            mtbxTelefone.Text = oCliente.strTelefone;
            mtbxTelefone2.Text = oCliente.strTelefone2;
        }

        private void PreencherClasse()
        {
            if (tbxCodigo.Text == string.Empty)
            {
                oCliente.intCodigo = 0;
            }
            else
            {
                oCliente.intCodigo = Convert.ToInt32(tbxCodigo.Text);
            }
            oCliente.strNome = tbxNome.Text;
            oCliente.strEndereco = tbxEndereco.Text;
            oCliente.strNumero = tbxNumero.Text;
            oCliente.strComplemento = tbxComplemento.Text;
            oCliente.strBairro = tbxBairro.Text;
            oCliente.strCidade = tbxCidade.Text;
            oCliente.strCEP = tbxCEP.Text;
            oCliente.strEstado = tbxUF.Text;
            oCliente.strEmail = tbxEmail.Text;

            if (mtbxTelefone.Text == "(  )    -")
            {
                mtbxTelefone.Mask = "";
            }
            else if (mtbxTelefone.Text == "(  ) ,    -")
            {
                mtbxTelefone.Mask = "";
            }
            if (mtbxTelefone2.Text == "(  )    -")
            {
                mtbxTelefone2.Mask = "";
            }
            else if (mtbxTelefone2.Text == "(  ) ,    -")
            {
                mtbxTelefone2.Mask = "";
            }

            oCliente.strTelefone = mtbxTelefone.Text;
            oCliente.strTelefone2 = mtbxTelefone2.Text;

            if (cbxTelCel.SelectedIndex == 1)
            {
                oCliente.strTelCel = "tt";
            }
            else if (cbxTelCel.SelectedIndex == 2)
            {
                oCliente.strTelCel = "tc";
            }
            else if(cbxTelCel.SelectedIndex == 3)
            {
                oCliente.strTelCel = "cc";
            }
            else
            {
                oCliente.strTelCel = "--";
            }

            if (rbtnPF.Checked)
            {
                oCliente.blnPF = rbtnPF.Checked;
                oCliente.strCPF = mtbxCPF.Text;
            }
            else if (rbtnPJ.Checked)
            {
                oCliente.blnPF = !rbtnPJ.Checked;
                oCliente.strCNPJ = mtbxCPF.Text;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsgErro = ValidarPreenchimento();

                if (strMsgErro != string.Empty)
                {
                    MessageBox.Show(strMsgErro, "Studio Mink'a - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxNome.Focus();
                }
                else
                {
                    PreencherClasse();
                    oCliente.Gravar();

                    MessageBox.Show("Cliente Cadastrado/Alterado com Sucesso.", "Studio Mink'a", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Studio Mink'a - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mtbxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbxTelefone2_Leave(object sender, EventArgs e)
        {
            if (cbxTelCel.SelectedIndex != 0 && (mtbxTelefone2.Text == "(__)____-____" || mtbxTelefone2.Text == "(__)_.____-____"))
            {
                mtbxTelefone2.Enabled = false;
                mtbxTelefone2.Mask = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbxTelefone_Leave(object sender, EventArgs e)
        {
            if (cbxTelCel.SelectedIndex != 0 && (mtbxTelefone.Text == "(__)____-____" || mtbxTelefone.Text == "(__)_.____-____"))
            {
                mtbxTelefone.Enabled = false;
                mtbxTelefone.Mask = "";
            }
        }

        private void mtbxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtbxCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }

        }

        private void cbxTelCel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTelCel.SelectedIndex == 0)
            {
                mtbxTelefone.Mask = "(00)0000-0000";
                mtbxTelefone2.Mask = "(00)0000-0000";
            }
            else if (cbxTelCel.SelectedIndex == 1)
            {
                mtbxTelefone.Mask = "(00)0000-0000";
                mtbxTelefone2.Mask = "(00)0.0000-0000";
            }
            else if (cbxTelCel.SelectedIndex == 2)
            {
                mtbxTelefone.Mask = "(00)0.0000-0000";
                mtbxTelefone2.Mask = "(00)0.0000-0000";
            }
        }
    }
}
