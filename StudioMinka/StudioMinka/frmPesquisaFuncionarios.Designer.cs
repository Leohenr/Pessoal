namespace StudioMinka
{
    partial class frmPesquisaFuncionarios
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.gbxFiltragem = new System.Windows.Forms.GroupBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.rbtnTelefone = new System.Windows.Forms.RadioButton();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnCPF = new System.Windows.Forms.RadioButton();
            this.rbtnNome = new System.Windows.Forms.RadioButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pbxFiltro = new System.Windows.Forms.PictureBox();
            this.gbxFiltragem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 57);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(166, 132);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(103, 57);
            this.btnNovoCliente.TabIndex = 7;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // gbxFiltragem
            // 
            this.gbxFiltragem.Controls.Add(this.lblTexto);
            this.gbxFiltragem.Controls.Add(this.pbxFiltro);
            this.gbxFiltragem.Controls.Add(this.rbtnTelefone);
            this.gbxFiltragem.Controls.Add(this.tbxFiltro);
            this.gbxFiltragem.Controls.Add(this.rbtnEmail);
            this.gbxFiltragem.Controls.Add(this.rbtnCPF);
            this.gbxFiltragem.Controls.Add(this.rbtnNome);
            this.gbxFiltragem.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltragem.Name = "gbxFiltragem";
            this.gbxFiltragem.Size = new System.Drawing.Size(257, 87);
            this.gbxFiltragem.TabIndex = 1;
            this.gbxFiltragem.TabStop = false;
            this.gbxFiltragem.Text = "Filtragem";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(7, 51);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(37, 13);
            this.lblTexto.TabIndex = 13;
            this.lblTexto.Text = "Texto:";
            // 
            // rbtnTelefone
            // 
            this.rbtnTelefone.AutoSize = true;
            this.rbtnTelefone.Location = new System.Drawing.Point(116, 19);
            this.rbtnTelefone.Name = "rbtnTelefone";
            this.rbtnTelefone.Size = new System.Drawing.Size(67, 17);
            this.rbtnTelefone.TabIndex = 4;
            this.rbtnTelefone.Text = "Telefone";
            this.rbtnTelefone.UseVisualStyleBackColor = true;
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(50, 48);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(144, 20);
            this.tbxFiltro.TabIndex = 6;
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Location = new System.Drawing.Point(189, 19);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(54, 17);
            this.rbtnEmail.TabIndex = 5;
            this.rbtnEmail.Text = "E-Mail";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            // 
            // rbtnCPF
            // 
            this.rbtnCPF.AutoSize = true;
            this.rbtnCPF.Location = new System.Drawing.Point(65, 19);
            this.rbtnCPF.Name = "rbtnCPF";
            this.rbtnCPF.Size = new System.Drawing.Size(45, 17);
            this.rbtnCPF.TabIndex = 3;
            this.rbtnCPF.Text = "CPF";
            this.rbtnCPF.UseVisualStyleBackColor = true;
            // 
            // rbtnNome
            // 
            this.rbtnNome.AutoSize = true;
            this.rbtnNome.Checked = true;
            this.rbtnNome.Location = new System.Drawing.Point(6, 19);
            this.rbtnNome.Name = "rbtnNome";
            this.rbtnNome.Size = new System.Drawing.Size(53, 17);
            this.rbtnNome.TabIndex = 2;
            this.rbtnNome.TabStop = true;
            this.rbtnNome.Text = "Nome";
            this.rbtnNome.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(275, 14);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(788, 175);
            this.dgvClientes.TabIndex = 16;
            // 
            // pbxFiltro
            // 
            this.pbxFiltro.Image = global::StudioMinka.Properties.Resources.filtro;
            this.pbxFiltro.Location = new System.Drawing.Point(208, 42);
            this.pbxFiltro.Name = "pbxFiltro";
            this.pbxFiltro.Size = new System.Drawing.Size(43, 33);
            this.pbxFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFiltro.TabIndex = 1;
            this.pbxFiltro.TabStop = false;
            this.pbxFiltro.Click += new System.EventHandler(this.pbxFiltro_Click);
            // 
            // frmPesquisaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 198);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.gbxFiltragem);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPesquisaFuncionarios";
            this.gbxFiltragem.ResumeLayout(false);
            this.gbxFiltragem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.GroupBox gbxFiltragem;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.PictureBox pbxFiltro;
        private System.Windows.Forms.RadioButton rbtnTelefone;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnCPF;
        private System.Windows.Forms.RadioButton rbtnNome;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}