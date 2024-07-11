namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamben = 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar6.png";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar6.png";
            }

            toplamben = toplamben + a + b;
            label16.Text = toplamben.ToString();

            label2.Text = a.ToString();
            label4.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;

            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);

            label10.Text = c.ToString();
            label11.Text = d.ToString();

            toplampc = toplampc + c + d;
            label17.Text = toplampc.ToString();

            if (c == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar1.png";
            }
            if (c == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar2.png";
            }
            if (c == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar3.png";
            }
            if (c == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar4.png";
            }
            if (c == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar5.png";
            }
            if (c == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar6.png";
            }

            if (d == 1)
            {
                pictureBox4.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar1.png";
            }
            if (d == 2)
            {
                pictureBox4.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar2.png";
            }
            if (d == 3)
            {
                pictureBox4.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar3.png";
            }
            if (d == 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar4.png";
            }
            if (d == 5)
            {
                pictureBox4.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar5.png";
            }
            if (d == 6)
            {
                pictureBox4.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotolarý\\zar6.png";
            }
            if (toplamben > 100 && toplamben > toplampc)
            {
                label13.Text = "Tebrikler 1. Oyuncu kazandý,  2. Oyuncu Kaybetti";
            }
            if (toplampc>100 && toplampc> toplamben)
            {
                label16.Text = "Tebrikler 2. Oyuncu Kazandý,  1. Oyuncu Kaybetti";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}
