using System;
using System.Windows.Forms;

namespace Student_man
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            try
            {
                DatabaseHelper.InitializeDatabase();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Database Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                CustomMessageBox.Show("Please enter username and password", "Login");
                return;
            }

            try
            {
                if (DatabaseHelper.ValidateLogin(txtUsername.Text, txtpass.Text))
                {
                    CustomMessageBox.Show("Login Successful", "Success");
                    this.Hide();
                    Createacc main = new Createacc();
                    main.FormClosed += (s, args) => this.Close();
                    main.Show();
                }
                else
                {
                    CustomMessageBox.Show("Invalid username or password", "Login Failed");
                    txtUsername.Clear();
                    txtpass.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpass.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Properly exit the application
            Application.ExitThread();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg main = new Reg();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }
    }
}

