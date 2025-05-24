using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeoulStay.Controllers;
using SeoulStay.Models;

namespace SeoulStay.Views
{
    public partial class LoginView : Form
    {
        private User user;
        public LoginView()
        {
            InitializeComponent();
            user = new User();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                pswdTxt.UseSystemPasswordChar = false;
                pswdTxt.PasswordChar = '\0';
            }
            else
            {
                pswdTxt.UseSystemPasswordChar = true;
                pswdTxt.PasswordChar = '●';
            }
        }

        private void OnClickToLogin(object sender, EventArgs e)
        {
            var result = setUsername();

            if (result == 1)
            {
                ManagementView? managementView = this.Controls.OfType<ManagementView>().FirstOrDefault();
                if (managementView != null)
                {
                    managementView.setType(1);
                    managementView.Visible = true;
                }
            }
            else if (result == 0)
            {
                ManagementView? managementView = this.Controls.OfType<ManagementView>().FirstOrDefault();
                if (managementView != null)
                {
                    managementView.setType(0);
                    managementView.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("User not founded!");
            }
        }

        private int setUsername()
        {
            user = new User();

            if (!string.IsNullOrEmpty(empTxt.Text))
            {
                user.Username = empTxt.Text;
                setPassword();
                if (UserController.PostUser("PostUser", user) == "Yes")
                {
                    return 1;
                }
            }
            else if (!string.IsNullOrEmpty(userTxt.Text))
            {
                user.Username = userTxt.Text;
                setPassword();
                if (UserController.PostUser("PostUser", user) == "Yes")
                {
                    return 0;
                }
            }

            return -1;
        }

        private void setPassword()
        {
            if (!string.IsNullOrEmpty(pswdTxt.Text))
            {
                user.Password = pswdTxt.Text;
            }
            else
            {
                MessageBox.Show("Please enter your password!");
                return;
            }
        }

        private void LoadManagementView(object sender, EventArgs e)
        {
            var mamanagementView = (ManagementView)sender;
            if (mamanagementView != null)
            {
                mamanagementView.Visible = false;
            }
            else
            {
                MessageBox.Show("Management view not found!");
            }
        }
    }
}
