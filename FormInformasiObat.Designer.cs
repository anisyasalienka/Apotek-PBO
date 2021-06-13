
namespace Apotek_PBO
{
    partial class FormInformasiObat
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
            this.dgInformasiObat = new System.Windows.Forms.DataGridView();
            this.tbCariInformasiObat = new System.Windows.Forms.TextBox();
            this.btnCariInformasiObat = new System.Windows.Forms.Button();
            this.lblJenisInformasiObat = new System.Windows.Forms.Label();
            this.lblKomposisiInformasiObat = new System.Windows.Forms.Label();
            this.lblKegunaanInformasiObat = new System.Windows.Forms.Label();
            this.lblUkuranInformasiObat = new System.Windows.Forms.Label();
            this.lblHargaInformasiObat = new System.Windows.Forms.Label();
            this.btnUbahInformasiObat = new System.Windows.Forms.Button();
            this.btnHapusInformasiObat = new System.Windows.Forms.Button();
            this.lblNamaInformasiObat = new System.Windows.Forms.Label();
            this.lblNamaObatInfoObat = new System.Windows.Forms.Label();
            this.lblJenisObatInfoObat = new System.Windows.Forms.Label();
            this.lblUkuranObatInfoObat = new System.Windows.Forms.Label();
            this.lblHargaObatInfoObat = new System.Windows.Forms.Label();
            this.lblKomposisiObatInfoObat = new System.Windows.Forms.Label();
            this.lblKegunaanObatInfoObat = new System.Windows.Forms.Label();
            this.tbCariUkuranInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInformasiObat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInformasiObat
            // 
            this.dgInformasiObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInformasiObat.Location = new System.Drawing.Point(39, 23);
            this.dgInformasiObat.Name = "dgInformasiObat";
            this.dgInformasiObat.RowHeadersWidth = 62;
            this.dgInformasiObat.RowTemplate.Height = 25;
            this.dgInformasiObat.Size = new System.Drawing.Size(716, 241);
            this.dgInformasiObat.TabIndex = 0;
            // 
            // tbCariInformasiObat
            // 
            this.tbCariInformasiObat.Location = new System.Drawing.Point(39, 279);
            this.tbCariInformasiObat.Name = "tbCariInformasiObat";
            this.tbCariInformasiObat.PlaceholderText = "Nama Obat";
            this.tbCariInformasiObat.Size = new System.Drawing.Size(170, 23);
            this.tbCariInformasiObat.TabIndex = 1;
            // 
            // btnCariInformasiObat
            // 
            this.btnCariInformasiObat.BackColor = System.Drawing.SystemColors.Control;
            this.btnCariInformasiObat.BackgroundImage = global::Apotek_PBO.Properties.Resources.Untitled_1_01;
            this.btnCariInformasiObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariInformasiObat.Location = new System.Drawing.Point(315, 278);
            this.btnCariInformasiObat.Name = "btnCariInformasiObat";
            this.btnCariInformasiObat.Size = new System.Drawing.Size(75, 23);
            this.btnCariInformasiObat.TabIndex = 2;
            this.btnCariInformasiObat.Text = "Cari";
            this.btnCariInformasiObat.UseVisualStyleBackColor = false;
            this.btnCariInformasiObat.Click += new System.EventHandler(this.btnCariInformasiObat_Click);
            // 
            // lblJenisInformasiObat
            // 
            this.lblJenisInformasiObat.AutoSize = true;
            this.lblJenisInformasiObat.Location = new System.Drawing.Point(39, 345);
            this.lblJenisInformasiObat.Name = "lblJenisInformasiObat";
            this.lblJenisInformasiObat.Size = new System.Drawing.Size(38, 15);
            this.lblJenisInformasiObat.TabIndex = 4;
            this.lblJenisInformasiObat.Text = "Jenis :";
            // 
            // lblKomposisiInformasiObat
            // 
            this.lblKomposisiInformasiObat.AutoSize = true;
            this.lblKomposisiInformasiObat.Location = new System.Drawing.Point(391, 315);
            this.lblKomposisiInformasiObat.Name = "lblKomposisiInformasiObat";
            this.lblKomposisiInformasiObat.Size = new System.Drawing.Size(68, 15);
            this.lblKomposisiInformasiObat.TabIndex = 5;
            this.lblKomposisiInformasiObat.Text = "Komposisi :";
            // 
            // lblKegunaanInformasiObat
            // 
            this.lblKegunaanInformasiObat.AutoSize = true;
            this.lblKegunaanInformasiObat.Location = new System.Drawing.Point(391, 376);
            this.lblKegunaanInformasiObat.Name = "lblKegunaanInformasiObat";
            this.lblKegunaanInformasiObat.Size = new System.Drawing.Size(66, 15);
            this.lblKegunaanInformasiObat.TabIndex = 6;
            this.lblKegunaanInformasiObat.Text = "Kegunaan :";
            // 
            // lblUkuranInformasiObat
            // 
            this.lblUkuranInformasiObat.AutoSize = true;
            this.lblUkuranInformasiObat.Location = new System.Drawing.Point(39, 376);
            this.lblUkuranInformasiObat.Name = "lblUkuranInformasiObat";
            this.lblUkuranInformasiObat.Size = new System.Drawing.Size(51, 15);
            this.lblUkuranInformasiObat.TabIndex = 7;
            this.lblUkuranInformasiObat.Text = "Ukuran :";
            // 
            // lblHargaInformasiObat
            // 
            this.lblHargaInformasiObat.AutoSize = true;
            this.lblHargaInformasiObat.Location = new System.Drawing.Point(39, 409);
            this.lblHargaInformasiObat.Name = "lblHargaInformasiObat";
            this.lblHargaInformasiObat.Size = new System.Drawing.Size(45, 15);
            this.lblHargaInformasiObat.TabIndex = 8;
            this.lblHargaInformasiObat.Text = "Harga :";
            // 
            // btnUbahInformasiObat
            // 
            this.btnUbahInformasiObat.BackgroundImage = global::Apotek_PBO.Properties.Resources.Untitled_1_01;
            this.btnUbahInformasiObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbahInformasiObat.Location = new System.Drawing.Point(587, 279);
            this.btnUbahInformasiObat.Name = "btnUbahInformasiObat";
            this.btnUbahInformasiObat.Size = new System.Drawing.Size(75, 23);
            this.btnUbahInformasiObat.TabIndex = 9;
            this.btnUbahInformasiObat.Text = "Ubah";
            this.btnUbahInformasiObat.UseVisualStyleBackColor = true;
            this.btnUbahInformasiObat.Click += new System.EventHandler(this.btnUbahInformasiObat_Click);
            // 
            // btnHapusInformasiObat
            // 
            this.btnHapusInformasiObat.BackgroundImage = global::Apotek_PBO.Properties.Resources.Untitled_1_01;
            this.btnHapusInformasiObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusInformasiObat.Location = new System.Drawing.Point(680, 279);
            this.btnHapusInformasiObat.Name = "btnHapusInformasiObat";
            this.btnHapusInformasiObat.Size = new System.Drawing.Size(75, 23);
            this.btnHapusInformasiObat.TabIndex = 10;
            this.btnHapusInformasiObat.Text = "Hapus";
            this.btnHapusInformasiObat.UseVisualStyleBackColor = true;
            this.btnHapusInformasiObat.Click += new System.EventHandler(this.btnHapusInformasiObat_Click);
            // 
            // lblNamaInformasiObat
            // 
            this.lblNamaInformasiObat.AutoSize = true;
            this.lblNamaInformasiObat.Location = new System.Drawing.Point(39, 315);
            this.lblNamaInformasiObat.Name = "lblNamaInformasiObat";
            this.lblNamaInformasiObat.Size = new System.Drawing.Size(45, 15);
            this.lblNamaInformasiObat.TabIndex = 3;
            this.lblNamaInformasiObat.Text = "Nama :";
            // 
            // lblNamaObatInfoObat
            // 
            this.lblNamaObatInfoObat.AutoSize = true;
            this.lblNamaObatInfoObat.Location = new System.Drawing.Point(90, 315);
            this.lblNamaObatInfoObat.Name = "lblNamaObatInfoObat";
            this.lblNamaObatInfoObat.Size = new System.Drawing.Size(12, 15);
            this.lblNamaObatInfoObat.TabIndex = 11;
            this.lblNamaObatInfoObat.Text = "-";
            // 
            // lblJenisObatInfoObat
            // 
            this.lblJenisObatInfoObat.AutoSize = true;
            this.lblJenisObatInfoObat.Location = new System.Drawing.Point(90, 345);
            this.lblJenisObatInfoObat.Name = "lblJenisObatInfoObat";
            this.lblJenisObatInfoObat.Size = new System.Drawing.Size(12, 15);
            this.lblJenisObatInfoObat.TabIndex = 12;
            this.lblJenisObatInfoObat.Text = "-";
            // 
            // lblUkuranObatInfoObat
            // 
            this.lblUkuranObatInfoObat.AutoSize = true;
            this.lblUkuranObatInfoObat.Location = new System.Drawing.Point(90, 376);
            this.lblUkuranObatInfoObat.Name = "lblUkuranObatInfoObat";
            this.lblUkuranObatInfoObat.Size = new System.Drawing.Size(12, 15);
            this.lblUkuranObatInfoObat.TabIndex = 13;
            this.lblUkuranObatInfoObat.Text = "-";
            // 
            // lblHargaObatInfoObat
            // 
            this.lblHargaObatInfoObat.AutoSize = true;
            this.lblHargaObatInfoObat.Location = new System.Drawing.Point(90, 409);
            this.lblHargaObatInfoObat.Name = "lblHargaObatInfoObat";
            this.lblHargaObatInfoObat.Size = new System.Drawing.Size(12, 15);
            this.lblHargaObatInfoObat.TabIndex = 14;
            this.lblHargaObatInfoObat.Text = "-";
            // 
            // lblKomposisiObatInfoObat
            // 
            this.lblKomposisiObatInfoObat.AutoSize = true;
            this.lblKomposisiObatInfoObat.Location = new System.Drawing.Point(465, 315);
            this.lblKomposisiObatInfoObat.Name = "lblKomposisiObatInfoObat";
            this.lblKomposisiObatInfoObat.Size = new System.Drawing.Size(12, 15);
            this.lblKomposisiObatInfoObat.TabIndex = 15;
            this.lblKomposisiObatInfoObat.Text = "-";
            // 
            // lblKegunaanObatInfoObat
            // 
            this.lblKegunaanObatInfoObat.AutoSize = true;
            this.lblKegunaanObatInfoObat.Location = new System.Drawing.Point(465, 376);
            this.lblKegunaanObatInfoObat.Name = "lblKegunaanObatInfoObat";
            this.lblKegunaanObatInfoObat.Size = new System.Drawing.Size(12, 15);
            this.lblKegunaanObatInfoObat.TabIndex = 16;
            this.lblKegunaanObatInfoObat.Text = "-";
            // 
            // tbCariUkuranInfo
            // 
            this.tbCariUkuranInfo.Location = new System.Drawing.Point(215, 278);
            this.tbCariUkuranInfo.Name = "tbCariUkuranInfo";
            this.tbCariUkuranInfo.PlaceholderText = "Ukuran Obat";
            this.tbCariUkuranInfo.Size = new System.Drawing.Size(86, 23);
            this.tbCariUkuranInfo.TabIndex = 17;
            // 
            // FormInformasiObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.tbCariUkuranInfo);
            this.Controls.Add(this.lblKegunaanObatInfoObat);
            this.Controls.Add(this.lblKomposisiObatInfoObat);
            this.Controls.Add(this.lblHargaObatInfoObat);
            this.Controls.Add(this.lblUkuranObatInfoObat);
            this.Controls.Add(this.lblJenisObatInfoObat);
            this.Controls.Add(this.lblNamaObatInfoObat);
            this.Controls.Add(this.btnHapusInformasiObat);
            this.Controls.Add(this.btnUbahInformasiObat);
            this.Controls.Add(this.lblHargaInformasiObat);
            this.Controls.Add(this.lblUkuranInformasiObat);
            this.Controls.Add(this.lblKegunaanInformasiObat);
            this.Controls.Add(this.lblKomposisiInformasiObat);
            this.Controls.Add(this.lblJenisInformasiObat);
            this.Controls.Add(this.lblNamaInformasiObat);
            this.Controls.Add(this.btnCariInformasiObat);
            this.Controls.Add(this.tbCariInformasiObat);
            this.Controls.Add(this.dgInformasiObat);
            this.Name = "FormInformasiObat";
            this.Text = "FormInformasiObat";
            this.Load += new System.EventHandler(this.FormInformasiObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInformasiObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInformasiObat;
        private System.Windows.Forms.TextBox tbCariInformasiObat;
        private System.Windows.Forms.Button btnCariInformasiObat;
        private System.Windows.Forms.Label lblJenisInformasiObat;
        private System.Windows.Forms.Label lblKomposisiInformasiObat;
        private System.Windows.Forms.Label lblKegunaanInformasiObat;
        private System.Windows.Forms.Label lblUkuranInformasiObat;
        private System.Windows.Forms.Label lblHargaInformasiObat;
        private System.Windows.Forms.Button btnUbahInformasiObat;
        private System.Windows.Forms.Button btnHapusInformasiObat;
        private System.Windows.Forms.Label lblNamaInformasiObat;
        private System.Windows.Forms.Label lblNamaObatInfoObat;
        private System.Windows.Forms.Label lblJenisObatInfoObat;
        private System.Windows.Forms.Label lblUkuranObatInfoObat;
        private System.Windows.Forms.Label lblHargaObatInfoObat;
        private System.Windows.Forms.Label lblKomposisiObatInfoObat;
        private System.Windows.Forms.Label lblKegunaanObatInfoObat;
        private System.Windows.Forms.TextBox tbCariUkuranInfo;
    }
}