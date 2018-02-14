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
    public partial class frmDelivery : Form
    {
        public frmDelivery()
        {
            InitializeComponent();
        }

        Cliente oCliente = new Cliente();
        Delivery oDelivery = new Delivery();
        bool blnMolhoAcomp = false;
        bool blnPao = false;
        bool blnBurger = false;
        bool blnPCarne = false;
        double dblDesconto = 0.00;
        double dblMoto = 0.00;

        /* public void CentralizarGourpBox(GroupBox grp)
         {
             grp.Visible = true;
             grp.Top = 180;  //(this.Height - SystemInformation.CaptionHeight - (SystemInformation.FrameBorderSize.Height * 2) - grp.Height) / 2;
             grp.Left = 170;// (this.Width - (SystemInformation.FrameBorderSize.Width * 2) - grp.Width) / 2;
             Application.DoEvents();
             grp.BringToFront();
             Application.DoEvents();
             bool blnSair = false;
             foreach (Control ctrl in this.Controls)
             {
                 if (ctrl.Name == grp.Name)
                 {
                     foreach (Control txt in ctrl.Controls)
                     {
                         if (txt.TabIndex == 0 && txt is TextBox)
                         {
                             blnSair = true;
                             txt.Focus();
                             break;
                         }
                     }
                 }
                 if (blnSair)
                 {
                     break;
                 }
             }
        }*/
        /*
        private void PreencherForm()
        {

            txtUsuario.Text = oFuncionario.strUsuario;
            txtNome.Text = oFuncionario.strNome;
            txtSenha.Text = oFuncionario.strSenha;
            txtConfirmacao.Text = oFuncionario.strSenha;
            rdbAtivo.Checked = oFuncionario.blnAtivo;
            rdbInativo.Checked = !oFuncionario.blnAtivo;
            txtCPF.Text = oFuncionario.strCPF;
            

        }

        private void PreencherClasse()
        {
            if (txtCodigo.Text == string.Empty)
            {
                oDelivery.intCodigo = 0;
            }
            else
            {
                oDelivery.intCodigo = Convert.ToInt32(txtCodigo.Text);
            }
            oDelivery.intAndamento = 0;
            oDelivery.intCliCodigo = txtSenha.Text;
            oDelivery.intUsuCodigo = rdbAtivo.Checked;
            oDelivery.intFncCodigo = txtCPF.Text;
            oDelivery.intPpdCodigo = txtTelefone.Text;
            oDelivery.dtDate = Convert.ToDateTime(tbxData.Text);
          //  foreach (string pro in lbxPedido.Items)
          //  {
          //      oCliente.strProduto.Add(pro);
          //  }
       }
        */
        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            btnPao.Enabled = false;
            btnBurguer.Enabled = false;
            btnPCarne.Enabled = false;
            btnQueijo.Enabled = false;
            btnIngredientes.Enabled = false;
            btnMolhos.Enabled = false;
            btnAcompanhamentos.Enabled = false;
            btnBebidas.Enabled = false;
            if (lbxPedido.Text.IndexOf("--------------------") != -1)
            {
            }
            else if (lbxPedido.Text.IndexOf("Pão: ") != -1)
            {
                btnPao.Enabled = true;
                btnPao.PerformClick();
            }
            else if (lbxPedido.Text.IndexOf("Burger: ") != -1)
            {
                btnBurguer.Enabled = true;
                btnBurguer.PerformClick();
            }
            else if (lbxPedido.Text.IndexOf("Ponto: ") != -1)
            {
                btnPCarne.Enabled = true;
                btnPCarne.PerformClick();
            }
            else if (lbxPedido.Text.IndexOf("Queijo: ") != -1)
            {
                btnQueijo.Enabled = true;
                btnQueijo.PerformClick();
            }
            else if (lbxPedido.Text.IndexOf("Ing: ") != -1)
            {
                btnIngredientes.Enabled = true;
                btnIngredientes.PerformClick();
            }
            else if (lbxPedido.Text.IndexOf("Molho: ") != -1)
            {
                btnMolhos.Enabled = true;
                btnMolhos.PerformClick();
            }
            else if (lbxPedido.Text.IndexOf("Acomp: ") != -1)
            {
                btnAcompanhamentos.Enabled = true;
                btnAcompanhamentos.PerformClick();
            }
            else if (lbxPedido.Text.IndexOf("Bebida: ") != -1)
            {
                btnBebidas.Enabled = true;
                btnBebidas.PerformClick();
            }

            btnDesfazer.Enabled = false;
            btnNvLanche.Enabled = false;
            btnCancelar.Enabled = false;
            btnEnviar.Enabled = false;
            btnProximo.Enabled = true;

            lstAux.Items.RemoveAt(lbxPedido.SelectedIndex);
            lbxValor.Items.RemoveAt(lbxPedido.SelectedIndex);
            lbxPedido.Items.Remove(lbxPedido.SelectedItem);

            CalcularTotal();

        }
        private string ValidarPreenchimento()
        {
            string strMensagem = string.Empty;


            if (txtCodigo.Text == string.Empty || txtCodigo.Text == "0")
            {
                if (tbxTelefone.Text == string.Empty)
                {
                    strMensagem += "Campo Telefone em Branco. \n";
                }
                if (tbxNome.Text == string.Empty)
                {
                    strMensagem += "Campo Nome em Branco. \n";
                }
                if (tbxCEP.Text == string.Empty)
                {
                    strMensagem += "Campo CEP em Branco. \n";
                }
                if (tbxBairro.Text == string.Empty)
                {
                    strMensagem += "Campo Bairro em Branco. \n";
                }
                if (tbxEnd.Text == string.Empty)
                {
                    strMensagem += "Campo Endereço em Branco. \n";
                }
                if (tbxNumero.Text == string.Empty)
                {
                    strMensagem += "Campo Numero em Branco. \n";
                }





            }
            return strMensagem;
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string strMsgErro = ValidarPreenchimento();

            if (strMsgErro != string.Empty)
            {
                MessageBox.Show(strMsgErro, "Burger Manager - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxTelefone.Focus();
            }
            else
            {
                gbxInfoCli.Enabled = false;
                gbxLanche.Enabled = true;
                tbxData.Enabled = true;
                btnPao.PerformClick();
                btnPCarne.Enabled = false;
                btnQueijo.Enabled = false;
                btnBurguer.Enabled = false;
                btnIngredientes.Enabled = false;
                btnMolhos.Enabled = false;
                btnAcompanhamentos.Enabled = false;
                btnBebidas.Enabled = false;


            }





        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            PreencherCombo();
            PreencherComboPagto();
            cbxMoto.SelectedIndex = 0;
            cbxPagto.SelectedIndex = 0;

        }

        private void btnCBebidas_Click(object sender, EventArgs e)
        {
            gbxCategoria.Enabled = false;
            gbxMotoboy.Enabled = true;
            btnCancelar.Enabled = true;
            btnEnviar.Enabled = true;

            btnNvLanche.Enabled = true;
            btnNvLanche.BackColor = Color.Green;
            btnNvLanche.ForeColor = Color.White;

            btnEnviar.BackColor = Color.Green;
            btnEnviar.ForeColor = Color.White;

            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
        }

        private void btnNvLanche_Click(object sender, EventArgs e)
        {
            lbxPedido.Items.Add("--------------------");
            lbxValor.Items.Add("----------");
            lstAux.Items.Add("-");
            txtDesconto.Text = string.Empty;
            dblDesconto = 0.00;
            btnPao.Enabled = true;
            btnNvLanche.Enabled = false;
            btnProximo.Enabled = true;
            btnCancelar.Enabled = false;
            btnEnviar.Enabled = false;
            blnPao = false;
            blnBurger = false;
            blnPCarne = false;
            btnPao.PerformClick();

        }

        private void PreencherClasse()
        {
            oDelivery.dtDate = Convert.ToDateTime(tbxData.Text);
            oDelivery.intAndamento = Convert.ToInt32(txtAndamento.Text);
            oDelivery.strTotal = lblTotal.Text;

            oDelivery.intCliCodigo = Convert.ToInt32(txtCodigo.Text);
            oDelivery.intUsuCodigo = Global.intCodigoUsuario;
            oDelivery.intPagCodigo = Convert.ToInt32(cbxPagto.SelectedValue);
            oDelivery.intFncCodigo = Convert.ToInt32(cbxMoto.SelectedValue);

            oDelivery.produtos.Clear();
            for (int intCont = 0; intCont < lbxPedido.Items.Count; intCont++)
            {
                Produto pdt = new Produto();
                pdt.intCodigo = Convert.ToInt32(lstAuxProCod.Items[intCont]);
                pdt.strNome = lbxPedido.Items[intCont].ToString();
                oDelivery.produtos.Add(pdt);

            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            PreencherClasse();
            oDelivery.Gravar();
            MessageBox.Show("Pedido Enviado", "Burger Manager - NOVO CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            frmCCliente ofrmCCliente = new frmCCliente();

            if (txtCodigo.Text == string.Empty || txtCodigo.Text == "0")
            {
                ofrmCCliente.ShowDialog();
            }
            else
            {
                ofrmCCliente.txtCodigo.Text = txtCodigo.Text;
                ofrmCCliente.txtNome.Text = tbxNome.Text;
                ofrmCCliente.txtCEP.Text = tbxCEP.Text;
                ofrmCCliente.txtBairro.Text = tbxBairro.Text;
                ofrmCCliente.txtEndereco.Text = tbxEnd.Text;
                ofrmCCliente.txtNumero.Text = tbxNumero.Text;
                ofrmCCliente.txtComplemento.Text = tbxComp.Text;

                ofrmCCliente.txtCidade.Text = oCliente.strCidade;
                ofrmCCliente.txtUF.Text = oCliente.strEstado;
                ofrmCCliente.txtCPF.Text = oCliente.strCPF;

                oCliente.Consultar(0);

                foreach (string tel in oCliente.strTelefones)
                {
                    ofrmCCliente.lstTelefones.Items.Add(tel);
                }

                ofrmCCliente.ShowDialog();
                oCliente = null;
                oCliente = new Cliente();

            }
        }

        private void botaoNome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OLA");
        }

        private void CalcularTotal()
        {
            string strTotal = string.Empty;
            double dblTotal = 0;
            double dblValor = 0;

            foreach (string valor in lbxValor.Items)
            {
                if (valor != "----------")
                {
                    dblValor = Convert.ToDouble(valor.Replace(".", ","));
                    dblTotal += dblValor;

                }
            }
            if (txtDesconto.Text == string.Empty)
            {
                dblDesconto = 0.00;
            }
            dblTotal -= dblDesconto;
            if (lblValorMoto.TextLength >= 1)
            {
                dblMoto = Convert.ToDouble(lblValorMoto.Text.Replace(".", ","));
                dblMoto = Convert.ToDouble(lblValorMoto.Text);
                dblTotal += dblMoto;
            }
            


            lblTotal.Text = dblTotal.ToString("#0.00");

        }

        private void lbxValor_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCCliente ofrmCliente = new frmCCliente();
            ofrmCliente.Show();
        }

        private void lbxPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxValor.SelectedIndex = lbxPedido.SelectedIndex;
            lstAux.SelectedIndex = lbxPedido.SelectedIndex;
        }

        private void gbxLanche_Enter(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {


            if (btnPao.Enabled == true)
            {

                if (blnPao == false)
                {
                    btnPao.Enabled = true;
                    MessageBox.Show("PÃO OBRIGATORIO, FAVOR PREENCHER.", "PEDIDO SEM PÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnPao.Enabled = false;
                    btnBurguer.Enabled = true;

                    btnBurguer.PerformClick();
                }



            }
            else if (btnBurguer.Enabled == true)
            {
                if (blnBurger == false)
                {
                    btnBurguer.Enabled = true;
                    MessageBox.Show("BURGER OBRIGATORIO, FAVOR PREENCHER.", "PEDIDO SEM BURGER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnBurguer.Enabled = false;
                    btnPCarne.Enabled = true;

                    btnPCarne.PerformClick();
                }

            }
            else if (btnPCarne.Enabled == true)
            {
                if (blnPCarne == false)
                {
                    btnPCarne.Enabled = true;
                    MessageBox.Show("PONTO DA CARNE OBRIGATORIO, FAVOR PREENCHER.", "PEDIDO SEM PONTO DA CARNE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnPCarne.Enabled = false;
                    btnQueijo.Enabled = true;

                    btnQueijo.PerformClick();
                }



            }
            else if (btnQueijo.Enabled == true)
            {
                btnQueijo.Enabled = false;
                btnIngredientes.Enabled = true;

                btnIngredientes.PerformClick();
            }
            else if (btnIngredientes.Enabled == true)
            {
                btnIngredientes.Enabled = false;
                btnMolhos.Enabled = true;

                btnMolhos.PerformClick();
            }
            else if (btnMolhos.Enabled == true)
            {
                btnMolhos.Enabled = false;
                btnAcompanhamentos.Enabled = true;

                btnAcompanhamentos.PerformClick();
            }
            else if (btnAcompanhamentos.Enabled == true)
            {

                btnAcompanhamentos.Enabled = false;

                if (blnMolhoAcomp == false)
                {

                    DialogResult oDialogResult = MessageBox.Show("Deseja Molho para Acomapanhamento?", "Molho Acompanhamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (oDialogResult == DialogResult.Yes)
                    {
                        btnMolhos.Enabled = true;
                        blnMolhoAcomp = true;
                        btnMolhos.PerformClick();
                    }
                    else if (oDialogResult == DialogResult.No)
                    {
                        btnBebidas.Enabled = true;
                        btnBebidas.PerformClick();
                    }
                }
                else
                {
                    btnBebidas.Enabled = true;
                    btnBebidas.PerformClick();
                }
            }
            else if (btnBebidas.Enabled == true)
            {

                btnBebidas.Enabled = false;
                gbxMotoboy.Enabled = true;
                btnCancelar.Enabled = true;
                btnEnviar.Enabled = true;
                btnNvLanche.Enabled = true;
                btnProximo.Enabled = false;

                lbxProdutos.DataSource = null;

                btnNvLanche.BackColor = Color.Green;
                btnNvLanche.ForeColor = Color.White;

                btnEnviar.BackColor = Color.Green;
                btnEnviar.ForeColor = Color.White;

                btnCancelar.BackColor = Color.Red;
                btnCancelar.ForeColor = Color.White;



            }
        }

        private void btnPao_Click(object sender, EventArgs e)
        {

            lstAuxProCod2.DataSource = null;
            lbxProdutos.DataSource = Global.ConsultarPaoDelivery();
            lbxProdutos.DisplayMember = "pro_nome";
            lbxProdutos.ValueMember = "pro_venda";
            lstAuxProCod2.DataSource = Global.ConsultarPaoDelivery();
            lstAuxProCod2.DisplayMember = "pro_codigo";
            lstAuxProCod2.ValueMember = "pro_codigo";
            btnPao.Enabled = true;


        }

        private void lbxProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (lbxProdutos.SelectedIndex != -1)
            {

                lbxPedido.Items.Add(lbxProdutos.Text);
                lbxValor.Items.Add(lbxProdutos.SelectedValue.ToString());
                lstAuxProCod.Items.Add(lstAuxProCod2.SelectedValue.ToString());
                CalcularTotal();



                if (btnPao.Enabled == true)
                {
                    lstAux.Items.Add(0);
                    blnPao = true;
                }
                else if (btnBurguer.Enabled == true)
                {
                    lstAux.Items.Add(1);
                    blnBurger = true;
                }
                else if (btnPCarne.Enabled == true)
                {
                    lstAux.Items.Add(2);
                    blnPCarne = true;
                }
                else if (btnQueijo.Enabled == true)
                {
                    lstAux.Items.Add(3);
                }
                else if (btnIngredientes.Enabled == true)
                {
                    lstAux.Items.Add(4);
                }
                else if (btnMolhos.Enabled == true)
                {
                    lstAux.Items.Add(5);
                }
                else if (btnAcompanhamentos.Enabled == true)
                {
                    lstAux.Items.Add(6);
                }
                else if (btnBebidas.Enabled == true)
                {
                    lstAux.Items.Add(7);
                }

            }

        }

        private void btnBurguer_Click(object sender, EventArgs e)
        {
            {

                lstAuxProCod2.DataSource = null;
                lbxProdutos.DataSource = Global.ConsultarBurguerDelivery();
                lbxProdutos.DisplayMember = "pro_nome";
                lbxProdutos.ValueMember = "pro_venda";
                lstAuxProCod2.DataSource = Global.ConsultarBurguerDelivery();
                lstAuxProCod2.DisplayMember = "pro_codigo";
                lstAuxProCod2.ValueMember = "pro_codigo";
                btnBurguer.Enabled = true;
            }
        }

        private void btnPCarne_Click(object sender, EventArgs e)
        {
            {

                lstAuxProCod2.DataSource = null;
                lbxProdutos.DataSource = Global.ConsultarPontoDelivery();
                lbxProdutos.DisplayMember = "pro_nome";
                lbxProdutos.ValueMember = "pro_venda";
                lstAuxProCod2.DataSource = Global.ConsultarPontoDelivery();
                lstAuxProCod2.DisplayMember = "pro_codigo";
                lstAuxProCod2.ValueMember = "pro_codigo";
            }
        }

        private void btnQueijo_Click(object sender, EventArgs e)
        {
            {
                lbxProdutos.DataSource = Global.ConsultarQueijoDelivery();
                lbxProdutos.DisplayMember = "pro_nome";
                lbxProdutos.ValueMember = "pro_venda";
                lstAuxProCod2.DataSource = Global.ConsultarQueijoDelivery();
                lstAuxProCod2.DisplayMember = "pro_codigo";
                lstAuxProCod2.ValueMember = "pro_codigo";
            }
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            {
                lbxProdutos.DataSource = Global.ConsultarIngredientesDelivery();
                lbxProdutos.DisplayMember = "pro_nome";
                lbxProdutos.ValueMember = "pro_venda";
                lstAuxProCod2.DataSource = Global.ConsultarIngredientesDelivery();
                lstAuxProCod2.DisplayMember = "pro_codigo";
                lstAuxProCod2.ValueMember = "pro_codigo";
            }
        }

        private void btnMolhos_Click(object sender, EventArgs e)
        {
            {
                lbxProdutos.DataSource = Global.ConsultarMolhosDelivery();
                lbxProdutos.DisplayMember = "pro_nome";
                lbxProdutos.ValueMember = "pro_venda";
                lstAuxProCod2.DataSource = Global.ConsultarMolhosDelivery();
                lstAuxProCod2.DisplayMember = "pro_codigo";
                lstAuxProCod2.ValueMember = "pro_codigo";
            }
        }

        private void btnAcompanhamentos_Click(object sender, EventArgs e)
        {
            {
                lbxProdutos.DataSource = Global.ConsultarAcompanhamentosDelivery();
                lbxProdutos.DisplayMember = "pro_nome";
                lbxProdutos.ValueMember = "pro_venda";
                lstAuxProCod2.DataSource = Global.ConsultarAcompanhamentosDelivery();
                lstAuxProCod2.DisplayMember = "pro_codigo";
                lstAuxProCod2.ValueMember = "pro_codigo";
            }
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            {
                lbxProdutos.DataSource = Global.ConsultarBebidasDelivery();
                lbxProdutos.DisplayMember = "pro_nome";
                lbxProdutos.ValueMember = "pro_venda";
                lstAuxProCod2.DataSource = Global.ConsultarBebidasDelivery();
                lstAuxProCod2.DisplayMember = "pro_codigo";
                lstAuxProCod2.ValueMember = "pro_codigo";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lbxProdutos.DataSource = null;
            lbxPedido.Items.Clear();
            lbxValor.Items.Clear();

            this.Close();
        }

        private void tbxTelefone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxTelefone.TextLength > 8)
                {
                    btnAlterar.Text = "Alterar";
                    oCliente.strTelefone = tbxTelefone.Text;
                    oCliente.ConsultarTel();

                    txtCodigo.Text = oCliente.intCodigo.ToString();
                    tbxNome.Text = oCliente.strNome;
                    tbxCEP.Text = oCliente.strCEP;
                    tbxEnd.Text = oCliente.strEndereco;
                    tbxNumero.Text = oCliente.strNumero;
                    tbxComp.Text = oCliente.strComplemento;
                    tbxBairro.Text = oCliente.strBairro;
                }
                if (tbxTelefone.TextLength < 8)
                {
                    btnAlterar.Text = "Novo Cliente";
                    txtCodigo.Text = string.Empty;
                    tbxNome.Text = string.Empty;
                    tbxCEP.Text = string.Empty;
                    tbxEnd.Text = string.Empty;
                    tbxNumero.Text = string.Empty;
                    tbxComp.Text = string.Empty;
                    tbxBairro.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Burger Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PreencherCombo()
        {
            try
            {
                cbxMoto.DataSource = Global.ConsultarMotoboy();
                cbxMoto.DisplayMember = "fnc_nome";
                cbxMoto.ValueMember = "fnc_codigo";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PreencherComboPagto()
        {
            try
            {
                cbxPagto.DataSource = Global.ConsultarPagto();
                cbxPagto.DisplayMember = "pag_forma";
                cbxPagto.ValueMember = "pag_codigo";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cbxMoto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblValorMoto_Click(object sender, EventArgs e)
        {

        }

        private void lbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void lstAux_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lbxPedido.SelectedIndex = lstAux.SelectedIndex;
            // lbxValor.SelectedIndex = lstAux.SelectedIndex;
        }

        private void lbxValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  lbxPedido.SelectedIndex = lbxValor.SelectedIndex;
            // lstAux.SelectedIndex = lbxValor.SelectedIndex;
        }

        private void lbxPedido_Click(object sender, EventArgs e)
        {
            btnDesfazer.Enabled = true;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lbxProdutos_DockChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text != string.Empty)
            {
                dblDesconto = Convert.ToDouble(txtDesconto.Text);
            }

            CalcularTotal();
        }

        private void gbxInfoCli_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxProdutos_Click(object sender, EventArgs e)
        {
            lstAuxProCod2.SelectedIndex = lbxProdutos.SelectedIndex;
        }

        private void lstAuxProCod2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblValorMoto_TextChanged(object sender, EventArgs e)
        {
            
                CalcularTotal();
            
        }


    }
}
