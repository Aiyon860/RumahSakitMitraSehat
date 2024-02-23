using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace RumahSakitMitraSehat
{
    public partial class FormDataPasien : Form
    {
        private Form RumahSakitMitraSehat;

        public FormDataPasien()
        {
            InitializeComponent();
        }
        private void FormDataPasien_Load(object sender, EventArgs e)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "rumah_sakit_mitra_sehat",
            };

            MySqlConnection con = new MySqlConnection(builder.ConnectionString);

            con.Open();
            MySqlCommand command_patient_list = new MySqlCommand("SELECT * FROM patient_list;", con);
            MySqlDataReader dataReader = command_patient_list.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            ShowDataPasienDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.RumahSakitMitraSehat = new RumahSakitMitraSehat();
            RumahSakitMitraSehat.Show();
            this.Close();
        }

        private void CariDataPasienTextBox_OnFocus(object sender, EventArgs e)
        {
            this.CariDataPasienTextBox.Text = "";
        }

        private void CariDataPasienTextBox_LoseFocus(object sender, EventArgs e)
        {
            this.CariDataPasienTextBox.Text = "Cari Data Pasien";
        }

    }
}
