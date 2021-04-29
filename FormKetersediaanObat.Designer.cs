
namespace Apotek_PBO
{
    partial class FormKetersediaanObat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObatMasuk = new System.Windows.Forms.Button();
            this.btnObatKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(572, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnObatMasuk
            // 
            this.btnObatMasuk.Location = new System.Drawing.Point(67, 394);
            this.btnObatMasuk.Name = "btnObatMasuk";
            this.btnObatMasuk.Size = new System.Drawing.Size(99, 31);
            this.btnObatMasuk.TabIndex = 1;
            this.btnObatMasuk.Text = "Obat Masuk";
            this.btnObatMasuk.UseVisualStyleBackColor = true;
            // 
            // btnObatKeluar
            // 
            this.btnObatKeluar.Location = new System.Drawing.Point(197, 394);
            this.btnObatKeluar.Name = "btnObatKeluar";
            this.btnObatKeluar.Size = new System.Drawing.Size(99, 31);
            this.btnObatKeluar.TabIndex = 2;
            this.btnObatKeluar.Text = "Obat Keluar";
            this.btnObatKeluar.UseVisualStyleBackColor = true;
            // 
            // FormKetersediaanObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObatKeluar);
            this.Controls.Add(this.btnObatMasuk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKetersediaanObat";
            this.Text = "FormKetersediaanObat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnObatMasuk;
        private System.Windows.Forms.Button btnObatKeluar;
    }
}