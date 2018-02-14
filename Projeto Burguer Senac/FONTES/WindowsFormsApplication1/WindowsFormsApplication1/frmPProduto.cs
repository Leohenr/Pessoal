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
    public partial class frmPProduto : Form
    {
        public frmPProduto()
        {
            InitializeComponent();
        }
        Produto oProduto = new Produto();


        public void CarregarGrid()
        {
            try
            {
                int intPesq = cbxTipo.SelectedIndex;

                grdProduto.DataSource = oProduto.Consultar(intPesq);

                grdProduto.Columns[0].Visible = false;

                grdProduto.Columns[1].Width = 200;
                grdProduto.Columns[2].Width = 100;
                grdProduto.Columns[3].Width = 200;


                grdProduto.Columns[1].HeaderText = "NOME";
                grdProduto.Columns[2].HeaderText = "PREÇO";
                grdProduto.Columns[3].HeaderText = "CATEGORIA";

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Burger Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIProduto_Click(object sender, EventArgs e)
        {
            frmCProduto ofrmCProduto = new frmCProduto();
            
            ofrmCProduto.ShowDialog();
            CarregarGrid();
        }

        private void frmPProduto_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            cbxTipo.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oProduto.strNome = txtPesquisa.Text;
            oProduto.intCodigo = 0;
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (grdProduto.SelectedCells.Count != 0)
            {
                frmCProduto ofrmCProduto = new frmCProduto();

                
                oProduto.intCodigo = Convert.ToInt32(grdProduto.SelectedCells[0].Value);

                ofrmCProduto.txtNome.Text = grdProduto.SelectedCells[1].Value.ToString();
                ofrmCProduto.txtVenda.Text = grdProduto.SelectedCells[2].Value.ToString();
                ofrmCProduto.cbxCategoria.Tag = grdProduto.SelectedCells[3].Value.ToString();

                oProduto.Consultar(0);

                ofrmCProduto.txtCodigo.Text = oProduto.intCodigo.ToString();

                ofrmCProduto.ShowDialog();
                oProduto = null;
                oProduto = new Produto();
                CarregarGrid();
            }
        }

        private void grdProduto_DoubleClick(object sender, EventArgs e)
        {
            btnAlterar.PerformClick();
        }
    }
}
