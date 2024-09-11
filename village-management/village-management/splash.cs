namespace village_management
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 1;
            Myprogress.Value = startp;
            percentageLbl.Text = startp + "%";
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                login obj = new login();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
