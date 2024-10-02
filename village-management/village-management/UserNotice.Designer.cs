namespace village_management
{
    partial class UserNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNotice));
            panel1 = new Panel();
            label3 = new Label();
            OpenNotice = new Bunifu.Framework.UI.BunifuThinButton2();
            id = new Label();
            NoticeId = new TextBox();
            NoticeGrid = new DataGridView();
            label2 = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            linkLabel1 = new LinkLabel();
            backmenu = new Panel();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            lblUserName = new Label();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            LogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            panel2 = new Panel();
            Back = new Bunifu.Framework.UI.BunifuThinButton2();
            NoticeDesc = new Label();
            NoticeHeading = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NoticeGrid).BeginInit();
            backmenu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(OpenNotice);
            panel1.Controls.Add(id);
            panel1.Controls.Add(NoticeId);
            panel1.Controls.Add(NoticeGrid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(291, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 957);
            panel1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(484, 404);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 43);
            label3.TabIndex = 60;
            label3.Text = "All Notices";
            // 
            // OpenNotice
            // 
            OpenNotice.ActiveBorderThickness = 1;
            OpenNotice.ActiveCornerRadius = 20;
            OpenNotice.ActiveFillColor = Color.SeaGreen;
            OpenNotice.ActiveForecolor = Color.White;
            OpenNotice.ActiveLineColor = Color.SeaGreen;
            OpenNotice.BackColor = Color.Snow;
            OpenNotice.BackgroundImage = (Image)resources.GetObject("OpenNotice.BackgroundImage");
            OpenNotice.ButtonText = "Open";
            OpenNotice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenNotice.ForeColor = Color.SeaGreen;
            OpenNotice.IdleBorderThickness = 1;
            OpenNotice.IdleCornerRadius = 20;
            OpenNotice.IdleFillColor = Color.White;
            OpenNotice.IdleForecolor = Color.SeaGreen;
            OpenNotice.IdleLineColor = Color.SeaGreen;
            OpenNotice.Location = new Point(711, 120);
            OpenNotice.Margin = new Padding(7, 7, 7, 7);
            OpenNotice.Name = "OpenNotice";
            OpenNotice.Size = new Size(200, 66);
            OpenNotice.TabIndex = 59;
            OpenNotice.TextAlign = ContentAlignment.MiddleCenter;
            OpenNotice.Click += OpenNotice_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(287, 138);
            id.Name = "id";
            id.Size = new Size(180, 37);
            id.TabIndex = 58;
            id.Text = "NOTICE ID :";
            // 
            // NoticeId
            // 
            NoticeId.ForeColor = Color.FromArgb(0, 0, 192);
            NoticeId.Location = new Point(475, 143);
            NoticeId.Name = "NoticeId";
            NoticeId.Size = new Size(206, 31);
            NoticeId.TabIndex = 57;
            // 
            // NoticeGrid
            // 
            NoticeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NoticeGrid.Location = new Point(356, 469);
            NoticeGrid.Name = "NoticeGrid";
            NoticeGrid.RowHeadersWidth = 62;
            NoticeGrid.Size = new Size(478, 282);
            NoticeGrid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(506, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 43);
            label2.TabIndex = 0;
            label2.Text = "Notice";
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
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Controls.Add(linkLabel5);
            backmenu.Location = new Point(15, 665);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(271, 62);
            backmenu.TabIndex = 31;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel5.LinkColor = Color.Black;
            linkLabel5.Location = new Point(69, 13);
            linkLabel5.Margin = new Padding(4, 0, 4, 0);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(112, 37);
            linkLabel5.TabIndex = 29;
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
            linkLabel4.Location = new Point(61, 561);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(119, 37);
            linkLabel4.TabIndex = 20;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Search";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblUserName.Location = new Point(11, 118);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(163, 37);
            lblUserName.TabIndex = 30;
            lblUserName.Text = "Username";
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
            linkLabel3.TabIndex = 28;
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
            linkLabel2.TabIndex = 27;
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
            LogOut.TabIndex = 32;
            LogOut.TextAlign = ContentAlignment.MiddleCenter;
            LogOut.Click += LogOut_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(Back);
            panel2.Controls.Add(NoticeDesc);
            panel2.Controls.Add(NoticeHeading);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(291, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1133, 957);
            panel2.TabIndex = 33;
            panel2.Paint += panel2_Paint;
            // 
            // Back
            // 
            Back.ActiveBorderThickness = 1;
            Back.ActiveCornerRadius = 20;
            Back.ActiveFillColor = Color.SeaGreen;
            Back.ActiveForecolor = Color.White;
            Back.ActiveLineColor = Color.SeaGreen;
            Back.BackColor = Color.Snow;
            Back.BackgroundImage = (Image)resources.GetObject("Back.BackgroundImage");
            Back.ButtonText = "Back";
            Back.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.SeaGreen;
            Back.IdleBorderThickness = 1;
            Back.IdleCornerRadius = 20;
            Back.IdleFillColor = Color.White;
            Back.IdleForecolor = Color.SeaGreen;
            Back.IdleLineColor = Color.SeaGreen;
            Back.Location = new Point(62, 25);
            Back.Margin = new Padding(7, 7, 7, 7);
            Back.Name = "Back";
            Back.Size = new Size(96, 46);
            Back.TabIndex = 67;
            Back.TextAlign = ContentAlignment.MiddleCenter;
            Back.Click += Back_Click;
            // 
            // NoticeDesc
            // 
            NoticeDesc.AutoSize = true;
            NoticeDesc.Location = new Point(307, 329);
            NoticeDesc.Margin = new Padding(4, 0, 4, 0);
            NoticeDesc.Name = "NoticeDesc";
            NoticeDesc.Size = new Size(59, 25);
            NoticeDesc.TabIndex = 66;
            NoticeDesc.Text = "label7";
            // 
            // NoticeHeading
            // 
            NoticeHeading.AutoSize = true;
            NoticeHeading.Location = new Point(307, 225);
            NoticeHeading.Margin = new Padding(4, 0, 4, 0);
            NoticeHeading.Name = "NoticeHeading";
            NoticeHeading.Size = new Size(59, 25);
            NoticeHeading.TabIndex = 65;
            NoticeHeading.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 329);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 27);
            label6.TabIndex = 64;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 222);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 28);
            label5.TabIndex = 63;
            label5.Text = "Notice Heading:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(454, 56);
            label4.TabIndex = 62;
            label4.Text = "Notice Description";
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 35;
            bunifuElipse4.TargetControl = backmenu;
            // 
            // bunifuElipse5
            // 
            bunifuElipse5.ElipseRadius = 35;
            bunifuElipse5.TargetControl = backmenu;
            // 
            // bunifuElipse6
            // 
            bunifuElipse6.ElipseRadius = 35;
            bunifuElipse6.TargetControl = panel2;
            // 
            // UserNotice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1441, 997);
            Controls.Add(LogOut);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel1);
            Controls.Add(backmenu);
            Controls.Add(lblUserName);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserNotice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserNotice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NoticeGrid).EndInit();
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel1;
        private Panel backmenu;
        private LinkLabel linkLabel5;
        private Label lblUserName;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOut;
        private DataGridView NoticeGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 OpenNotice;
        private Label id;
        private TextBox NoticeId;
        private Label label3;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuThinButton2 Back;
        private Label CDesc;
        private Label NoticeHeading;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label NoticeDesc;
    }
}