namespace Burger_Manager
{
    partial class frmCCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCCliente));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPJ = new System.Windows.Forms.RadioButton();
            this.rdbPF = new System.Windows.Forms.RadioButton();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lstTelefones = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 337);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 90);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 92);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbPJ);
            this.groupBox1.Controls.Add(this.rdbPF);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(192, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(932, 321);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(112, 125);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(300, 31);
            this.txtCNPJ.TabIndex = 30;
            this.txtCNPJ.Visible = false;
            this.txtCNPJ.TextChanged += new System.EventHandler(this.txtCNPJ_TextChanged);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(666, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(234, 31);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(574, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Código";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(804, 173);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(98, 31);
            this.txtUF.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(754, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(424, 173);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(318, 31);
            this.txtCidade.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cidade";
            // 
            // rdbPJ
            // 
            this.rdbPJ.AutoSize = true;
            this.rdbPJ.Location = new System.Drawing.Point(204, 33);
            this.rdbPJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPJ.Name = "rdbPJ";
            this.rdbPJ.Size = new System.Drawing.Size(196, 29);
            this.rdbPJ.TabIndex = 20;
            this.rdbPJ.Text = "Pessoa Juridica";
            this.rdbPJ.UseVisualStyleBackColor = true;
            this.rdbPJ.CheckedChanged += new System.EventHandler(this.rdbPJ_CheckedChanged);
            // 
            // rdbPF
            // 
            this.rdbPF.AutoSize = true;
            this.rdbPF.Checked = true;
            this.rdbPF.Location = new System.Drawing.Point(16, 33);
            this.rdbPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPF.Name = "rdbPF";
            this.rdbPF.Size = new System.Drawing.Size(178, 29);
            this.rdbPF.TabIndex = 19;
            this.rdbPF.TabStop = true;
            this.rdbPF.Text = "Pessoa Fisica";
            this.rdbPF.UseVisualStyleBackColor = true;
            this.rdbPF.CheckedChanged += new System.EventHandler(this.rdbPF_CheckedChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(538, 127);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(364, 31);
            this.txtBairro.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(446, 265);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComplemento.MaxLength = 5;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(456, 31);
            this.txtComplemento.TabIndex = 16;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(114, 265);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(170, 31);
            this.txtNumero.TabIndex = 15;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(112, 219);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(790, 31);
            this.txtEndereco.TabIndex = 14;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(112, 171);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(184, 31);
            this.txtCEP.TabIndex = 13;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(112, 125);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(300, 31);
            this.txtCPF.TabIndex = 10;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 81);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(790, 31);
            this.txtNome.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Endereço";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 129);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(54, 25);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(1244, 21);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(246, 31);
            this.txtTelefone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1128, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefones";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(384, 337);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(40, 38);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(546, 77);
            this.webBrowser1.TabIndex = 19;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // lstTelefones
            // 
            this.lstTelefones.FormattingEnabled = true;
            this.lstTelefones.ItemHeight = 25;
            this.lstTelefones.Location = new System.Drawing.Point(1134, 138);
            this.lstTelefones.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstTelefones.Name = "lstTelefones";
            this.lstTelefones.Size = new System.Drawing.Size(356, 279);
            this.lstTelefones.TabIndex = 23;
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::Burger_Manager.Properties.Resources.math_minus_icon;
            this.btnRemover.Location = new System.Drawing.Point(1244, 65);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(64, 62);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::Burger_Manager.Properties.Resources.add_icon;
            this.btnAdicionar.Location = new System.Drawing.Point(1430, 65);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(64, 62);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Burger_Manager.Properties.Resources._1455337589_kuser;
            this.pictureBox1.Location = new System.Drawing.Point(20, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmCCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 438);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lstTelefones);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCCliente_Load);
            this.Leave += new System.EventHandler(this.frmCCliente_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.RadioButton rdbPJ;
        public System.Windows.Forms.RadioButton rdbPF;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtCEP;
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.TextBox txtCPF;
        public System.Windows.Forms.TextBox txtUF;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.ListBox lstTelefones;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtCNPJ;
    }
}