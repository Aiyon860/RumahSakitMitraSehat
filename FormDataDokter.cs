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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RumahSakitMitraSehat
{
    public partial class FormDataDokter : Form
    {
        private Form RumahSakitMitraSehat;

        public FormDataDokter()
        {
            InitializeComponent();
        }

        private void FormDataDokter_Load(object sender, EventArgs e)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "rumah_sakit_mitra_sehat",
            };

            var con = new MySqlConnection(builder.ConnectionString);
            con.Open();
            MySqlCommand command_doctor_type = new MySqlCommand("SELECT * FROM doctor_types;", con);
            MySqlDataReader reader = command_doctor_type.ExecuteReader();

            while (reader.Read())
            {
                SpesialisasiComboBox.Items.Add(String.Concat(reader["id"].ToString(), ". ", reader["type"]));
            }
            con.Close();

            con.Open();
            MySqlCommand command_doctor_list = new MySqlCommand("SELECT * FROM doctor_list;", con);
            MySqlDataReader dataReader = command_doctor_list.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterDokterDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.RumahSakitMitraSehat = new RumahSakitMitraSehat();
            RumahSakitMitraSehat.Show();
            this.Close();
        }

        private void FilterDokterTextBox_OnFocus(object sender, EventArgs e)
        {
            this.FilterDokterTextBox.Text = "";
        }

        private void FilterDokterTextBox_LoseFocus(object sender, EventArgs e)
        {
            this.FilterDokterTextBox.Text = "Filter Dokter";
        }

        private void SpesialisasiComboBox_OnFocus(object sender, EventArgs e)
        {
            this.SpesialisasiComboBox.Text = "";
        }

        private void SpesialisasiComboBox_LoseFocus(object sender, EventArgs e)
        {
            this.SpesialisasiComboBox.Text = "Spesialisasi";
        }
    }
}
