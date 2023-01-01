using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarısması_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            richTextBox1.Text = "Kim 1 günlük yevmiye kazanmak ister? Yarışmamıza Hoşgeldiniz";
        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        int sayac = 20;
        void soruisaretlenmesi()
            {
             btnA.Enabled = false;
             btnB.Enabled = false;
             btnC.Enabled = false;
             btnD.Enabled = false;
             btnSonraki.Enabled = true;
            }
        void dogrumuyanlısmı()
        {
            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox1.Visible = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblsayacYazısı.Text = sayac.ToString();
            if (sayac==0)
            {
                timer1.Stop();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Hızlı olsana birader");
            }
           
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label5.Text = btnA.Text;
            soruisaretlenmesi();
            dogrumuyanlısmı();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label5.Text = btnB.Text;
            soruisaretlenmesi();
            dogrumuyanlısmı();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
             timer1.Stop();
            label5.Text = btnC.Text;
            soruisaretlenmesi();
            dogrumuyanlısmı();
        }



        private void btnD_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label5.Text = btnD.Text;
            soruisaretlenmesi();
            dogrumuyanlısmı();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sayac = 20;
            soruno++;
            lblSoruno.Text = soruno.ToString();
            richTextBox1.Focus();
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            if (soruno == 1)
            {
                richTextBox1.Text = "“Sinekli Bakkal” Romanının Yazarı Aşağıdakilerden Hangisidir?";
                btnA.Text = "Reşat Nuri Güntekin";
                btnB.Text = "Halide Edip Adıvar";
                btnC.Text = "Ziya Gökalp";
                btnD.Text = "Ömer Seyfettin";
                label4.Text = "Halide Edip Adıvar";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıda Verilen İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir?";
                btnA.Text = "Hititler ";
                btnB.Text = "Elamlar ";
                btnC.Text = "Sümerler ";
                btnD.Text = "Urartular";
                label4.Text = "Sümerler ";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Tsunami Felaketinde En Fazla Zarar Gören Güney Asya Ülkesi Aşağıdakilerden Hangisidir";
                btnA.Text = "Endonezya";
                btnB.Text = "Srilanka ";
                btnC.Text = "Tayland ";
                btnD.Text = "Hindistan";
                label4.Text = "Endonezya";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "2003 Yılında Euro Vizyon Şarkı Yarışmasında Ülkemizi Temsil Eden ve Yarışmada Birinci Gelen Sanatçımız Kimdir";
                btnA.Text = "Grup Athena";
                btnB.Text = "Sertap Erener";
                btnC.Text = "Şebnem Paker";
                btnD.Text = "Ajda Pekkan";
                label4.Text = "Sertap Erener";

            }
            if (soruno == 5)
            {
                richTextBox1.Text = " Mustafa Kemal Atatürk’ün Nüfusa Kayıtlı Olduğu İl Hangisidir? ";
                btnA.Text = "Bursa";
                btnB.Text = "Ankara ";
                btnC.Text = "İstanbul ";
                btnD.Text = "Gaziantep";
                label4.Text = "Gaziantep";

            } 
            if (soruno == 6)
            {
                richTextBox1.Text = "Aşağıdakilerden Hangisi Dünya Sağlık Örgütünün Kısaltılmış İsmidir?";
                btnA.Text = "Uhw ";
                btnB.Text = "Unıcef";
                btnC.Text = "Who";
                btnD.Text = "Nato";
                label4.Text = "Who";

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Romen Rakamında Hangi Sayı Yoktur?";
                btnA.Text = "0";
                btnB.Text = "50";
                btnC.Text = "100";
                btnD.Text = "1000";
                label4.Text = "0";

            } 
            if (soruno == 8)
            {
                richTextBox1.Text = "Bir Gün Kaç Saniyedir?";
                btnA.Text = "86000";
                btnB.Text = "88600";
                btnC.Text = "86400";
                btnD.Text = "84800";
                label4.Text = "86400";

            } 
            if (soruno == 9)
            {
                richTextBox1.Text = "Üç Büyük Dince Kutsal Sayılan Şehir Hangisidir?";
                btnA.Text = "Mekke";
                btnB.Text = "Kudüs";
                btnC.Text = "Roma";
                btnD.Text = "İstanbul";
                label4.Text = "Kudüs";

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Aspirinin Hammaddesi Nedir?";
                btnA.Text = "Söğüt";
                btnB.Text = "Köknar";
                btnC.Text = "Kavak";
                btnD.Text = "Meşe";
                label4.Text = "Söğüt";

            }

            if (soruno == 11)
            {
                string odulmiktari="Ö";
                if (dogru>yanlıs)
                {
                    odulmiktari= "1 Günlük";
                }
                if (yanlıs>dogru)
                {
                    odulmiktari = "Yarım Günlük";

                }
                MessageBox.Show("Tebrikler! Bilgi Yarışması bitti."+ odulmiktari +" Yevmiye  KAZANDINIZ" + "\n"+ "Doğru Sayısı:"+" "+dogru + "\n" +"Yanlış Sayısı:"+" "+yanlıs);
                soruno = 3;
                timer1.Stop();
                btnA.Visible = false;
                btnB.Visible = false;
                btnC.Visible = false;
                btnD.Visible = false;
                btnSonraki.Visible = false;
                richTextBox1.Text = "Düşünceleriniz nelerdir ?\n \n";
            }


        }

    }
}
