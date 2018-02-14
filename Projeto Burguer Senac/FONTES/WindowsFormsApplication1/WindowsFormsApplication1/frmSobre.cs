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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            lblSobre.Text = "BURGER MANAGER \n";
            lblSobre.Text += "Versão 1.0 \n \n";
            lblSobre.Text += "Burger Manager é um programa feito \n"; 
            lblSobre.Text += "para a gestão de uma Hamburgueria. \n";
            lblSobre.Text += "Nele você faz Cadastro de Produtos, \n";
            lblSobre.Text += "Funcionarios e Clientes e Alteração \n";
            lblSobre.Text += "dos mesmos. Temos também um \n";
            lblSobre.Text += "Menu de Delivery, onde você pode criar \n";
            lblSobre.Text += "pedidos e/ou ver o andamento deles. \n";


            lblApp.Text = "SYSTEM MANAGER \n";
            lblApp.Text += "Desenvolvido por Leonardo Henrique, \n";
            lblApp.Text += "Jean Crepaldi, Kenneth Anderson.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
