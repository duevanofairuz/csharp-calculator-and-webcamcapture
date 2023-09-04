namespace simple_calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strhasil, operasi;
        int x, y, hasil;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn9.Text;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + btn0.Text;
        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            txtres.Clear();
            hasil = (0);
            x = (0);
            y = (0);
        }
        private void buttonres_Click(object sender, EventArgs e)
        {
            y = int.Parse(txtres.Text);
            if (operasi.Equals("+"))
                hasil = x + y;
            else if (operasi.Equals("-"))
                hasil = x - y;
            else if (operasi.Equals("*"))
                hasil = x * y;
            else if (operasi.Equals("/"))
                hasil = x / y;
            txtres.Text = hasil + "";
        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            operasi = "+";
            x = int.Parse(txtres.Text);
            txtres.Clear();
        }
        private void buttonmin_Click(object sender, EventArgs e)
        {
            operasi = "-";
            x = int.Parse(txtres.Text);
            txtres.Clear();
        }
        private void buttonmul_Click(object sender, EventArgs e)
        {
            operasi = "*";
            x = int.Parse(txtres.Text);
            txtres.Clear();
        }
        private void buttondiv_Click(object sender, EventArgs e)
        {
            operasi = "/";
            x = int.Parse(txtres.Text);
            txtres.Clear();
        }
    }
}