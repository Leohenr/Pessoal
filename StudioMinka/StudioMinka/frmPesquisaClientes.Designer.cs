namespace StudioMinka
{
    partial class frmPesquisaClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbxFiltragem = new System.Windows.Forms.GroupBox();
            this.rbtnTelefone = new System.Windows.Forms.RadioButton();
            this.rbtnEndereco = new System.Windows.Forms.RadioButton();
            this.pbxFiltro = new System.Windows.Forms.PictureBox();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.rbtnCPF = new System.Windows.Forms.RadioButton();
            this.rbtnCNPJ = new System.Windows.Forms.RadioButton();
            this.rbtnNome = new System.Windows.Forms.RadioButton();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbxFiltragem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 73);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1051, 202);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // gbxFiltragem
            // 
            this.gbxFiltragem.Controls.Add(this.rbtnTelefone);
            this.gbxFiltragem.Controls.Add(this.rbtnEndereco);
            this.gbxFiltragem.Controls.Add(this.pbxFiltro);
            this.gbxFiltragem.Controls.Add(this.rbtnEmail);
            this.gbxFiltragem.Controls.Add(this.lblTexto);
            this.gbxFiltragem.Controls.Add(this.rbtnCPF);
            this.gbxFiltragem.Controls.Add(this.rbtnCNPJ);
            this.gbxFiltragem.Controls.Add(this.rbtnNome);
            this.gbxFiltragem.Controls.Add(this.tbxFiltro);
            this.gbxFiltragem.Location = new System.Drawing.Point(281, 10);
            this.gbxFiltragem.Name = "gbxFiltragem";
            this.gbxFiltragem.Size = new System.Drawing.Size(782, 57);
            this.gbxFiltragem.TabIndex = 1;
            this.gbxFiltragem.TabStop = false;
            this.gbxFiltragem.Text = "Filtragem";
            // 
            // rbtnTelefone
            // 
            this.rbtnTelefone.AutoSize = true;
            this.rbtnTelefone.Location = new System.Drawing.Point(389, 26);
            this.rbtnTelefone.Name = "rbtnTelefone";
            this.rbtnTelefone.Size = new System.Drawing.Size(67, 17);
            this.rbtnTelefone.TabIndex = 14;
            this.rbtnTelefone.Text = "Telefone";
            this.rbtnTelefone.UseVisualStyleBackColor = true;
            // 
            // rbtnEndereco
            // 
            this.rbtnEndereco.AutoSize = true;
            this.rbtnEndereco.Location = new System.Drawing.Point(229, 26);
            this.rbtnEndereco.Name = "rbtnEndereco";
            this.rbtnEndereco.Size = new System.Drawing.Size(71, 17);
            this.rbtnEndereco.TabIndex = 5;
            this.rbtnEndereco.Text = "Endereço";
            this.rbtnEndereco.UseVisualStyleBackColor = true;
            // 
            // pbxFiltro
            // 
            this.pbxFiltro.Image = global::StudioMinka.Properties.Resources.limpa_filtro;
            this.pbxFiltro.Location = new System.Drawing.Point(738, 12);
            this.pbxFiltro.Name = "pbxFiltro";
            this.pbxFiltro.Size = new System.Drawing.Size(43, 33);
            this.pbxFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFiltro.TabIndex = 1;
            this.pbxFiltro.TabStop = false;
            this.pbxFiltro.Click += new System.EventHandler(this.pbxFiltro_Click);
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Location = new System.Drawing.Point(318, 26);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(54, 17);
            this.rbtnEmail.TabIndex = 7;
            this.rbtnEmail.Text = "E-Mail";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(462, 28);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(37, 13);
            this.lblTexto.TabIndex = 13;
            this.lblTexto.Text = "Texto:";
            // 
            // rbtnCPF
            // 
            this.rbtnCPF.AutoSize = true;
            this.rbtnCPF.Location = new System.Drawing.Point(80, 26);
            this.rbtnCPF.Name = "rbtnCPF";
            this.rbtnCPF.Size = new System.Drawing.Size(45, 17);
            this.rbtnCPF.TabIndex = 4;
            this.rbtnCPF.Text = "CPF";
            this.rbtnCPF.UseVisualStyleBackColor = true;
            // 
            // rbtnCNPJ
            // 
            this.rbtnCNPJ.AutoSize = true;
            this.rbtnCNPJ.Location = new System.Drawing.Point(152, 26);
            this.rbtnCNPJ.Name = "rbtnCNPJ";
            this.rbtnCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rbtnCNPJ.TabIndex = 3;
            this.rbtnCNPJ.Text = "CNPJ";
            this.rbtnCNPJ.UseVisualStyleBackColor = true;
            // 
            // rbtnNome
            // 
            this.rbtnNome.AutoSize = true;
            this.rbtnNome.Checked = true;
            this.rbtnNome.Location = new System.Drawing.Point(6, 26);
            this.rbtnNome.Name = "rbtnNome";
            this.rbtnNome.Size = new System.Drawing.Size(53, 17);
            this.rbtnNome.TabIndex = 2;
            this.rbtnNome.TabStop = true;
            this.rbtnNome.Text = "Nome";
            this.rbtnNome.UseVisualStyleBackColor = true;
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(505, 25);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(227, 20);
            this.tbxFiltro.TabIndex = 8;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(12, 10);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(103, 57);
            this.btnNovoCliente.TabIndex = 9;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(172, 12);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(103, 57);
            this.btnEditarCliente.TabIndex = 10;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // frmPesquisaClientes
            // 
            this.AcceptButton = this.btnNovoCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 285);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.gbxFiltragem);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisar Clientes";
            this.Load += new System.EventHandler(this.frmPesquisaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbxFiltragem.ResumeLayout(false);
            this.gbxFiltragem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gbxFiltragem;
        private System.Windows.Forms.RadioButton rbtnEndereco;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnCPF;
        private System.Windows.Forms.RadioButton rbtnNome;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.RadioButton rbtnCNPJ;
        private System.Windows.Forms.PictureBox pbxFiltro;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.RadioButton rbtnTelefone;
    }
}