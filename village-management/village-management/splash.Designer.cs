namespace village_management
{
    partial class splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Myprogress = new ProgressBar();
            percentageLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(101, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 19);
            label1.TabIndex = 1;
            label1.Text = "VILLAGE MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(115, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 12;
            label2.Text = "Loading Module";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 114);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Myprogress
            // 
            Myprogress.ForeColor = SystemColors.GrayText;
            Myprogress.Location = new Point(115, 154);
            Myprogress.Margin = new Padding(2, 2, 2, 2);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(297, 20);
            Myprogress.TabIndex = 14;
            Myprogress.Click += progressBar1_Click;
            // 
            // percentageLbl
            // 
            percentageLbl.AutoSize = true;
            percentageLbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percentageLbl.ForeColor = SystemColors.ActiveCaptionText;
            percentageLbl.Location = new Point(115, 114);
            percentageLbl.Margin = new Padding(4, 0, 4, 0);
            percentageLbl.Name = "percentageLbl";
            percentageLbl.Size = new Size(34, 21);
            percentageLbl.TabIndex = 15;
            percentageLbl.Text = "%%";
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
            // splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(440, 195);
            Controls.Add(percentageLbl);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ProgressBar Myprogress;
        private Label percentageLbl;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
