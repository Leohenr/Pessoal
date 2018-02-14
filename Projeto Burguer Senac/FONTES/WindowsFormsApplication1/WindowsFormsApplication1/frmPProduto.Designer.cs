namespace Burger_Manager
{
    partial class frmPProduto
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
            this.btnIProduto = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grdProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIProduto
            // 
            this.btnIProduto.Location = new System.Drawing.Point(464, 256);
            this.btnIProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnIProduto.Name = "btnIProduto";
            this.btnIProduto.Size = new System.Drawing.Size(104, 37);
            this.btnIProduto.TabIndex = 0;
            this.btnIProduto.Text = "Incluir";
            this.btnIProduto.UseVisualStyleBackColor = true;
            this.btnIProduto.Click += new System.EventHandler(this.btnIProduto_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "CONTÉM",
            "COMEÇA COM"});
            this.cbxTipo.Location = new System.Drawing.Point(122, 11);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(161, 21);
            this.cbxTipo.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 255);
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
            this.txtPesquisa.Location = new System.Drawing.Point(287, 11);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(281, 20);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grdProduto
            // 
            this.grdProduto.AllowUserToAddRows = false;
            this.grdProduto.AllowUserToDeleteRows = false;
            this.grdProduto.AllowUserToOrderColumns = true;
            this.grdProduto.AllowUserToResizeColumns = false;
            this.grdProduto.AllowUserToResizeRows = false;
            this.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduto.Location = new System.Drawing.Point(6, 35);
            this.grdProduto.Margin = new System.Windows.Forms.Padding(2);
            this.grdProduto.MultiSelect = false;
            this.grdProduto.Name = "grdProduto";
            this.grdProduto.ReadOnly = true;
            this.grdProduto.RowTemplate.Height = 24;
            this.grdProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduto.Size = new System.Drawing.Size(562, 214);
            this.grdProduto.TabIndex = 8;
            this.grdProduto.DoubleClick += new System.EventHandler(this.grdProduto_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "NOME DO PRODUTO";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(355, 256);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(104, 37);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmPProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 300);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.grdProduto);
            this.Controls.Add(this.btnIProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.frmPProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIProduto;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView grdProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
    }
}