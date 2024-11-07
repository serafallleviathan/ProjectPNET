
namespace ProjectPNET
{
    partial class FormJadwal
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
            this.titlejadwal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlejadwal
            // 
            this.titlejadwal.AutoSize = true;
            this.titlejadwal.Location = new System.Drawing.Point(361, 33);
            this.titlejadwal.Name = "titlejadwal";
            this.titlejadwal.Size = new System.Drawing.Size(40, 13);
            this.titlejadwal.TabIndex = 0;
            this.titlejadwal.Text = "Jadwal";
            // 
            // FormJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlejadwal);
            this.Name = "FormJadwal";
            this.Text = "FormJadwal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlejadwal;
    }
}