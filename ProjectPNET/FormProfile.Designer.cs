
namespace ProjectPNET
{
    partial class FormProfile
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
            this.titleprofile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleprofile
            // 
            this.titleprofile.AutoSize = true;
            this.titleprofile.Location = new System.Drawing.Point(377, 43);
            this.titleprofile.Name = "titleprofile";
            this.titleprofile.Size = new System.Drawing.Size(36, 13);
            this.titleprofile.TabIndex = 0;
            this.titleprofile.Text = "Profile";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleprofile);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleprofile;
    }
}