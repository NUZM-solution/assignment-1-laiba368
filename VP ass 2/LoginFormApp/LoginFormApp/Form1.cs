using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
            txtUser.Focus(); // Focus back to username
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        Double count = 0; // Declare this at the class level

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = "Laiba Arshad"; // Hard-coded username
            pass = "22011556-024"; // Hard-coded password

            if ((txtUser.Text == user) && (txtPass.Text == pass))
            {
                MessageBox.Show("Welcome User"); // Show welcome message if login is successful
            }
            else
            {
                count++;
                double maxcount = 3;
                double remain = maxcount - count;

                MessageBox.Show("Wrong user name or password. " + remain + " tries left.");
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Focus();

                if (count == maxcount)
                {
                    MessageBox.Show("Max tries exceeded.");
                    Application.Exit(); // Close application after 3 failed attempts
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLabel1.Text=="Show")
            {
                txtPass.PasswordChar = '\0';
                linkLabel1.Text = "Hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                linkLabel1.Text = "Show";
            }
        }
    }
}
