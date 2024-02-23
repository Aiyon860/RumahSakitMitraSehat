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
    public partial class FormDataObat : Form
    {
        private Form RumahSakitMitraSehat;

        public FormDataObat()
        {
            InitializeComponent();
        }

        private void FormDataObat_Load(object sender, EventArgs e)
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
            MySqlCommand command_medicine = new MySqlCommand("SELECT * FROM medicine_list;", con);
            MySqlDataReader dataReader = command_medicine.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterObatDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.RumahSakitMitraSehat = new RumahSakitMitraSehat();
            RumahSakitMitraSehat.Show();
            this.Close();
        }

        private void FilterObatTextBox_OnFocus(object sender, EventArgs e)
        {
            this.FilterObatTextBox.Text = "";
        }

        private void FilterObatTextBox_LoseFocus(object sender, EventArgs e)
        {
            this.FilterObatTextBox.Text = "Filter Obat";
        }

    }
}
