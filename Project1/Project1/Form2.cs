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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                UsernameShowGuest.Show();
                Welcome.Hide();
            } if (user == "User")
            {
                UsernameShowGuest.Hide();
                Welcome.Show();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Link2022_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginTab LT = new LoginTab();
            LT.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2011_Click(object sender, EventArgs e)
        {
            
        }
    }
}
