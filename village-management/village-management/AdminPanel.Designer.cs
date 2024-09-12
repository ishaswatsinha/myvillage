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
            backmenu.SuspendLayout();
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
            panel1.Location = new Point(321, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 957);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 807);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 52);
            button1.TabIndex = 7;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(50, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 13;
            label1.Text = "Admin Name";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(50, 597);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(243, 37);
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
            linkLabel3.Location = new Point(50, 500);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(164, 37);
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
            linkLabel2.Location = new Point(50, 403);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(223, 37);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Users";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // dashboard
            // 
            dashboard.AutoSize = true;
            dashboard.BackColor = Color.Transparent;
            dashboard.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            dashboard.LinkColor = Color.Black;
            dashboard.Location = new Point(38, 10);
            dashboard.Margin = new Padding(4, 0, 4, 0);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(178, 37);
            dashboard.TabIndex = 8;
            dashboard.TabStop = true;
            dashboard.Text = "Dashboard";
            dashboard.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = panel1;
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Controls.Add(dashboard);
            backmenu.Location = new Point(31, 282);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(271, 62);
            backmenu.TabIndex = 14;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 35;
            bunifuElipse3.TargetControl = backmenu;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1441, 997);
            Controls.Add(backmenu);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
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
    }
}