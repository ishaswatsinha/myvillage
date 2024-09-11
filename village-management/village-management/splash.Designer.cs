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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(93, 26);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(408, 31);
            label1.TabIndex = 1;
            label1.Text = "VILLAGE MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(129, 225);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 26);
            label2.TabIndex = 12;
            label2.Text = "Loading Module";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Myprogress
            // 
            Myprogress.ForeColor = SystemColors.GrayText;
            Myprogress.Location = new Point(136, 254);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(424, 34);
            Myprogress.TabIndex = 14;
            Myprogress.Click += progressBar1_Click;
            // 
            // percentageLbl
            // 
            percentageLbl.AutoSize = true;
            percentageLbl.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percentageLbl.ForeColor = SystemColors.ActiveCaptionText;
            percentageLbl.Location = new Point(264, 122);
            percentageLbl.Margin = new Padding(6, 0, 6, 0);
            percentageLbl.Name = "percentageLbl";
            percentageLbl.Size = new Size(48, 31);
            percentageLbl.TabIndex = 15;
            percentageLbl.Text = "%%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // splash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(628, 325);
            Controls.Add(percentageLbl);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}
