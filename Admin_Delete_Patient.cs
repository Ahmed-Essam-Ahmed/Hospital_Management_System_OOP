﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System_OOP
{
    public partial class Admin_Delete_Patient : Form
    {
        public Admin_Delete_Patient()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }
    }
}