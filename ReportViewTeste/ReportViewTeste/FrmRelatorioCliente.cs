using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportViewTeste
{
    public partial class FrmRelatorioCliente : Form
    {
        public FrmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void FrmRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportViewTesteDataSet.tb_clientes_cli' table. You can move, or remove it, as needed.
            this.tb_clientes_cliTableAdapter.Fill(this.ReportViewTesteDataSet.tb_clientes_cli);

            this.reportViewer1.RefreshReport();
        }
    }
}
