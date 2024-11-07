
namespace ProjectPNET
{
    partial class FormPasien
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
            this.titlepasien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlepasien
            // 
            this.titlepasien.AutoSize = true;
            this.titlepasien.Location = new System.Drawing.Point(361, 58);
            this.titlepasien.Name = "titlepasien";
            this.titlepasien.Size = new System.Drawing.Size(39, 13);
            this.titlepasien.TabIndex = 0;
            this.titlepasien.Text = "Pasien";
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlepasien);
            this.Name = "FormPasien";
            this.Text = "FormPasien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlepasien;
    }
}