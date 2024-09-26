namespace village_management
{
    partial class AdminSeeComplaints
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
            panel1 = new Panel();
            dashboard = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            backmenu = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(233, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 766);
            panel1.TabIndex = 0;
            // 
            // dashboard
            // 
            dashboard.AutoSize = true;
            dashboard.BackColor = Color.Transparent;
            dashboard.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            dashboard.LinkColor = Color.Black;
            dashboard.Location = new Point(30, 284);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(116, 23);
            dashboard.TabIndex = 25;
            dashboard.TabStop = true;
            dashboard.Text = "Dashboard";
            dashboard.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(30, 466);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(163, 23);
            linkLabel4.TabIndex = 28;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "See Complaints";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(30, 408);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(110, 23);
            linkLabel3.TabIndex = 27;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Put Notice";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.CadetBlue;
            linkLabel2.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(30, 350);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(148, 23);
            linkLabel2.TabIndex = 26;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Users";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(43, 186);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 24;
            label1.Text = "Admin Name";
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Location = new Point(19, 345);
            backmenu.Margin = new Padding(2);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(168, 37);
            backmenu.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(318, 47);
            label3.Name = "label3";
            label3.Size = new Size(360, 38);
            label3.TabIndex = 54;
            label3.Text = "Complaint Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 170);
            label2.Name = "label2";
            label2.Size = new Size(150, 19);
            label2.TabIndex = 55;
            label2.Text = "Problem Heading:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 174);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 56;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 255);
            label5.Name = "label5";
            label5.Size = new Size(95, 18);
            label5.TabIndex = 57;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 258);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 58;
            label6.Text = "label6";
            // 
            // AdminSeeComplaints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1153, 788);
            Controls.Add(dashboard);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(backmenu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminSeeComplaints";
            Text = "AdminSeeComplaints";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel dashboard;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Label label1;
        private Panel backmenu;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
    }
}