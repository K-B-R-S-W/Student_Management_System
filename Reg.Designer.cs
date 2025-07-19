namespace Student_man
{
    partial class Reg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtpass = new TextBox();
            txtUsername = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtpasscon = new TextBox();
            checkBox1 = new CheckBox();
            btnReg = new Button();
            label2 = new Label();
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
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(btnReg);
            mainPanel.Controls.Add(checkBox1);
            mainPanel.Controls.Add(txtpasscon);
            mainPanel.Controls.Add(txtpass);
            mainPanel.Controls.Add(txtUsername);
            mainPanel.Controls.Add(panel3);
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(pictureBox4);
            mainPanel.Controls.Add(pictureBox3);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(50, 20);
            mainPanel.Size = new Size(300, 450);
            mainPanel.Name = "mainPanel";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(300, 45);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.FromArgb(0, 117, 214);
            txtpass.Location = new Point(83, 191);
            txtpass.Size = new Size(182, 27);
            txtpass.Name = "txtpass";
            txtpass.PlaceholderText = "Password";
            txtpass.PasswordChar = '●';
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(0, 117, 214);
            txtUsername.Location = new Point(83, 122);
            txtUsername.Size = new Size(182, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(29, 225);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(29, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.images;
            pictureBox4.Location = new Point(29, 191);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images__1_;
            pictureBox3.Location = new Point(29, 122);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(29, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.Location = new Point(29, 292);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 1);
            // 
            // txtpasscon
            // 
            txtpasscon.BorderStyle = BorderStyle.None;
            txtpasscon.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasscon.ForeColor = Color.FromArgb(0, 117, 214);
            txtpasscon.Location = new Point(83, 258);
            txtpasscon.Size = new Size(182, 27);
            txtpasscon.Name = "txtpasscon";
            txtpasscon.PlaceholderText = "Confirm Password";
            txtpasscon.PasswordChar = '●';
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(0, 117, 214);
            checkBox1.Location = new Point(85, 316);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 22);
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Padding = new Padding(0);
            checkBox1.Margin = new Padding(0);
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.FromArgb(0, 117, 214);
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(29, 344);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(236, 40);
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Cursor = Cursors.Hand;
            btnReg.Click += btnReg_Click;
            // 
            // label2
            // 
            label2.AutoSize = false;
            label2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(29, 400);
            label2.Name = "label2";
            label2.Size = new Size(236, 25);
            label2.Text = "Already Have an Account";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Cursor = Cursors.Hand;
            label2.Click += label2_Click;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Reg";
            Text = "Registration";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtpass;
        private TextBox txtUsername;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txtpasscon;
        private CheckBox checkBox1;
        private Button btnReg;
        private Label label2;
        private Panel mainPanel;
    }
}