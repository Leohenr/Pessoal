using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool blnQueijo = false;
        bool blnMolhos = false;
        bool blnIngred1 = false;
        bool blnIngred2 = false;
        bool blnIngred3 = false;
        bool blnIngred4 = false;
        string strValor = "0,00";

        private void btnPTrad_Click(object sender, EventArgs e)
        {
            if (lblPedido.Text == string.Empty)
            {
                lblPedido.Text += "Pão Tradicional \n";
                lbxPedido.Text += "Pão Tradicional \n";
                lblValorPedido.Text += "\n 2,00 \n";
                gbxPao.Enabled = false;
                gbxBurguer.Enabled = true;
                gbxPao.BackColor = SystemColors.Control;
                gbxBurguer.BackColor = Color.OliveDrab;
            }
            else
            {
                lblPedido.Text += "\n Pão Tradicional \n";
                lblValorPedido.Text += "\n 2,00 \n";
                gbxPao.Enabled = false;
                gbxBurguer.Enabled = true;
                gbxPao.BackColor = SystemColors.Control;
                gbxBurguer.BackColor = Color.OliveDrab;
            }
        }

        private void btnPGergelim_Click(object sender, EventArgs e)
        {
            if (lblPedido.Text == string.Empty)
            {
                lblPedido.Text += "Pão Tradicional com Gergelim \n";
                gbxPao.Enabled = false;
                gbxBurguer.Enabled = true;
                gbxPao.BackColor = SystemColors.Control;
                gbxBurguer.BackColor = Color.OliveDrab;
            }
            else
            {
                lblPedido.Text += "\n Pão Tradicional com Gergelim \n";
                gbxPao.Enabled = false;
                gbxBurguer.Enabled = true;
                gbxPao.BackColor = SystemColors.Control;
                gbxBurguer.BackColor = Color.OliveDrab;
            }
        }

        private void btnAustraliano_Click(object sender, EventArgs e)
        {
            if (lblPedido.Text == string.Empty)
            {
                lblPedido.Text += "Pão Australiano \n";
                gbxPao.Enabled = false;
                gbxBurguer.Enabled = true;
                gbxPao.BackColor = SystemColors.Control;
                gbxBurguer.BackColor = Color.OliveDrab;
            }
            else
            {
                lblPedido.Text += "\n Pão Australiano \n";
                gbxPao.Enabled = false;
                gbxBurguer.Enabled = true;
                gbxPao.BackColor = SystemColors.Control;
                gbxBurguer.BackColor = Color.OliveDrab;
            }
        }

        private void btnTrad_Click(object sender, EventArgs e)
        {
            lblPedido.Text += " + Hamburguer: Tradicional (120g) \n";
            gbxBurguer.Enabled = false;
            gbxPonto.Enabled = true;
            gbxBurguer.BackColor = SystemColors.Control;
            gbxPonto.BackColor = Color.OliveDrab;
            
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            lblPedido.Text += " + Hamburguer: Picanha (150g) \n";
            gbxBurguer.Enabled = false;
            gbxPonto.Enabled = true;
            gbxBurguer.BackColor = SystemColors.Control;
            gbxPonto.BackColor = Color.OliveDrab;
        }

        private void btnFrald_Click(object sender, EventArgs e)
        {
            lblPedido.Text += " + Hamburguer: Fraldinha (200g) \n";
            gbxBurguer.Enabled = false;
            gbxPonto.Enabled = true;
            gbxBurguer.BackColor = SystemColors.Control;
            gbxPonto.BackColor = Color.OliveDrab;
        }

        private void btnFra_Click(object sender, EventArgs e)
        {
            lblPedido.Text += " + Hamburguer: Frango Crispy (120g) \n";
            gbxBurguer.Enabled = false;
            gbxPonto.Enabled = true;
            gbxBurguer.BackColor = SystemColors.Control;
            gbxPonto.BackColor = Color.OliveDrab;
        }

        private void btnVeg_Click(object sender, EventArgs e)
        {
            lblPedido.Text += " + Hamburguer: Vegetariano (120g) \n";
            gbxBurguer.Enabled = false;
            gbxPonto.Enabled = true;
            gbxBurguer.BackColor = SystemColors.Control;
            gbxPonto.BackColor = Color.OliveDrab;
        }

        private void btnMal_Click(object sender, EventArgs e)
        {
            lblPedido.Text += "     + Mal Passado \n";
            gbxPonto.Enabled = false;
            gbxQueijo.Enabled = true;
            gbxPonto.BackColor = SystemColors.Control;
            gbxQueijo.BackColor = Color.OliveDrab;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            lblPedido.Text += "     + Ao Ponto \n";
            gbxPonto.Enabled = false;
            gbxQueijo.Enabled = true;
            gbxPonto.BackColor = SystemColors.Control;
            gbxQueijo.BackColor = Color.OliveDrab;
        }

        private void btnBem_Click(object sender, EventArgs e)
        {
            lblPedido.Text += "     + Bem Passado \n";
            gbxPonto.Enabled = false;
            gbxQueijo.Enabled = true;
            gbxPonto.BackColor = SystemColors.Control;
            gbxQueijo.BackColor = Color.OliveDrab;
        }

        private void rbtSemQ_CheckedChanged(object sender, EventArgs e)
        {
            gbxQueijo.Enabled = false;
            gbxIngredientes.Enabled = true;
            gbxQueijo.BackColor = SystemColors.Control;
            gbxIngredientes.BackColor = Color.OliveDrab;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          if (blnQueijo != true)
            {
                blnQueijo = true;
                lblPedido.Text += " + Queijo Prato \n";
                btnPrato.Enabled = false;
            }
          else
          {
              lblPedido.Text += " + Queijo Prato \n";
              gbxQueijo.Enabled = false;
              gbxIngredientes.Enabled = true;
              gbxQueijo.BackColor = SystemColors.Control;
              gbxIngredientes.BackColor = Color.OliveDrab;
              btnPrato.Enabled = false;
              
          }
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (blnQueijo != true)
            {
                blnQueijo = true;
                lblPedido.Text += " + Queijo Mussarela \n";
                btnMussarela.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Queijo Mussarela \n";
                gbxQueijo.Enabled = false;
                gbxIngredientes.Enabled = true;
                gbxQueijo.BackColor = SystemColors.Control;
                gbxIngredientes.BackColor = Color.OliveDrab;
                btnMussarela.Enabled = false;
            }

                
        }

        private void btnCatupiry_Click(object sender, EventArgs e)
        {
            if (blnQueijo != true)
            {
                blnQueijo = true;
                lblPedido.Text += " + Queijo Catupiry \n";
                btnCatupiry.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Queijo Catupiry \n";
                gbxQueijo.Enabled = false;
                gbxIngredientes.Enabled = true;
                gbxQueijo.BackColor = SystemColors.Control;
                gbxIngredientes.BackColor = Color.OliveDrab;
                btnCatupiry.Enabled = false;
            }
            
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
            if (blnQueijo != true)
            {
                blnQueijo = true;
                lblPedido.Text += " + Queijo Cheddar \n";
                btnCheddar.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Queijo Cheddar \n";
                gbxQueijo.Enabled = false;
                gbxIngredientes.Enabled = true;
                gbxQueijo.BackColor = SystemColors.Control;
                gbxIngredientes.BackColor = Color.OliveDrab;
                btnCheddar.Enabled = false;
            }
            
        }

        private void gbxIngredientes_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {

        }

        private void btnAlface_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Alface \n";
                blnIngred1 = true;
                btnAlface.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Alface \n";
                blnIngred2 = true;
                btnAlface.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Alface \n";
                blnIngred3 = true;
                btnAlface.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Alface \n";
                blnIngred4 = true;
                btnAlface.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Alface \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnAlface.Enabled = false;
            }
            
        }

        private void btnTomate_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Tomate \n";
                blnIngred1 = true;
                btnTomate.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Tomate \n";
                blnIngred2 = true;
                btnTomate.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Tomate \n";
                blnIngred3 = true;
                btnTomate.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Tomate \n";
                blnIngred4 = true;
                btnTomate.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Tomate \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnTomate.Enabled = false;
            }
        }

        private void btnCebola_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Cebola \n";
                blnIngred1 = true;
                btnCebola.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Cebola \n";
                blnIngred2 = true;
                btnCebola.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Cebola \n";
                blnIngred3 = true;
                btnCebola.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Cebola \n";
                blnIngred4 = true;
                btnCebola.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Cebola \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnCebola.Enabled = false;
            }
        }

        private void btnBacon_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred1 = true;
                btnBacon.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred2 = true;
                btnBacon.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred3 = true;
                btnBacon.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred4 = true;
                btnBacon.Enabled = false;
            }
            
            else
            {
                lblPedido.Text += " + Bacon \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnBacon.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbxIngredientes.Enabled = false;
            gbxMolhos.Enabled = true;
            gbxIngredientes.BackColor = SystemColors.Control;
            gbxMolhos.BackColor = Color.OliveDrab;
        }

        private void rbtMolho_CheckedChanged(object sender, EventArgs e)
        {
            gbxMolhos.Enabled = false;
            gbxMolhos.BackColor = SystemColors.Control;
            btnEnviar.BackColor = Color.OliveDrab;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
        }

        private void btnRucula_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Rucula \n";
                blnIngred1 = true;
                btnRucula.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Rucula \n";
                blnIngred2 = true;
                btnRucula.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Rucula \n";
                blnIngred3 = true;
                btnRucula.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Rucula \n";
                blnIngred4 = true;
                btnRucula.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Rucula \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnRucula.Enabled = false;
            }
        }

        private void btnGorgonzola_Click_1(object sender, EventArgs e)
        {
            if (blnQueijo != true)
            {
                blnQueijo = true;
                lblPedido.Text += " + Queijo Gorgonzola \n";
                btnGorgonzola.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Queijo Gorgonzola \n";
                gbxQueijo.Enabled = false;
                gbxIngredientes.Enabled = true;
                gbxQueijo.BackColor = SystemColors.Control;
                gbxIngredientes.BackColor = Color.OliveDrab;
                btnGorgonzola.Enabled = false;
            }
            
        }

        private void btnTomateSeco_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Tomate Seco \n";
                blnIngred1 = true;
                btnTomateSeco.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Tomate Seco \n";
                blnIngred2 = true;
                btnTomateSeco.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Tomate Seco \n";
                blnIngred3 = true;
                btnTomateSeco.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Tomate Seco \n";
                blnIngred4 = true;
                btnTomateSeco.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Tomate Seco \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnTomateSeco.Enabled = false;
            }
        }

        private void lblValor_Click(object sender, EventArgs e)
        {
            lblValor.Text = strValor;
        }

        private void gbxMolhos_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: " + tbxNome.Text + "\n" + "Endereço: " + tbxEnd.Text + "\n" + "Número: " + tbxNumero.Text + "\n" + "Complemento: " + tbxComp.Text + "\n \n" + "Resumo do Pedido: " + "\n" + lblPedido.Text + "\n" + "MotoBoy: " + cbxMoto.Text + "\n \n" + "Valor: " + "\n" + "R$ " + lblTotal.Text);
        }

        private void btnMaionese_Click(object sender, EventArgs e)
        {
            if (blnMolhos != true)
            {
                blnMolhos = true;
                lblPedido.Text += " + Maionese da Casa \n";
                btnMaionese.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Maionese da Casa \n";
                gbxMolhos.Enabled = false;
                gbxMolhos.BackColor = SystemColors.Control;
                btnEnviar.BackColor = Color.OliveDrab;
                btnCancelar.BackColor = Color.Red;
                btnCancelar.ForeColor = Color.White;
                btnMaionese.Enabled = false;
            }
        }

        private void btnBarb_Click(object sender, EventArgs e)
        {
            if (blnMolhos != true)
            {
                blnMolhos = true;
                lblPedido.Text += " + Molho Barbecue \n";
                btnBarb.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Molho Barbecue \n";
                gbxMolhos.Enabled = false;
                gbxMolhos.BackColor = SystemColors.Control;
                btnEnviar.BackColor = Color.OliveDrab;
                btnCancelar.BackColor = Color.Red;
                btnCancelar.ForeColor = Color.White;
                btnBarb.Enabled = false;
            }
        }

        private void btnRose_Click(object sender, EventArgs e)
        {
            if (blnMolhos != true)
            {
                blnMolhos = true;
                lblPedido.Text += " + Molho Rosê \n";
                btnRose.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Molho Rosê \n";
                gbxMolhos.Enabled = false;
                gbxMolhos.BackColor = SystemColors.Control;
                btnEnviar.BackColor = Color.OliveDrab;
                btnCancelar.BackColor = Color.Red;
                btnCancelar.ForeColor = Color.White;
                btnRose.Enabled = false;
            }
        }

        private void btnEspecial_Click(object sender, EventArgs e)
        {
            if (blnMolhos != true)
            {
                blnMolhos = true;
                lblPedido.Text += " + Molho Especial da Casa \n";
                btnEspecial.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Molho Especial da Casa \n";
                gbxMolhos.Enabled = false;
                gbxMolhos.BackColor = SystemColors.Control;
                btnEnviar.BackColor = Color.OliveDrab;
                btnCancelar.BackColor = Color.Red;
                btnCancelar.ForeColor = Color.White;
                btnEspecial.Enabled = false;
            }
        }

        private void btnAgridoce_Click(object sender, EventArgs e)
        {
            if (blnMolhos != true)
            {
                blnMolhos = true;
                lblPedido.Text += " + Molho Agridoce \n";
                btnAgridoce.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Molho Agridoce \n";
                gbxMolhos.Enabled = false;
                gbxMolhos.BackColor = SystemColors.Control;
                btnEnviar.BackColor = Color.OliveDrab;
                btnCancelar.BackColor = Color.Red;
                btnCancelar.ForeColor = Color.White;
                btnAgridoce.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEgg_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Egg \n";
                blnIngred1 = true;
                btnEgg.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Egg \n";
                blnIngred2 = true;
                btnEgg.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Egg \n";
                blnIngred3 = true;
                btnEgg.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Egg \n";
                blnIngred4 = true;
                btnEgg.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Egg \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnEgg.Enabled = false;
            }
        }

        private void btnPicles_Click(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Picles \n";
                blnIngred1 = true;
                btnPicles.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Picles \n";
                blnIngred2 = true;
                btnPicles.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Picles \n";
                blnIngred3 = true;
                btnPicles.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Picles \n";
                blnIngred4 = true;
                btnPicles.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Picles \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnPicles.Enabled = false;
            }
        }

        private void btnBacon_Click_1(object sender, EventArgs e)
        {
            if (blnIngred1 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred1 = true;
                btnBacon.Enabled = false;
            }
            else if (blnIngred2 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred2 = true;
                btnBacon.Enabled = false;
            }
            else if (blnIngred3 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred3 = true;
                btnBacon.Enabled = false;
            }
            else if (blnIngred4 != true)
            {
                lblPedido.Text += " + Bacon \n";
                blnIngred4 = true;
                btnBacon.Enabled = false;
            }
            else
            {
                lblPedido.Text += " + Bacon \n";
                gbxIngredientes.Enabled = false;
                gbxMolhos.Enabled = true;
                gbxIngredientes.BackColor = SystemColors.Control;
                gbxMolhos.BackColor = Color.OliveDrab;
                btnBacon.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            gbxInfoCli.Enabled = false;
            gbxPao.Enabled = true;
            gbxLanche.Enabled = true;
            gbxPao.BackColor = Color.OliveDrab;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void btnNvLanche_Click(object sender, EventArgs e)
        {
            gbxPao.Enabled = true;
            gbxPao.BackColor = Color.OliveDrab;
            

        }
    }
}
