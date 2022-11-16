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
        public MainMenu(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                UsernameShowGuest.Show();
                Username.Hide();
            }
            else
            {
                UsernameShowGuest.Hide();
                Username.Text = LoginTab.username;
                Username.Show();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginTab LT = new LoginTab();
            LT.Show();
        }

        private void Button2011_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2013_Click(object sender, EventArgs e)
        {

        }
    }
}
