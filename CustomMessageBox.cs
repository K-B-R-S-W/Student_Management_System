using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_man
{
    public partial class CustomMessageBox : Form
    {
        private readonly Panel panel1;
        private readonly Label lblTitle;
        private readonly Label lblMessage;
        private readonly Button btnOK;

        public CustomMessageBox(string message, string title = "Message")
        {
            // Initialize all controls
            panel1 = new Panel();
            lblTitle = new Label();
            lblMessage = new Label();
            btnOK = new Button();

            InitializeComponent();
            this.Text = "";  // Remove title bar text
            lblMessage.Text = message;
            lblTitle.Text = title;
        }

        private void InitializeComponent()
        {
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // Panel for title bar
            this.panel1.BackColor = Color.FromArgb(0, 117, 214);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Height = 40;
            this.panel1.Controls.Add(lblTitle);

            // Title label
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Message label
            this.lblMessage.AutoSize = false;
            this.lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMessage.Font = new Font("Bahnschrift", 11F);
            this.lblMessage.ForeColor = Color.FromArgb(0, 117, 214);
            this.lblMessage.Location = new Point(20, 60);
            this.lblMessage.Size = new Size(260, 60);

            // OK Button
            this.btnOK.BackColor = Color.FromArgb(0, 117, 214);
            this.btnOK.FlatStyle = FlatStyle.Flat;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            this.btnOK.ForeColor = Color.White;
            this.btnOK.Location = new Point(85, 130);
            this.btnOK.Size = new Size(130, 35);
            this.btnOK.Text = "OK";
            this.btnOK.Cursor = Cursors.Hand;
            this.btnOK.Click += (s, e) => this.Close();

            // Form properties
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(300, 180);
            this.Controls.AddRange(new Control[] { panel1, lblMessage, btnOK });
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;

            // Add shadow and border
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 117, 214), 2),
                    new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            };

            // Make form draggable
            bool isDragging = false;
            Point dragStart = Point.Empty;

            this.panel1.MouseDown += (s, e) =>
            {
                isDragging = true;
                dragStart = new Point(e.X, e.Y);
            };

            this.panel1.MouseMove += (s, e) =>
            {
                if (isDragging)
                {
                    Point p = PointToScreen(new Point(e.X, e.Y));
                    Location = new Point(p.X - dragStart.X, p.Y - dragStart.Y);
                }
            };

            this.panel1.MouseUp += (s, e) => isDragging = false;

            panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public static void Show(string message, string title = "Message")
        {
            using (var msgBox = new CustomMessageBox(message, title))
            {
                msgBox.ShowDialog();
            }
        }
    }
} 