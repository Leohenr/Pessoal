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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DateTime dttLogin;
        private void tsCadastros_Click(object sender, EventArgs e)
        {
            frmCadastros ofrmCadastros = new frmCadastros();
            ofrmCadastros.ShowDialog();
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tsCadastros_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                tsLancamentos_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                tsContas_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                tsRelatorios_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F12)
            {
                sairToolStripMenuItem_Click(sender, e);
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsLancamentos_Click(object sender, EventArgs e)
        {

        }

        private void tsContas_Click(object sender, EventArgs e)
        {

        }

        private void tsRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Global.strNomeUsuario;
            dttLogin = DateTime.Now;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = DateTime.Now.Subtract(dttLogin);
            lblDuracao.Text = String.Format("Duração: {0}:{1}:{2}", ts.Hours.ToString("00"), ts.Minutes.ToString("00"), ts.Seconds.ToString("00"));

        }
    }
}
