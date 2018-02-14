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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Funcionario oFuncinario = new Funcionario();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                oFuncinario.strUsuario = txtUsuario.Text;

                if (oFuncinario.AutenticarUsuario())
                {
                    if (txtSenha.Text == oFuncinario.strSenha)
                    {
                        if (oFuncinario.blnAtivo)
                        {
                            MessageBox.Show("Bem-Vindo " + oFuncinario.strNome, "Burger Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Global.intCodigoUsuario = oFuncinario.intCodigo;
                            Global.strNomeUsuario = oFuncinario.strNome;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário Inativo", "Burger Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta. Tente Novamente.", "Burger Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Usuário Invalido. Tente Novamente.", "Burger Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO -->" + ex.Message, "Burger Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
