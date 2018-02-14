namespace Burger_Manager
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mstCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tstFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tstProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mstDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.tstNvPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tstAndamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tstSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tstSair = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusstrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDuracao = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsCadF = new System.Windows.Forms.ToolStripButton();
            this.tsCadP = new System.Windows.Forms.ToolStripButton();
            this.tsCadC = new System.Windows.Forms.ToolStripButton();
            this.tsCadD = new System.Windows.Forms.ToolStripButton();
            this.tsCadSP = new System.Windows.Forms.ToolStripButton();
            this.tsCadSb = new System.Windows.Forms.ToolStripButton();
            this.tsCadExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstCadastros,
            this.mstDelivery,
            this.tstSobre,
            this.tstSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mstCadastros
            // 
            this.mstCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstFuncionarios,
            this.tstProdutos,
            this.tstCliente});
            this.mstCadastros.Name = "mstCadastros";
            this.mstCadastros.Size = new System.Drawing.Size(71, 20);
            this.mstCadastros.Text = "Cadastros";
            // 
            // tstFuncionarios
            // 
            this.tstFuncionarios.Name = "tstFuncionarios";
            this.tstFuncionarios.Size = new System.Drawing.Size(142, 22);
            this.tstFuncionarios.Text = "Funcionarios";
            this.tstFuncionarios.Click += new System.EventHandler(this.tstFuncionarios_Click);
            // 
            // tstProdutos
            // 
            this.tstProdutos.Name = "tstProdutos";
            this.tstProdutos.Size = new System.Drawing.Size(142, 22);
            this.tstProdutos.Text = "Produtos";
            this.tstProdutos.Click += new System.EventHandler(this.tstProdutos_Click);
            // 
            // tstCliente
            // 
            this.tstCliente.Name = "tstCliente";
            this.tstCliente.Size = new System.Drawing.Size(142, 22);
            this.tstCliente.Text = "Cliente";
            this.tstCliente.Click += new System.EventHandler(this.tstCliente_Click);
            // 
            // mstDelivery
            // 
            this.mstDelivery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstNvPedido,
            this.tstAndamento});
            this.mstDelivery.Name = "mstDelivery";
            this.mstDelivery.Size = new System.Drawing.Size(61, 20);
            this.mstDelivery.Text = "Delivery";
            this.mstDelivery.Click += new System.EventHandler(this.mstDelivery_Click);
            // 
            // tstNvPedido
            // 
            this.tstNvPedido.Name = "tstNvPedido";
            this.tstNvPedido.Size = new System.Drawing.Size(186, 22);
            this.tstNvPedido.Text = "Novo Pedido";
            this.tstNvPedido.Click += new System.EventHandler(this.tstNvPedido_Click);
            // 
            // tstAndamento
            // 
            this.tstAndamento.Name = "tstAndamento";
            this.tstAndamento.Size = new System.Drawing.Size(186, 22);
            this.tstAndamento.Text = "Situação dos Pedidos";
            this.tstAndamento.Click += new System.EventHandler(this.tstAndamento_Click);
            // 
            // tstSobre
            // 
            this.tstSobre.Name = "tstSobre";
            this.tstSobre.Size = new System.Drawing.Size(49, 20);
            this.tstSobre.Text = "Sobre";
            this.tstSobre.Click += new System.EventHandler(this.tstSobre_Click);
            // 
            // tstSair
            // 
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(38, 20);
            this.tstSair.Text = "Sair";
            this.tstSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusstrip
            // 
            this.statusstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblDuracao});
            this.statusstrip.Location = new System.Drawing.Point(0, 452);
            this.statusstrip.Name = "statusstrip";
            this.statusstrip.Size = new System.Drawing.Size(755, 22);
            this.statusstrip.TabIndex = 4;
            this.statusstrip.Text = "statusStrip1";
            this.statusstrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusstrip_ItemClicked);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(370, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário: ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDuracao
            // 
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(370, 17);
            this.lblDuracao.Spring = true;
            this.lblDuracao.Text = "Duração: 00:00:00";
            this.lblDuracao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadF,
            this.tsCadP,
            this.tsCadC,
            this.tsCadD,
            this.tsCadSP,
            this.tsCadSb,
            this.tsCadExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(755, 54);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tsCadF
            // 
            this.tsCadF.Image = global::Burger_Manager.Properties.Resources._1455761997_Business_People_01;
            this.tsCadF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCadF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadF.Name = "tsCadF";
            this.tsCadF.Size = new System.Drawing.Size(101, 51);
            this.tsCadF.Text = "Cad. Funcionário";
            this.tsCadF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsCadF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCadF.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsCadP
            // 
            this.tsCadP.Image = global::Burger_Manager.Properties.Resources._1455760722_shopping_add;
            this.tsCadP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCadP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadP.Name = "tsCadP";
            this.tsCadP.Size = new System.Drawing.Size(81, 51);
            this.tsCadP.Text = "Cad. Produto";
            this.tsCadP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCadP.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsCadC
            // 
            this.tsCadC.Image = global::Burger_Manager.Properties.Resources._1455761677_emblem_people;
            this.tsCadC.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCadC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadC.Name = "tsCadC";
            this.tsCadC.Size = new System.Drawing.Size(75, 51);
            this.tsCadC.Text = "Cad. Cliente";
            this.tsCadC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCadC.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsCadD
            // 
            this.tsCadD.Image = global::Burger_Manager.Properties.Resources._1455761929_fast_food;
            this.tsCadD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCadD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadD.Name = "tsCadD";
            this.tsCadD.Size = new System.Drawing.Size(53, 51);
            this.tsCadD.Text = "Delivery";
            this.tsCadD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsCadD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCadD.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsCadSP
            // 
            this.tsCadSP.Image = global::Burger_Manager.Properties.Resources._121;
            this.tsCadSP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadSP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCadSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadSP.Name = "tsCadSP";
            this.tsCadSP.Size = new System.Drawing.Size(96, 51);
            this.tsCadSP.Text = "Situação Pedido";
            this.tsCadSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCadSP.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsCadSb
            // 
            this.tsCadSb.Image = global::Burger_Manager.Properties.Resources._1455762274_19;
            this.tsCadSb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadSb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCadSb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadSb.Name = "tsCadSb";
            this.tsCadSb.Size = new System.Drawing.Size(41, 51);
            this.tsCadSb.Text = "Sobre";
            this.tsCadSb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadSb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCadSb.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tsCadExit
            // 
            this.tsCadExit.Image = global::Burger_Manager.Properties.Resources._1455762291_exit;
            this.tsCadExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCadExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadExit.Name = "tsCadExit";
            this.tsCadExit.Size = new System.Drawing.Size(36, 51);
            this.tsCadExit.Text = "Sair";
            this.tsCadExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCadExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCadExit.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 474);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.statusstrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPrincipal_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusstrip.ResumeLayout(false);
            this.statusstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mstCadastros;
        private System.Windows.Forms.ToolStripMenuItem tstFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem tstProdutos;
        private System.Windows.Forms.ToolStripMenuItem mstDelivery;
        private System.Windows.Forms.ToolStripMenuItem tstCliente;
        private System.Windows.Forms.ToolStripMenuItem tstNvPedido;
        private System.Windows.Forms.ToolStripMenuItem tstAndamento;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusstrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblDuracao;
        private System.Windows.Forms.ToolStripMenuItem tstSobre;
        private System.Windows.Forms.ToolStripMenuItem tstSair;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton tsCadF;
        private System.Windows.Forms.ToolStripButton tsCadP;
        private System.Windows.Forms.ToolStripButton tsCadC;
        private System.Windows.Forms.ToolStripButton tsCadD;
        private System.Windows.Forms.ToolStripButton tsCadSP;
        private System.Windows.Forms.ToolStripButton tsCadSb;
        private System.Windows.Forms.ToolStripButton tsCadExit;

    }
}

