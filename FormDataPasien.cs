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

        static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "root",
            Database = "rumah_sakit_mitra_sehat",
        };

        static MySqlConnection con = new MySqlConnection(builder.ConnectionString);

        private void FormDataPasien_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand command_list = new MySqlCommand("SELECT * FROM patient_list;", con);
            MySqlDataReader dataReader = command_list.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            ShowDataPasienDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Search_Patient(String keyword)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM patient_list WHERE `Nama Lengkap` LIKE @keyword", con);
            dataCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataReader dataReader = dataCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            ShowDataPasienDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Load_Patient()
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM patient_list", con);
            MySqlDataReader dataReader = dataCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            ShowDataPasienDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Clear_Form()
        {
            NamaLengkapTextBox.Text = "";
            NIKTextBox.Text = "";
            TanggalLahirDateTimePicker.ResetText();
            TempatLahirTextBox.Text = "";
            LakiLakiRadioButton.Checked = false;
            PerempuanRadioButton.Checked = false;
            PekerjaanTextBox.Text = "";
            NotVisibleTextBox.Text = "";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.Clear_Form();
        }

        private void SimpanButton_Click(object sender, EventArgs e)
        {
            var fullname = NamaLengkapTextBox.Text;
            var NIK = NIKTextBox.Text;
            var birth_date = TanggalLahirDateTimePicker.Value.ToString("yyyy-MM-dd");
            var birth_place = TempatLahirTextBox.Text;
            var gender = "";
            if (LakiLakiRadioButton.Checked)
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }
            var occupation = PekerjaanTextBox.Text;

            // get the highest id
            int highestID = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(id) FROM patients", con);
            highestID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            con.Open();
            MySqlCommand dataCommand;
            if (NotVisibleTextBox.Text == "")
            {
                dataCommand = new MySqlCommand
                (
                    $"INSERT INTO patients (id, fullname, NIK, birth_date, birth_place, gender, occupation) " +
                    $"VALUES (@id, @fullname, @NIK, @birth_date, @birth_place, @gender, @occupation)", con
                );
                dataCommand.Parameters.AddWithValue("@id", highestID + 1);
            }
            else
            {
                dataCommand = new MySqlCommand
                (
                    "UPDATE patients " +
                    "SET fullname = @fullname, " +
                        "NIK = @NIK, " +
                        "birth_date = @birth_date, " +
                        "birth_place = @birth_place, " +
                        "gender = @gender, " +
                        "occupation = @occupation " +
                    "WHERE id = @id", con
                );
                dataCommand.Parameters.AddWithValue("@id", Int16.Parse(NotVisibleTextBox.Text));
            }

            dataCommand.Parameters.AddWithValue("@fullname", fullname);
            dataCommand.Parameters.AddWithValue("@NIK", NIK);
            dataCommand.Parameters.AddWithValue("@birth_date", birth_date);
            dataCommand.Parameters.AddWithValue("@birth_place", birth_place);
            dataCommand.Parameters.AddWithValue("@gender", gender);
            dataCommand.Parameters.AddWithValue("@occupation", occupation);

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
                this.Text = "Form Data Pasien";
            }

            con.Close();
            this.Clear_Form();
            this.Load_Patient();
        }

        private void Load_Single_Patient(int patient_id)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM patients WHERE id = @id", con);
            dataCommand.Parameters.AddWithValue("@id", patient_id);
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

                PekerjaanTextBox.Text = dataReader.GetString(dataReader.GetOrdinal("occupation"));
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

        private void Drop_Single_Patient(int patient_id)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("DELETE FROM patients WHERE id = @id", con);
            try
            {
                dataCommand.Parameters.AddWithValue("@id", patient_id);
                dataCommand.ExecuteNonQuery();
                MessageBox.Show
                (
                    "Berhasil menghapus data", 
                    "Berhasil", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception e)
            {
                MessageBox.Show
                (
                    "Gagal menghapus data.",
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
                var rowIndex = ShowDataPasienDataGridView.CurrentCell.RowIndex;
                var patient_id = ShowDataPasienDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                this.Drop_Single_Patient(Int16.Parse(patient_id));
                this.Load_Patient();
            }
        }

        private void CariButton_Click(object sender, EventArgs e)
        {
            if (this.FilterPasienTextBox.Text == "Filter Pasien")
            {
                return;
            }
            this.Search_Patient(this.FilterPasienTextBox.Text);
        }

        private void FilterPasienTextBox_OnFocus(object sender, EventArgs e)
        {
            if (this.FilterPasienTextBox.Text != ""
                && this.FilterPasienTextBox.Text != "Filter Pasien")
            {
                return;
            }
            this.FilterPasienTextBox.ForeColor = Color.Black;
            this.FilterPasienTextBox.Text = "";
        }

        private void FilterPasienTextBox_LoseFocus(object sender, EventArgs e)
        {
            if (this.FilterPasienTextBox.Text == "")
            {
                // showing back "Filter Dokter" when box is empty
                FilterPasienTextBox.Text = "Filter Pasien";
                FilterPasienTextBox.ForeColor = Color.Gray;

                // displaying all data when box is empty
                con.Open();
                MySqlCommand commandDoctorList = new MySqlCommand("SELECT * FROM patient_list;", con);
                MySqlDataReader dataReader = commandDoctorList.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                ShowDataPasienDataGridView.DataSource = dataTable;
                con.Close();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // indicate that user in data editing process
            this.Text = "Form Data Pasien (Editing)";

            // select the specific 'id' based on row
            var rowIndex = ShowDataPasienDataGridView.CurrentCell.RowIndex;
            var patient_id = ShowDataPasienDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            NotVisibleTextBox.Text = patient_id;
            this.Load_Single_Patient(Int16.Parse(patient_id));
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            RumahSakitMitraSehat = new RumahSakitMitraSehat();
            RumahSakitMitraSehat.Show();
            this.Close();
        }
    }
}
