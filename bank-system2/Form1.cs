namespace bank_system2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPreDefinedUsername = "AGrover";
            string sPreDefinedPassword = "Turkey";

            bool bUserNameCheck = false;
            bool bPasswordCheck = false;

            bUserNameCheck = txbUserName.Text == sPreDefinedUsername;   
            bPasswordCheck = txbPassword.Text == sPreDefinedPassword;   

            if (bUserNameCheck && bPasswordCheck)
            {
                Form2 frNewForm = new Form2();
                this.Hide();
                frNewForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
            
        }



    }
}