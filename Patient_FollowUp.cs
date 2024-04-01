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
    public partial class Patient_FollowUp : Form
    {
        public Patient_FollowUp()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Dashboard patient_Dashboard = new Patient_Dashboard();
            patient_Dashboard.Show();
        }
    }
}
