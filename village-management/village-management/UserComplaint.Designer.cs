namespace village_management
{
    partial class UserComplaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserComplaint));
            panel1 = new Panel();
            label2 = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            linkLabel1 = new LinkLabel();
            backmenu = new Panel();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            LogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            panel1.SuspendLayout();
            backmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(204, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 574);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 59);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 0;
            label2.Text = "Complaints";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 35;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = panel1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(43, 169);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 23);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Controls.Add(linkLabel3);
            backmenu.Location = new Point(10, 277);
            backmenu.Margin = new Padding(2, 2, 2, 2);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(190, 37);
            backmenu.TabIndex = 23;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(34, 7);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(121, 23);
            linkLabel3.TabIndex = 19;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Complaints";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(43, 71);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 22;
            label1.Text = "Username";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel5.LinkColor = Color.Black;
            linkLabel5.Location = new Point(43, 394);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(75, 23);
            linkLabel5.TabIndex = 21;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Notice";
            linkLabel5.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(43, 336);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(77, 23);
            linkLabel4.TabIndex = 20;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Search";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(43, 220);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(69, 23);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Profile";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 35;
            bunifuElipse3.TargetControl = backmenu;
            // 
            // LogOut
            // 
            LogOut.ActiveBorderThickness = 1;
            LogOut.ActiveCornerRadius = 20;
            LogOut.ActiveFillColor = Color.SeaGreen;
            LogOut.ActiveForecolor = Color.White;
            LogOut.ActiveLineColor = Color.SeaGreen;
            LogOut.BackColor = Color.LightSteelBlue;
            LogOut.BackgroundImage = (Image)resources.GetObject("LogOut.BackgroundImage");
            LogOut.ButtonText = "Logout";
            LogOut.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.SeaGreen;
            LogOut.IdleBorderThickness = 1;
            LogOut.IdleCornerRadius = 20;
            LogOut.IdleFillColor = Color.White;
            LogOut.IdleForecolor = Color.SeaGreen;
            LogOut.IdleLineColor = Color.SeaGreen;
            LogOut.Location = new Point(43, 486);
            LogOut.Margin = new Padding(5, 4, 5, 4);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(134, 38);
            LogOut.TabIndex = 24;
            LogOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserComplaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(970, 598);
            Controls.Add(LogOut);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(backmenu);
            Controls.Add(label1);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserComplaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserComplaint";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private LinkLabel linkLabel1;
        private Panel backmenu;
        private LinkLabel linkLabel3;
        private Label label1;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOut;
    }
}