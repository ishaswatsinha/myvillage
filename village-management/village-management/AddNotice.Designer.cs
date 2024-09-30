namespace village_management
{
    partial class AddNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNotice));
            panel1 = new Panel();
            NoticeSubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            NoticeSub = new TextBox();
            label4 = new Label();
            label2 = new Label();
            NoticeDesc = new RichTextBox();
            label3 = new Label();
            dashboard = new LinkLabel();
            backmenu = new Panel();
            label1 = new Label();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            LogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(NoticeSubmit);
            panel1.Controls.Add(NoticeSub);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NoticeDesc);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(291, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 957);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // NoticeSubmit
            // 
            NoticeSubmit.ActiveBorderThickness = 1;
            NoticeSubmit.ActiveCornerRadius = 20;
            NoticeSubmit.ActiveFillColor = Color.SeaGreen;
            NoticeSubmit.ActiveForecolor = Color.White;
            NoticeSubmit.ActiveLineColor = Color.SeaGreen;
            NoticeSubmit.BackColor = SystemColors.ButtonHighlight;
            NoticeSubmit.BackgroundImage = (Image)resources.GetObject("NoticeSubmit.BackgroundImage");
            NoticeSubmit.ButtonText = "Submit";
            NoticeSubmit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoticeSubmit.ForeColor = Color.SeaGreen;
            NoticeSubmit.IdleBorderThickness = 1;
            NoticeSubmit.IdleCornerRadius = 20;
            NoticeSubmit.IdleFillColor = Color.White;
            NoticeSubmit.IdleForecolor = Color.SeaGreen;
            NoticeSubmit.IdleLineColor = Color.SeaGreen;
            NoticeSubmit.Location = new Point(513, 878);
            NoticeSubmit.Margin = new Padding(7, 7, 7, 7);
            NoticeSubmit.Name = "NoticeSubmit";
            NoticeSubmit.Size = new Size(191, 62);
            NoticeSubmit.TabIndex = 58;
            NoticeSubmit.TextAlign = ContentAlignment.MiddleCenter;
            NoticeSubmit.Click += NoticeSubmit_Click;
            // 
            // NoticeSub
            // 
            NoticeSub.Location = new Point(103, 309);
            NoticeSub.Margin = new Padding(4, 5, 4, 5);
            NoticeSub.Name = "NoticeSub";
            NoticeSub.Size = new Size(940, 31);
            NoticeSub.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 27);
            label4.TabIndex = 56;
            label4.Text = "Notice Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 403);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 54;
            label2.Text = "Description:";
            // 
            // NoticeDesc
            // 
            NoticeDesc.Location = new Point(103, 471);
            NoticeDesc.Margin = new Padding(4, 5, 4, 5);
            NoticeDesc.Name = "NoticeDesc";
            NoticeDesc.Size = new Size(940, 382);
            NoticeDesc.TabIndex = 52;
            NoticeDesc.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(569, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(292, 56);
            label3.TabIndex = 50;
            label3.Text = "Add Notice";
            // 
            // dashboard
            // 
            dashboard.AutoSize = true;
            dashboard.BackColor = Color.CadetBlue;
            dashboard.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            dashboard.LinkColor = Color.Black;
            dashboard.Location = new Point(30, 380);
            dashboard.Margin = new Padding(4, 0, 4, 0);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(178, 37);
            dashboard.TabIndex = 48;
            dashboard.TabStop = true;
            dashboard.Text = "Dashboard";
            dashboard.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Location = new Point(16, 372);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(194, 62);
            backmenu.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(30, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 52;
            label1.Text = "Admin Name";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(30, 683);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(243, 37);
            linkLabel4.TabIndex = 51;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "See Complaints";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(30, 587);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(164, 37);
            linkLabel3.TabIndex = 50;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Put Notice";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(30, 490);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(223, 37);
            linkLabel2.TabIndex = 49;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Users";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
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
            LogOut.Location = new Point(48, 769);
            LogOut.Margin = new Padding(7, 7, 7, 7);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(191, 63);
            LogOut.TabIndex = 47;
            LogOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddNotice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1441, 997);
            Controls.Add(dashboard);
            Controls.Add(backmenu);
            Controls.Add(label1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(LogOut);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddNotice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNotice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel dashboard;
        private Panel backmenu;
        private Label label1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOut;
        private Label label3;
        private Label label4;
        private Label label2;
        private RichTextBox NoticeDesc;
        private TextBox NoticeSub;
        private Bunifu.Framework.UI.BunifuThinButton2 NoticeSubmit;
    }
}