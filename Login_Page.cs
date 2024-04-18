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

                        // Read usernames and passwords from the text file
                        string[] lines = File.ReadAllLines("AdminData.txt");

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');
                            if (parts[2] == username && parts[3] == password)
                            {
                                MessageBox.Show("Login Successful!");
                                Admin_Dashboard admin = new Admin_Dashboard();
                                this.Hide();
                                admin.Show();
                                return;
                            }
                        }

                        MessageBox.Show("Invalid username or password.");
                    }
                }
                else if (selectedItem == "Front Desk")
                {

                }

                else if (selectedItem == "Patient")
                {

                }
                else
                {

                }
            }
        
            //this.Hide();
            ////Admin_Dashboard admin =new Admin_Dashboard();
            ////admin.Show();
            ////Front_Desk_Dashboard front_Desk_Dashboard = new Front_Desk_Dashboard();
            ////front_Desk_Dashboard.Show();
            //Patient_Dashboard patient_Dashboard = new Patient_Dashboard();
            //patient_Dashboard.Show();
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
    }
}
