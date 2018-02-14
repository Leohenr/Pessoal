using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMB
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblValor.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblValor.Text != "0")
            {
                lblValor.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "1";
            }
            else
            {
                lblValor.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "2";
            }
            else
            {
                lblValor.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "3";
            }
            else
            {
                lblValor.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "4";
            }
            else
            {
                lblValor.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "5";
            }
            else
            {
                lblValor.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "6";
            }
            else
            {
                lblValor.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "7";
            }
            else
            {
                lblValor.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "8";
            }
            else
            {
                lblValor.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblValor.Text == "0")
            {
                lblValor.Text = "9";
            }
            else
            {
                lblValor.Text += "9";
            }
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            int intTamanho = lblValor.Text.Length; //Contar o nº de caracteres
            if (intTamanho == 1 || lblValor.Text == "0")
            {
                lblValor.Text = "0";
            }
            else
            {
            lblValor.Text = lblValor.Text.Substring(0, intTamanho - 1);
            }
        }
    }
}
