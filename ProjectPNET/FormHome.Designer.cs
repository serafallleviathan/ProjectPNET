
namespace ProjectPNET
{
    partial class FormHome
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
            this.titlehome = new System.Windows.Forms.Label();
            this.btnpasien = new System.Windows.Forms.Button();
            this.btndokter = new System.Windows.Forms.Button();
            this.btnjadwal = new System.Windows.Forms.Button();
            this.btnprofile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlehome
            // 
            this.titlehome.AutoSize = true;
            this.titlehome.Location = new System.Drawing.Point(382, 26);
            this.titlehome.Name = "titlehome";
            this.titlehome.Size = new System.Drawing.Size(39, 13);
            this.titlehome.TabIndex = 0;
            this.titlehome.Text = "HOME";
            // 
            // btnpasien
            // 
            this.btnpasien.Location = new System.Drawing.Point(206, 132);
            this.btnpasien.Name = "btnpasien";
            this.btnpasien.Size = new System.Drawing.Size(397, 48);
            this.btnpasien.TabIndex = 1;
            this.btnpasien.Text = "Pasien";
            this.btnpasien.UseVisualStyleBackColor = true;
            this.btnpasien.Click += new System.EventHandler(this.btnpasien_Click);
            // 
            // btndokter
            // 
            this.btndokter.Location = new System.Drawing.Point(206, 195);
            this.btndokter.Name = "btndokter";
            this.btndokter.Size = new System.Drawing.Size(397, 48);
            this.btndokter.TabIndex = 2;
            this.btndokter.Text = "Dokter";
            this.btndokter.UseVisualStyleBackColor = true;
            this.btndokter.Click += new System.EventHandler(this.btndokter_Click);
            // 
            // btnjadwal
            // 
            this.btnjadwal.Location = new System.Drawing.Point(206, 253);
            this.btnjadwal.Name = "btnjadwal";
            this.btnjadwal.Size = new System.Drawing.Size(397, 48);
            this.btnjadwal.TabIndex = 3;
            this.btnjadwal.Text = "Jadwal";
            this.btnjadwal.UseVisualStyleBackColor = true;
            this.btnjadwal.Click += new System.EventHandler(this.btnjadwal_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.Location = new System.Drawing.Point(712, 15);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(75, 23);
            this.btnprofile.TabIndex = 4;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnprofile);
            this.Controls.Add(this.btnjadwal);
            this.Controls.Add(this.btndokter);
            this.Controls.Add(this.btnpasien);
            this.Controls.Add(this.titlehome);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlehome;
        private System.Windows.Forms.Button btnpasien;
        private System.Windows.Forms.Button btndokter;
        private System.Windows.Forms.Button btnjadwal;
        private System.Windows.Forms.Button btnprofile;
    }
}