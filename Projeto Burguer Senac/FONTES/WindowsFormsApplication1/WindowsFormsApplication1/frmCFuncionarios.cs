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
    public partial class frmCFuncionarios : Form
    {
        public frmCFuncionarios()
        {
            InitializeComponent();
        }
        Funcionario oFuncionario = new Funcionario();
        bool blnLoad = false;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string endereco = string.Empty;
            string bairro = string.Empty;
            string retorno = webBrowser1.Document.Body.InnerText;

            if (retorno.IndexOf("CEP não encontrado") == -1)
            {
                bairro = retorno.Substring(retorno.IndexOf("<district>") + 10);
                bairro = bairro.Substring(0, bairro.IndexOf("</district>"));
                endereco = retorno.Substring(retorno.IndexOf("<address>") + 9);
                endereco = endereco.Substring(0, endereco.IndexOf("</address>"));

                txtEndereco.Text = endereco;
                txtBairro.Text = bairro;

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


        private void PreencherForm()
        {
            txtCodigo.Text = oFuncionario.intCodigo.ToString();
            txtUsuario.Text = oFuncionario.strUsuario;
            txtNome.Text = oFuncionario.strNome;
            txtSenha.Text = oFuncionario.strSenha;
            txtConfirmacao.Text = oFuncionario.strSenha;
            rdbAtivo.Checked = oFuncionario.blnAtivo;
            rdbInativo.Checked = !oFuncionario.blnAtivo;

            txtCPF.Text = oFuncionario.strCPF;
            txtTelefone.Text = oFuncionario.strTelefone;
            txtCEP.Text = oFuncionario.strCEP;
            txtBairro.Text = oFuncionario.strBairro;
            txtEndereco.Text = oFuncionario.strEndereco;
            txtNumero.Text = oFuncionario.strNumero;
            txtComplemento.Text = oFuncionario.strComplemento;
            cbxFuncao.SelectedValue = oFuncionario.intFuncao;

        }

        private void PreencherClasse()
        {
            if (txtCodigo.Text == string.Empty)
            {
                oFuncionario.intCodigo = 0;
            }
            else
            {
                oFuncionario.intCodigo = Convert.ToInt32(txtCodigo.Text);
            }
            oFuncionario.strUsuario = txtUsuario.Text;
            oFuncionario.strNome = txtNome.Text;
            oFuncionario.strSenha = txtSenha.Text;
            oFuncionario.blnAtivo = rdbAtivo.Checked;

            oFuncionario.strCPF = txtCPF.Text;
            oFuncionario.strTelefone = txtTelefone.Text;
            oFuncionario.strCEP = txtCEP.Text;
            oFuncionario.strBairro = txtBairro.Text;
            oFuncionario.strEndereco = txtEndereco.Text;
            oFuncionario.strNumero = txtNumero.Text;
            oFuncionario.strComplemento = txtComplemento.Text;
            oFuncionario.intFuncao = Convert.ToInt32(cbxFuncao.SelectedValue);
        }

        private void LimparCampos()
        {

            txtUsuario.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmacao.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;


            rdbAtivo.Checked = true;

            oFuncionario = null;

            oFuncionario = new Funcionario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            LimparCampos();
        }



        private string ValidarPreenchimento()
        {

            string strMensagem = string.Empty;


            try
            {
                if (txtCodigo.Text == string.Empty || txtCodigo.Text == "0")
                {
                    if (cbxFuncao.SelectedIndex == 0 || cbxFuncao.SelectedIndex == 3)
                    {
                        if (txtUsuario.Text == string.Empty)
                        {

                            strMensagem = "Usuário em branco.\n";
                        }
                        else
                        {
                            int intAux = oFuncionario.intCodigo;
                            oFuncionario.intCodigo = 0;
                            oFuncionario.strNome = string.Empty;
                            oFuncionario.strUsuario = txtUsuario.Text;
                            oFuncionario.Consultar(0);
                            if (oFuncionario.intCodigo != 0 && oFuncionario.intCodigo != intAux)
                            {
                                strMensagem += "Usuário indisponível.\n";
                            }
                            oFuncionario.intCodigo = intAux;
                        }
                        if (txtSenha.Text == string.Empty)
                        {
                            strMensagem += "Senha em branco.\n";
                        }
                        else if (txtSenha.Text != txtConfirmacao.Text)
                        {
                            strMensagem += "Senha e confirmação não conferem.\n";
                        }
                    }

                    if (txtNome.Text == string.Empty)
                    {
                        strMensagem += "Nome em branco.\n";
                    }

                    if (txtCPF.Text == string.Empty)
                    {
                        strMensagem = "CPF em branco.\n";
                    }
                    else
                    {
                        int intAux = oFuncionario.intCodigo;
                        oFuncionario.intCodigo = 0;
                        oFuncionario.strNome = string.Empty;
                        oFuncionario.strCPF = txtCPF.Text;
                        oFuncionario.strUsuario = string.Empty;
                        oFuncionario.Consultar(0);
                        if (oFuncionario.intCodigo != 0 || oFuncionario.intCodigo != intAux)
                        {
                            strMensagem += "CPF indisponível.\n";

                        }
                        oFuncionario.intCodigo = intAux;
                    }
                    if (txtCEP.Text == string.Empty)
                    {
                        strMensagem += "CEP em branco.\n";
                    }
                    if (txtTelefone.Text == string.Empty)
                    {
                        strMensagem += "Telefone em branco.\n";
                    }
                    if (txtBairro.Text == string.Empty)
                    {
                        strMensagem += "Bairro em branco.\n";
                    }
                    if (txtEndereco.Text == string.Empty)
                    {
                        strMensagem += "Endereço em branco.\n";
                    }
                    if (txtNumero.Text == string.Empty)
                    {
                        strMensagem += "Numero em branco.\n";
                    }
                }
                else
                {
                    if (cbxFuncao.SelectedIndex == 0 || cbxFuncao.SelectedIndex == 3)
                    {
                        if (txtUsuario.Text == string.Empty)
                        {
                            strMensagem = "Usuário em branco.\n";
                        }
                        if (txtSenha.Text == string.Empty)
                        {
                            strMensagem += "Senha em branco.\n";
                        }
                        else if (txtSenha.Text != txtConfirmacao.Text)
                        {
                            strMensagem += "Senha e confirmação não conferem.\n";
                        }
                    }
                    if (txtNome.Text == string.Empty)
                    {
                        strMensagem += "Nome em branco.\n";
                    }

                    if (txtCPF.Text == string.Empty)
                    {
                        strMensagem = "CPF em branco.\n";
                    }
                    if (txtCEP.Text == string.Empty)
                    {
                        strMensagem += "CEP em branco.\n";
                    }
                    if (txtTelefone.Text == string.Empty)
                    {
                        strMensagem += "Telefone em branco.\n";
                    }
                    if (txtBairro.Text == string.Empty)
                    {
                        strMensagem += "Bairro em branco.\n";
                    }
                    if (txtEndereco.Text == string.Empty)
                    {
                        strMensagem += "Endereço em branco.\n";
                    }
                    if (txtNumero.Text == string.Empty)
                    {
                        strMensagem += "Numero em branco.\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Burger Manager",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return strMensagem;
        
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherCombo()
        {
            try
            {
                cbxFuncao.DataSource = Global.ConsultarFuncao();
                cbxFuncao.DisplayMember = "fun_funcoes";
                cbxFuncao.ValueMember = "fun_codigo";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmCFuncionarios_Load(object sender, EventArgs e)
        {
            PreencherCombo();
            blnLoad = true;


            if (cbxFuncao.Tag != null)
            {
                cbxFuncao.SelectedIndex = cbxFuncao.FindStringExact(cbxFuncao.Tag.ToString());
            }
            
        }

        private void txtConfirmacao_Leave(object sender, EventArgs e)
        {

        }

        private void txtConfirmacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsgErro = ValidarPreenchimento();

                if (strMsgErro != string.Empty)
                {
                    MessageBox.Show(strMsgErro, "Burger Manager - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Focus();
                }
                else
                {
                    PreencherClasse();
                    oFuncionario.Gravar();

                    MessageBox.Show("Funcionario Cadastrado/Alterado com Sucesso.", "Burger Manager - NOVO CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    this.Close();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Burger Manager - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!blnLoad)
            {
                return;
            }
            if (Convert.ToInt32(cbxFuncao.SelectedValue) == 2 || Convert.ToInt32(cbxFuncao.SelectedValue) == 3)
            {
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtConfirmacao.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
                txtConfirmacao.Enabled = true;
            }




        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {


        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
