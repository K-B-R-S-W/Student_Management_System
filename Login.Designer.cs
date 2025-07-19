namespace Student_man
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnlog = new Button();
            label1 = new Label();
            lblclear = new Label();
            lblExit = new Label();
            txtUsername = new TextBox();
            txtpass = new TextBox();
            label4 = new Label();
            button1 = new Button();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.None;
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(txtpass);
            mainPanel.Controls.Add(txtUsername);
            mainPanel.Controls.Add(label4);
            mainPanel.Controls.Add(lblExit);
            mainPanel.Controls.Add(lblclear);
            mainPanel.Controls.Add(btnlog);
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(pictureBox4);
            mainPanel.Controls.Add(pictureBox3);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(50, 20);
            mainPanel.Size = new Size(300, 450);
            mainPanel.Name = "mainPanel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4cc88e8068fb873ea050ebc4e94eafed850f2409__2_;
            pictureBox1.Location = new Point(100, 20);
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(0, 130);
            label1.Size = new Size(300, 40);
            label1.Name = "label1";
            label1.Text = "User Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(83, 200);
            txtUsername.Size = new Size(182, 27);
            txtUsername.ForeColor = Color.FromArgb(0, 117, 214);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(83, 260);
            txtpass.Size = new Size(182, 27);
            txtpass.ForeColor = Color.FromArgb(0, 117, 214);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '●';
            txtpass.PlaceholderText = "Password";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images__1_;
            pictureBox3.Location = new Point(29, 200);
            pictureBox3.Size = new Size(48, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.images;
            pictureBox4.Location = new Point(29, 260);
            pictureBox4.Size = new Size(48, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(29, 230);
            panel1.Size = new Size(236, 1);
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(29, 290);
            panel2.Size = new Size(236, 1);
            panel2.Name = "panel2";
            // 
            // btnlog
            // 
            btnlog.BackColor = Color.FromArgb(0, 117, 214);
            btnlog.FlatStyle = FlatStyle.Flat;
            btnlog.FlatAppearance.BorderSize = 0;
            btnlog.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnlog.ForeColor = Color.White;
            btnlog.Location = new Point(29, 320);
            btnlog.Size = new Size(236, 40);
            btnlog.Name = "btnlog";
            btnlog.Text = "LOG IN";
            btnlog.UseVisualStyleBackColor = false;
            btnlog.Cursor = Cursors.Hand;
            btnlog.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 117, 214);
            button1.FlatAppearance.BorderSize = 1;
            button1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 117, 214);
            button1.Location = new Point(29, 370);
            button1.Size = new Size(236, 40);
            button1.Name = "button1";
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Cursor = Cursors.Hand;
            button1.Click += button1_Click;
            // 
            // lblclear
            // 
            lblclear.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold);
            lblclear.ForeColor = Color.FromArgb(0, 117, 214);
            lblclear.Location = new Point(29, 420);
            lblclear.Size = new Size(80, 20);
            lblclear.Name = "lblclear";
            lblclear.Text = "Clear";
            lblclear.TextAlign = ContentAlignment.MiddleLeft;
            lblclear.Cursor = Cursors.Hand;
            lblclear.Click += label2_Click_1;
            // 
            // lblExit
            // 
            lblExit.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold);
            lblExit.ForeColor = Color.FromArgb(0, 117, 214);
            lblExit.Location = new Point(185, 420);
            lblExit.Size = new Size(80, 20);
            lblExit.Name = "lblExit";
            lblExit.Text = "Exit";
            lblExit.TextAlign = ContentAlignment.MiddleRight;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Login";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanel;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnlog;
        public Label label1;
        private Label lblclear;
        private Label lblExit;
        private TextBox txtUsername;
        private TextBox txtpass;
        private Label label4;
        private Button button1;
    }
}
