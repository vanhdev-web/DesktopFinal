using System.Drawing;
using System.Windows.Forms;

namespace OOP.Forms
{
    partial class User
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
            picAvatar = new PictureBox();
            lblUsername = new Label();
            lblEmail = new Label();
            lstProjects = new ListBox();
            grpPassword = new GroupBox();
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            lblOld = new Label();
            lblNew = new Label();
            lblConfirm = new Label();
            lblProjects = new Label();
            lblActivity = new Label();
            lstActivity = new ListBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            grpPassword.SuspendLayout();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(30, 30);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(120, 120);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 5;
            picAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.Location = new Point(170, 40);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(250, 25);
            lblUsername.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(170, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(300, 20);
            lblEmail.TabIndex = 3;
            // 
            // lstProjects
            // 
            lstProjects.Font = new Font("Segoe UI", 10F);
            lstProjects.ItemHeight = 23;
            lstProjects.Location = new Point(30, 200);
            lstProjects.Name = "lstProjects";
            lstProjects.Size = new Size(400, 96);
            lstProjects.TabIndex = 2;
            // 
            // grpPassword
            // 
            grpPassword.Controls.Add(txtOldPassword);
            grpPassword.Controls.Add(txtNewPassword);
            grpPassword.Controls.Add(txtConfirmPassword);
            grpPassword.Controls.Add(btnChangePassword);
            grpPassword.Controls.Add(lblOld);
            grpPassword.Controls.Add(lblNew);
            grpPassword.Controls.Add(lblConfirm);
            grpPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPassword.Location = new Point(30, 320);
            grpPassword.Name = "grpPassword";
            grpPassword.Size = new Size(400, 200);
            grpPassword.TabIndex = 1;
            grpPassword.TabStop = false;
            grpPassword.Text = "Đổi mật khẩu";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(150, 30);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(200, 30);
            txtOldPassword.TabIndex = 0;
            txtOldPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(150, 70);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(200, 30);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(150, 110);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 30);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(150, 150);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(131, 30);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lblOld
            // 
            lblOld.Location = new Point(20, 30);
            lblOld.Name = "lblOld";
            lblOld.Size = new Size(120, 25);
            lblOld.TabIndex = 4;
            lblOld.Text = "Mật khẩu cũ:";
            // 
            // lblNew
            // 
            lblNew.Location = new Point(20, 70);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(120, 25);
            lblNew.TabIndex = 5;
            lblNew.Text = "Mật khẩu mới:";
            // 
            // lblConfirm
            // 
            lblConfirm.Location = new Point(20, 110);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(120, 25);
            lblConfirm.TabIndex = 6;
            lblConfirm.Text = "Xác nhận lại:";
            // 
            // lblProjects
            // 
            lblProjects.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProjects.Location = new Point(30, 170);
            lblProjects.Name = "lblProjects";
            lblProjects.Size = new Size(200, 20);
            lblProjects.TabIndex = 0;
            lblProjects.Text = "Dự án tham gia:";
            // 
            // lblActivity
            // 
            lblActivity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActivity.Location = new Point(30, 540);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(200, 20);
            lblActivity.TabIndex = 6;
            lblActivity.Text = "Lịch sử hoạt động:";
            // 
            // lstActivity
            // 
            lstActivity.Font = new Font("Segoe UI", 10F);
            lstActivity.ItemHeight = 23;
            lstActivity.Items.AddRange(new object[] { "Chưa có dữ liệu..." });
            lstActivity.Location = new Point(30, 570);
            lstActivity.Name = "lstActivity";
            lstActivity.Size = new Size(400, 96);
            lstActivity.TabIndex = 7;
            // 
            // User
            // 
            ClientSize = new Size(480, 700);
            Controls.Add(lblProjects);
            Controls.Add(grpPassword);
            Controls.Add(lstProjects);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(picAvatar);
            Controls.Add(lblActivity);
            Controls.Add(lstActivity);
            Name = "User";
            Text = "Thông tin người dùng";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            grpPassword.ResumeLayout(false);
            grpPassword.PerformLayout();
            ResumeLayout(false);

            #endregion
        }
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ListBox lstActivity;
    }
}