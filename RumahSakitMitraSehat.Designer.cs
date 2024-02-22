namespace RumahSakitMitraSehat
{
    partial class RumahSakitMitraSehat
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
        /// 

        private void InitializeComponent()
        {
            this.MasterData = new System.Windows.Forms.GroupBox();
            this.DataDokter = new System.Windows.Forms.Button();
            this.dataPasien = new System.Windows.Forms.Button();
            this.DataObat = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DataPemeriksaanCheckUp = new System.Windows.Forms.GroupBox();
            this.DataCheckup = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.MasterData.SuspendLayout();
            this.DataPemeriksaanCheckUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterData
            // 
            this.MasterData.Controls.Add(this.DataDokter);
            this.MasterData.Controls.Add(this.DataObat);
            this.MasterData.Controls.Add(this.dataPasien);
            this.MasterData.Location = new System.Drawing.Point(28, 28);
            this.MasterData.Name = "MasterData";
            this.MasterData.Size = new System.Drawing.Size(552, 80);
            this.MasterData.TabIndex = 0;
            this.MasterData.TabStop = false;
            this.MasterData.Text = "Master Data";
            // 
            // DataDokter
            // 
            this.DataDokter.Location = new System.Drawing.Point(158, 34);
            this.DataDokter.Name = "DataDokter";
            this.DataDokter.Size = new System.Drawing.Size(111, 27);
            this.DataDokter.TabIndex = 1;
            this.DataDokter.Text = "Data Dokter";
            this.DataDokter.UseVisualStyleBackColor = true;
            this.DataDokter.Click += new System.EventHandler(this.DataDokter_Click);
            // 
            // dataPasien
            // 
            this.dataPasien.Location = new System.Drawing.Point(18, 34);
            this.dataPasien.Name = "dataPasien";
            this.dataPasien.Size = new System.Drawing.Size(108, 27);
            this.dataPasien.TabIndex = 0;
            this.dataPasien.Text = "Data Pasien";
            this.dataPasien.UseVisualStyleBackColor = true;
            this.dataPasien.Click += new System.EventHandler(this.DataPasien_Click);
            // 
            // DataObat
            // 
            this.DataObat.Location = new System.Drawing.Point(304, 34);
            this.DataObat.Name = "DataObat";
            this.DataObat.Size = new System.Drawing.Size(97, 27);
            this.DataObat.TabIndex = 2;
            this.DataObat.Text = "Data Obat";
            this.DataObat.UseVisualStyleBackColor = true;
            this.DataObat.Click += new System.EventHandler(this.DataObat_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Location = new System.Drawing.Point(561, 24);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(36, 31);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DataPemeriksaanCheckUp
            // 
            this.DataPemeriksaanCheckUp.Controls.Add(this.DataCheckup);
            this.DataPemeriksaanCheckUp.Location = new System.Drawing.Point(28, 134);
            this.DataPemeriksaanCheckUp.Name = "DataPemeriksaanCheckUp";
            this.DataPemeriksaanCheckUp.Size = new System.Drawing.Size(552, 80);
            this.DataPemeriksaanCheckUp.TabIndex = 3;
            this.DataPemeriksaanCheckUp.TabStop = false;
            this.DataPemeriksaanCheckUp.Text = "Data Pemeriksaan/CheckUp";
            // 
            // DataCheckup
            // 
            this.DataCheckup.Location = new System.Drawing.Point(18, 34);
            this.DataCheckup.Name = "DataCheckup";
            this.DataCheckup.Size = new System.Drawing.Size(108, 29);
            this.DataCheckup.TabIndex = 0;
            this.DataCheckup.Text = "Data Checkup";
            this.DataCheckup.UseVisualStyleBackColor = true;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(25, 239);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(521, 16);
            this.Copyright.TabIndex = 5;
            this.Copyright.Text = "Dikembangkan Oleh: D4 Teknologi Rekayasa Komputer - Politeknik Negeri Semarang";
            // 
            // RumahSakitMitraSehat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 284);
            this.ControlBox = false;
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DataPemeriksaanCheckUp);
            this.Controls.Add(this.MasterData);
            this.Name = "RumahSakitMitraSehat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rumah Sakit Mitra Sehat";
            this.MasterData.ResumeLayout(false);
            this.DataPemeriksaanCheckUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MasterData;
        private System.Windows.Forms.Button DataObat;
        private System.Windows.Forms.Button DataDokter;
        private System.Windows.Forms.Button dataPasien;
        private System.Windows.Forms.GroupBox DataPemeriksaanCheckUp;
        private System.Windows.Forms.Button DataCheckup;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Copyright;
    }
}

