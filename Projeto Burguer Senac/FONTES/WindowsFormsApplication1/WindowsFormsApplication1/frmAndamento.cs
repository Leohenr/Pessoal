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
    public partial class frmAndamento : Form
    {
        public frmAndamento()
        {
            InitializeComponent();
        }

        Delivery oDelivery = new Delivery();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void CarregarGrid()
        {
            try
            {
                grdAndamento.DataSource = oDelivery.Consultar();
                
                grdAndamento.Columns[1].Visible = false;
                grdAndamento.Columns[3].Visible = false;
                grdAndamento.Columns[5].Visible = false;
                grdAndamento.Columns[6].Visible = false;
                grdAndamento.Columns[7].Visible = false;
                grdAndamento.Columns[8].Visible = false;
                grdAndamento.Columns[9].Visible = false;
                grdAndamento.Columns[10].Visible = false;
                grdAndamento.Columns[11].Visible = false;
                grdAndamento.Columns[19].Visible = false;
                grdAndamento.Columns[20].Visible = false;
                grdAndamento.Columns[21].Visible = false;
                grdAndamento.Columns[23].Visible = false;
                grdAndamento.Columns[24].Visible = false;
                grdAndamento.Columns[25].Visible = false;
                grdAndamento.Columns[26].Visible = false;
                grdAndamento.Columns[28].Visible = false;
                grdAndamento.Columns[29].Visible = false;
                grdAndamento.Columns[31].Visible = false;
                grdAndamento.Columns[32].Visible = false;
                grdAndamento.Columns[33].Visible = false;
                grdAndamento.Columns[34].Visible = false;
                grdAndamento.Columns[35].Visible = false;
                grdAndamento.Columns[36].Visible = false;
                grdAndamento.Columns[37].Visible = false;
                grdAndamento.Columns[38].Visible = false;

                grdAndamento.Columns[13].Width = 200;

                grdAndamento.Columns[2].HeaderText = "DATA";
                grdAndamento.Columns[4].HeaderText = "TOTAL";
                grdAndamento.Columns[12].HeaderText = "NOME";
                grdAndamento.Columns[13].HeaderText = "ENDEREÇO";
                grdAndamento.Columns[14].HeaderText = "NUMERO";
                grdAndamento.Columns[15].HeaderText = "COMPLEMENTO";
                grdAndamento.Columns[16].HeaderText = "BAIRRO";
                grdAndamento.Columns[17].HeaderText = "CEP";
                grdAndamento.Columns[18].HeaderText = "CIDADE";
                grdAndamento.Columns[22].HeaderText = "USUARIO";
                grdAndamento.Columns[27].HeaderText = "FORMA DE PAGTO";
                grdAndamento.Columns[30].HeaderText = "NOME";
                grdAndamento.Columns[39].HeaderText = "FUNÇÕES";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Burger Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oDelivery.intAndamento = 1;
            grdAndamento.SelectedCells[0].Value = "Pedido Cancelado";

        }

        private void frmAndamento_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            oDelivery.intAndamento = 2;
            grdAndamento.SelectedCells[0].Value = "Pedido Finalizado";
        }

        private void grdAndamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdAndamento_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdAndamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
   
        }
    }
}
