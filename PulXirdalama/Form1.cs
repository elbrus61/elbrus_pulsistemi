namespace PulXirdalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            int s5 = 0;
            int s6 = 0;
            int s7 = 0;
            int s8 = 0;
            int n = Convert.ToInt32(maskedTextBox1.Text);
            int mebleg = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;

            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
            listBox7.Visible = true;
            listBox8.Visible = true;

            if (n >= 500)
            {
                s8 = n / 500; n = n % 500;
                if (s8 > 0) { listBox8.Items.Add(s8 + " eded "); }
            }
            else
            {
                pictureBox8.Visible = false;
                listBox8.Visible = false;
            }
            if (n >= 200)
            {
                s7 = n / 200; n = n % 200;
                if (s7 > 0) { listBox7.Items.Add(s7 + " eded"); }
            }
            else
            {
                pictureBox7.Visible = false;
                listBox7.Visible = false;
            }

            if (n >= 100)
            {
                s6 = n / 100; n = n % 100;
                if (s6 > 0) { listBox6.Items.Add(s6 + " eded "); }
            }
            else
            {
                pictureBox6.Visible = false;
                listBox6.Visible = false;
            }

            if (n >= 50)
            {
                s5 = n / 50; n = n % 50;
                if (s5 > 0) { listBox5.Items.Add(s5 + " eded "); }
            }
            else
            {
                pictureBox5.Visible = false;
                listBox5.Visible = false;
            }

            if (n >= 20)
            {
                s4 = n / 20; n = n % 20;
                if (s4 > 0) { listBox4.Items.Add(s4 + " eded "); }
            }
            else
            {
                pictureBox4.Visible = false;
                listBox4.Visible = false;
            }
            if (n >= 10)
            {
                s3 = n / 10; n = n % 10;
                if (s3 > 0) { listBox3.Items.Add(s3 + " eded "); }
            }
            else
            {
                pictureBox3.Visible = false;
                listBox3.Visible = false;
            }

            if (n >= 5)
            {
                s2 = n / 5; n = n % 5;
                if (s2 > 0) { listBox2.Items.Add(s2 + " eded "); }
            }
            else
            {
                pictureBox2.Visible = false;
                listBox2.Visible = false;
            }

            if (n >= 1)
            {
                s1 = n / 1; n = n % 1;
                if (s1 > 0) { listBox1.Items.Add(s1 + " eded "); }
            }
            else
            {
                pictureBox1.Visible = false;
                listBox1.Visible = false;
            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
