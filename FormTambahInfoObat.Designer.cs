
namespace Apotek_PBO
{
    partial class FormTambahInfoObat
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
            this.lblObatName = new System.Windows.Forms.Label();
            this.lblObatKomposisi = new System.Windows.Forms.Label();
            this.lblObatKegunaan = new System.Windows.Forms.Label();
            this.lblObatJenis = new System.Windows.Forms.Label();
            this.lblObatHarga = new System.Windows.Forms.Label();
            this.rtbObatKomposisi = new System.Windows.Forms.RichTextBox();
            this.tbObatName = new System.Windows.Forms.TextBox();
            this.tbObatKegunaan = new System.Windows.Forms.TextBox();
            this.tbObatHarga = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cbObatJenis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblObatName
            // 
            this.lblObatName.AutoSize = true;
            this.lblObatName.Location = new System.Drawing.Point(87, 90);
            this.lblObatName.Name = "lblObatName";
            this.lblObatName.Size = new System.Drawing.Size(51, 15);
            this.lblObatName.TabIndex = 0;
            this.lblObatName.Text = "Nama  : ";
            // 
            // lblObatKomposisi
            // 
            this.lblObatKomposisi.AutoSize = true;
            this.lblObatKomposisi.Location = new System.Drawing.Point(87, 178);
            this.lblObatKomposisi.Name = "lblObatKomposisi";
            this.lblObatKomposisi.Size = new System.Drawing.Size(68, 15);
            this.lblObatKomposisi.TabIndex = 1;
            this.lblObatKomposisi.Text = "Komposisi :";
            // 
            // lblObatKegunaan
            // 
            this.lblObatKegunaan.AutoSize = true;
            this.lblObatKegunaan.Location = new System.Drawing.Point(87, 264);
            this.lblObatKegunaan.Name = "lblObatKegunaan";
            this.lblObatKegunaan.Size = new System.Drawing.Size(69, 15);
            this.lblObatKegunaan.TabIndex = 2;
            this.lblObatKegunaan.Text = "Kegunaan : ";
            // 
            // lblObatJenis
            // 
            this.lblObatJenis.AutoSize = true;
            this.lblObatJenis.Location = new System.Drawing.Point(87, 135);
            this.lblObatJenis.Name = "lblObatJenis";
            this.lblObatJenis.Size = new System.Drawing.Size(41, 15);
            this.lblObatJenis.TabIndex = 3;
            this.lblObatJenis.Text = "Jenis : ";
            // 
            // lblObatHarga
            // 
            this.lblObatHarga.AutoSize = true;
            this.lblObatHarga.Location = new System.Drawing.Point(87, 307);
            this.lblObatHarga.Name = "lblObatHarga";
            this.lblObatHarga.Size = new System.Drawing.Size(48, 15);
            this.lblObatHarga.TabIndex = 4;
            this.lblObatHarga.Text = "Harga : ";
            // 
            // rtbObatKomposisi
            // 
            this.rtbObatKomposisi.Location = new System.Drawing.Point(162, 175);
            this.rtbObatKomposisi.Name = "rtbObatKomposisi";
            this.rtbObatKomposisi.Size = new System.Drawing.Size(265, 63);
            this.rtbObatKomposisi.TabIndex = 5;
            this.rtbObatKomposisi.Text = "";
            // 
            // tbObatName
            // 
            this.tbObatName.Location = new System.Drawing.Point(162, 87);
            this.tbObatName.Name = "tbObatName";
            this.tbObatName.Size = new System.Drawing.Size(265, 23);
            this.tbObatName.TabIndex = 6;
            // 
            // tbObatKegunaan
            // 
            this.tbObatKegunaan.Location = new System.Drawing.Point(162, 261);
            this.tbObatKegunaan.Name = "tbObatKegunaan";
            this.tbObatKegunaan.Size = new System.Drawing.Size(265, 23);
            this.tbObatKegunaan.TabIndex = 7;
            // 
            // tbObatHarga
            // 
            this.tbObatHarga.Location = new System.Drawing.Point(162, 304);
            this.tbObatHarga.Name = "tbObatHarga";
            this.tbObatHarga.Size = new System.Drawing.Size(265, 23);
            this.tbObatHarga.TabIndex = 8;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(162, 350);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cbObatJenis
            // 
            this.cbObatJenis.FormattingEnabled = true;
            this.cbObatJenis.Items.AddRange(new object[] {
            "Tablet",
            "Pil",
            "Kapsul",
            "Kaplet",
            "Larutan",
            "Infusa",
            "Salep",
            "Obat Tetes"});
            this.cbObatJenis.Location = new System.Drawing.Point(162, 132);
            this.cbObatJenis.Name = "cbObatJenis";
            this.cbObatJenis.Size = new System.Drawing.Size(265, 23);
            this.cbObatJenis.TabIndex = 10;
            // 
            // FormTambahObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbObatJenis);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.tbObatHarga);
            this.Controls.Add(this.tbObatKegunaan);
            this.Controls.Add(this.tbObatName);
            this.Controls.Add(this.rtbObatKomposisi);
            this.Controls.Add(this.lblObatHarga);
            this.Controls.Add(this.lblObatJenis);
            this.Controls.Add(this.lblObatKegunaan);
            this.Controls.Add(this.lblObatKomposisi);
            this.Controls.Add(this.lblObatName);
            this.Name = "FormTambahObat";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObatName;
        private System.Windows.Forms.Label lblObatKomposisi;
        private System.Windows.Forms.Label lblObatKegunaan;
        private System.Windows.Forms.Label lblObatJenis;
        private System.Windows.Forms.Label lblObatHarga;
        private System.Windows.Forms.RichTextBox rtbObatKomposisi;
        private System.Windows.Forms.TextBox tbObatName;
        private System.Windows.Forms.TextBox tbObatKegunaan;
        private System.Windows.Forms.TextBox tbObatHarga;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cbObatJenis;
    }
}