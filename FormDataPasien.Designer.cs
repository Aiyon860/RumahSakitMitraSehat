namespace RumahSakitMitraSehat
{
    partial class FormDataPasien
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
            this.KembaliButton = new System.Windows.Forms.Button();
            this.NamaLengkap = new System.Windows.Forms.Label();
            this.NamaLengkapTextBox = new System.Windows.Forms.TextBox();
            this.NIKTextBox = new System.Windows.Forms.TextBox();
            this.NIK = new System.Windows.Forms.Label();
            this.TempatLahirTextBox = new System.Windows.Forms.TextBox();
            this.TempatLahir = new System.Windows.Forms.Label();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.TanggalLahirDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PekerjaanTextBox = new System.Windows.Forms.TextBox();
            this.Pekerjaan = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.LakiLakiRadioButton = new System.Windows.Forms.RadioButton();
            this.PerempuanRadioButton = new System.Windows.Forms.RadioButton();
            this.SimpanButton = new System.Windows.Forms.Button();
            this.FilterPasienTextBox = new System.Windows.Forms.TextBox();
            this.ShowDataPasienDataGridView = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.HapusButton = new System.Windows.Forms.Button();
            this.NotVisibleTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CariButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataPasienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KembaliButton
            // 
            this.KembaliButton.ForeColor = System.Drawing.Color.Black;
            this.KembaliButton.Location = new System.Drawing.Point(24, 23);
            this.KembaliButton.Name = "KembaliButton";
            this.KembaliButton.Size = new System.Drawing.Size(107, 29);
            this.KembaliButton.TabIndex = 0;
            this.KembaliButton.Text = "<< Kembali";
            this.KembaliButton.UseVisualStyleBackColor = true;
            this.KembaliButton.Click += new System.EventHandler(this.KembaliButton_Click);
            // 
            // NamaLengkap
            // 
            this.NamaLengkap.AutoSize = true;
            this.NamaLengkap.ForeColor = System.Drawing.Color.Black;
            this.NamaLengkap.Location = new System.Drawing.Point(26, 67);
            this.NamaLengkap.Name = "NamaLengkap";
            this.NamaLengkap.Size = new System.Drawing.Size(100, 16);
            this.NamaLengkap.TabIndex = 1;
            this.NamaLengkap.Text = "Nama Lengkap";
            // 
            // NamaLengkapTextBox
            // 
            this.NamaLengkapTextBox.Location = new System.Drawing.Point(166, 67);
            this.NamaLengkapTextBox.Name = "NamaLengkapTextBox";
            this.NamaLengkapTextBox.Size = new System.Drawing.Size(242, 22);
            this.NamaLengkapTextBox.TabIndex = 2;
            // 
            // NIKTextBox
            // 
            this.NIKTextBox.Location = new System.Drawing.Point(166, 101);
            this.NIKTextBox.Name = "NIKTextBox";
            this.NIKTextBox.Size = new System.Drawing.Size(242, 22);
            this.NIKTextBox.TabIndex = 4;
            // 
            // NIK
            // 
            this.NIK.AutoSize = true;
            this.NIK.ForeColor = System.Drawing.Color.Black;
            this.NIK.Location = new System.Drawing.Point(26, 101);
            this.NIK.Name = "NIK";
            this.NIK.Size = new System.Drawing.Size(89, 16);
            this.NIK.TabIndex = 3;
            this.NIK.Text = "NIK (No. KTP)";
            // 
            // TempatLahirTextBox
            // 
            this.TempatLahirTextBox.Location = new System.Drawing.Point(166, 173);
            this.TempatLahirTextBox.Name = "TempatLahirTextBox";
            this.TempatLahirTextBox.Size = new System.Drawing.Size(242, 22);
            this.TempatLahirTextBox.TabIndex = 6;
            // 
            // TempatLahir
            // 
            this.TempatLahir.AutoSize = true;
            this.TempatLahir.ForeColor = System.Drawing.Color.Black;
            this.TempatLahir.Location = new System.Drawing.Point(26, 173);
            this.TempatLahir.Name = "TempatLahir";
            this.TempatLahir.Size = new System.Drawing.Size(86, 16);
            this.TempatLahir.TabIndex = 5;
            this.TempatLahir.Text = "Tempat Lahir";
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.ForeColor = System.Drawing.Color.Black;
            this.TanggalLahir.Location = new System.Drawing.Point(26, 137);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(90, 16);
            this.TanggalLahir.TabIndex = 7;
            this.TanggalLahir.Text = "Tanggal Lahir";
            // 
            // TanggalLahirDateTimePicker
            // 
            this.TanggalLahirDateTimePicker.Location = new System.Drawing.Point(166, 137);
            this.TanggalLahirDateTimePicker.Name = "TanggalLahirDateTimePicker";
            this.TanggalLahirDateTimePicker.Size = new System.Drawing.Size(242, 22);
            this.TanggalLahirDateTimePicker.TabIndex = 8;
            // 
            // PekerjaanTextBox
            // 
            this.PekerjaanTextBox.Location = new System.Drawing.Point(166, 253);
            this.PekerjaanTextBox.Name = "PekerjaanTextBox";
            this.PekerjaanTextBox.Size = new System.Drawing.Size(242, 22);
            this.PekerjaanTextBox.TabIndex = 10;
            // 
            // Pekerjaan
            // 
            this.Pekerjaan.AutoSize = true;
            this.Pekerjaan.ForeColor = System.Drawing.Color.Black;
            this.Pekerjaan.Location = new System.Drawing.Point(26, 253);
            this.Pekerjaan.Name = "Pekerjaan";
            this.Pekerjaan.Size = new System.Drawing.Size(69, 16);
            this.Pekerjaan.TabIndex = 9;
            this.Pekerjaan.Text = "Pekerjaan";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.ForeColor = System.Drawing.Color.Black;
            this.JenisKelamin.Location = new System.Drawing.Point(26, 214);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(90, 16);
            this.JenisKelamin.TabIndex = 11;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // LakiLakiRadioButton
            // 
            this.LakiLakiRadioButton.AutoSize = true;
            this.LakiLakiRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LakiLakiRadioButton.Location = new System.Drawing.Point(166, 214);
            this.LakiLakiRadioButton.Name = "LakiLakiRadioButton";
            this.LakiLakiRadioButton.Size = new System.Drawing.Size(82, 20);
            this.LakiLakiRadioButton.TabIndex = 12;
            this.LakiLakiRadioButton.TabStop = true;
            this.LakiLakiRadioButton.Text = "Laki-Laki";
            this.LakiLakiRadioButton.UseVisualStyleBackColor = true;
            // 
            // PerempuanRadioButton
            // 
            this.PerempuanRadioButton.AutoSize = true;
            this.PerempuanRadioButton.ForeColor = System.Drawing.Color.Black;
            this.PerempuanRadioButton.Location = new System.Drawing.Point(279, 214);
            this.PerempuanRadioButton.Name = "PerempuanRadioButton";
            this.PerempuanRadioButton.Size = new System.Drawing.Size(98, 20);
            this.PerempuanRadioButton.TabIndex = 13;
            this.PerempuanRadioButton.TabStop = true;
            this.PerempuanRadioButton.Text = "Perempuan";
            this.PerempuanRadioButton.UseVisualStyleBackColor = true;
            // 
            // SimpanButton
            // 
            this.SimpanButton.ForeColor = System.Drawing.Color.Black;
            this.SimpanButton.Location = new System.Drawing.Point(166, 304);
            this.SimpanButton.Name = "SimpanButton";
            this.SimpanButton.Size = new System.Drawing.Size(135, 38);
            this.SimpanButton.TabIndex = 14;
            this.SimpanButton.Text = "Simpan";
            this.SimpanButton.UseVisualStyleBackColor = true;
            this.SimpanButton.Click += new System.EventHandler(this.SimpanButton_Click);
            // 
            // FilterPasienTextBox
            // 
            this.FilterPasienTextBox.AccessibleName = "";
            this.FilterPasienTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FilterPasienTextBox.Location = new System.Drawing.Point(453, 354);
            this.FilterPasienTextBox.Name = "FilterPasienTextBox";
            this.FilterPasienTextBox.Size = new System.Drawing.Size(150, 22);
            this.FilterPasienTextBox.TabIndex = 15;
            this.FilterPasienTextBox.Text = "Filter Pasien";
            this.FilterPasienTextBox.GotFocus += new System.EventHandler(this.FilterPasienTextBox_OnFocus);
            this.FilterPasienTextBox.LostFocus += new System.EventHandler(this.FilterPasienTextBox_LoseFocus);
            // 
            // ShowDataPasienDataGridView
            // 
            this.ShowDataPasienDataGridView.AllowUserToAddRows = false;
            this.ShowDataPasienDataGridView.AllowUserToDeleteRows = false;
            this.ShowDataPasienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataPasienDataGridView.Location = new System.Drawing.Point(453, 67);
            this.ShowDataPasienDataGridView.MultiSelect = false;
            this.ShowDataPasienDataGridView.Name = "ShowDataPasienDataGridView";
            this.ShowDataPasienDataGridView.ReadOnly = true;
            this.ShowDataPasienDataGridView.RowHeadersWidth = 51;
            this.ShowDataPasienDataGridView.RowTemplate.Height = 24;
            this.ShowDataPasienDataGridView.Size = new System.Drawing.Size(513, 270);
            this.ShowDataPasienDataGridView.TabIndex = 16;
            // 
            // EditButton
            // 
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Location = new System.Drawing.Point(806, 354);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(76, 27);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // HapusButton
            // 
            this.HapusButton.ForeColor = System.Drawing.Color.Black;
            this.HapusButton.Location = new System.Drawing.Point(888, 354);
            this.HapusButton.Name = "HapusButton";
            this.HapusButton.Size = new System.Drawing.Size(78, 27);
            this.HapusButton.TabIndex = 18;
            this.HapusButton.Text = "Delete";
            this.HapusButton.UseVisualStyleBackColor = true;
            this.HapusButton.Click += new System.EventHandler(this.HapusButton_Click);
            // 
            // NotVisibleTextBox
            // 
            this.NotVisibleTextBox.Location = new System.Drawing.Point(279, 23);
            this.NotVisibleTextBox.Name = "NotVisibleTextBox";
            this.NotVisibleTextBox.Size = new System.Drawing.Size(129, 22);
            this.NotVisibleTextBox.TabIndex = 42;
            this.NotVisibleTextBox.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.Location = new System.Drawing.Point(323, 308);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(85, 30);
            this.ResetButton.TabIndex = 44;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CariButton
            // 
            this.CariButton.ForeColor = System.Drawing.Color.Black;
            this.CariButton.Location = new System.Drawing.Point(609, 352);
            this.CariButton.Name = "CariButton";
            this.CariButton.Size = new System.Drawing.Size(76, 27);
            this.CariButton.TabIndex = 45;
            this.CariButton.Text = "Cari";
            this.CariButton.UseVisualStyleBackColor = true;
            this.CariButton.Click += new System.EventHandler(this.CariButton_Click);
            // 
            // FormDataPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 520);
            this.ControlBox = false;
            this.Controls.Add(this.CariButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NotVisibleTextBox);
            this.Controls.Add(this.HapusButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ShowDataPasienDataGridView);
            this.Controls.Add(this.FilterPasienTextBox);
            this.Controls.Add(this.SimpanButton);
            this.Controls.Add(this.PerempuanRadioButton);
            this.Controls.Add(this.LakiLakiRadioButton);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.PekerjaanTextBox);
            this.Controls.Add(this.Pekerjaan);
            this.Controls.Add(this.TanggalLahirDateTimePicker);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.TempatLahirTextBox);
            this.Controls.Add(this.TempatLahir);
            this.Controls.Add(this.NIKTextBox);
            this.Controls.Add(this.NIK);
            this.Controls.Add(this.NamaLengkapTextBox);
            this.Controls.Add(this.NamaLengkap);
            this.Controls.Add(this.KembaliButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormDataPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data Pasien";
            this.Load += new System.EventHandler(this.FormDataPasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataPasienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KembaliButton;
        private System.Windows.Forms.Label NamaLengkap;
        private System.Windows.Forms.TextBox NamaLengkapTextBox;
        private System.Windows.Forms.TextBox NIKTextBox;
        private System.Windows.Forms.Label NIK;
        private System.Windows.Forms.TextBox TempatLahirTextBox;
        private System.Windows.Forms.Label TempatLahir;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.DateTimePicker TanggalLahirDateTimePicker;
        private System.Windows.Forms.TextBox PekerjaanTextBox;
        private System.Windows.Forms.Label Pekerjaan;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.RadioButton LakiLakiRadioButton;
        private System.Windows.Forms.RadioButton PerempuanRadioButton;
        private System.Windows.Forms.Button SimpanButton;
        private System.Windows.Forms.TextBox FilterPasienTextBox;
        private System.Windows.Forms.DataGridView ShowDataPasienDataGridView;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button HapusButton;
        private System.Windows.Forms.TextBox NotVisibleTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CariButton;
    }
}