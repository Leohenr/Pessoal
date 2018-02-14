namespace ReportViewTeste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReportCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportCliente
            // 
            this.btnReportCliente.Location = new System.Drawing.Point(12, 12);
            this.btnReportCliente.Name = "btnReportCliente";
            this.btnReportCliente.Size = new System.Drawing.Size(636, 297);
            this.btnReportCliente.TabIndex = 0;
            this.btnReportCliente.Text = "Gerar Relatorio Cliente";
            this.btnReportCliente.UseVisualStyleBackColor = true;
            this.btnReportCliente.Click += new System.EventHandler(this.btnReportCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 321);
            this.Controls.Add(this.btnReportCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportViewTeste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportCliente;
    }
}

