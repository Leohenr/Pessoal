namespace Burger_Manager
{
    partial class frmPCliente
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
            this.btnICliente = new System.Windows.Forms.Button();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.grdTelefone = new System.Windows.Forms.DataGridView();
            this.txtPTelefone = new System.Windows.Forms.TextBox();
            this.txtGRV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnICliente
            // 
            this.btnICliente.Location = new System.Drawing.Point(883, 254);
            this.btnICliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnICliente.Name = "btnICliente";
            this.btnICliente.Size = new System.Drawing.Size(101, 38);
            this.btnICliente.TabIndex = 0;
            this.btnICliente.Text = "Incluir";
            this.btnICliente.UseVisualStyleBackColor = true;
            this.btnICliente.Click += new System.EventHandler(this.btnICliente_Click);
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AllowUserToOrderColumns = true;
            this.grdCliente.AllowUserToResizeColumns = false;
            this.grdCliente.AllowUserToResizeRows = false;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(9, 35);
            this.grdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.grdCliente.MultiSelect = false;
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RowTemplate.Height = 24;
            this.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCliente.Size = new System.Drawing.Size(728, 214);
            this.grdCliente.TabIndex = 1;
            this.grdCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTelefone_CellClick);
            this.grdCliente.DoubleClick += new System.EventHandler(this.grdCliente_DoubleClick);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "NOME",
            "CPF",
            "CNPJ"});
            this.cbxCategoria.Location = new System.Drawing.Point(10, 11);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(159, 21);
            this.cbxCategoria.TabIndex = 2;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(338, 11);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(399, 20);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.Click += new System.EventHandler(this.txtPesquisa_Click);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(743, 255);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 37);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Contem:",
            "Começa Com:"});
            this.cbxTipo.Location = new System.Drawing.Point(173, 11);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(161, 21);
            this.cbxTipo.TabIndex = 6;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // grdTelefone
            // 
            this.grdTelefone.AllowUserToAddRows = false;
            this.grdTelefone.AllowUserToDeleteRows = false;
            this.grdTelefone.AllowUserToOrderColumns = true;
            this.grdTelefone.AllowUserToResizeColumns = false;
            this.grdTelefone.AllowUserToResizeRows = false;
            this.grdTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTelefone.Location = new System.Drawing.Point(743, 35);
            this.grdTelefone.MultiSelect = false;
            this.grdTelefone.Name = "grdTelefone";
            this.grdTelefone.ReadOnly = true;
            this.grdTelefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTelefone.Size = new System.Drawing.Size(241, 214);
            this.grdTelefone.TabIndex = 7;
            this.grdTelefone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTelefone_CellClick);
            this.grdTelefone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTelefone_CellClick);
            this.grdTelefone.DoubleClick += new System.EventHandler(this.grdTelefone_DoubleClick);
            // 
            // txtPTelefone
            // 
            this.txtPTelefone.Location = new System.Drawing.Point(743, 12);
            this.txtPTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPTelefone.Name = "txtPTelefone";
            this.txtPTelefone.Size = new System.Drawing.Size(241, 20);
            this.txtPTelefone.TabIndex = 8;
            this.txtPTelefone.Text = "PESQUISA TELEFONE";
            this.txtPTelefone.Click += new System.EventHandler(this.textBox1_Click);
            this.txtPTelefone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGRV
            // 
            this.txtGRV.Enabled = false;
            this.txtGRV.Location = new System.Drawing.Point(680, 11);
            this.txtGRV.Name = "txtGRV";
            this.txtGRV.Size = new System.Drawing.Size(57, 20);
            this.txtGRV.TabIndex = 9;
            this.txtGRV.Visible = false;
            this.txtGRV.TextChanged += new System.EventHandler(this.txtGRV_TextChanged);
            // 
            // frmPCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 300);
            this.Controls.Add(this.txtGRV);
            this.Controls.Add(this.txtPTelefone);
            this.Controls.Add(this.grdTelefone);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.btnICliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes";
            this.Load += new System.EventHandler(this.frmPCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnICliente;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.DataGridView grdTelefone;
        private System.Windows.Forms.TextBox txtPTelefone;
        public System.Windows.Forms.TextBox txtGRV;
    }
}