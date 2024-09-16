namespace village_management
{
    partial class UserSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearch));
            SearchPanel = new Panel();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            lblGender = new Label();
            label10 = new Label();
            lblHouse = new Label();
            label8 = new Label();
            lblPhone = new Label();
            label6 = new Label();
            lblEmail = new Label();
            label5 = new Label();
            lblName = new Label();
            label3 = new Label();
            id = new Label();
            textId = new TextBox();
            label2 = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            linkLabel1 = new LinkLabel();
            backmenu = new Panel();
            linkLabel4 = new LinkLabel();
            label1 = new Label();
            linkLabel5 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            LogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            SearchPanel.SuspendLayout();
            backmenu.SuspendLayout();
            SuspendLayout();
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.Snow;
            SearchPanel.Controls.Add(bunifuThinButton21);
            SearchPanel.Controls.Add(lblGender);
            SearchPanel.Controls.Add(label10);
            SearchPanel.Controls.Add(lblHouse);
            SearchPanel.Controls.Add(label8);
            SearchPanel.Controls.Add(lblPhone);
            SearchPanel.Controls.Add(label6);
            SearchPanel.Controls.Add(lblEmail);
            SearchPanel.Controls.Add(label5);
            SearchPanel.Controls.Add(lblName);
            SearchPanel.Controls.Add(label3);
            SearchPanel.Controls.Add(id);
            SearchPanel.Controls.Add(textId);
            SearchPanel.Controls.Add(label2);
            SearchPanel.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            SearchPanel.Location = new Point(291, 20);
            SearchPanel.Margin = new Padding(4, 5, 4, 5);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(1133, 957);
            SearchPanel.TabIndex = 16;
            SearchPanel.Paint += SearchPanel_Paint;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            bunifuThinButton21.BackColor = Color.Snow;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Search";
            bunifuThinButton21.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.SeaGreen;
            bunifuThinButton21.IdleLineColor = Color.SeaGreen;
            bunifuThinButton21.Location = new Point(442, 580);
            bunifuThinButton21.Margin = new Padding(7, 7, 7, 7);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(250, 66);
            bunifuThinButton21.TabIndex = 13;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Navy;
            lblGender.Location = new Point(847, 387);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(102, 37);
            lblGender.TabIndex = 12;
            lblGender.Text = "name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(685, 383);
            label10.Name = "label10";
            label10.Size = new Size(153, 37);
            label10.TabIndex = 11;
            label10.Text = "GENDER :";
            // 
            // lblHouse
            // 
            lblHouse.AutoSize = true;
            lblHouse.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHouse.ForeColor = Color.Navy;
            lblHouse.Location = new Point(847, 286);
            lblHouse.Name = "lblHouse";
            lblHouse.Size = new Size(149, 37);
            lblHouse.TabIndex = 10;
            lblHouse.Text = "house no";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(685, 293);
            label8.Name = "label8";
            label8.Size = new Size(130, 37);
            label8.TabIndex = 9;
            label8.Text = "HOUSE :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Navy;
            lblPhone.Location = new Point(262, 469);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 37);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 473);
            label6.Name = "label6";
            label6.Size = new Size(135, 37);
            label6.TabIndex = 7;
            label6.Text = "PHONE :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Navy;
            lblEmail.Location = new Point(262, 383);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(98, 37);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 383);
            label5.Name = "label5";
            label5.Size = new Size(121, 37);
            label5.TabIndex = 5;
            label5.Text = "EMAIL :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Navy;
            lblName.Location = new Point(262, 293);
            lblName.Name = "lblName";
            lblName.Size = new Size(102, 37);
            lblName.TabIndex = 4;
            lblName.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 293);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 3;
            label3.Text = "NAME :";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(355, 143);
            id.Name = "id";
            id.Size = new Size(140, 37);
            id.TabIndex = 2;
            id.Text = "USER ID :";
            // 
            // textId
            // 
            textId.ForeColor = Color.FromArgb(0, 0, 192);
            textId.Location = new Point(501, 140);
            textId.Name = "textId";
            textId.Size = new Size(206, 44);
            textId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 43);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 35;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = SearchPanel;
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
            backmenu.Controls.Add(linkLabel4);
            backmenu.Location = new Point(14, 552);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(271, 62);
            backmenu.TabIndex = 23;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(67, 11);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(119, 37);
            linkLabel4.TabIndex = 20;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Search";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
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
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(61, 463);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(181, 37);
            linkLabel3.TabIndex = 19;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Complaints";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
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
            LogOut.Size = new Size(191, 64);
            LogOut.TabIndex = 25;
            LogOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1441, 997);
            Controls.Add(LogOut);
            Controls.Add(linkLabel1);
            Controls.Add(SearchPanel);
            Controls.Add(backmenu);
            Controls.Add(label1);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserSearch";
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel SearchPanel;
        private Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel backmenu;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private TextBox textId;
        private Label id;
        private Label label3;
        private Label lblEmail;
        private Label label5;
        private Label lblName;
        private Label lblGender;
        private Label label10;
        private Label lblHouse;
        private Label label8;
        private Label lblPhone;
        private Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOut;
    }
}