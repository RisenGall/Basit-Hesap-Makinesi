namespace hesap_makinesi_basit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sonuc, sayi1, sayi2;
        private void btnarti_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label1.Text = Convert.ToString(sonuc);

        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label1.Text = Convert.ToString(sonuc);
        }

        private void btnbolu_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label1.Text = Convert.ToString(sonuc);
        }

        private void btncarpi_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label1.Text = Convert.ToString(sonuc);
        }
    }
}