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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TxtBoxUsername.Text == "Omitted" && TxtBoxPassword.Text == "Markidoo")
            {
                MainMenu MM = new MainMenu("User");
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

        private void LinkLabelGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenu MM = new MainMenu("Guest");
            MM.Show();
            this.Hide();
        }
    }
}
