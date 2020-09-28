﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4_Code;

namespace P4_Code
{
    public partial class FormLogin : Form
    {
        FakeAppUserRepository userDatabase = new FakeAppUserRepository();
        public AppUser user;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String userName = UserNameTextBox.Text;
            String password = PasswordTextBox.Text;

            // Successful Authentication
            if (userDatabase.Login(userName, password))
            {
                userDatabase.SetAuthentication(userName, true);
                user = userDatabase.GetByUserName(userName);
                
                this.Close();
            }
            // Failure to Authenticate
            else
            {
                MessageBox.Show("Incorrect Username or Password.", "Attention");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
