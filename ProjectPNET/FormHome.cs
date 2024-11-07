using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPNET
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnpasien_Click(object sender, EventArgs e)
        {
            FormPasien formPasien = new FormPasien();
            formPasien.Show();
        }

        private void btndokter_Click(object sender, EventArgs e)
        {
            FormDokter formDokter = new FormDokter();
            formDokter.Show();
        }

        private void btnjadwal_Click(object sender, EventArgs e)
        {
            FormJadwal formJadwal = new FormJadwal();
            formJadwal.Show();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
        }
    }
}
