using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RumahSakitMitraSehat
{
    public partial class FormDataDokter : Form
    {
        private Form RumahSakitMitraSehat;

        public FormDataDokter()
        {
            InitializeComponent();
        }

        static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "root",
            Database = "rumah_sakit_mitra_sehat",
        };

        static MySqlConnection con = new MySqlConnection(builder.ConnectionString);

        private void FormDataDokter_Load(object sender, EventArgs e)
        {
            // spesifikasi
            con.Open();
            MySqlCommand command_type = new MySqlCommand("SELECT * FROM doctor_types;", con);
            MySqlDataReader reader = command_type.ExecuteReader();

            while (reader.Read())
            {
                SpesialisasiComboBox.Items.Add(String.Concat(reader["id"].ToString(), ". ", reader["type"]));
            }
            con.Close();

            // doctor_list view
            con.Open();
            MySqlCommand command_list = new MySqlCommand("SELECT * FROM doctor_list;", con);
            MySqlDataReader dataReader = command_list.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterDokterDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Search_Doctor(String keyword)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM doctor_list WHERE `Nama Lengkap` LIKE @keyword", con);
            dataCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataReader dataReader = dataCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterDokterDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Load_Doctor()
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM doctor_list", con);
            MySqlDataReader dataReader = dataCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterDokterDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Clear_Form()
        {
            NamaLengkapTextBox.Text = "";
            NIKTextBox.Text = "";
            TanggalLahirDateTimePicker.ResetText();
            TempatLahirTextBox.Text = "";
            NotVisibleTextBox.Text = "";
            LakiLakiRadioButton.Checked = false;
            PerempuanRadioButton.Checked = false;
            SpesialisasiComboBox.SelectedItem = null;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.Clear_Form();
        }

        private void SimpanButton_Click(object sender, EventArgs e)
        {
            var nama_lengkap = NamaLengkapTextBox.Text;
            var NIK = NIKTextBox.Text;
            var tgl_lahir = TanggalLahirDateTimePicker.Value.ToString("yyyy-MM-dd");
            var tmp_lahir = TempatLahirTextBox.Text;
            var gender = "";
            bool isChecked = LakiLakiRadioButton.Checked;
            if (isChecked)
                gender = "M";
            else
                gender = "F";
            string spesialisasi = SpesialisasiComboBox.Text;
            string[] spesialisasi_components = spesialisasi.Split(' ');

            // get the highest id
            int highestID = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(id) FROM doctor_list", con);
            highestID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            con.Open();
            MySqlCommand dataCommand;
            if (NotVisibleTextBox.Text == "")
            {
                dataCommand = new MySqlCommand
                (
                    $"INSERT INTO doctors (id, fullname, NIK, birth_date, birth_place, gender, type_id) " +
                    $"VALUES (@id, @fullname, @NIK, @birth_date, @birth_place, @gender,@type_id)", con
                );
                dataCommand.Parameters.AddWithValue("@id", highestID + 1);
            }
            else
            {
                dataCommand = new MySqlCommand
                    (
                        "UPDATE doctors " +
                            "SET fullname = @fullname, " +
                            "NIK = @NIK, " +
                            "birth_date = @birth_date, " +
                            "birth_place = @birth_place, " +
                            "gender = @gender," +
                            "type_id = @type_id " +
                        "WHERE id = @id", con
                    );
              dataCommand.Parameters.AddWithValue("@id", Int16.Parse(NotVisibleTextBox.Text));
            }

            dataCommand.Parameters.AddWithValue("@fullname", nama_lengkap);
            dataCommand.Parameters.AddWithValue("@NIK", NIK);
            dataCommand.Parameters.AddWithValue("@birth_date", tgl_lahir);
            dataCommand.Parameters.AddWithValue("@birth_place", tmp_lahir);
            dataCommand.Parameters.AddWithValue("@gender", gender);
            dataCommand.Parameters.AddWithValue("@type_id", spesialisasi_components[0]);
           
            int affected_rows = dataCommand.ExecuteNonQuery();
            if (affected_rows > 0)
            {
                MessageBox.Show
                (
                        "Berhasil menyimpan data", 
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                );
                this.Text = "Form Data Dokter";
            }

            con.Close();
            this.Clear_Form();
            this.Load_Doctor();
        }

        private void load_single_dokter(int doctor_id)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM doctors WHERE id = @id", con);
            dataCommand.Parameters.AddWithValue("@id", doctor_id);
            MySqlDataReader dataReader = dataCommand.ExecuteReader();

            if (dataReader.HasRows == true)
            {
                dataReader.Read();

                NamaLengkapTextBox.Text = dataReader.GetString(dataReader.GetOrdinal("fullname"));
                NIKTextBox.Text = dataReader.GetInt64(dataReader.GetOrdinal("NIK")).ToString();
                var fulldate = dataReader.GetDateTime("birth_date").ToString("yyyy-MM-dd").Split('-');
                TanggalLahirDateTimePicker.Value = new DateTime(Int32.Parse(fulldate[0]),
                                                   Int32.Parse(fulldate[1]), Int32.Parse(fulldate[2]));
                TempatLahirTextBox.Text = dataReader.GetString(dataReader.GetOrdinal("birth_place"));
                
                if (dataReader.GetString(dataReader.GetOrdinal("gender")) == "M")
                {
                    LakiLakiRadioButton.Checked = true;
                    PerempuanRadioButton.Checked = false;
                }
                else
                {
                    LakiLakiRadioButton.Checked = false;
                    PerempuanRadioButton.Checked = true;
                }

                var comboIndex = SpesialisasiComboBox.FindString(
                    String.Concat
                    (
                        dataReader.GetInt16(dataReader.GetOrdinal("type_id")).ToString(), "."
                    )
                );
                SpesialisasiComboBox.SelectedIndex = comboIndex;
            }
            else
            {
                MessageBox.Show
                    (
                        "Data Tidak Ditemukan", 
                        "Perhatian",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
            }

            con.Close();
        }

        private void Drop_Single_Doctor(int doctor_id)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("DELETE FROM doctors WHERE id = @id", con);
            try
            {
                dataCommand.Parameters.AddWithValue("@id", doctor_id);
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus data", "Berhasil");
            }
            catch (Exception e)
            {
                MessageBox.Show
                (
                    "Gagal menghapus data. Dokter pernah melakukan pemeriksaan (checkup).", 
                    "Perhatian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Console.WriteLine(e.Message);
            }
            con.Close();
        }

        private void HapusButton_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show
                         (
                            "Anda yakin ingin menghapus data ini?", 
                            "Perhatian", 
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                         );

            if (answer == DialogResult.Yes)
            {
                var rowIndex = FilterDokterDataGridView.CurrentCell.RowIndex;
                var doctor_id = FilterDokterDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                this.Drop_Single_Doctor(Int16.Parse(doctor_id));
                this.Load_Doctor();
            }
        }

        private void CariButton_Click(object sender, EventArgs e)
        {
            if (this.FilterDokterTextBox.Text == "Filter Dokter")
            {
                return;
            }
            this.Search_Doctor(this.FilterDokterTextBox.Text);
        }

        private void FilterDokterTextBox_OnFocus(object sender, EventArgs e)
        {
            if (this.FilterDokterTextBox.Text != "" 
                && this.FilterDokterTextBox.Text != "Filter Dokter") 
            {
                return;
            }
            this.FilterDokterTextBox.ForeColor = Color.Black;
            this.FilterDokterTextBox.Text = "";
        }

        private void FilterDokterTextBox_LoseFocus(object sender, EventArgs e)
        {
            if (this.FilterDokterTextBox.Text == "")
            {
                // showing back "Filter Dokter" when box is empty
                FilterDokterTextBox.Text = "Filter Dokter";
                FilterDokterTextBox.ForeColor = Color.Gray;
                
                // displaying all data when box is empty
                con.Open();
                MySqlCommand command_list = new MySqlCommand("SELECT * FROM doctor_list;", con);
                MySqlDataReader dataReader = command_list.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                FilterDokterDataGridView.DataSource = dataTable;
                con.Close();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // indicate that user in data editing process
            this.Text = "Form Data Dokter (Editing)";

            // select the specific 'id' based on row
            var rowIndex = FilterDokterDataGridView.CurrentCell.RowIndex;
            var doctor_id = FilterDokterDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            NotVisibleTextBox.Text = doctor_id;
            this.load_single_dokter(Int16.Parse(doctor_id));
        }

        private void SpesialisasiComboBox_OnFocus(object sender, EventArgs e)
        {
            this.SpesialisasiComboBox.Text = "";
        }

        private void SpesialisasiComboBox_LoseFocus(object sender, EventArgs e)
        {
            this.SpesialisasiComboBox.Text = "Spesialisasi";
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            RumahSakitMitraSehat = new RumahSakitMitraSehat();
            RumahSakitMitraSehat.Show();
            this.Close();
        }
    }
}
