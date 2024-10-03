namespace village_management
{
    partial class AdminComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminComplaints));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            Com1 = new Panel();
            ComOpen = new Bunifu.Framework.UI.BunifuThinButton2();
            id = new Label();
            ComId = new TextBox();
            label3 = new Label();
            allcomplaints = new DataGridView();
            label2 = new Label();
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            dashboard = new LinkLabel();
            backmenu = new Panel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            Com2 = new Panel();
            BtnResolved = new Bunifu.Framework.UI.BunifuThinButton2();
            CDesc = new RichTextBox();
            Back = new Bunifu.Framework.UI.BunifuThinButton2();
            Cheading = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            LogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            Com1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allcomplaints).BeginInit();
            backmenu.SuspendLayout();
            Com2.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 35;
            bunifuElipse1.TargetControl = this;
            // 
            // Com1
            // 
            Com1.BackColor = Color.Snow;
            Com1.Controls.Add(ComOpen);
            Com1.Controls.Add(id);
            Com1.Controls.Add(ComId);
            Com1.Controls.Add(label3);
            Com1.Controls.Add(allcomplaints);
            Com1.Controls.Add(label2);
            Com1.Location = new Point(291, 20);
            Com1.Margin = new Padding(4, 5, 4, 5);
            Com1.Name = "Com1";
            Com1.Size = new Size(1133, 957);
            Com1.TabIndex = 0;
            // 
            // ComOpen
            // 
            ComOpen.ActiveBorderThickness = 1;
            ComOpen.ActiveCornerRadius = 20;
            ComOpen.ActiveFillColor = Color.SeaGreen;
            ComOpen.ActiveForecolor = Color.White;
            ComOpen.ActiveLineColor = Color.SeaGreen;
            ComOpen.BackColor = Color.Snow;
            ComOpen.BackgroundImage = (Image)resources.GetObject("ComOpen.BackgroundImage");
            ComOpen.ButtonText = "Open";
            ComOpen.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComOpen.ForeColor = Color.SeaGreen;
            ComOpen.IdleBorderThickness = 1;
            ComOpen.IdleCornerRadius = 20;
            ComOpen.IdleFillColor = Color.White;
            ComOpen.IdleForecolor = Color.SeaGreen;
            ComOpen.IdleLineColor = Color.SeaGreen;
            ComOpen.Location = new Point(805, 164);
            ComOpen.Margin = new Padding(7, 7, 7, 7);
            ComOpen.Name = "ComOpen";
            ComOpen.Size = new Size(200, 66);
            ComOpen.TabIndex = 56;
            ComOpen.TextAlign = ContentAlignment.MiddleCenter;
            ComOpen.Click += ComOpen_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(317, 182);
            id.Name = "id";
            id.Size = new Size(246, 37);
            id.TabIndex = 55;
            id.Text = "COMPLAINT ID :";
            // 
            // ComId
            // 
            ComId.ForeColor = Color.FromArgb(0, 0, 192);
            ComId.Location = new Point(569, 187);
            ComId.Name = "ComId";
            ComId.Size = new Size(206, 31);
            ComId.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(569, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(289, 56);
            label3.TabIndex = 53;
            label3.Text = "Complaints";
            // 
            // allcomplaints
            // 
            allcomplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allcomplaints.Location = new Point(317, 398);
            allcomplaints.Margin = new Padding(4, 5, 4, 5);
            allcomplaints.Name = "allcomplaints";
            allcomplaints.RowHeadersWidth = 62;
            allcomplaints.Size = new Size(667, 264);
            allcomplaints.TabIndex = 52;
            allcomplaints.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(527, 347);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 36);
            label2.TabIndex = 51;
            label2.Text = "All Complaints";
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = Com1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(88, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 18;
            label1.Text = "Admin ";
            // 
            // dashboard
            // 
            dashboard.AutoSize = true;
            dashboard.BackColor = Color.Transparent;
            dashboard.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            dashboard.LinkColor = Color.Black;
            dashboard.Location = new Point(30, 282);
            dashboard.Margin = new Padding(4, 0, 4, 0);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(178, 37);
            dashboard.TabIndex = 19;
            dashboard.TabStop = true;
            dashboard.Text = "Dashboard";
            dashboard.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            dashboard.LinkClicked += dashboard_LinkClicked;
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Controls.Add(linkLabel4);
            backmenu.Location = new Point(14, 560);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(271, 62);
            backmenu.TabIndex = 23;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(14, 10);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(243, 37);
            linkLabel4.TabIndex = 22;
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
            linkLabel3.TabIndex = 21;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Put Notice";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.LightSteelBlue;
            linkLabel2.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(30, 367);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(223, 37);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Users";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 20;
            bunifuElipse3.TargetControl = backmenu;
            // 
            // Com2
            // 
            Com2.BackColor = Color.Snow;
            Com2.CausesValidation = false;
            Com2.Controls.Add(BtnResolved);
            Com2.Controls.Add(CDesc);
            Com2.Controls.Add(Back);
            Com2.Controls.Add(Cheading);
            Com2.Controls.Add(label6);
            Com2.Controls.Add(label5);
            Com2.Controls.Add(label4);
            Com2.Location = new Point(291, 20);
            Com2.Name = "Com2";
            Com2.Size = new Size(1133, 957);
            Com2.TabIndex = 24;
            // 
            // BtnResolved
            // 
            BtnResolved.ActiveBorderThickness = 1;
            BtnResolved.ActiveCornerRadius = 20;
            BtnResolved.ActiveFillColor = Color.SeaGreen;
            BtnResolved.ActiveForecolor = Color.White;
            BtnResolved.ActiveLineColor = Color.SeaGreen;
            BtnResolved.BackColor = Color.Snow;
            BtnResolved.BackgroundImage = (Image)resources.GetObject("BtnResolved.BackgroundImage");
            BtnResolved.ButtonText = "Resolved";
            BtnResolved.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnResolved.ForeColor = Color.SeaGreen;
            BtnResolved.IdleBorderThickness = 1;
            BtnResolved.IdleCornerRadius = 20;
            BtnResolved.IdleFillColor = Color.White;
            BtnResolved.IdleForecolor = Color.SeaGreen;
            BtnResolved.IdleLineColor = Color.SeaGreen;
            BtnResolved.Location = new Point(938, 137);
            BtnResolved.Margin = new Padding(7, 7, 7, 7);
            BtnResolved.Name = "BtnResolved";
            BtnResolved.Size = new Size(154, 53);
            BtnResolved.TabIndex = 63;
            BtnResolved.TextAlign = ContentAlignment.MiddleCenter;
            BtnResolved.Click += BtnResolved_Click;
            // 
            // CDesc
            // 
            CDesc.BackColor = Color.Snow;
            CDesc.BorderStyle = BorderStyle.None;
            CDesc.Location = new Point(291, 340);
            CDesc.Name = "CDesc";
            CDesc.Size = new Size(801, 160);
            CDesc.TabIndex = 62;
            CDesc.Text = "";
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
            Back.Location = new Point(22, 28);
            Back.Margin = new Padding(7, 7, 7, 7);
            Back.Name = "Back";
            Back.Size = new Size(96, 46);
            Back.TabIndex = 61;
            Back.TextAlign = ContentAlignment.MiddleCenter;
            Back.Click += Back_Click;
            // 
            // Cheading
            // 
            Cheading.AutoSize = true;
            Cheading.Location = new Point(379, 222);
            Cheading.Margin = new Padding(4, 0, 4, 0);
            Cheading.Name = "Cheading";
            Cheading.Size = new Size(59, 25);
            Cheading.TabIndex = 59;
            Cheading.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(134, 326);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 27);
            label6.TabIndex = 58;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 219);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 56;
            label5.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(291, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(564, 56);
            label4.TabIndex = 55;
            label4.Text = "Complaints Description";
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 35;
            bunifuElipse4.TargetControl = Com2;
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
            LogOut.TabIndex = 48;
            LogOut.TextAlign = ContentAlignment.MiddleCenter;
            LogOut.Click += LogOut_Click;
            // 
            // AdminComplaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1441, 997);
            Controls.Add(LogOut);
            Controls.Add(dashboard);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(backmenu);
            Controls.Add(Com1);
            Controls.Add(Com2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminComplaints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminComplaints";
            Com1.ResumeLayout(false);
            Com1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allcomplaints).EndInit();
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
            Com2.ResumeLayout(false);
            Com2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel Com1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Label label1;
        private LinkLabel dashboard;
        private Panel backmenu;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Label label3;
        private DataGridView allcomplaints;
        private Label label2;
        private Label id;
        private TextBox ComId;
        private Bunifu.Framework.UI.BunifuThinButton2 ComOpen;
        private Panel Com2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label Cheading;
        private Bunifu.Framework.UI.BunifuThinButton2 Back;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOut;
        private RichTextBox CDesc;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnResolved;
    }
}