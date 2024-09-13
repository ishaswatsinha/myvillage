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
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1 = new Panel();
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            dashboard = new LinkLabel();
            backmenu = new Panel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
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
            panel1.Location = new Point(224, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 449);
            panel1.TabIndex = 0;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = panel1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(35, 69);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 18;
            label1.Text = "Admin Name";
            // 
            // dashboard
            // 
            dashboard.AutoSize = true;
            dashboard.BackColor = Color.Transparent;
            dashboard.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            dashboard.LinkColor = Color.Black;
            dashboard.Location = new Point(22, 167);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(116, 23);
            dashboard.TabIndex = 19;
            dashboard.TabStop = true;
            dashboard.Text = "Dashboard";
            dashboard.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Location = new Point(11, 228);
            backmenu.Margin = new Padding(2);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(168, 37);
            backmenu.TabIndex = 23;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(22, 349);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(163, 23);
            linkLabel4.TabIndex = 22;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "See Complaints";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(22, 291);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(110, 23);
            linkLabel3.TabIndex = 21;
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
            linkLabel2.Location = new Point(22, 233);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(148, 23);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Users";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 20;
            bunifuElipse3.TargetControl = backmenu;
            // 
            // AdminComplaints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(970, 473);
            Controls.Add(dashboard);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(backmenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminComplaints";
            Text = "AdminComplaints";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Label label1;
        private LinkLabel dashboard;
        private Panel backmenu;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}