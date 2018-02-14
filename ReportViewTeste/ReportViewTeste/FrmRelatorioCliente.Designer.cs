namespace ReportViewTeste
{
    partial class FrmRelatorioCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportViewTesteDataSet = new ReportViewTeste.ReportViewTesteDataSet();
            this.tb_clientes_cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clientes_cliTableAdapter = new ReportViewTeste.ReportViewTesteDataSetTableAdapters.tb_clientes_cliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewTesteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clientes_cliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_clientes_cliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewTeste.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(648, 301);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportViewTesteDataSet
            // 
            this.ReportViewTesteDataSet.DataSetName = "ReportViewTesteDataSet";
            this.ReportViewTesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clientes_cliBindingSource
            // 
            this.tb_clientes_cliBindingSource.DataMember = "tb_clientes_cli";
            this.tb_clientes_cliBindingSource.DataSource = this.ReportViewTesteDataSet;
            // 
            // tb_clientes_cliTableAdapter
            // 
            this.tb_clientes_cliTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRelatorioCliente";
            this.Load += new System.EventHandler(this.FrmRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewTesteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clientes_cliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_clientes_cliBindingSource;
        private ReportViewTesteDataSet ReportViewTesteDataSet;
        private ReportViewTesteDataSetTableAdapters.tb_clientes_cliTableAdapter tb_clientes_cliTableAdapter;
    }
}