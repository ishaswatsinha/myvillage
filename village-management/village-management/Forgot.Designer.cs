namespace village_management
{
    partial class Forgot
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
            OTP = new Panel();
            label3 = new Label();
            tym = new Label();
            label2 = new Label();
            otpsubmit = new Button();
            txtotp = new TextBox();
            label1 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            Updatepannel = new Panel();
            UpdateBtn = new Button();
            newPass = new TextBox();
            label6 = new Label();
            label7 = new Label();
            OTP.SuspendLayout();
            Updatepannel.SuspendLayout();
            SuspendLayout();
            // 
            // OTP
            // 
            OTP.BackColor = Color.LightSteelBlue;
            OTP.Controls.Add(label3);
            OTP.Controls.Add(tym);
            OTP.Controls.Add(label2);
            OTP.Controls.Add(otpsubmit);
            OTP.Controls.Add(txtotp);
            OTP.Controls.Add(label1);
            OTP.Controls.Add(label5);
            OTP.Location = new Point(0, 0);
            OTP.Name = "OTP";
            OTP.Size = new Size(441, 733);
            OTP.TabIndex = 0;
            OTP.Paint += OTP_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(74, 265);
            label3.Name = "label3";
            label3.Size = new Size(342, 21);
            label3.TabIndex = 19;
            label3.Text = "OTP has been sent, check your e-mail";
            // 
            // tym
            // 
            tym.AutoSize = true;
            tym.BackColor = Color.Transparent;
            tym.Font = new Font("Century Gothic", 9F);
            tym.ForeColor = SystemColors.ActiveCaptionText;
            tym.Location = new Point(310, 567);
            tym.Name = "tym";
            tym.Size = new Size(38, 21);
            tym.TabIndex = 18;
            tym.Text = "%%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(126, 567);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 17;
            label2.Text = "Your OTP expires in: ";
            // 
            // otpsubmit
            // 
            otpsubmit.BackColor = SystemColors.HotTrack;
            otpsubmit.FlatStyle = FlatStyle.Popup;
            otpsubmit.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otpsubmit.ForeColor = SystemColors.ButtonHighlight;
            otpsubmit.Location = new Point(159, 452);
            otpsubmit.Name = "otpsubmit";
            otpsubmit.Size = new Size(149, 52);
            otpsubmit.TabIndex = 16;
            otpsubmit.Text = "SUBMIT";
            otpsubmit.UseVisualStyleBackColor = false;
            otpsubmit.Click += otpsubmit_Click;
            // 
            // txtotp
            // 
            txtotp.BackColor = Color.White;
            txtotp.BorderStyle = BorderStyle.None;
            txtotp.ForeColor = SystemColors.ActiveCaptionText;
            txtotp.Location = new Point(74, 377);
            txtotp.Name = "txtotp";
            txtotp.Size = new Size(317, 24);
            txtotp.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(74, 345);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 14;
            label1.Text = "ENTER OTP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 133);
            label5.Name = "label5";
            label5.Size = new Size(281, 38);
            label5.TabIndex = 13;
            label5.Text = "AUTHENTICATION";
            label5.Click += label5_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = this;
            // 
            // Updatepannel
            // 
            Updatepannel.BackColor = Color.LightSteelBlue;
            Updatepannel.Controls.Add(UpdateBtn);
            Updatepannel.Controls.Add(newPass);
            Updatepannel.Controls.Add(label6);
            Updatepannel.Controls.Add(label7);
            Updatepannel.Location = new Point(0, 0);
            Updatepannel.Name = "Updatepannel";
            Updatepannel.Size = new Size(441, 733);
            Updatepannel.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.HotTrack;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = SystemColors.ButtonHighlight;
            UpdateBtn.Location = new Point(159, 435);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(149, 52);
            UpdateBtn.TabIndex = 23;
            UpdateBtn.Text = "SUBMIT";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // newPass
            // 
            newPass.BackColor = Color.White;
            newPass.BorderStyle = BorderStyle.None;
            newPass.ForeColor = SystemColors.ActiveCaptionText;
            newPass.Location = new Point(64, 278);
            newPass.Name = "newPass";
            newPass.Size = new Size(317, 24);
            newPass.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(64, 246);
            label6.Name = "label6";
            label6.Size = new Size(213, 21);
            label6.TabIndex = 21;
            label6.Text = "ENTER NEW PASSWORD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(68, 35);
            label7.Name = "label7";
            label7.Size = new Size(313, 38);
            label7.TabIndex = 20;
            label7.Text = "UPDATE PASSWORD";
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 733);
            Controls.Add(OTP);
            Controls.Add(Updatepannel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forgot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot";
            OTP.ResumeLayout(false);
            OTP.PerformLayout();
            Updatepannel.ResumeLayout(false);
            Updatepannel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel OTP;
        private Label tym;
        private Label label2;
        private Button otpsubmit;
        private TextBox txtEmail;
        private Label label1;
        private Label label5;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtotp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel Updatepannel;
        private Button UpdateBtn;
        private TextBox newPass;
        private Label label6;
        private Label label7;
    }
}