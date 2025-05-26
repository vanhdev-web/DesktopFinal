using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Services;
using OOP.Models;

namespace OOP.Forms
{
    public partial class User : Form, IUserView
    {
        private UserPresenter presenter;
        public int CurrentUserID { get; private set; }
        public string OldPassword => txtOldPassword.Text;
        public string NewPassword => txtNewPassword.Text;
        public string ConfirmPassword => txtConfirmPassword.Text;

        public User(int userId)
        {
            InitializeComponent();
            CurrentUserID = userId;
            presenter = new UserPresenter(this);
            presenter.LoadUserData();
        }

        public void DisplayUser(string username, string email, byte[] avatar)
        {
            lblUsername.Text = username;
            lblEmail.Text = email;
            if (avatar != null)
            {
                using (MemoryStream ms = new MemoryStream(avatar))
                {
                    picAvatar.Image = Image.FromStream(ms);
                }
            }
        }

        public void DisplayProjects(string[] projectNames)
        {
            lstProjects.DataSource = projectNames;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            presenter.ChangePassword();
        }
        public void DisplayActivityHistory(string[] activities)
        {
            lstActivity.DataSource = activities;
        }
    }
}
