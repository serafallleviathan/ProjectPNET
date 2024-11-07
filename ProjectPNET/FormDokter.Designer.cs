
namespace ProjectPNET
{
    partial class FormDokter
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
            this.titledokter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titledokter
            // 
            this.titledokter.AutoSize = true;
            this.titledokter.Location = new System.Drawing.Point(366, 48);
            this.titledokter.Name = "titledokter";
            this.titledokter.Size = new System.Drawing.Size(39, 13);
            this.titledokter.TabIndex = 0;
            this.titledokter.Text = "Dokter";
            // 
            // FormDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titledokter);
            this.Name = "FormDokter";
            this.Text = "FormDokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titledokter;
    }
}