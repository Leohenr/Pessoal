namespace Burger_Manager
{
    partial class frmAndamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdAndamento = new System.Windows.Forms.DataGridView();
            this.andamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAndamento)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAndamento
            // 
            this.grdAndamento.AllowUserToAddRows = false;
            this.grdAndamento.AllowUserToDeleteRows = false;
            this.grdAndamento.AllowUserToOrderColumns = true;
            this.grdAndamento.AllowUserToResizeColumns = false;
            this.grdAndamento.AllowUserToResizeRows = false;
            this.grdAndamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAndamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.andamento});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAndamento.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdAndamento.Location = new System.Drawing.Point(36, 26);
            this.grdAndamento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdAndamento.MultiSelect = false;
            this.grdAndamento.Name = "grdAndamento";
            this.grdAndamento.ReadOnly = true;
            this.grdAndamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAndamento.Size = new System.Drawing.Size(1282, 308);
            this.grdAndamento.TabIndex = 0;
            this.grdAndamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAndamento_CellContentClick);
            this.grdAndamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdAndamento_CellFormatting);
            this.grdAndamento.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdAndamento_RowPrePaint);
            // 
            // andamento
            // 
            this.andamento.HeaderText = "ANDAMENTO";
            this.andamento.Name = "andamento";
            this.andamento.ReadOnly = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1168, 346);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 79);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1006, 346);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 79);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(36, 346);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(150, 79);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmAndamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 437);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grdAndamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAndamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Andamento";
            this.Load += new System.EventHandler(this.frmAndamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAndamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAndamento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn andamento;

    }
}