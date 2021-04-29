
namespace Apotek_PBO
{
    partial class FormObatKeluar
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
            this.lblNamaKeluar = new System.Windows.Forms.Label();
            this.lblJumlahKeluar = new System.Windows.Forms.Label();
            this.lblUkuranKeluar = new System.Windows.Forms.Label();
            this.lblTanggalKeluar = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.tbNamaKeluar = new System.Windows.Forms.TextBox();
            this.tbJumlahKeluar = new System.Windows.Forms.TextBox();
            this.tbUkuranKeluar = new System.Windows.Forms.TextBox();
            this.dtTanggalKeluar = new System.Windows.Forms.DateTimePicker();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNamaKeluar
            // 
            this.lblNamaKeluar.AutoSize = true;
            this.lblNamaKeluar.Location = new System.Drawing.Point(80, 49);
            this.lblNamaKeluar.Name = "lblNamaKeluar";
            this.lblNamaKeluar.Size = new System.Drawing.Size(68, 25);
            this.lblNamaKeluar.TabIndex = 0;
            this.lblNamaKeluar.Text = "Nama :";
            // 
            // lblJumlahKeluar
            // 
            this.lblJumlahKeluar.AutoSize = true;
            this.lblJumlahKeluar.Location = new System.Drawing.Point(80, 125);
            this.lblJumlahKeluar.Name = "lblJumlahKeluar";
            this.lblJumlahKeluar.Size = new System.Drawing.Size(76, 25);
            this.lblJumlahKeluar.TabIndex = 1;
            this.lblJumlahKeluar.Text = "Jumlah :";
            // 
            // lblUkuranKeluar
            // 
            this.lblUkuranKeluar.AutoSize = true;
            this.lblUkuranKeluar.Location = new System.Drawing.Point(80, 196);
            this.lblUkuranKeluar.Name = "lblUkuranKeluar";
            this.lblUkuranKeluar.Size = new System.Drawing.Size(77, 25);
            this.lblUkuranKeluar.TabIndex = 2;
            this.lblUkuranKeluar.Text = "Ukuran :";
            // 
            // lblTanggalKeluar
            // 
            this.lblTanggalKeluar.AutoSize = true;
            this.lblTanggalKeluar.Location = new System.Drawing.Point(80, 269);
            this.lblTanggalKeluar.Name = "lblTanggalKeluar";
            this.lblTanggalKeluar.Size = new System.Drawing.Size(82, 25);
            this.lblTanggalKeluar.TabIndex = 3;
            this.lblTanggalKeluar.Text = "Tanggal :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(80, 337);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(98, 25);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer :";
            // 
            // tbNamaKeluar
            // 
            this.tbNamaKeluar.Location = new System.Drawing.Point(183, 46);
            this.tbNamaKeluar.Name = "tbNamaKeluar";
            this.tbNamaKeluar.Size = new System.Drawing.Size(433, 31);
            this.tbNamaKeluar.TabIndex = 5;
            // 
            // tbJumlahKeluar
            // 
            this.tbJumlahKeluar.Location = new System.Drawing.Point(183, 122);
            this.tbJumlahKeluar.Name = "tbJumlahKeluar";
            this.tbJumlahKeluar.Size = new System.Drawing.Size(433, 31);
            this.tbJumlahKeluar.TabIndex = 6;
            // 
            // tbUkuranKeluar
            // 
            this.tbUkuranKeluar.Location = new System.Drawing.Point(183, 193);
            this.tbUkuranKeluar.Name = "tbUkuranKeluar";
            this.tbUkuranKeluar.Size = new System.Drawing.Size(433, 31);
            this.tbUkuranKeluar.TabIndex = 7;
            // 
            // dtTanggalKeluar
            // 
            this.dtTanggalKeluar.Location = new System.Drawing.Point(183, 264);
            this.dtTanggalKeluar.Name = "dtTanggalKeluar";
            this.dtTanggalKeluar.Size = new System.Drawing.Size(433, 31);
            this.dtTanggalKeluar.TabIndex = 8;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(184, 334);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(432, 31);
            this.tbCustomer.TabIndex = 9;
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(184, 403);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(112, 34);
            this.btnKurang.TabIndex = 10;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(503, 403);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(113, 34);
            this.btnTutup.TabIndex = 11;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // FormObatKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 478);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.dtTanggalKeluar);
            this.Controls.Add(this.tbUkuranKeluar);
            this.Controls.Add(this.tbJumlahKeluar);
            this.Controls.Add(this.tbNamaKeluar);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTanggalKeluar);
            this.Controls.Add(this.lblUkuranKeluar);
            this.Controls.Add(this.lblJumlahKeluar);
            this.Controls.Add(this.lblNamaKeluar);
            this.Name = "FormObatKeluar";
            this.Text = "Obat Keluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaKeluar;
        private System.Windows.Forms.Label lblJumlahKeluar;
        private System.Windows.Forms.Label lblUkuranKeluar;
        private System.Windows.Forms.Label lblTanggalKeluar;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox tbNamaKeluar;
        private System.Windows.Forms.TextBox tbJumlahKeluar;
        private System.Windows.Forms.TextBox tbUkuranKeluar;
        private System.Windows.Forms.DateTimePicker dtTanggalKeluar;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTutupKeluar;
        private System.Windows.Forms.Button btnTutup;
    }
}