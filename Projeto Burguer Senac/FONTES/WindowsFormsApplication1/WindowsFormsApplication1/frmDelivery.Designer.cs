namespace Burger_Manager
{
    partial class frmDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxMotoboy = new System.Windows.Forms.GroupBox();
            this.lblValorMoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPagto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMoto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxValor = new System.Windows.Forms.ListBox();
            this.lbxPedido = new System.Windows.Forms.ListBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gbxLanche = new System.Windows.Forms.GroupBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.btnNvLanche = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnAcompanhamentos = new System.Windows.Forms.Button();
            this.btnMolhos = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnQueijo = new System.Windows.Forms.Button();
            this.btnPCarne = new System.Windows.Forms.Button();
            this.btnBurguer = new System.Windows.Forms.Button();
            this.btnPao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxInfoCli = new System.Windows.Forms.GroupBox();
            this.txtAndamento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tbxCEP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tbxComp = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstAux = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lstAuxProCod = new System.Windows.Forms.ListBox();
            this.lstAuxProCod2 = new System.Windows.Forms.ListBox();
            this.tbxData = new System.Windows.Forms.DateTimePicker();
            this.gbxMotoboy.SuspendLayout();
            this.gbxLanche.SuspendLayout();
            this.gbxCategoria.SuspendLayout();
            this.gbxInfoCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMotoboy
            // 
            this.gbxMotoboy.Controls.Add(this.lblValorMoto);
            this.gbxMotoboy.Controls.Add(this.label3);
            this.gbxMotoboy.Controls.Add(this.cbxPagto);
            this.gbxMotoboy.Controls.Add(this.label4);
            this.gbxMotoboy.Controls.Add(this.cbxMoto);
            this.gbxMotoboy.Controls.Add(this.label6);
            this.gbxMotoboy.Controls.Add(this.label7);
            this.gbxMotoboy.Enabled = false;
            this.gbxMotoboy.Location = new System.Drawing.Point(8, 480);
            this.gbxMotoboy.Margin = new System.Windows.Forms.Padding(2);
            this.gbxMotoboy.Name = "gbxMotoboy";
            this.gbxMotoboy.Padding = new System.Windows.Forms.Padding(2);
            this.gbxMotoboy.Size = new System.Drawing.Size(417, 70);
            this.gbxMotoboy.TabIndex = 147;
            this.gbxMotoboy.TabStop = false;
            this.gbxMotoboy.Text = "Motoboy e Forma de Pagamento";
            // 
            // lblValorMoto
            // 
            this.lblValorMoto.Location = new System.Drawing.Point(368, 16);
            this.lblValorMoto.Name = "lblValorMoto";
            this.lblValorMoto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValorMoto.Size = new System.Drawing.Size(42, 20);
            this.lblValorMoto.TabIndex = 155;
            this.lblValorMoto.Text = "4,00";
            this.lblValorMoto.TextChanged += new System.EventHandler(this.lblValorMoto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 154;
            this.label3.Text = "FORMA DE PAGAMENTO";
            // 
            // cbxPagto
            // 
            this.cbxPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPagto.FormattingEnabled = true;
            this.cbxPagto.Location = new System.Drawing.Point(145, 40);
            this.cbxPagto.Name = "cbxPagto";
            this.cbxPagto.Size = new System.Drawing.Size(260, 21);
            this.cbxPagto.TabIndex = 153;
            this.cbxPagto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "MOTOBOY";
            // 
            // cbxMoto
            // 
            this.cbxMoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoto.FormattingEnabled = true;
            this.cbxMoto.Location = new System.Drawing.Point(68, 15);
            this.cbxMoto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMoto.Name = "cbxMoto";
            this.cbxMoto.Size = new System.Drawing.Size(165, 21);
            this.cbxMoto.TabIndex = 30;
            this.cbxMoto.SelectedIndexChanged += new System.EventHandler(this.cbxMoto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "TAXA DE ENTREGA:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "R$";
            // 
            // lbxValor
            // 
            this.lbxValor.Enabled = false;
            this.lbxValor.FormattingEnabled = true;
            this.lbxValor.Location = new System.Drawing.Point(628, 166);
            this.lbxValor.Margin = new System.Windows.Forms.Padding(2);
            this.lbxValor.Name = "lbxValor";
            this.lbxValor.Size = new System.Drawing.Size(74, 355);
            this.lbxValor.TabIndex = 146;
            this.lbxValor.SelectedIndexChanged += new System.EventHandler(this.lbxValor_SelectedIndexChanged);
            this.lbxValor.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.lbxValor_ControlAdded);
            // 
            // lbxPedido
            // 
            this.lbxPedido.FormattingEnabled = true;
            this.lbxPedido.Location = new System.Drawing.Point(432, 167);
            this.lbxPedido.Margin = new System.Windows.Forms.Padding(2);
            this.lbxPedido.Name = "lbxPedido";
            this.lbxPedido.Size = new System.Drawing.Size(179, 355);
            this.lbxPedido.TabIndex = 145;
            this.lbxPedido.Click += new System.EventHandler(this.lbxPedido_Click);
            this.lbxPedido.SelectedIndexChanged += new System.EventHandler(this.lbxPedido_SelectedIndexChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(555, 76);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 31);
            this.btnConfirmar.TabIndex = 144;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(640, 549);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 22);
            this.lblTotal.TabIndex = 143;
            this.lblTotal.Text = "0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(600, 552);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 24);
            this.label10.TabIndex = 142;
            this.label10.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 552);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 141;
            this.label9.Text = "TOTAL DO PEDIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 140;
            this.label5.Text = "Valor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(8, 550);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 47);
            this.btnCancelar.TabIndex = 136;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(555, 39);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(132, 33);
            this.btnAlterar.TabIndex = 134;
            this.btnAlterar.Text = "Novo Cliente";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(329, 550);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(96, 46);
            this.btnEnviar.TabIndex = 135;
            this.btnEnviar.Text = "Enviar Pedido";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // gbxLanche
            // 
            this.gbxLanche.Controls.Add(this.btnProximo);
            this.gbxLanche.Controls.Add(this.lbxProdutos);
            this.gbxLanche.Controls.Add(this.btnNvLanche);
            this.gbxLanche.Controls.Add(this.btnDesfazer);
            this.gbxLanche.Controls.Add(this.gbxCategoria);
            this.gbxLanche.Enabled = false;
            this.gbxLanche.Location = new System.Drawing.Point(8, 126);
            this.gbxLanche.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLanche.Name = "gbxLanche";
            this.gbxLanche.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLanche.Size = new System.Drawing.Size(417, 355);
            this.gbxLanche.TabIndex = 132;
            this.gbxLanche.TabStop = false;
            this.gbxLanche.Text = "Montar o Lanche";
            this.gbxLanche.Enter += new System.EventHandler(this.gbxLanche_Enter);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProximo.Location = new System.Drawing.Point(154, 320);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(256, 31);
            this.btnProximo.TabIndex = 135;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.Location = new System.Drawing.Point(154, 62);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(256, 251);
            this.lbxProdutos.TabIndex = 134;
            this.lbxProdutos.Click += new System.EventHandler(this.lbxProdutos_Click);
            this.lbxProdutos.SelectedIndexChanged += new System.EventHandler(this.lbxProdutos_SelectedIndexChanged);
            this.lbxProdutos.DockChanged += new System.EventHandler(this.lbxProdutos_DockChanged);
            this.lbxProdutos.DoubleClick += new System.EventHandler(this.lbxProdutos_DoubleClick);
            // 
            // btnNvLanche
            // 
            this.btnNvLanche.BackColor = System.Drawing.SystemColors.Control;
            this.btnNvLanche.Enabled = false;
            this.btnNvLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvLanche.ForeColor = System.Drawing.Color.Black;
            this.btnNvLanche.Location = new System.Drawing.Point(154, 11);
            this.btnNvLanche.Margin = new System.Windows.Forms.Padding(2);
            this.btnNvLanche.Name = "btnNvLanche";
            this.btnNvLanche.Size = new System.Drawing.Size(86, 39);
            this.btnNvLanche.TabIndex = 124;
            this.btnNvLanche.Text = "ADICIONAR LANCHE";
            this.btnNvLanche.UseVisualStyleBackColor = false;
            this.btnNvLanche.Click += new System.EventHandler(this.btnNvLanche_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.BackColor = System.Drawing.Color.Firebrick;
            this.btnDesfazer.Enabled = false;
            this.btnDesfazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesfazer.ForeColor = System.Drawing.Color.White;
            this.btnDesfazer.Location = new System.Drawing.Point(321, 13);
            this.btnDesfazer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(92, 37);
            this.btnDesfazer.TabIndex = 123;
            this.btnDesfazer.Text = "DELETAR ITEM";
            this.btnDesfazer.UseVisualStyleBackColor = false;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.btnBebidas);
            this.gbxCategoria.Controls.Add(this.btnAcompanhamentos);
            this.gbxCategoria.Controls.Add(this.btnMolhos);
            this.gbxCategoria.Controls.Add(this.btnIngredientes);
            this.gbxCategoria.Controls.Add(this.btnQueijo);
            this.gbxCategoria.Controls.Add(this.btnPCarne);
            this.gbxCategoria.Controls.Add(this.btnBurguer);
            this.gbxCategoria.Controls.Add(this.btnPao);
            this.gbxCategoria.Location = new System.Drawing.Point(8, 17);
            this.gbxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCategoria.Size = new System.Drawing.Size(142, 334);
            this.gbxCategoria.TabIndex = 25;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categorias";
            // 
            // btnBebidas
            // 
            this.btnBebidas.Location = new System.Drawing.Point(6, 299);
            this.btnBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(128, 32);
            this.btnBebidas.TabIndex = 7;
            this.btnBebidas.Text = "BEBIDAS";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnAcompanhamentos
            // 
            this.btnAcompanhamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnAcompanhamentos.Location = new System.Drawing.Point(6, 262);
            this.btnAcompanhamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcompanhamentos.Name = "btnAcompanhamentos";
            this.btnAcompanhamentos.Size = new System.Drawing.Size(128, 34);
            this.btnAcompanhamentos.TabIndex = 6;
            this.btnAcompanhamentos.Text = "ACOMPANHAMENTOS";
            this.btnAcompanhamentos.UseVisualStyleBackColor = true;
            this.btnAcompanhamentos.Click += new System.EventHandler(this.btnAcompanhamentos_Click);
            // 
            // btnMolhos
            // 
            this.btnMolhos.Location = new System.Drawing.Point(5, 224);
            this.btnMolhos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMolhos.Name = "btnMolhos";
            this.btnMolhos.Size = new System.Drawing.Size(129, 32);
            this.btnMolhos.TabIndex = 5;
            this.btnMolhos.Text = "MOLHOS";
            this.btnMolhos.UseVisualStyleBackColor = true;
            this.btnMolhos.Click += new System.EventHandler(this.btnMolhos_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(6, 181);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(128, 37);
            this.btnIngredientes.TabIndex = 4;
            this.btnIngredientes.Text = "INGREDIENTES";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnQueijo
            // 
            this.btnQueijo.Location = new System.Drawing.Point(6, 141);
            this.btnQueijo.Margin = new System.Windows.Forms.Padding(2);
            this.btnQueijo.Name = "btnQueijo";
            this.btnQueijo.Size = new System.Drawing.Size(128, 35);
            this.btnQueijo.TabIndex = 3;
            this.btnQueijo.Text = "QUEIJOS";
            this.btnQueijo.UseVisualStyleBackColor = true;
            this.btnQueijo.Click += new System.EventHandler(this.btnQueijo_Click);
            // 
            // btnPCarne
            // 
            this.btnPCarne.Location = new System.Drawing.Point(6, 93);
            this.btnPCarne.Margin = new System.Windows.Forms.Padding(2);
            this.btnPCarne.Name = "btnPCarne";
            this.btnPCarne.Size = new System.Drawing.Size(128, 41);
            this.btnPCarne.TabIndex = 2;
            this.btnPCarne.Text = "PONTO DA CARNE";
            this.btnPCarne.UseVisualStyleBackColor = true;
            this.btnPCarne.Click += new System.EventHandler(this.btnPCarne_Click);
            // 
            // btnBurguer
            // 
            this.btnBurguer.Location = new System.Drawing.Point(5, 54);
            this.btnBurguer.Margin = new System.Windows.Forms.Padding(2);
            this.btnBurguer.Name = "btnBurguer";
            this.btnBurguer.Size = new System.Drawing.Size(129, 33);
            this.btnBurguer.TabIndex = 1;
            this.btnBurguer.Text = "BURGUER";
            this.btnBurguer.UseVisualStyleBackColor = true;
            this.btnBurguer.Click += new System.EventHandler(this.btnBurguer_Click);
            // 
            // btnPao
            // 
            this.btnPao.Location = new System.Drawing.Point(5, 18);
            this.btnPao.Margin = new System.Windows.Forms.Padding(2);
            this.btnPao.Name = "btnPao";
            this.btnPao.Size = new System.Drawing.Size(129, 31);
            this.btnPao.TabIndex = 0;
            this.btnPao.Text = "PÃO";
            this.btnPao.UseVisualStyleBackColor = true;
            this.btnPao.Click += new System.EventHandler(this.btnPao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Informações do Pedido";
            // 
            // gbxInfoCli
            // 
            this.gbxInfoCli.Controls.Add(this.txtAndamento);
            this.gbxInfoCli.Controls.Add(this.label12);
            this.gbxInfoCli.Controls.Add(this.txtCodigo);
            this.gbxInfoCli.Controls.Add(this.tbxCEP);
            this.gbxInfoCli.Controls.Add(this.label8);
            this.gbxInfoCli.Controls.Add(this.tbxBairro);
            this.gbxInfoCli.Controls.Add(this.lblBairro);
            this.gbxInfoCli.Controls.Add(this.tbxTelefone);
            this.gbxInfoCli.Controls.Add(this.lblTelefone);
            this.gbxInfoCli.Controls.Add(this.tbxComp);
            this.gbxInfoCli.Controls.Add(this.lblComp);
            this.gbxInfoCli.Controls.Add(this.tbxNumero);
            this.gbxInfoCli.Controls.Add(this.lblNumero);
            this.gbxInfoCli.Controls.Add(this.tbxEnd);
            this.gbxInfoCli.Controls.Add(this.btnConfirmar);
            this.gbxInfoCli.Controls.Add(this.lblEnd);
            this.gbxInfoCli.Controls.Add(this.lblNome);
            this.gbxInfoCli.Controls.Add(this.tbxNome);
            this.gbxInfoCli.Controls.Add(this.btnAlterar);
            this.gbxInfoCli.Location = new System.Drawing.Point(9, 10);
            this.gbxInfoCli.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInfoCli.Name = "gbxInfoCli";
            this.gbxInfoCli.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInfoCli.Size = new System.Drawing.Size(691, 112);
            this.gbxInfoCli.TabIndex = 130;
            this.gbxInfoCli.TabStop = false;
            this.gbxInfoCli.Text = "Informações do Cliente";
            this.gbxInfoCli.Enter += new System.EventHandler(this.gbxInfoCli_Enter);
            // 
            // txtAndamento
            // 
            this.txtAndamento.Location = new System.Drawing.Point(674, 16);
            this.txtAndamento.Name = "txtAndamento";
            this.txtAndamento.Size = new System.Drawing.Size(12, 20);
            this.txtAndamento.TabIndex = 154;
            this.txtAndamento.Text = "0";
            this.txtAndamento.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(555, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 153;
            this.label12.Text = "Codigo do Cliente";
            this.label12.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(634, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(34, 20);
            this.txtCodigo.TabIndex = 152;
            this.txtCodigo.Visible = false;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // tbxCEP
            // 
            this.tbxCEP.Enabled = false;
            this.tbxCEP.Location = new System.Drawing.Point(44, 39);
            this.tbxCEP.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCEP.Name = "tbxCEP";
            this.tbxCEP.Size = new System.Drawing.Size(161, 20);
            this.tbxCEP.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 145;
            this.label8.Text = "CEP";
            // 
            // tbxBairro
            // 
            this.tbxBairro.Enabled = false;
            this.tbxBairro.Location = new System.Drawing.Point(281, 39);
            this.tbxBairro.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.Size = new System.Drawing.Size(270, 20);
            this.tbxBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(243, 42);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro";
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(377, 16);
            this.tbxTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(174, 20);
            this.tbxTelefone.TabIndex = 9;
            this.tbxTelefone.TextChanged += new System.EventHandler(this.tbxTelefone_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(325, 19);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone";
            // 
            // tbxComp
            // 
            this.tbxComp.Enabled = false;
            this.tbxComp.Location = new System.Drawing.Point(225, 87);
            this.tbxComp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxComp.Name = "tbxComp";
            this.tbxComp.Size = new System.Drawing.Size(326, 20);
            this.tbxComp.TabIndex = 7;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(150, 90);
            this.lblComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(71, 13);
            this.lblComp.TabIndex = 6;
            this.lblComp.Text = "Complemento";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Enabled = false;
            this.tbxNumero.Location = new System.Drawing.Point(62, 87);
            this.tbxNumero.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(70, 20);
            this.tbxNumero.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(5, 90);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número";
            // 
            // tbxEnd
            // 
            this.tbxEnd.Enabled = false;
            this.tbxEnd.Location = new System.Drawing.Point(62, 63);
            this.tbxEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(489, 20);
            this.tbxEnd.TabIndex = 3;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(5, 66);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "Endereço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 19);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // tbxNome
            // 
            this.tbxNome.Enabled = false;
            this.tbxNome.Location = new System.Drawing.Point(44, 16);
            this.tbxNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(270, 20);
            this.tbxNome.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(436, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 147;
            this.label11.Text = "DATA";
            // 
            // lstAux
            // 
            this.lstAux.FormattingEnabled = true;
            this.lstAux.Location = new System.Drawing.Point(595, 167);
            this.lstAux.Name = "lstAux";
            this.lstAux.Size = new System.Drawing.Size(28, 355);
            this.lstAux.TabIndex = 149;
            this.lstAux.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 150;
            this.label2.Text = "DESCONTO";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(581, 524);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(121, 20);
            this.txtDesconto.TabIndex = 151;
            this.txtDesconto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstAuxProCod
            // 
            this.lstAuxProCod.FormattingEnabled = true;
            this.lstAuxProCod.Location = new System.Drawing.Point(789, 166);
            this.lstAuxProCod.Name = "lstAuxProCod";
            this.lstAuxProCod.Size = new System.Drawing.Size(86, 355);
            this.lstAuxProCod.TabIndex = 152;
            this.lstAuxProCod.Visible = false;
            // 
            // lstAuxProCod2
            // 
            this.lstAuxProCod2.FormattingEnabled = true;
            this.lstAuxProCod2.Location = new System.Drawing.Point(707, 167);
            this.lstAuxProCod2.Name = "lstAuxProCod2";
            this.lstAuxProCod2.Size = new System.Drawing.Size(76, 355);
            this.lstAuxProCod2.TabIndex = 153;
            this.lstAuxProCod2.Visible = false;
            this.lstAuxProCod2.SelectedIndexChanged += new System.EventHandler(this.lstAuxProCod2_SelectedIndexChanged);
            // 
            // tbxData
            // 
            this.tbxData.Location = new System.Drawing.Point(477, 127);
            this.tbxData.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(225, 20);
            this.tbxData.TabIndex = 154;
            this.tbxData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 599);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.lstAuxProCod2);
            this.Controls.Add(this.lstAuxProCod);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxPedido);
            this.Controls.Add(this.lstAux);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbxMotoboy);
            this.Controls.Add(this.lbxValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gbxLanche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxInfoCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.gbxMotoboy.ResumeLayout(false);
            this.gbxMotoboy.PerformLayout();
            this.gbxLanche.ResumeLayout(false);
            this.gbxCategoria.ResumeLayout(false);
            this.gbxInfoCli.ResumeLayout(false);
            this.gbxInfoCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMotoboy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxValor;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox gbxLanche;
        private System.Windows.Forms.Button btnNvLanche;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnAcompanhamentos;
        private System.Windows.Forms.Button btnMolhos;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnQueijo;
        private System.Windows.Forms.Button btnPCarne;
        private System.Windows.Forms.Button btnBurguer;
        private System.Windows.Forms.Button btnPao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxInfoCli;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbxComp;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox tbxCEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstAux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ComboBox cbxPagto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAndamento;
        private System.Windows.Forms.ListBox lstAuxProCod;
        private System.Windows.Forms.ListBox lstAuxProCod2;
        private System.Windows.Forms.DateTimePicker tbxData;
        public System.Windows.Forms.ListBox lbxPedido;
        private System.Windows.Forms.TextBox lblValorMoto;
    }
}