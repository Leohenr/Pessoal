namespace StudioMinka
{
    partial class frmEditaFuncionarios
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.gbxLogradouro = new System.Windows.Forms.GroupBox();
            this.tbxUF = new System.Windows.Forms.TextBox();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.tbxComplemento = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxCEP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxInfoPessoais = new System.Windows.Forms.GroupBox();
            this.mtbxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbxTelefones = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRmv = new System.Windows.Forms.Button();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbxLogradouro.SuspendLayout();
            this.gbxInfoPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(328, 415);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(55, 35);
            this.webBrowser1.TabIndex = 29;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // gbxLogradouro
            // 
            this.gbxLogradouro.Controls.Add(this.tbxUF);
            this.gbxLogradouro.Controls.Add(this.tbxCidade);
            this.gbxLogradouro.Controls.Add(this.tbxComplemento);
            this.gbxLogradouro.Controls.Add(this.tbxNumero);
            this.gbxLogradouro.Controls.Add(this.tbxBairro);
            this.gbxLogradouro.Controls.Add(this.tbxEndereco);
            this.gbxLogradouro.Controls.Add(this.tbxCEP);
            this.gbxLogradouro.Controls.Add(this.label12);
            this.gbxLogradouro.Controls.Add(this.label6);
            this.gbxLogradouro.Controls.Add(this.label11);
            this.gbxLogradouro.Controls.Add(this.label9);
            this.gbxLogradouro.Controls.Add(this.label8);
            this.gbxLogradouro.Controls.Add(this.label7);
            this.gbxLogradouro.Controls.Add(this.label10);
            this.gbxLogradouro.Location = new System.Drawing.Point(12, 247);
            this.gbxLogradouro.Name = "gbxLogradouro";
            this.gbxLogradouro.Size = new System.Drawing.Size(495, 136);
            this.gbxLogradouro.TabIndex = 15;
            this.gbxLogradouro.TabStop = false;
            this.gbxLogradouro.Text = "Logradouro";
            // 
            // tbxUF
            // 
            this.tbxUF.Location = new System.Drawing.Point(388, 101);
            this.tbxUF.MaxLength = 2;
            this.tbxUF.Name = "tbxUF";
            this.tbxUF.Size = new System.Drawing.Size(82, 20);
            this.tbxUF.TabIndex = 22;
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(68, 101);
            this.tbxCidade.MaxLength = 100;
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(271, 20);
            this.tbxCidade.TabIndex = 21;
            // 
            // tbxComplemento
            // 
            this.tbxComplemento.Location = new System.Drawing.Point(258, 75);
            this.tbxComplemento.MaxLength = 40;
            this.tbxComplemento.Name = "tbxComplemento";
            this.tbxComplemento.Size = new System.Drawing.Size(212, 20);
            this.tbxComplemento.TabIndex = 20;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(68, 75);
            this.tbxNumero.MaxLength = 10;
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(82, 20);
            this.tbxNumero.TabIndex = 19;
            // 
            // tbxBairro
            // 
            this.tbxBairro.Location = new System.Drawing.Point(258, 22);
            this.tbxBairro.MaxLength = 100;
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.Size = new System.Drawing.Size(212, 20);
            this.tbxBairro.TabIndex = 17;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(68, 49);
            this.tbxEndereco.MaxLength = 100;
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(402, 20);
            this.tbxEndereco.TabIndex = 18;
            // 
            // tbxCEP
            // 
            this.tbxCEP.Location = new System.Drawing.Point(68, 22);
            this.tbxCEP.MaxLength = 10;
            this.tbxCEP.Name = "tbxCEP";
            this.tbxCEP.Size = new System.Drawing.Size(114, 20);
            this.tbxCEP.TabIndex = 16;
            this.tbxCEP.Leave += new System.EventHandler(this.tbxCEP_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "UF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CEP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Bairro";
            // 
            // gbxInfoPessoais
            // 
            this.gbxInfoPessoais.Controls.Add(this.label2);
            this.gbxInfoPessoais.Controls.Add(this.cbxFuncao);
            this.gbxInfoPessoais.Controls.Add(this.mtbxCPF);
            this.gbxInfoPessoais.Controls.Add(this.mtbxTelefone);
            this.gbxInfoPessoais.Controls.Add(this.btnRmv);
            this.gbxInfoPessoais.Controls.Add(this.pbxCliente);
            this.gbxInfoPessoais.Controls.Add(this.btnAdd);
            this.gbxInfoPessoais.Controls.Add(this.lbxTelefones);
            this.gbxInfoPessoais.Controls.Add(this.label13);
            this.gbxInfoPessoais.Controls.Add(this.tbxEmail);
            this.gbxInfoPessoais.Controls.Add(this.tbxNome);
            this.gbxInfoPessoais.Controls.Add(this.lblNome);
            this.gbxInfoPessoais.Controls.Add(this.lblCPF);
            this.gbxInfoPessoais.Controls.Add(this.label5);
            this.gbxInfoPessoais.Location = new System.Drawing.Point(12, 12);
            this.gbxInfoPessoais.Name = "gbxInfoPessoais";
            this.gbxInfoPessoais.Size = new System.Drawing.Size(495, 175);
            this.gbxInfoPessoais.TabIndex = 1;
            this.gbxInfoPessoais.TabStop = false;
            this.gbxInfoPessoais.Text = "Informações Pessoais";
            // 
            // mtbxCPF
            // 
            this.mtbxCPF.Location = new System.Drawing.Point(58, 45);
            this.mtbxCPF.Name = "mtbxCPF";
            this.mtbxCPF.Size = new System.Drawing.Size(120, 20);
            this.mtbxCPF.TabIndex = 3;
            // 
            // mtbxTelefone
            // 
            this.mtbxTelefone.Location = new System.Drawing.Point(58, 101);
            this.mtbxTelefone.Name = "mtbxTelefone";
            this.mtbxTelefone.Size = new System.Drawing.Size(123, 20);
            this.mtbxTelefone.TabIndex = 6;
            this.mtbxTelefone.Leave += new System.EventHandler(this.mtbxTelefone_Leave);
            // 
            // lbxTelefones
            // 
            this.lbxTelefones.FormattingEnabled = true;
            this.lbxTelefones.Location = new System.Drawing.Point(241, 98);
            this.lbxTelefones.Name = "lbxTelefones";
            this.lbxTelefones.Size = new System.Drawing.Size(140, 56);
            this.lbxTelefones.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Telefone";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(58, 72);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(323, 20);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(58, 19);
            this.tbxNome.MaxLength = 100;
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(323, 20);
            this.tbxNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 48);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-Mail";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(299, 389);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(94, 20);
            this.tbxCodigo.TabIndex = 24;
            this.tbxCodigo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo";
            this.label1.Visible = false;
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(229, 44);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(152, 21);
            this.cbxFuncao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Função";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::StudioMinka.Properties.Resources.excluir;
            this.btnCancelar.Location = new System.Drawing.Point(12, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 54);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRmv
            // 
            this.btnRmv.Enabled = false;
            this.btnRmv.Image = global::StudioMinka.Properties.Resources.menos;
            this.btnRmv.Location = new System.Drawing.Point(212, 102);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(23, 20);
            this.btnRmv.TabIndex = 9;
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // pbxCliente
            // 
            this.pbxCliente.Image = global::StudioMinka.Properties.Resources.usuarios;
            this.pbxCliente.Location = new System.Drawing.Point(387, 28);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(97, 60);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 18;
            this.pbxCliente.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::StudioMinka.Properties.Resources.mais;
            this.btnAdd.Location = new System.Drawing.Point(184, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(22, 20);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::StudioMinka.Properties.Resources.selecionado;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.Location = new System.Drawing.Point(406, 389);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 54);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseCompatibleTextRendering = true;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.radioButton2);
            this.gbxLogin.Controls.Add(this.radioButton1);
            this.gbxLogin.Controls.Add(this.textBox2);
            this.gbxLogin.Controls.Add(this.textBox1);
            this.gbxLogin.Controls.Add(this.label4);
            this.gbxLogin.Controls.Add(this.label3);
            this.gbxLogin.Location = new System.Drawing.Point(12, 193);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(495, 48);
            this.gbxLogin.TabIndex = 10;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Informações de Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 22);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 22);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(358, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ativo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(413, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Inativo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmEditaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 461);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxLogradouro);
            this.Controls.Add(this.gbxInfoPessoais);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditaFuncionarios";
            this.gbxLogradouro.ResumeLayout(false);
            this.gbxLogradouro.PerformLayout();
            this.gbxInfoPessoais.ResumeLayout(false);
            this.gbxInfoPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxLogradouro;
        private System.Windows.Forms.TextBox tbxUF;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.TextBox tbxComplemento;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxCEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbxInfoPessoais;
        private System.Windows.Forms.MaskedTextBox mtbxCPF;
        private System.Windows.Forms.MaskedTextBox mtbxTelefone;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxTelefones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFuncao;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}