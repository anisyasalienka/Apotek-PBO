
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
            this.btnKetersediaanObat = new System.Windows.Forms.Button();
            this.btn_InformasiObat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKetersediaanObat
            // 
            this.btnKetersediaanObat.Location = new System.Drawing.Point(51, 49);
            this.btnKetersediaanObat.Name = "btnKetersediaanObat";
            this.btnKetersediaanObat.Size = new System.Drawing.Size(111, 100);
            this.btnKetersediaanObat.TabIndex = 0;
            this.btnKetersediaanObat.Text = "Ketersediaan Obat";
            this.btnKetersediaanObat.UseVisualStyleBackColor = true;
            this.btnKetersediaanObat.Click += new System.EventHandler(this.btnTambahObat_Click);
            // 
            // btn_InformasiObat
            // 
            this.btn_InformasiObat.Location = new System.Drawing.Point(226, 49);
            this.btn_InformasiObat.Name = "btn_InformasiObat";
            this.btn_InformasiObat.Size = new System.Drawing.Size(111, 100);
            this.btn_InformasiObat.TabIndex = 2;
            this.btn_InformasiObat.Text = "Informasi Obat";
            this.btn_InformasiObat.UseVisualStyleBackColor = true;
            this.btn_InformasiObat.Click += new System.EventHandler(this.btn_InformasiObat_Click);
            // 
            // FormInformasiObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_InformasiObat);
            this.Controls.Add(this.btnKetersediaanObat);
            this.Name = "FormInformasiObat";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormInformasiObat_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKetersediaanObat;
        private System.Windows.Forms.Button btn_InformasiObat;
    }
}