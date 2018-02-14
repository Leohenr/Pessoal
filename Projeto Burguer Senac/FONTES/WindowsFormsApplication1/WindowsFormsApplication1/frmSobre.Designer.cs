namespace Burger_Manager
{
    partial class frmSobre
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
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Location = new System.Drawing.Point(42, 37);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(35, 13);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "label1";
            this.lblSobre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(42, 276);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(35, 13);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Burger_Manager.Properties.Resources.LOGO_SYSTEM_MANAGER;
            this.pictureBox1.Location = new System.Drawing.Point(308, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 351);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.lblSobre);
            this.Name = "frmSobre";
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}