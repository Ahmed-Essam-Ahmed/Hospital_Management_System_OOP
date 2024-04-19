using Microsoft.Data.SqlClient;

namespace Hospital_Managment_System_OOP
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (bxRole.SelectedItem != null)
            {
                string selectedItem = bxRole.SelectedItem.ToString();

                if (selectedItem == "Admin")
                {
                    {
                        string username = bxUserName.Text;
                        string password = bxPassword.Text;

                        Admin currentAdmin=new Admin(username, password);
                        if(currentAdmin.Login())
                        {
                            MessageBox.Show("Login Successful!");
                            Admin_Dashboard admin = new Admin_Dashboard();
                            this.Hide();
                            admin.Show();

                            return;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                else if (selectedItem == "Front Desk")
                {
                    {
                        string username = bxUserName.Text;
                        string password = bxPassword.Text;

                        FrontDesk currentFrontDesk=new FrontDesk(username, password);
                        {
                            if(currentFrontDesk.Login())
                            {
                                MessageBox.Show("Login Successful!");
                                Front_Desk_Dashboard frontdesk = new Front_Desk_Dashboard();
                                this.Hide();
                                frontdesk.Show();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }

                else if (selectedItem == "Patient")
                {
                    {
                        string username = bxUserName.Text;
                        string password = bxPassword.Text;
                        string[] lines = File.ReadAllLines("PatientData.txt");

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');
                            if (parts[10] == username && parts[11] == password)
                            {
                                MessageBox.Show("Login Successful!");
                                
                                Patient_Dashboard patient = new Patient_Dashboard();
                                this.Hide();
                                patient.Show();
                                return;
                            }
                        }

                        MessageBox.Show("Invalid username or password.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter a role");
            }

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Page register_Page = new Register_Page();
            register_Page.Show();
        }

        private void bxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
