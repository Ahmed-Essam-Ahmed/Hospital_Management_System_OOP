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
    public partial class Front_Desk_Dashboard : Form
    {
        public Front_Desk_Dashboard()
        {
            InitializeComponent();
        }

        private void Front_Desk_Dashboard_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Front_DeskData.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[2] == CurrentUser.UserName)
                {
                    CurrentUser.FirstName = parts[0];
                    CurrentUser.LastName = parts[1];
                    lblName.Text = ($"Welcome  {parts[0] + ' ' + parts[1]}");

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Front_Desk_Adding_Patient front_Desk_Adding_Patient = new Front_Desk_Adding_Patient();
            front_Desk_Adding_Patient.Show();
        }
    }
}
