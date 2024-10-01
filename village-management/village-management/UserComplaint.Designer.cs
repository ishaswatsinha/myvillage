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
            Csubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            subject = new TextBox();
            label4 = new Label();
            label2 = new Label();
            description = new RichTextBox();
            label3 = new Label();
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
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1.SuspendLayout();
            backmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(Csubmit);
            panel1.Controls.Add(subject);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(description);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(291, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 957);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // Csubmit
            // 
            Csubmit.ActiveBorderThickness = 1;
            Csubmit.ActiveCornerRadius = 20;
            Csubmit.ActiveFillColor = Color.SeaGreen;
            Csubmit.ActiveForecolor = Color.White;
            Csubmit.ActiveLineColor = Color.SeaGreen;
            Csubmit.BackColor = Color.Snow;
            Csubmit.BackgroundImage = (Image)resources.GetObject("Csubmit.BackgroundImage");
            Csubmit.ButtonText = "Submit";
            Csubmit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Csubmit.ForeColor = Color.SeaGreen;
            Csubmit.IdleBorderThickness = 1;
            Csubmit.IdleCornerRadius = 20;
            Csubmit.IdleFillColor = Color.White;
            Csubmit.IdleForecolor = Color.SeaGreen;
            Csubmit.IdleLineColor = Color.SeaGreen;
            Csubmit.Location = new Point(496, 887);
            Csubmit.Margin = new Padding(7, 7, 7, 7);
            Csubmit.Name = "Csubmit";
            Csubmit.Size = new Size(191, 63);
            Csubmit.TabIndex = 63;
            Csubmit.TextAlign = ContentAlignment.MiddleCenter;
            Csubmit.Click += Csubmit_Click;
            // 
            // subject
            // 
            subject.BackColor = Color.GhostWhite;
            subject.BorderStyle = BorderStyle.FixedSingle;
            subject.Location = new Point(128, 245);
            subject.Margin = new Padding(4, 5, 4, 5);
            subject.Name = "subject";
            subject.Size = new Size(880, 31);
            subject.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(219, 27);
            label4.TabIndex = 61;
            label4.Text = "Complain Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 333);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 60;
            label2.Text = "Description:";
            // 
            // description
            // 
            description.BackColor = Color.GhostWhite;
            description.Location = new Point(128, 383);
            description.Margin = new Padding(4, 5, 4, 5);
            description.Name = "description";
            description.Size = new Size(880, 495);
            description.TabIndex = 59;
            description.Text = "";
            description.TextChanged += richTextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(451, 18);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(402, 56);
            label3.TabIndex = 58;
            label3.Text = "Add Complaints";
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
            linkLabel1.Location = new Point(61, 282);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 37);
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
            backmenu.Location = new Point(14, 462);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(271, 62);
            backmenu.TabIndex = 23;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(49, 12);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(181, 37);
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
            label1.Location = new Point(61, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 22;
            label1.Text = "Username";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel5.LinkColor = Color.Black;
            linkLabel5.Location = new Point(61, 657);
            linkLabel5.Margin = new Padding(4, 0, 4, 0);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(112, 37);
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
            linkLabel4.Location = new Point(61, 560);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(119, 37);
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
            linkLabel2.Location = new Point(61, 367);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(104, 37);
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
            LogOut.Location = new Point(61, 810);
            LogOut.Margin = new Padding(7, 7, 7, 7);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(191, 63);
            LogOut.TabIndex = 24;
            LogOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 30;
            bunifuElipse4.TargetControl = description;
            // 
            // UserComplaint
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1441, 997);
            Controls.Add(LogOut);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(backmenu);
            Controls.Add(label1);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserComplaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserComplaint";
            Load += UserComplaint_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
        private TextBox subject;
        private Label label4;
        private Label label2;
        private RichTextBox description;
        private Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 Csubmit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}