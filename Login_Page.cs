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
            this.Hide();
            Patient_Dashboard d=new Patient_Dashboard();
            d.Show();
        }
    }
}
