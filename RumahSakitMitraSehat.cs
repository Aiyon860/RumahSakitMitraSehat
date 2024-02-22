using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakitMitraSehat
{
    public partial class RumahSakitMitraSehat : Form
    {
        private Form FormDataPasien;
        private Form FormDataDokter;
        private Form FormDataObat;

        public RumahSakitMitraSehat()
        {
            InitializeComponent();
        }

        private void DataPasien_Click(object sender, EventArgs e)
        {
            this.FormDataPasien = new FormDataPasien();
            FormDataPasien.Show();
            this.Hide();
        }

        private void DataDokter_Click(object sender, EventArgs e)
        {
            this.FormDataDokter = new FormDataDokter();
            FormDataDokter.Show();
            this.Hide();
        }

        private void DataObat_Click(object sender, EventArgs e)
        {
            this.FormDataObat = new FormDataObat();
            FormDataObat.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (this.FormDataPasien != null)
            {
                this.FormDataPasien.Close();
            }
            Application.Exit();
        }

    }
}
