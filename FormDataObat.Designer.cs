namespace RumahSakitMitraSehat
{
    partial class FormDataObat
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
            this.FilterObatDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterObatTextBox = new System.Windows.Forms.TextBox();
            this.SimpanButton = new System.Windows.Forms.Button();
            this.HargaLabel = new System.Windows.Forms.Label();
            this.KuantitasLabel = new System.Windows.Forms.Label();
            this.IndikasiTextBox = new System.Windows.Forms.TextBox();
            this.IndikasiLabel = new System.Windows.Forms.Label();
            this.NamaObatTextBox = new System.Windows.Forms.TextBox();
            this.NamaObatLabel = new System.Windows.Forms.Label();
            this.KembaliButton = new System.Windows.Forms.Button();
            this.HargaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CariButton = new System.Windows.Forms.Button();
            this.NotVisibleTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.KuantitasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FilterObatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HargaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KuantitasNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HapusButton
            // 
            this.HapusButton.ForeColor = System.Drawing.Color.Black;
            this.HapusButton.Location = new System.Drawing.Point(888, 354);
            this.HapusButton.Name = "HapusButton";
            this.HapusButton.Size = new System.Drawing.Size(78, 27);
            this.HapusButton.TabIndex = 37;
            this.HapusButton.Text = "Delete";
            this.HapusButton.UseVisualStyleBackColor = true;
            this.HapusButton.Click += new System.EventHandler(this.HapusButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Location = new System.Drawing.Point(806, 354);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(76, 27);
            this.EditButton.TabIndex = 36;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FilterObatDataGridView
            // 
            this.FilterObatDataGridView.AllowUserToAddRows = false;
            this.FilterObatDataGridView.AllowUserToDeleteRows = false;
            this.FilterObatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterObatDataGridView.Location = new System.Drawing.Point(453, 67);
            this.FilterObatDataGridView.MultiSelect = false;
            this.FilterObatDataGridView.Name = "FilterObatDataGridView";
            this.FilterObatDataGridView.ReadOnly = true;
            this.FilterObatDataGridView.RowHeadersWidth = 51;
            this.FilterObatDataGridView.RowTemplate.Height = 24;
            this.FilterObatDataGridView.Size = new System.Drawing.Size(513, 270);
            this.FilterObatDataGridView.TabIndex = 35;
            // 
            // FilterObatTextBox
            // 
            this.FilterObatTextBox.AccessibleName = "";
            this.FilterObatTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FilterObatTextBox.Location = new System.Drawing.Point(453, 354);
            this.FilterObatTextBox.Name = "FilterObatTextBox";
            this.FilterObatTextBox.Size = new System.Drawing.Size(150, 22);
            this.FilterObatTextBox.TabIndex = 34;
            this.FilterObatTextBox.Text = "Filter Obat";
            this.FilterObatTextBox.GotFocus += new System.EventHandler(this.FilterObatTextBox_OnFocus);
            this.FilterObatTextBox.LostFocus += new System.EventHandler(this.FilterObatTextBox_LoseFocus);
            // 
            // SimpanButton
            // 
            this.SimpanButton.ForeColor = System.Drawing.Color.Black;
            this.SimpanButton.Location = new System.Drawing.Point(166, 225);
            this.SimpanButton.Name = "SimpanButton";
            this.SimpanButton.Size = new System.Drawing.Size(135, 38);
            this.SimpanButton.TabIndex = 33;
            this.SimpanButton.Text = "Simpan";
            this.SimpanButton.UseVisualStyleBackColor = true;
            this.SimpanButton.Click += new System.EventHandler(this.SimpanButton_Click);
            // 
            // HargaLabel
            // 
            this.HargaLabel.AutoSize = true;
            this.HargaLabel.Location = new System.Drawing.Point(26, 173);
            this.HargaLabel.Name = "HargaLabel";
            this.HargaLabel.Size = new System.Drawing.Size(45, 16);
            this.HargaLabel.TabIndex = 28;
            this.HargaLabel.Text = "Harga";
            // 
            // KuantitasLabel
            // 
            this.KuantitasLabel.AutoSize = true;
            this.KuantitasLabel.Location = new System.Drawing.Point(26, 136);
            this.KuantitasLabel.Name = "KuantitasLabel";
            this.KuantitasLabel.Size = new System.Drawing.Size(61, 16);
            this.KuantitasLabel.TabIndex = 24;
            this.KuantitasLabel.Text = "Kuantitas";
            // 
            // IndikasiTextBox
            // 
            this.IndikasiTextBox.Location = new System.Drawing.Point(166, 101);
            this.IndikasiTextBox.Name = "IndikasiTextBox";
            this.IndikasiTextBox.Size = new System.Drawing.Size(242, 22);
            this.IndikasiTextBox.TabIndex = 23;
            // 
            // IndikasiLabel
            // 
            this.IndikasiLabel.AutoSize = true;
            this.IndikasiLabel.Location = new System.Drawing.Point(26, 101);
            this.IndikasiLabel.Name = "IndikasiLabel";
            this.IndikasiLabel.Size = new System.Drawing.Size(53, 16);
            this.IndikasiLabel.TabIndex = 22;
            this.IndikasiLabel.Text = "Indikasi";
            // 
            // NamaObatTextBox
            // 
            this.NamaObatTextBox.Location = new System.Drawing.Point(166, 67);
            this.NamaObatTextBox.Name = "NamaObatTextBox";
            this.NamaObatTextBox.Size = new System.Drawing.Size(242, 22);
            this.NamaObatTextBox.TabIndex = 21;
            // 
            // NamaObatLabel
            // 
            this.NamaObatLabel.AutoSize = true;
            this.NamaObatLabel.Location = new System.Drawing.Point(26, 67);
            this.NamaObatLabel.Name = "NamaObatLabel";
            this.NamaObatLabel.Size = new System.Drawing.Size(76, 16);
            this.NamaObatLabel.TabIndex = 20;
            this.NamaObatLabel.Text = "Nama Obat";
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
            // HargaNumericUpDown
            // 
            this.HargaNumericUpDown.Location = new System.Drawing.Point(166, 173);
            this.HargaNumericUpDown.Name = "HargaNumericUpDown";
            this.HargaNumericUpDown.Size = new System.Drawing.Size(242, 22);
            this.HargaNumericUpDown.TabIndex = 38;
            // 
            // CariButton
            // 
            this.CariButton.ForeColor = System.Drawing.Color.Black;
            this.CariButton.Location = new System.Drawing.Point(609, 352);
            this.CariButton.Name = "CariButton";
            this.CariButton.Size = new System.Drawing.Size(76, 27);
            this.CariButton.TabIndex = 41;
            this.CariButton.Text = "Cari";
            this.CariButton.UseVisualStyleBackColor = true;
            this.CariButton.Click += new System.EventHandler(this.CariButton_Click);
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
            this.ResetButton.Location = new System.Drawing.Point(323, 229);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(85, 30);
            this.ResetButton.TabIndex = 43;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // KuantitasNumericUpDown
            // 
            this.KuantitasNumericUpDown.Location = new System.Drawing.Point(166, 136);
            this.KuantitasNumericUpDown.Name = "KuantitasNumericUpDown";
            this.KuantitasNumericUpDown.Size = new System.Drawing.Size(242, 22);
            this.KuantitasNumericUpDown.TabIndex = 44;
            // 
            // FormDataObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1005, 520);
            this.ControlBox = false;
            this.Controls.Add(this.KuantitasNumericUpDown);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NotVisibleTextBox);
            this.Controls.Add(this.CariButton);
            this.Controls.Add(this.HargaNumericUpDown);
            this.Controls.Add(this.HapusButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.FilterObatDataGridView);
            this.Controls.Add(this.FilterObatTextBox);
            this.Controls.Add(this.SimpanButton);
            this.Controls.Add(this.HargaLabel);
            this.Controls.Add(this.KuantitasLabel);
            this.Controls.Add(this.IndikasiTextBox);
            this.Controls.Add(this.IndikasiLabel);
            this.Controls.Add(this.NamaObatTextBox);
            this.Controls.Add(this.NamaObatLabel);
            this.Controls.Add(this.KembaliButton);
            this.Name = "FormDataObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data Obat";
            this.Load += new System.EventHandler(this.FormDataObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilterObatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HargaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KuantitasNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HapusButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView FilterObatDataGridView;
        private System.Windows.Forms.TextBox FilterObatTextBox;
        private System.Windows.Forms.Button SimpanButton;
        private System.Windows.Forms.Label HargaLabel;
        private System.Windows.Forms.Label KuantitasLabel;
        private System.Windows.Forms.TextBox IndikasiTextBox;
        private System.Windows.Forms.Label IndikasiLabel;
        private System.Windows.Forms.TextBox NamaObatTextBox;
        private System.Windows.Forms.Label NamaObatLabel;
        private System.Windows.Forms.Button KembaliButton;
        private System.Windows.Forms.NumericUpDown HargaNumericUpDown;
        private System.Windows.Forms.Button CariButton;
        private System.Windows.Forms.TextBox NotVisibleTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.NumericUpDown KuantitasNumericUpDown;
    }
}