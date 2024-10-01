namespace village_management
{
    partial class AdminPanel
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
            components = new System.ComponentModel.Container();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            dashboard = new LinkLabel();
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            backmenu = new Panel();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 35;
            bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(233, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 766);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(48, 555);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 7;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(35, 125);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 13;
            label1.Text = "Admin Name";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(35, 420);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(163, 23);
            linkLabel4.TabIndex = 11;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "See Complaints";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(35, 362);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(110, 23);
            linkLabel3.TabIndex = 10;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Put Notice";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(35, 304);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(148, 23);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Users";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // dashboard
            // 
            dashboard.AutoSize = true;
            dashboard.BackColor = Color.CadetBlue;
            dashboard.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            dashboard.LinkColor = Color.Black;
            dashboard.Location = new Point(35, 238);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(116, 23);
            dashboard.TabIndex = 8;
            dashboard.TabStop = true;
            dashboard.Text = "Dashboard";
            dashboard.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            dashboard.LinkClicked += dashboard_LinkClicked;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = panel1;
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Location = new Point(25, 233);
            backmenu.Margin = new Padding(2);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(136, 37);
            backmenu.TabIndex = 14;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 20;
            bunifuElipse3.TargetControl = backmenu;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label2.Location = new Point(120, 470);
            label2.Name = "label2";
            label2.Size = new Size(212, 32);
            label2.TabIndex = 0;
            label2.Text = "Total Residents:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F);
            label3.Location = new Point(527, 470);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label4.Location = new Point(120, 546);
            label4.Name = "label4";
            label4.Size = new Size(363, 32);
            label4.TabIndex = 2;
            label4.Text = "Total Complaints Resolved:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F);
            label5.Location = new Point(527, 550);
            label5.Name = "label5";
            label5.Size = new Size(74, 24);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label6.Location = new Point(120, 622);
            label6.Name = "label6";
            label6.Size = new Size(187, 32);
            label6.TabIndex = 4;
            label6.Text = "Total Notices:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F);
            label7.Location = new Point(527, 622);
            label7.Name = "label7";
            label7.Size = new Size(74, 24);
            label7.TabIndex = 5;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(120, 337);
            label8.Name = "label8";
            label8.Size = new Size(256, 58);
            label8.TabIndex = 6;
            label8.Text = "STATISTICS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(120, 102);
            label9.Name = "label9";
            label9.Size = new Size(321, 32);
            label9.TabIndex = 7;
            label9.Text = "Welcome Back, Admin!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic);
            label10.Location = new Point(120, 193);
            label10.Name = "label10";
            label10.Size = new Size(692, 22);
            label10.TabIndex = 8;
            label10.Text = "Check up on what's happening with the village, in the complaints section";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic);
            label11.Location = new Point(120, 239);
            label11.Name = "label11";
            label11.Size = new Size(680, 22);
            label11.TabIndex = 9;
            label11.Text = "To put out a notice regarding something important, go to notice section";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1153, 788);
            Controls.Add(dashboard);
            Controls.Add(backmenu);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel dashboard;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Panel backmenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
    }
}