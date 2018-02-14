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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Login oLogin = new Login();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                oLogin.strUsuario = txtUsuario.Text;

                if (oLogin.AutenticarUsuario())
                {
                    if (txtSenha.Text == oLogin.strSenha)
                    {
                        
                            MessageBox.Show("Bem-Vindo " + oLogin.strUsuario, "Studio Mink'a", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Global.intCodigoUsuario = oLogin.intCodigo;
                            Global.strNomeUsuario = oLogin.strUsuario;
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta. Tente Novamente.", "Studio Mink'a", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Usuário Invalido. Tente Novamente.", "Studio Mink'a", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO -->" + ex.Message, "Studio Mink'a", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
