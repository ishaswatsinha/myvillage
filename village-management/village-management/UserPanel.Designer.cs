namespace village_management
{
    partial class UserPanel
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
            panel1 = new Panel();
            label2 = new Label();
            UserPannel = new Bunifu.Framework.UI.BunifuElipse(components);
            mainPannel = new Bunifu.Framework.UI.BunifuElipse(components);
            button1 = new Button();
            back = new Bunifu.Framework.UI.BunifuElipse(components);
            backmenu = new Panel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            label1 = new Label();
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
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 59);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 0;
            label2.Text = "Welcome User!";
            // 
            // UserPannel
            // 
            UserPannel.ElipseRadius = 35;
            UserPannel.TargetControl = this;
            // 
            // mainPannel
            // 
            mainPannel.ElipseRadius = 35;
            mainPannel.TargetControl = panel1;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(43, 486);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            back.ElipseRadius = 35;
            back.TargetControl = backmenu;
            // 
            // backmenu
            // 
            backmenu.BackColor = Color.CadetBlue;
            backmenu.Controls.Add(linkLabel1);
            backmenu.Location = new Point(8, 158);
            backmenu.Margin = new Padding(2, 2, 2, 2);
            backmenu.Name = "backmenu";
            backmenu.Size = new Size(190, 37);
            backmenu.TabIndex = 15;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(55, 7);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 23);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(43, 220);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(69, 23);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Profile";
            linkLabel2.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(43, 278);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(121, 23);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Complaints";
            linkLabel3.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(43, 336);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(77, 23);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Search";
            linkLabel4.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            linkLabel5.LinkColor = Color.Black;
            linkLabel5.Location = new Point(43, 394);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(75, 23);
            linkLabel5.TabIndex = 5;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Notice";
            linkLabel5.VisitedLinkColor = Color.FromArgb(192, 255, 255);
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(43, 71);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(970, 473);
            Controls.Add(backmenu);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            backmenu.ResumeLayout(false);
            backmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse UserPannel;
        private Bunifu.Framework.UI.BunifuElipse mainPannel;
        private Button button1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuElipse back;
        private Panel backmenu;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
    }
}