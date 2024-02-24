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

        static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "root",
            Database = "rumah_sakit_mitra_sehat",
        };

        static MySqlConnection con = new MySqlConnection(builder.ConnectionString);
        
        private void FormDataObat_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand command_medicine = new MySqlCommand("SELECT * FROM medicine_list;", con);
            MySqlDataReader dataReader = command_medicine.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterObatDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Search_Medicine(String keyword)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM medicine_list WHERE `Nama Obat` LIKE @keyword", con);
            dataCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataReader dataReader = dataCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterObatDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Load_Medicine()
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM medicine_list", con);
            MySqlDataReader dataReader = dataCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            FilterObatDataGridView.DataSource = dataTable;
            con.Close();
        }

        private void Clear_Form()
        {
            NamaObatTextBox.Text = "";
            IndikasiTextBox.Text = "";
            KuantitasNumericUpDown.Value = 0;
            HargaNumericUpDown.Value = 0;
            NotVisibleTextBox.Text = "";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.Clear_Form();
        }

        private void SimpanButton_Click(object sender, EventArgs e)
        {
            var medicine_name = NamaObatTextBox.Text;
            var indication = IndikasiTextBox.Text;
            var quantity = KuantitasNumericUpDown.Value;
            var price = HargaNumericUpDown.Value;

            // get the highest id
            int highestID = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(id) FROM medicines", con);
            highestID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            con.Open();
            MySqlCommand dataCommand;
            if (NotVisibleTextBox.Text == "")
            {
                dataCommand = new MySqlCommand
                (
                    $"INSERT INTO medicines (id, medicine_name, indication, quantity, price) " +
                    $"VALUES (@id, @medicine_name, @indication, @quantity, @price)", con
                );
                dataCommand.Parameters.AddWithValue("@id", highestID + 1);
            }
            else
            {
                dataCommand = new MySqlCommand
                (
                    "UPDATE medicines " +
                    "SET medicine_name = @medicine_name, " +
                        "indication = @indication, " +
                        "quantity = @quantity, " +
                        "price = @price " +
                    "WHERE id = @id", con
                );
                dataCommand.Parameters.AddWithValue("@id", Int16.Parse(NotVisibleTextBox.Text));
            }

            dataCommand.Parameters.AddWithValue("@medicine_name", medicine_name);
            dataCommand.Parameters.AddWithValue("@indication", indication);
            dataCommand.Parameters.AddWithValue("@quantity", quantity);
            dataCommand.Parameters.AddWithValue("@price", price);

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
                this.Text = "Form Data Obat";
            }

            con.Close();
            this.Clear_Form();
            this.Load_Medicine();
        }

        private void Load_Single_Medicine(int medicine_id)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("SELECT * FROM medicines WHERE id = @id", con);
            dataCommand.Parameters.AddWithValue("@id", medicine_id);
            MySqlDataReader dataReader = dataCommand.ExecuteReader();

            if (dataReader.HasRows == true)
            {
                dataReader.Read();

                NamaObatTextBox.Text = dataReader.GetString(dataReader.GetOrdinal("medicine_name"));
                IndikasiTextBox.Text = dataReader.GetString(dataReader.GetOrdinal("indication"));
                KuantitasNumericUpDown.Value = dataReader.GetInt16(dataReader.GetOrdinal("quantity"));
                HargaNumericUpDown.Maximum = 1_000_000_000;
                HargaNumericUpDown.Value = dataReader.GetInt16(dataReader.GetOrdinal("price"));
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

        private void Drop_Single_Medicine(int medicine_id)
        {
            con.Open();
            MySqlCommand dataCommand = new MySqlCommand("DELETE FROM medicines WHERE id = @id", con);
            try
            {
                dataCommand.Parameters.AddWithValue("@id", medicine_id);
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus data", "Berhasil");
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
                var rowIndex = FilterObatDataGridView.CurrentCell.RowIndex;
                var doctor_id = FilterObatDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                this.Drop_Single_Medicine(Int16.Parse(doctor_id));
                this.Load_Medicine();
            }
        }

        private void CariButton_Click(object sender, EventArgs e)
        {
            if (this.FilterObatTextBox.Text == "Filter Obat")
            {
                return;
            }
            this.Search_Medicine(this.FilterObatTextBox.Text);
        }

        private void FilterObatTextBox_OnFocus(object sender, EventArgs e)
        {
            if (this.FilterObatTextBox.Text != ""
                && this.FilterObatTextBox.Text != "Filter Obat")
            {
                return;
            }
            this.FilterObatTextBox.ForeColor = Color.Black;
            this.FilterObatTextBox.Text = "";
        }

        private void FilterObatTextBox_LoseFocus(object sender, EventArgs e)
        {
            if (this.FilterObatTextBox.Text == "")
            {
                // showing back "Filter Dokter" when box is empty
                FilterObatTextBox.Text = "Filter Obat";
                FilterObatTextBox.ForeColor = Color.Gray;

                // displaying all data when box is empty
                con.Open();
                MySqlCommand commandDoctorList = new MySqlCommand("SELECT * FROM medicine_list;", con);
                MySqlDataReader dataReader = commandDoctorList.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                FilterObatDataGridView.DataSource = dataTable;
                con.Close();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // indicate that user in data editing process
            this.Text = "Form Data Obat (Editing)";

            // select the specific 'id' based on row
            var rowIndex = FilterObatDataGridView.CurrentCell.RowIndex;
            var medicine_id = FilterObatDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            NotVisibleTextBox.Text = medicine_id;
            this.Load_Single_Medicine(Int16.Parse(medicine_id));
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            RumahSakitMitraSehat = new RumahSakitMitraSehat();
            RumahSakitMitraSehat.Show();
            this.Close();
        } 
    }
}
