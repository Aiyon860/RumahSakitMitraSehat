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
            MySqlCommand commandDoctorType = new MySqlCommand("SELECT * FROM doctor_types;", con);
            MySqlDataReader reader = commandDoctorType.ExecuteReader();

            while (reader.Read())
            {
                SpesialisasiComboBox.Items.Add(String.Concat(reader["id"].ToString(), ". ", reader["type"]));
            }
            con.Close();

            // doctor_list view
            con.Open();
            MySqlCommand commandDoctorList = new MySqlCommand("SELECT * FROM doctor_list;", con);
            MySqlDataReader dataReader = commandDoctorList.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterDokterDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Search_DoctorData(String keyword)
        {
            con.Open();
            MySqlCommand dataSearchCommand = new MySqlCommand("SELECT * FROM doctor_list WHERE `Nama Lengkap` LIKE @keyword", con);
            dataSearchCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataReader dataReader = dataSearchCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterDokterDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void load_data_dokter()
        {
            con.Open();
            MySqlCommand dataSearchCommand = new MySqlCommand("SELECT * FROM doctor_list", con);
            MySqlDataReader dataReader = dataSearchCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterDokterDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void clear_form()
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
            this.clear_form();
        }

        private void SimpanButton_Click(object sender, EventArgs e)
        {
            var nama_lengkap = NamaLengkapTextBox.Text;
            var nik = NIKTextBox.Text;
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
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(id) FROM doctors", con);
            highestID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            con.Open();
            MySqlCommand dataSearchCommand;
            if (NotVisibleTextBox.Text == "")
            {
                dataSearchCommand = new MySqlCommand
                (
                    $"INSERT INTO doctors (id, fullname, NIK, birth_date, birth_place, gender, type_id) " +
                    $"VALUES (@id, @fullname, @nik, @birth_date, @birth_place, @gender,@type_id)", con
                );
                dataSearchCommand.Parameters.AddWithValue("@id", highestID + 1);
            }
            else
            {
                dataSearchCommand = new MySqlCommand
                    (
                        "UPDATE doctors " +
                            "SET fullname = @fullname, " +
                            "nik = @nik, " +
                            "birth_date = @birth_date, " +
                            "birth_place = @birth_place, " +
                            "gender = @gender," +
                            "type_id = @type_id " +
                        "WHERE id = @id", con
                    );
              dataSearchCommand.Parameters.AddWithValue("@id", NotVisibleTextBox.Text);
            }

            dataSearchCommand.Parameters.AddWithValue("@fullname", nama_lengkap);
            dataSearchCommand.Parameters.AddWithValue("@NIK", nik);
            dataSearchCommand.Parameters.AddWithValue("@birth_date", tgl_lahir);
            dataSearchCommand.Parameters.AddWithValue("@birth_place", tmp_lahir);
            dataSearchCommand.Parameters.AddWithValue("@gender", gender);
            dataSearchCommand.Parameters.AddWithValue("@type_id", spesialisasi_components[0]);
           
            int affected_rows = dataSearchCommand.ExecuteNonQuery();
            if (affected_rows > 0)
            {
                MessageBox.Show
                    (
                        "Berhasil menyimpan data", 
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
            }

            con.Close();
            this.clear_form();
            this.load_data_dokter();
        }

        private void load_single_dokter(int doctor_id)
        {
            con.Open();
            MySqlCommand dataSearchCommand = new MySqlCommand("SELECT * FROM doctors WHERE id = @id", con);
            dataSearchCommand.Parameters.AddWithValue("@id", doctor_id);
            MySqlDataReader dataReader = dataSearchCommand.ExecuteReader();

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

        private void drop_single_dokter(int doctor_id)
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
                this.drop_single_dokter(Int16.Parse(doctor_id));
                this.load_data_dokter();
            }
        }

        private void CariButton_Click(object sender, EventArgs e)
        {
            if (this.FilterDokterTextBox.Text == "Filter Dokter")
            {
                return;
            }
            this.Search_DoctorData(this.FilterDokterTextBox.Text);
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.RumahSakitMitraSehat = new RumahSakitMitraSehat();
            RumahSakitMitraSehat.Show();
            this.Close();
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
                MySqlCommand commandDoctorList = new MySqlCommand("SELECT * FROM doctor_list;", con);
                MySqlDataReader dataReader = commandDoctorList.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                FilterDokterDataGridView.DataSource = dataTable;
                con.Close();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
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

    }
}
