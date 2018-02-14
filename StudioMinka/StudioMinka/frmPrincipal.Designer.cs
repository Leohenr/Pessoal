namespace StudioMinka
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
            this.navMenus = new System.Windows.Forms.BindingNavigator(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusstrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDuracao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCadastros = new System.Windows.Forms.ToolStripButton();
            this.tsLancamentos = new System.Windows.Forms.ToolStripButton();
            this.tsContas = new System.Windows.Forms.ToolStripButton();
            this.tsRelatorios = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navMenus)).BeginInit();
            this.navMenus.SuspendLayout();
            this.statusstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenus
            // 
            this.navMenus.AddNewItem = null;
            this.navMenus.CountItem = null;
            this.navMenus.DeleteItem = null;
            resources.ApplyResources(this.navMenus, "navMenus");
            this.navMenus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadastros,
            this.tsLancamentos,
            this.tsContas,
            this.tsRelatorios});
            this.navMenus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.navMenus.MoveFirstItem = null;
            this.navMenus.MoveLastItem = null;
            this.navMenus.MoveNextItem = null;
            this.navMenus.MovePreviousItem = null;
            this.navMenus.Name = "navMenus";
            this.navMenus.PositionItem = null;
            this.navMenus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusstrip
            // 
            this.statusstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblDuracao});
            resources.ApplyResources(this.statusstrip, "statusstrip");
            this.statusstrip.Name = "statusstrip";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Spring = true;
            // 
            // lblDuracao
            // 
            this.lblDuracao.Name = "lblDuracao";
            resources.ApplyResources(this.lblDuracao, "lblDuracao");
            this.lblDuracao.Spring = true;
            // 
            // tsCadastros
            // 
            this.tsCadastros.Image = global::StudioMinka.Properties.Resources.editar;
            resources.ApplyResources(this.tsCadastros, "tsCadastros");
            this.tsCadastros.Name = "tsCadastros";
            this.tsCadastros.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tsCadastros.Click += new System.EventHandler(this.tsCadastros_Click);
            // 
            // tsLancamentos
            // 
            this.tsLancamentos.Image = global::StudioMinka.Properties.Resources.lista;
            resources.ApplyResources(this.tsLancamentos, "tsLancamentos");
            this.tsLancamentos.Name = "tsLancamentos";
            this.tsLancamentos.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tsLancamentos.Click += new System.EventHandler(this.tsLancamentos_Click);
            // 
            // tsContas
            // 
            this.tsContas.Image = global::StudioMinka.Properties.Resources.contas2;
            resources.ApplyResources(this.tsContas, "tsContas");
            this.tsContas.Name = "tsContas";
            this.tsContas.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tsContas.Click += new System.EventHandler(this.tsContas_Click);
            // 
            // tsRelatorios
            // 
            this.tsRelatorios.Image = global::StudioMinka.Properties.Resources.relatorio;
            resources.ApplyResources(this.tsRelatorios, "tsRelatorios");
            this.tsRelatorios.Name = "tsRelatorios";
            this.tsRelatorios.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tsRelatorios.Click += new System.EventHandler(this.tsRelatorios_Click);
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusstrip);
            this.Controls.Add(this.navMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.navMenus)).EndInit();
            this.navMenus.ResumeLayout(false);
            this.navMenus.PerformLayout();
            this.statusstrip.ResumeLayout(false);
            this.statusstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator navMenus;
        private System.Windows.Forms.ToolStripButton tsCadastros;
        private System.Windows.Forms.ToolStripButton tsLancamentos;
        private System.Windows.Forms.ToolStripButton tsContas;
        private System.Windows.Forms.ToolStripButton tsRelatorios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusstrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblDuracao;
    }
}

