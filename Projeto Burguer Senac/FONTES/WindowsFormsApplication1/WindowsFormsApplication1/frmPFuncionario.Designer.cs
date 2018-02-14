namespace Burger_Manager
{
    partial class frmPFuncionario
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
            this.btnIFuncionario = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.grdFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIFuncionario
            // 
            this.btnIFuncionario.Location = new System.Drawing.Point(827, 249);
            this.btnIFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnIFuncionario.Name = "btnIFuncionario";
            this.btnIFuncionario.Size = new System.Drawing.Size(100, 38);
            this.btnIFuncionario.TabIndex = 0;
            this.btnIFuncionario.Text = "Incluir";
            this.btnIFuncionario.UseVisualStyleBackColor = true;
            this.btnIFuncionario.Click += new System.EventHandler(this.btnIFuncionario_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "CONTÉM",
            "COMEÇA COM"});
            this.cbxTipo.Location = new System.Drawing.Point(258, 6);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(207, 21);
            this.cbxTipo.TabIndex = 13;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(722, 250);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 37);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(469, 6);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(458, 20);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "CPF",
            "NOME",
            "USUARIO"});
            this.cbxCategoria.Location = new System.Drawing.Point(10, 6);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(244, 21);
            this.cbxCategoria.TabIndex = 9;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // grdFuncionarios
            // 
            this.grdFuncionarios.AllowUserToAddRows = false;
            this.grdFuncionarios.AllowUserToDeleteRows = false;
            this.grdFuncionarios.AllowUserToOrderColumns = true;
            this.grdFuncionarios.AllowUserToResizeColumns = false;
            this.grdFuncionarios.AllowUserToResizeRows = false;
            this.grdFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFuncionarios.Location = new System.Drawing.Point(9, 31);
            this.grdFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.grdFuncionarios.MultiSelect = false;
            this.grdFuncionarios.Name = "grdFuncionarios";
            this.grdFuncionarios.ReadOnly = true;
            this.grdFuncionarios.RowTemplate.Height = 24;
            this.grdFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFuncionarios.Size = new System.Drawing.Size(918, 214);
            this.grdFuncionarios.TabIndex = 8;
            this.grdFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFuncionarios_CellContentClick);
            this.grdFuncionarios.DoubleClick += new System.EventHandler(this.grdFuncionarios_DoubleClick);
            // 
            // frmPFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 298);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.grdFuncionarios);
            this.Controls.Add(this.btnIFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Funcionários";
            this.Load += new System.EventHandler(this.frmPFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIFuncionario;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DataGridView grdFuncionarios;
    }
}