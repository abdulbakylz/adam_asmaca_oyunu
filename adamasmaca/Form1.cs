using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace adamasmaca
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }
        private string[] hayvan = { "akrep", "aslan", "balýk", "böcek", "domuz", "geyik", "goril", "horoz", "karga", "koyun", "köpek", "kumru", "sýðýr", "sinek", "tavuk", "tilki", "yýlan", "yunus", "zebra" };
        Random rnd = new Random();
        char[] chrdizi = { };
        int haksayiyisi = 5;
        string gelenhayvan;
        int index;
        int sayac = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            index = rnd.Next(20);
            gelenhayvan = hayvan[index];
            gelenhayvan = gelenhayvan.ToUpper();
            chrdizi = gelenhayvan.ToCharArray();
            label1.Text = haksayiyisi.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (progressBar1.Value < 120)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("süreniz doldu . tahmin kýsmýna hayvan tahmininizi giriniz.");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (haksayiyisi == 0)
            {
                timer1.Stop();
                MessageBox.Show("kaybettiniz . aranan hayvan ise" +  gelenhayvan);
                Application.Restart();
            }
            int adet = 0;
            string tahmin = maskedTextBox6.Text;
            maskedTextBox6.Clear();
            foreach (char c in chrdizi)
            {
                if (c.ToString() == tahmin)
                {
                    adet++;
                    if (c == chrdizi[0]) { textBox2.Text = tahmin; }
                    if (c == chrdizi[1]) { textBox3.Text = tahmin; }
                    if (c == chrdizi[2]) { textBox4.Text = tahmin; }
                    if (c == chrdizi[3]) { textBox5.Text = tahmin; }
                    if (c == chrdizi[4]) { textBox6.Text = tahmin; }
                }
            }
            if (adet == 0)
            {
                MessageBox.Show("girdiðiniz  harf , olan kelimede bulunamadý");
                haksayiyisi--;
                label1.Text = haksayiyisi.ToString();

            }
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text))

            {
                tebrikler();

            }

        }
        public void tebrikler()
        {
            timer1.Stop();
            MessageBox.Show("tebrik ederim . bildiniz..");
            pictureBox1.Image = ýmageList1.Images[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == gelenhayvan)
            {
                tebrikler();
            }
            else
            {
                MessageBox.Show("yeniden oyanyýnýz . kaybettiniz");
                Application.Restart();
            }
        }

        private void çIKIÞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDAMASMACAOYUNUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

}


