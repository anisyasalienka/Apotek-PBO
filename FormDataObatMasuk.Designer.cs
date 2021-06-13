
namespace Apotek_PBO
{
    partial class FormDataObatMasuk
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
            this.dgObatMasukData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgObatMasukData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgObatMasukData
            // 
            this.dgObatMasukData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObatMasukData.Location = new System.Drawing.Point(45, 82);
            this.dgObatMasukData.Name = "dgObatMasukData";
            this.dgObatMasukData.RowTemplate.Height = 25;
            this.dgObatMasukData.Size = new System.Drawing.Size(716, 241);
            this.dgObatMasukData.TabIndex = 0;
            // 
            // FormDataObatMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgObatMasukData);
            this.Name = "FormDataObatMasuk";
            this.Text = "FormDataObatMasuk";
            this.Load += new System.EventHandler(this.FormDataObatMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgObatMasukData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgObatMasukData;
    }
}