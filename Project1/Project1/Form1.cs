using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class LoginTab : Form
    {
        public LoginTab()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string username, password;

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TxtBoxUsername.Text != null && TxtBoxPassword.Text != null)
            {
                username = TxtBoxUsername.Text;
                password = TxtBoxPassword.Text;
                MainMenu MM = new MainMenu(TxtBoxUsername.Text);
                MM.Show();
                this.Hide();
            }
        }

        private void TxtBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtBoxPassword.Focus();
            }
        }

        private void TxtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonLogin.PerformClick();
            }
        }

        private void LoginTab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void LinkLabelGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenu MM = new MainMenu("Guest");
            MM.Show();
            this.Hide();
        }
    }
}
