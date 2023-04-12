namespace FuerzaBruta
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        String[] NIP = { "0", "0", "0", "0" };
        private DateTime start;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NIP[0] = random.Next(10).ToString();
            label1.Text = NIP[0] + NIP[1] + NIP[2] + NIP[3];
            if ((DateTime.Now - start).TotalSeconds > 1)
            {
                timer1.Stop();
                NIP[0] = textBox1.Text[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 4)
            {
                start = DateTime.Now;
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NIP[1] = random.Next(10).ToString();
            label1.Text = NIP[0] + NIP[1] + NIP[2] + NIP[3];
            if ((DateTime.Now - start).TotalSeconds > 2)
            {
                timer2.Stop();
                NIP[1] = textBox1.Text[1].ToString();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            NIP[2] = random.Next(10).ToString();
            label1.Text = NIP[0] + NIP[1] + NIP[2] + NIP[3];
            if ((DateTime.Now - start).TotalSeconds > 3)
            {
                NIP[2] = textBox1.Text[2].ToString();
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            NIP[3] = random.Next(10).ToString();
            if ((DateTime.Now - start).TotalSeconds > 4)
            {
                timer4.Stop();
                NIP[3] = textBox1.Text[3].ToString();
            }
            label1.Text = NIP[0] + NIP[1] + NIP[2] + NIP[3];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}