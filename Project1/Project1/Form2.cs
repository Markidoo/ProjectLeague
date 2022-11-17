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
            user20111.Visible = false;
            user20121.Visible = false;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
            user20201.Visible = false;
            user20211.Visible = false;
            user20221.Visible = false;
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginTab LT = new LoginTab();
            LT.Show();
        }

        private void Button2011_Click(object sender, EventArgs e)
        {
            user20111.Visible = true;
            user20121.Visible = false;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
        }

        private void Button2013_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = false;
            user20131.Visible = true;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
        }

        private void user20111_Load(object sender, EventArgs e)
        {

        }

        private void Button2012_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = true;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = true;
            user20131.Visible = false;
            user20141.Visible = true;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = true;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = true;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = true;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = true;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = true;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = true;
            user20181.Visible = false;
            user20191.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = true;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = true;
            user20191.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = true;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = true;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = false;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
            user20201.Visible = true;
            user20211.Visible = false;
            user20221.Visible = false;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = false;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
            user20201.Visible = false;
            user20211.Visible = true;
            user20221.Visible = false;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            user20111.Visible = false;
            user20121.Visible = false;
            user20131.Visible = false;
            user20141.Visible = false;
            user20151.Visible = false;
            user20161.Visible = false;
            user20171.Visible = false;
            user20181.Visible = false;
            user20191.Visible = false;
            user20201.Visible = false;
            user20211.Visible = false;
            user20221.Visible = true;
        }
    }
}
