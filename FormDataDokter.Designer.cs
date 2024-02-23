using System.Windows.Forms;

namespace RumahSakitMitraSehat
{
    partial class FormDataDokter
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
            this.HapusButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.FilterDokterDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterDokterTextBox = new System.Windows.Forms.TextBox();
            this.SimpanButton = new System.Windows.Forms.Button();
            this.PerempuanRadioButton = new System.Windows.Forms.RadioButton();
            this.LakiLakiRadioButton = new System.Windows.Forms.RadioButton();
            this.JenisKelaminLabel = new System.Windows.Forms.Label();
            this.SpesialisasiLabel = new System.Windows.Forms.Label();
            this.TanggalLahirDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TanggalLahirLabel = new System.Windows.Forms.Label();
            this.TempatLahirTextBox = new System.Windows.Forms.TextBox();
            this.TempatLahirLabel = new System.Windows.Forms.Label();
            this.NIKTextBox = new System.Windows.Forms.TextBox();
            this.NIKLabel = new System.Windows.Forms.Label();
            this.NamaLengkapTextBox = new System.Windows.Forms.TextBox();
            this.NamaLengkapLabel = new System.Windows.Forms.Label();
            this.KembaliButton = new System.Windows.Forms.Button();
            this.SpesialisasiComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilterDokterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HapusButton
            // 
            this.HapusButton.ForeColor = System.Drawing.Color.Black;
            this.HapusButton.Location = new System.Drawing.Point(754, 352);
            this.HapusButton.Name = "HapusButton";
            this.HapusButton.Size = new System.Drawing.Size(78, 27);
            this.HapusButton.TabIndex = 37;
            this.HapusButton.Text = "Delete";
            this.HapusButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Location = new System.Drawing.Point(672, 352);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(76, 27);
            this.EditButton.TabIndex = 36;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // FilterDokterDataGridView
            // 
            this.FilterDokterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterDokterDataGridView.Location = new System.Drawing.Point(453, 67);
            this.FilterDokterDataGridView.Name = "FilterDokterDataGridView";
            this.FilterDokterDataGridView.RowHeadersWidth = 51;
            this.FilterDokterDataGridView.RowTemplate.Height = 24;
            this.FilterDokterDataGridView.Size = new System.Drawing.Size(379, 270);
            this.FilterDokterDataGridView.TabIndex = 35;
            // 
            // FilterDokterTextBox
            // 
            this.FilterDokterTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FilterDokterTextBox.Location = new System.Drawing.Point(453, 354);
            this.FilterDokterTextBox.Name = "FilterDokterTextBox";
            this.FilterDokterTextBox.Size = new System.Drawing.Size(150, 22);
            this.FilterDokterTextBox.TabIndex = 34;
            this.FilterDokterTextBox.Text = "Filter Dokter";
            this.FilterDokterTextBox.GotFocus += new System.EventHandler(this.FilterDokterTextBox_OnFocus);
            this.FilterDokterTextBox.LostFocus += new System.EventHandler(this.FilterDokterTextBox_LoseFocus);
            // 
            // SimpanButton
            // 
            this.SimpanButton.ForeColor = System.Drawing.Color.Black;
            this.SimpanButton.Location = new System.Drawing.Point(166, 304);
            this.SimpanButton.Name = "SimpanButton";
            this.SimpanButton.Size = new System.Drawing.Size(128, 33);
            this.SimpanButton.TabIndex = 33;
            this.SimpanButton.Text = "Simpan";
            this.SimpanButton.UseVisualStyleBackColor = true;
            // 
            // PerempuanRadioButton
            // 
            this.PerempuanRadioButton.AutoSize = true;
            this.PerempuanRadioButton.Location = new System.Drawing.Point(279, 214);
            this.PerempuanRadioButton.Name = "PerempuanRadioButton";
            this.PerempuanRadioButton.Size = new System.Drawing.Size(98, 20);
            this.PerempuanRadioButton.TabIndex = 32;
            this.PerempuanRadioButton.TabStop = true;
            this.PerempuanRadioButton.Text = "Perempuan";
            this.PerempuanRadioButton.UseVisualStyleBackColor = true;
            // 
            // LakiLakiRadioButton
            // 
            this.LakiLakiRadioButton.AutoSize = true;
            this.LakiLakiRadioButton.Location = new System.Drawing.Point(166, 214);
            this.LakiLakiRadioButton.Name = "LakiLakiRadioButton";
            this.LakiLakiRadioButton.Size = new System.Drawing.Size(82, 20);
            this.LakiLakiRadioButton.TabIndex = 31;
            this.LakiLakiRadioButton.TabStop = true;
            this.LakiLakiRadioButton.Text = "Laki-Laki";
            this.LakiLakiRadioButton.UseVisualStyleBackColor = true;
            // 
            // JenisKelaminLabel
            // 
            this.JenisKelaminLabel.AutoSize = true;
            this.JenisKelaminLabel.Location = new System.Drawing.Point(26, 214);
            this.JenisKelaminLabel.Name = "JenisKelaminLabel";
            this.JenisKelaminLabel.Size = new System.Drawing.Size(90, 16);
            this.JenisKelaminLabel.TabIndex = 30;
            this.JenisKelaminLabel.Text = "Jenis Kelamin";
            // 
            // SpesialisasiLabel
            // 
            this.SpesialisasiLabel.AutoSize = true;
            this.SpesialisasiLabel.Location = new System.Drawing.Point(26, 253);
            this.SpesialisasiLabel.Name = "SpesialisasiLabel";
            this.SpesialisasiLabel.Size = new System.Drawing.Size(81, 16);
            this.SpesialisasiLabel.TabIndex = 28;
            this.SpesialisasiLabel.Text = "Spesialisasi";
            // 
            // TanggalLahirDateTimePicker
            // 
            this.TanggalLahirDateTimePicker.Location = new System.Drawing.Point(166, 137);
            this.TanggalLahirDateTimePicker.Name = "TanggalLahirDateTimePicker";
            this.TanggalLahirDateTimePicker.Size = new System.Drawing.Size(242, 22);
            this.TanggalLahirDateTimePicker.TabIndex = 27;
            // 
            // TanggalLahirLabel
            // 
            this.TanggalLahirLabel.AutoSize = true;
            this.TanggalLahirLabel.Location = new System.Drawing.Point(26, 137);
            this.TanggalLahirLabel.Name = "TanggalLahirLabel";
            this.TanggalLahirLabel.Size = new System.Drawing.Size(90, 16);
            this.TanggalLahirLabel.TabIndex = 26;
            this.TanggalLahirLabel.Text = "Tanggal Lahir";
            // 
            // TempatLahirTextBox
            // 
            this.TempatLahirTextBox.Location = new System.Drawing.Point(166, 173);
            this.TempatLahirTextBox.Name = "TempatLahirTextBox";
            this.TempatLahirTextBox.Size = new System.Drawing.Size(242, 22);
            this.TempatLahirTextBox.TabIndex = 25;
            // 
            // TempatLahirLabel
            // 
            this.TempatLahirLabel.AutoSize = true;
            this.TempatLahirLabel.Location = new System.Drawing.Point(26, 173);
            this.TempatLahirLabel.Name = "TempatLahirLabel";
            this.TempatLahirLabel.Size = new System.Drawing.Size(86, 16);
            this.TempatLahirLabel.TabIndex = 24;
            this.TempatLahirLabel.Text = "Tempat Lahir";
            // 
            // NIKTextBox
            // 
            this.NIKTextBox.Location = new System.Drawing.Point(166, 101);
            this.NIKTextBox.Name = "NIKTextBox";
            this.NIKTextBox.Size = new System.Drawing.Size(242, 22);
            this.NIKTextBox.TabIndex = 23;
            // 
            // NIKLabel
            // 
            this.NIKLabel.AutoSize = true;
            this.NIKLabel.Location = new System.Drawing.Point(26, 101);
            this.NIKLabel.Name = "NIKLabel";
            this.NIKLabel.Size = new System.Drawing.Size(28, 16);
            this.NIKLabel.TabIndex = 22;
            this.NIKLabel.Text = "NIK";
            // 
            // NamaLengkapTextBox
            // 
            this.NamaLengkapTextBox.Location = new System.Drawing.Point(166, 67);
            this.NamaLengkapTextBox.Name = "NamaLengkapTextBox";
            this.NamaLengkapTextBox.Size = new System.Drawing.Size(242, 22);
            this.NamaLengkapTextBox.TabIndex = 21;
            // 
            // NamaLengkapLabel
            // 
            this.NamaLengkapLabel.AutoSize = true;
            this.NamaLengkapLabel.Location = new System.Drawing.Point(26, 67);
            this.NamaLengkapLabel.Name = "NamaLengkapLabel";
            this.NamaLengkapLabel.Size = new System.Drawing.Size(100, 16);
            this.NamaLengkapLabel.TabIndex = 20;
            this.NamaLengkapLabel.Text = "Nama Lengkap";
            // 
            // KembaliButton
            // 
            this.KembaliButton.Location = new System.Drawing.Point(24, 23);
            this.KembaliButton.Name = "KembaliButton";
            this.KembaliButton.Size = new System.Drawing.Size(107, 29);
            this.KembaliButton.TabIndex = 19;
            this.KembaliButton.Text = "<< Kembali";
            this.KembaliButton.UseVisualStyleBackColor = true;
            this.KembaliButton.Click += new System.EventHandler(this.KembaliButton_Click);
            // 
            // SpesialisasiComboBox
            // 
            this.SpesialisasiComboBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SpesialisasiComboBox.FormattingEnabled = true;
            this.SpesialisasiComboBox.Location = new System.Drawing.Point(166, 253);
            this.SpesialisasiComboBox.Name = "SpesialisasiComboBox";
            this.SpesialisasiComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpesialisasiComboBox.Size = new System.Drawing.Size(242, 24);
            this.SpesialisasiComboBox.TabIndex = 38;
            this.SpesialisasiComboBox.Text = "Spesialisasi";
            this.SpesialisasiComboBox.GotFocus += new System.EventHandler(this.SpesialisasiComboBox_OnFocus);
            this.SpesialisasiComboBox.LostFocus += new System.EventHandler(this.SpesialisasiComboBox_LoseFocus);
            // 
            // FormDataDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 520);
            this.ControlBox = false;
            this.Controls.Add(this.SpesialisasiComboBox);
            this.Controls.Add(this.HapusButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.FilterDokterDataGridView);
            this.Controls.Add(this.FilterDokterTextBox);
            this.Controls.Add(this.SimpanButton);
            this.Controls.Add(this.PerempuanRadioButton);
            this.Controls.Add(this.LakiLakiRadioButton);
            this.Controls.Add(this.JenisKelaminLabel);
            this.Controls.Add(this.SpesialisasiLabel);
            this.Controls.Add(this.TanggalLahirDateTimePicker);
            this.Controls.Add(this.TanggalLahirLabel);
            this.Controls.Add(this.TempatLahirTextBox);
            this.Controls.Add(this.TempatLahirLabel);
            this.Controls.Add(this.NIKTextBox);
            this.Controls.Add(this.NIKLabel);
            this.Controls.Add(this.NamaLengkapTextBox);
            this.Controls.Add(this.NamaLengkapLabel);
            this.Controls.Add(this.KembaliButton);
            this.Name = "FormDataDokter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data Dokter";
            this.Load += new System.EventHandler(this.FormDataDokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilterDokterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HapusButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView FilterDokterDataGridView;
        private System.Windows.Forms.TextBox FilterDokterTextBox;
        private System.Windows.Forms.Button SimpanButton;
        private System.Windows.Forms.RadioButton PerempuanRadioButton;
        private System.Windows.Forms.RadioButton LakiLakiRadioButton;
        private System.Windows.Forms.Label JenisKelaminLabel;
        private System.Windows.Forms.Label SpesialisasiLabel;
        private System.Windows.Forms.DateTimePicker TanggalLahirDateTimePicker;
        private System.Windows.Forms.Label TanggalLahirLabel;
        private System.Windows.Forms.TextBox TempatLahirTextBox;
        private System.Windows.Forms.Label TempatLahirLabel;
        private System.Windows.Forms.TextBox NIKTextBox;
        private System.Windows.Forms.Label NIKLabel;
        private System.Windows.Forms.TextBox NamaLengkapTextBox;
        private System.Windows.Forms.Label NamaLengkapLabel;
        private System.Windows.Forms.Button KembaliButton;
        private System.Windows.Forms.ComboBox SpesialisasiComboBox;
    }
}