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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DateTime dttLogin;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Global.strNomeUsuario;
            dttLogin = DateTime.Now;
            timer1.Enabled = true;
        }

        private void AbrirForm(Form pform)
        {
            bool blnExiste = false;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == pform.Name)
                {
                    blnExiste = true;
                    break;
                }
            }
            if (!blnExiste)
            {
                pform.MdiParent = this;
                pform.Show();
            }
        }

        private void tstFuncionarios_Click(object sender, EventArgs e)
        {
            frmPFuncionario ofrmPFuncionario = new frmPFuncionario();
            AbrirForm(ofrmPFuncionario);
        }

        private void tstNvPedido_Click(object sender, EventArgs e)
        {
            frmDelivery ofrmDelivery = new frmDelivery();
            AbrirForm(ofrmDelivery);
        }

        private void tstProdutos_Click(object sender, EventArgs e)
        {
            frmPProduto ofrmPProduto = new frmPProduto();
            AbrirForm(ofrmPProduto);
        }

        private void tstCliente_Click(object sender, EventArgs e)
        {
            frmPCliente ofrmPCliente = new frmPCliente();
            AbrirForm(ofrmPCliente);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Burger Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            frmSobre ofrmSobre = new frmSobre();
            AbrirForm(ofrmSobre);
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
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

        private void statusstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mstDelivery_Click(object sender, EventArgs e)
        {

        }

        private void tstAndamento_Click(object sender, EventArgs e)
        {
            frmAndamento ofrmAndamento = new frmAndamento();
            AbrirForm(ofrmAndamento);
        }

        private void bairroVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteCompraXMotoboyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mstRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPFuncionario ofrmPF = new frmPFuncionario();
            AbrirForm(ofrmPF);
        }

        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                tstFuncionarios_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                tstProdutos_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                tstCliente_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                tstNvPedido_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                tstAndamento_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F12)
            {
                sairToolStripMenuItem_Click(sender, e);
            }

           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPProduto ofrmPP = new frmPProduto();
            AbrirForm(ofrmPP);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmPCliente ofrmPC = new frmPCliente();
            AbrirForm(ofrmPC);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmDelivery ofrmD = new frmDelivery();
            AbrirForm(ofrmD);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmAndamento ofrmA = new frmAndamento();
            AbrirForm(ofrmA);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmSobre ofrmS = new frmSobre();
            AbrirForm(ofrmS);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tstSobre_Click(object sender, EventArgs e)
        {
            frmSobre ofrmS = new frmSobre();
            AbrirForm(ofrmS);
        }
        
    }
}
