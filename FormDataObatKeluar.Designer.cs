
namespace Apotek_PBO
{
    partial class FormDataObatKeluar
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
            this.dgObatKeluarData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgObatKeluarData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgObatKeluarData
            // 
            this.dgObatKeluarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObatKeluarData.Location = new System.Drawing.Point(45, 82);
            this.dgObatKeluarData.Name = "dgObatKeluarData";
            this.dgObatKeluarData.RowTemplate.Height = 25;
            this.dgObatKeluarData.Size = new System.Drawing.Size(716, 241);
            this.dgObatKeluarData.TabIndex = 0;
            // 
            // FormDataObatKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgObatKeluarData);
            this.Name = "FormDataObatKeluar";
            this.Text = "FormDataObatKeluar";
            this.Load += new System.EventHandler(this.FormDataObatKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgObatKeluarData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgObatKeluarData;
    }
}