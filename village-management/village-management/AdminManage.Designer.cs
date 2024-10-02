namespace village_management
{
    partial class AdminManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManage));
            ViewUserPanel1 = new Panel();
            OpenUserDetails = new Bunifu.Framework.UI.BunifuThinButton2();
            id = new Label();
            UserId = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            dashboard = new LinkLabel();
            backmenu = new Panel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            LogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            UserDetailPanel2 = new Panel();
            DeleteUser = new Bunifu.Framework.UI.BunifuThinButton2();
            UpdateUser = new Bunifu.Framework.UI.BunifuThinButton2();
            pictureBox1 = new PictureBox();
            lblPhone = new Label();
            label7 = new Label();
            lblHouse = new Label();
            label9 = new Label();
            lblGender = new Label();
            label11 = new Label();
            lblUserId = new Label();
            lblEmail = new Label();
            label5 = new Label();
            lblName = new Label();
            label4 = new Label();
            label8 = new Label();
            UpdatePanel3 = new Panel();
            txtuhouse = new TextBox();
            txtugender = new TextBox();
            txtuphone = new TextBox();
            txtuemail = new TextBox();
            txtuid = new TextBox();
            Update = new Bunifu.Framework.UI.BunifuThinButton2();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label13 = new Label();
            label15 = new Label();
            label18 = new Label();
            txtUserName = new Label();
            label20 = new Label();
            label21 = new Label();
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(components);
            ViewUserPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            backmenu.SuspendLayout();
            UserDetailPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            UpdatePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ViewUserPanel1
            // 
            ViewUserPanel1.BackColor = SystemColors.Control;
            ViewUserPanel1.Controls.Add(OpenUserDetails);
            ViewUserPanel1.Controls.Add(id);
            ViewUserPanel1.Controls.Add(UserId);
            ViewUserPanel1.Controls.Add(label3);
            ViewUserPanel1.Controls.Add(dataGridView1);
            ViewUserPanel1.Controls.Add(label2);
            ViewUserPanel1.Location = new Point(291, 20);
            ViewUserPanel1.Margin = new Padding(4, 5, 4, 5);
            ViewUserPanel1.Name = "ViewUserPanel1";
            ViewUserPanel1.Size = new Size(1133, 957);
            ViewUserPanel1.TabIndex = 0;
            // 
            // OpenUserDetails
            // 
            OpenUserDetails.ActiveBorderThickness = 1;
            OpenUserDetails.ActiveCornerRadius = 20;
            OpenUserDetails.ActiveFillColor = Color.SeaGreen;
            OpenUserDetails.ActiveForecolor = Color.White;
            OpenUserDetails.ActiveLineColor = Color.SeaGreen;
            OpenUserDetails.BackColor = SystemColors.Control;
            OpenUserDetails.BackgroundImage = (Image)resources.GetObject("OpenUserDetails.BackgroundImage");
            OpenUserDetails.ButtonText = "Open";
            OpenUserDetails.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenUserDetails.ForeColor = Color.SeaGreen;
            OpenUserDetails.IdleBorderThickness = 1;
            OpenUserDetails.IdleCornerRadius = 20;
            OpenUserDetails.IdleFillColor = Color.White;
            OpenUserDetails.IdleForecolor = Color.SeaGreen;
            OpenUserDetails.IdleLineColor = Color.SeaGreen;
            OpenUserDetails.Location = new Point(648, 182);
            OpenUserDetails.Margin = new Padding(7, 7, 7, 7);
            OpenUserDetails.Name = "OpenUserDetails";
            OpenUserDetails.Size = new Size(200, 70);
            OpenUserDetails.TabIndex = 62;
            OpenUserDetails.TextAlign = ContentAlignment.MiddleCenter;
            OpenUserDetails.Click += OpenUserDetails_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(224, 200);
            id.Name = "id";
            id.Size = new Size(140, 37);
            id.TabIndex = 61;
            id.Text = "USER ID :";
            // 
            // UserId
            // 
            UserId.ForeColor = Color.FromArgb(0, 0, 192);
            UserId.Location = new Point(412, 205);
            UserId.Name = "UserId";
            UserId.Size = new Size(206, 31);
            UserId.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(376, 41);
            label3.Name = "label3";
            label3.Size = new Size(355, 56);
            label3.TabIndex = 53;
            label3.Text = "Manage Users";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(257, 399);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(676, 308);
            dataGridView1.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(490, 347);
            label2.Name = "label2";
            label2.Size = new Size(216, 36);
            label2.TabIndex = 51;
            label2.Text = "List of All Users";
            // 
            // dashboard
            // 
            dashboard.AutoSize = true;
            dashboard.BackColor = Color.LightSteelBlue;
            dashboard.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            dashboard.LinkColor = Color.Black;
            dashboard.Location = new Point(30, 282);
            dashboard.Margin = new Padding(4, 0, 4, 0);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(178, 37);
            dashboard.TabIndex = 48;
            dashboard.TabStop = true;
            dashboard.Text = "Dashboard";
            dashboard.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            dashboard.LinkClicked += dashboard_LinkClicked;
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Controls.Add(linkLabel2);
            backmenu.Location = new Point(14, 367);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(271, 62);
            backmenu.TabIndex = 53;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(14, 10);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(223, 37);
            linkLabel2.TabIndex = 49;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Users";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(88, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 52;
            label1.Text = "Admin ";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(30, 560);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(243, 37);
            linkLabel4.TabIndex = 51;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "See Complaints";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(30, 467);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(164, 37);
            linkLabel3.TabIndex = 50;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Put Notice";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
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
            LogOut.Location = new Point(30, 810);
            LogOut.Margin = new Padding(7, 7, 7, 7);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(191, 63);
            LogOut.TabIndex = 47;
            LogOut.TextAlign = ContentAlignment.MiddleCenter;
            LogOut.Click += LogOut_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 35;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = ViewUserPanel1;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 20;
            bunifuElipse3.TargetControl = backmenu;
            // 
            // UserDetailPanel2
            // 
            UserDetailPanel2.BackColor = SystemColors.Control;
            UserDetailPanel2.Controls.Add(DeleteUser);
            UserDetailPanel2.Controls.Add(UpdateUser);
            UserDetailPanel2.Controls.Add(pictureBox1);
            UserDetailPanel2.Controls.Add(lblPhone);
            UserDetailPanel2.Controls.Add(label7);
            UserDetailPanel2.Controls.Add(lblHouse);
            UserDetailPanel2.Controls.Add(label9);
            UserDetailPanel2.Controls.Add(lblGender);
            UserDetailPanel2.Controls.Add(label11);
            UserDetailPanel2.Controls.Add(lblUserId);
            UserDetailPanel2.Controls.Add(lblEmail);
            UserDetailPanel2.Controls.Add(label5);
            UserDetailPanel2.Controls.Add(lblName);
            UserDetailPanel2.Controls.Add(label4);
            UserDetailPanel2.Controls.Add(label8);
            UserDetailPanel2.Location = new Point(291, 20);
            UserDetailPanel2.Name = "UserDetailPanel2";
            UserDetailPanel2.Size = new Size(1133, 957);
            UserDetailPanel2.TabIndex = 54;
            // 
            // DeleteUser
            // 
            DeleteUser.ActiveBorderThickness = 1;
            DeleteUser.ActiveCornerRadius = 20;
            DeleteUser.ActiveFillColor = Color.SeaGreen;
            DeleteUser.ActiveForecolor = Color.White;
            DeleteUser.ActiveLineColor = Color.SeaGreen;
            DeleteUser.BackColor = SystemColors.Control;
            DeleteUser.BackgroundImage = (Image)resources.GetObject("DeleteUser.BackgroundImage");
            DeleteUser.ButtonText = "DeleteUser";
            DeleteUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteUser.ForeColor = Color.SeaGreen;
            DeleteUser.IdleBorderThickness = 1;
            DeleteUser.IdleCornerRadius = 20;
            DeleteUser.IdleFillColor = Color.White;
            DeleteUser.IdleForecolor = Color.SeaGreen;
            DeleteUser.IdleLineColor = Color.SeaGreen;
            DeleteUser.Location = new Point(611, 790);
            DeleteUser.Margin = new Padding(7, 7, 7, 7);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(191, 63);
            DeleteUser.TabIndex = 49;
            DeleteUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateUser
            // 
            UpdateUser.ActiveBorderThickness = 1;
            UpdateUser.ActiveCornerRadius = 20;
            UpdateUser.ActiveFillColor = Color.SeaGreen;
            UpdateUser.ActiveForecolor = Color.White;
            UpdateUser.ActiveLineColor = Color.SeaGreen;
            UpdateUser.BackColor = SystemColors.Control;
            UpdateUser.BackgroundImage = (Image)resources.GetObject("UpdateUser.BackgroundImage");
            UpdateUser.ButtonText = "UpdateUser";
            UpdateUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateUser.ForeColor = Color.SeaGreen;
            UpdateUser.IdleBorderThickness = 1;
            UpdateUser.IdleCornerRadius = 20;
            UpdateUser.IdleFillColor = Color.White;
            UpdateUser.IdleForecolor = Color.SeaGreen;
            UpdateUser.IdleLineColor = Color.SeaGreen;
            UpdateUser.Location = new Point(356, 790);
            UpdateUser.Margin = new Padding(7, 7, 7, 7);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Size = new Size(191, 68);
            UpdateUser.TabIndex = 48;
            UpdateUser.TextAlign = ContentAlignment.MiddleCenter;
            UpdateUser.Click += UpdateUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(468, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Navy;
            lblPhone.Location = new Point(286, 649);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 37);
            lblPhone.TabIndex = 35;
            lblPhone.Text = "phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(124, 653);
            label7.Name = "label7";
            label7.Size = new Size(135, 37);
            label7.TabIndex = 34;
            label7.Text = "PHONE :";
            // 
            // lblHouse
            // 
            lblHouse.AutoSize = true;
            lblHouse.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHouse.ForeColor = Color.Navy;
            lblHouse.Location = new Point(825, 553);
            lblHouse.Name = "lblHouse";
            lblHouse.Size = new Size(171, 37);
            lblHouse.TabIndex = 33;
            lblHouse.Text = "HouseNo...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(663, 553);
            label9.Name = "label9";
            label9.Size = new Size(130, 37);
            label9.TabIndex = 32;
            label9.Text = "HOUSE :";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Navy;
            lblGender.Location = new Point(825, 463);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(128, 37);
            lblGender.TabIndex = 31;
            lblGender.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(663, 472);
            label11.Name = "label11";
            label11.Size = new Size(153, 37);
            label11.TabIndex = 30;
            label11.Text = "GENDER :";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserId.ForeColor = Color.Navy;
            lblUserId.Location = new Point(286, 463);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(106, 37);
            lblUserId.TabIndex = 29;
            lblUserId.Text = "UserId";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Navy;
            lblEmail.Location = new Point(286, 553);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(98, 37);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 553);
            label5.Name = "label5";
            label5.Size = new Size(121, 37);
            label5.TabIndex = 26;
            label5.Text = "EMAIL :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Navy;
            lblName.Location = new Point(457, 250);
            lblName.Name = "lblName";
            lblName.Size = new Size(102, 37);
            lblName.TabIndex = 25;
            lblName.Text = "name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 463);
            label4.Name = "label4";
            label4.Size = new Size(140, 37);
            label4.TabIndex = 24;
            label4.Text = "USER ID :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mistral", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(445, 26);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(200, 53);
            label8.TabIndex = 23;
            label8.Text = "User Profile";
            // 
            // UpdatePanel3
            // 
            UpdatePanel3.BackColor = SystemColors.Control;
            UpdatePanel3.Controls.Add(txtuhouse);
            UpdatePanel3.Controls.Add(txtugender);
            UpdatePanel3.Controls.Add(txtuphone);
            UpdatePanel3.Controls.Add(txtuemail);
            UpdatePanel3.Controls.Add(txtuid);
            UpdatePanel3.Controls.Add(Update);
            UpdatePanel3.Controls.Add(pictureBox2);
            UpdatePanel3.Controls.Add(label10);
            UpdatePanel3.Controls.Add(label13);
            UpdatePanel3.Controls.Add(label15);
            UpdatePanel3.Controls.Add(label18);
            UpdatePanel3.Controls.Add(txtUserName);
            UpdatePanel3.Controls.Add(label20);
            UpdatePanel3.Controls.Add(label21);
            UpdatePanel3.Location = new Point(291, 20);
            UpdatePanel3.Name = "UpdatePanel3";
            UpdatePanel3.Size = new Size(1133, 957);
            UpdatePanel3.TabIndex = 55;
            // 
            // txtuhouse
            // 
            txtuhouse.Location = new Point(846, 572);
            txtuhouse.Name = "txtuhouse";
            txtuhouse.Size = new Size(256, 31);
            txtuhouse.TabIndex = 53;
            // 
            // txtugender
            // 
            txtugender.Location = new Point(846, 480);
            txtugender.Name = "txtugender";
            txtugender.Size = new Size(256, 31);
            txtugender.TabIndex = 52;
            // 
            // txtuphone
            // 
            txtuphone.Location = new Point(301, 661);
            txtuphone.Name = "txtuphone";
            txtuphone.Size = new Size(246, 31);
            txtuphone.TabIndex = 51;
            // 
            // txtuemail
            // 
            txtuemail.Location = new Point(301, 572);
            txtuemail.Name = "txtuemail";
            txtuemail.Size = new Size(246, 31);
            txtuemail.TabIndex = 50;
            // 
            // txtuid
            // 
            txtuid.Location = new Point(301, 472);
            txtuid.Name = "txtuid";
            txtuid.Size = new Size(246, 31);
            txtuid.TabIndex = 49;
            // 
            // Update
            // 
            Update.ActiveBorderThickness = 1;
            Update.ActiveCornerRadius = 20;
            Update.ActiveFillColor = Color.SeaGreen;
            Update.ActiveForecolor = Color.White;
            Update.ActiveLineColor = Color.SeaGreen;
            Update.BackColor = SystemColors.Control;
            Update.BackgroundImage = (Image)resources.GetObject("Update.BackgroundImage");
            Update.ButtonText = "Update";
            Update.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Update.ForeColor = Color.SeaGreen;
            Update.IdleBorderThickness = 1;
            Update.IdleCornerRadius = 20;
            Update.IdleFillColor = Color.White;
            Update.IdleForecolor = Color.SeaGreen;
            Update.IdleLineColor = Color.SeaGreen;
            Update.Location = new Point(481, 790);
            Update.Margin = new Padding(7, 7, 7, 7);
            Update.Name = "Update";
            Update.Size = new Size(191, 68);
            Update.TabIndex = 48;
            Update.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(124, 653);
            label10.Name = "label10";
            label10.Size = new Size(135, 37);
            label10.TabIndex = 34;
            label10.Text = "PHONE :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(663, 553);
            label13.Name = "label13";
            label13.Size = new Size(130, 37);
            label13.TabIndex = 32;
            label13.Text = "HOUSE :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(663, 472);
            label15.Name = "label15";
            label15.Size = new Size(153, 37);
            label15.TabIndex = 30;
            label15.Text = "GENDER :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(124, 553);
            label18.Name = "label18";
            label18.Size = new Size(121, 37);
            label18.TabIndex = 26;
            label18.Text = "EMAIL :";
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Navy;
            txtUserName.Location = new Point(457, 250);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(102, 37);
            txtUserName.TabIndex = 25;
            txtUserName.Text = "name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(124, 463);
            label20.Name = "label20";
            label20.Size = new Size(140, 37);
            label20.TabIndex = 24;
            label20.Text = "USER ID :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Mistral", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(376, 16);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(362, 53);
            label21.TabIndex = 23;
            label21.Text = "UPDATE USER DETAILS";
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 35;
            bunifuElipse4.TargetControl = UpdatePanel3;
            // 
            // bunifuElipse5
            // 
            bunifuElipse5.ElipseRadius = 35;
            bunifuElipse5.TargetControl = UserDetailPanel2;
            // 
            // AdminManage
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
            Controls.Add(LogOut);
            Controls.Add(UpdatePanel3);
            Controls.Add(UserDetailPanel2);
            Controls.Add(ViewUserPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManage";
            Load += AdminManage_Load;
            ViewUserPanel1.ResumeLayout(false);
            ViewUserPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
            UserDetailPanel2.ResumeLayout(false);
            UserDetailPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            UpdatePanel3.ResumeLayout(false);
            UpdatePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ViewUserPanel1;
        private LinkLabel dashboard;
        private Panel backmenu;
        private Label label1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOut;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;

        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 OpenUserDetails;
        private Label id;
        private TextBox UserId;
        private Panel UserDetailPanel2;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteUser;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateUser;
        private PictureBox pictureBox1;
        private Label lblPhone;
        private Label label7;
        private Label lblHouse;
        private Label label9;
        private Label lblGender;
        private Label label11;
        private Label lblUserId;
        private Label lblEmail;
        private Label label5;
        private Label lblName;
        private Label label4;
        private Label label8;
        private Panel UpdatePanel3;
        private TextBox txtuhouse;
        private TextBox txtugender;
        private TextBox txtuphone;
        private TextBox txtuemail;
        private TextBox txtuid;
        private Bunifu.Framework.UI.BunifuThinButton2 Update;
        private PictureBox pictureBox2;
        private Label label10;
        private Label label13;
        private Label label15;
        private Label label18;
        private Label txtUserName;
        private Label label20;
        private Label label21;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}