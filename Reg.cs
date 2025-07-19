using System;
using System.Windows.Forms;

namespace Student_man
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            
            try
            {
                DatabaseHelper.InitializeDatabase();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Database Error");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = checkBox1.Checked ? '\0' : '●';
            txtpasscon.PasswordChar = checkBox1.Checked ? '\0' : '●';
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || 
                string.IsNullOrWhiteSpace(txtpass.Text) || 
                string.IsNullOrWhiteSpace(txtpasscon.Text))
            {
                CustomMessageBox.Show("Please fill all fields", "Registration");
                return;
            }

            if (txtpass.Text != txtpasscon.Text)
            {
                CustomMessageBox.Show("Passwords do not match!", "Registration");
                return;
            }

            try
            {
                if (DatabaseHelper.RegisterUser(txtUsername.Text, txtpass.Text, txtpasscon.Text))
                {
                    CustomMessageBox.Show("Registration Successful", "Success");
                    this.Hide();
                    Login main = new Login();
                    main.FormClosed += (s, args) => this.Close();
                    main.Show();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error");
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty event handler for the title label
        }
    }
}
