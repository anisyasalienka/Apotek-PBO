
namespace Apotek_PBO
{
    partial class FormSignUp
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
            this.lblUnameSignin = new System.Windows.Forms.Label();
            this.lblPassSignin = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUlangPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTutupSignin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnameSignin
            // 
            this.lblUnameSignin.AutoSize = true;
            this.lblUnameSignin.BackColor = System.Drawing.SystemColors.Window;
            this.lblUnameSignin.Location = new System.Drawing.Point(115, 90);
            this.lblUnameSignin.Name = "lblUnameSignin";
            this.lblUnameSignin.Size = new System.Drawing.Size(66, 15);
            this.lblUnameSignin.TabIndex = 0;
            this.lblUnameSignin.Text = "Username :";
            // 
            // lblPassSignin
            // 
            this.lblPassSignin.AutoSize = true;
            this.lblPassSignin.BackColor = System.Drawing.SystemColors.Window;
            this.lblPassSignin.Location = new System.Drawing.Point(115, 122);
            this.lblPassSignin.Name = "lblPassSignin";
            this.lblPassSignin.Size = new System.Drawing.Size(63, 15);
            this.lblPassSignin.TabIndex = 1;
            this.lblPassSignin.Text = "Password :";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(218, 87);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(140, 23);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(218, 119);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(140, 23);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUlangPassword
            // 
            this.tbUlangPassword.Location = new System.Drawing.Point(218, 150);
            this.tbUlangPassword.Name = "tbUlangPassword";
            this.tbUlangPassword.PasswordChar = '*';
            this.tbUlangPassword.Size = new System.Drawing.Size(140, 23);
            this.tbUlangPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(115, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ulang Password :";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.rbAdmin.Location = new System.Drawing.Point(121, 191);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(59, 19);
            this.rbAdmin.TabIndex = 6;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "admin";
            this.rbAdmin.UseVisualStyleBackColor = false;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.BackColor = System.Drawing.SystemColors.Window;
            this.rbUser.Location = new System.Drawing.Point(196, 191);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(47, 19);
            this.rbUser.TabIndex = 7;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "user";
            this.rbUser.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(314, 266);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTutupSignin
            // 
            this.btnTutupSignin.Location = new System.Drawing.Point(406, 266);
            this.btnTutupSignin.Name = "btnTutupSignin";
            this.btnTutupSignin.Size = new System.Drawing.Size(75, 23);
            this.btnTutupSignin.TabIndex = 9;
            this.btnTutupSignin.Text = "tutup";
            this.btnTutupSignin.UseVisualStyleBackColor = true;
            this.btnTutupSignin.Click += new System.EventHandler(this.btnTutupSignin_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apotek_PBO.Properties.Resources.design_MedStorage_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 301);
            this.Controls.Add(this.btnTutupSignin);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUlangPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPassSignin);
            this.Controls.Add(this.lblUnameSignin);
            this.Name = "FormSignUp";
            this.Text = "FormSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnameSignin;
        private System.Windows.Forms.Label lblPassSignin;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUlangPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTutupSignin;
    }
}