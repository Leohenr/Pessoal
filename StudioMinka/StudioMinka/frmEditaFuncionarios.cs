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
    public partial class frmEditaFuncionarios : Form
    {
        public frmEditaFuncionarios()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string endereco = string.Empty;
            string bairro = string.Empty;
            string cidade = string.Empty;
            string uf = string.Empty;
            string retorno = webBrowser1.Document.Body.InnerText;

            if (retorno.IndexOf("CEP não encontrado") == -1)
            {
                uf = retorno.Substring(retorno.IndexOf("<state>") + 7, 2);
                cidade = retorno.Substring(retorno.IndexOf("<city>") + 6);
                cidade = cidade.Substring(0, cidade.IndexOf("</city>"));
                bairro = retorno.Substring(retorno.IndexOf("<district>") + 10);
                bairro = bairro.Substring(0, bairro.IndexOf("</district>"));
                endereco = retorno.Substring(retorno.IndexOf("<address>") + 9);
                endereco = endereco.Substring(0, endereco.IndexOf("</address>"));

                tbxEndereco.Text = endereco;
                tbxBairro.Text = bairro;
                tbxCidade.Text = cidade;
                tbxUF.Text = uf;
            }
            else
            {
                MessageBox.Show("CEP NÃO ENCONTRADO.");
            }
        }

        private void BuscarCEP()
        {
            string url = String.Format("http://apps.widenet.com.br/busca-cep/api/cep/{0}.xml", tbxCEP.Text);
            webBrowser1.Navigate(url);
        }
        private void tbxCEP_Leave(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mtbxTelefone.Text == string.Empty)
            {
                MessageBox.Show("Campo 'Telefone' Vazio, por favor preencher.", "Studio Mink'a - Atenção: Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbxTelefone.Focus();
            }
            else
            {
                lbxTelefones.Items.Add(mtbxTelefone.Text);
                mtbxTelefone.Clear();
                mtbxTelefone.Mask = "";
                btnRmv.Enabled = true;
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            lbxTelefones.Items.Remove(lbxTelefones.SelectedItem);
            if (lbxTelefones.Items.Count == 0)
            {
                btnRmv.Enabled = false;
            }
        }

        private void mtbxTelefone_Leave(object sender, EventArgs e)
        {
            if (mtbxTelefone.Text.Length > 10 & mtbxTelefone.Mask == string.Empty)
            {
                mtbxTelefone.Mask = "(00)0.0000-0000";
            }
            else if (mtbxTelefone.Mask == string.Empty & mtbxTelefone.Text.Length <= 10 & mtbxTelefone.Text.Length > 1)
            {
                mtbxTelefone.Mask = "(00)0000-0000";
            }
            else if (mtbxTelefone.Mask != string.Empty)
            {
                mtbxTelefone.Mask = "";
            }
        }
    }
}
