using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace düz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string oyuncuSecimi;
        string bilgisayarSecimi;
        int oyuncuPuani;
        int bilgisayarPuani;
        int rastgele;
        Random random=new Random(); 

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Makas_Click(object sender, EventArgs e)
        {
            OYUNCU.ImageLocation = "resim/makas.png";
            oyuncuSecimi = "Makas";
        }

        private void Taş_Click(object sender, EventArgs e)
        {
            OYUNCU.ImageLocation = "resim/tas.png";
            oyuncuSecimi = "Taş";
        }

        private void Kağıt_Click(object sender, EventArgs e)
        {
            OYUNCU.ImageLocation = "resim/kağıt.png";
            oyuncuSecimi = "Kağıt";
        }

        private void BilgisayarHamle()
        {
            rastgele = random.Next(1,4);
            if(rastgele == 1)
            {
                BİLGİSAYAR.ImageLocation = "resim/tas.png";
                bilgisayarSecimi = "Taş";
            }
            else if (rastgele==2)
            {
                BİLGİSAYAR.ImageLocation = "resim/kağıt.png";
                bilgisayarSecimi = "Kağıt";

            }
            else if (rastgele == 3)
            {
                BİLGİSAYAR.ImageLocation = "resim/makas.png";
                bilgisayarSecimi = "Makas";

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir hamle seçiniz");
            }
        }

        private void OYUNCU_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(bilgisayarPuani==0 && oyuncuPuani == 0) //oyun başlangıç durumunda ise
            { 
                label5.Visible = false; 
                label6.Visible = false; 
                Oyuncu_Puan.Text="0";
                Bilgisayar_Puan.Text = "0";
            }
            if (oyuncuSecimi==null)
            {
                MessageBox.Show("Lütfen hamle seçiniz");
            }
            else
            {
                BilgisayarHamle();
            }
            Puan();
        }
        private void Puan()
        {
            if (oyuncuSecimi=="Taş" && bilgisayarSecimi=="Kağıt")
            {
                bilgisayarPuani++;
                Bilgisayar_Puan.Text=bilgisayarPuani.ToString();    
            }
            else if (oyuncuSecimi=="Taş" && bilgisayarSecimi=="Makas")
            {
                oyuncuPuani++;
                Oyuncu_Puan.Text = oyuncuPuani.ToString();
            }
            else if (oyuncuSecimi == "Kağıt" && bilgisayarSecimi == "Taş")
            {
                oyuncuPuani++;
                Oyuncu_Puan.Text = oyuncuPuani.ToString();
            }
            else if (oyuncuSecimi == "Kağıt" && bilgisayarSecimi == "Makas")
            {
                bilgisayarPuani++;
                Bilgisayar_Puan.Text = bilgisayarPuani.ToString();
            }
            else if (oyuncuSecimi == "Makas" && bilgisayarSecimi == "Taş")
            {
                bilgisayarPuani++;
                Bilgisayar_Puan.Text = bilgisayarPuani.ToString();
            }
            else if (oyuncuSecimi == "Makas" && bilgisayarSecimi == "Kağıt")
            {
                oyuncuPuani++;
                Oyuncu_Puan.Text = oyuncuPuani.ToString();
            }

            if(oyuncuPuani==5 || bilgisayarPuani == 5)
            {
                label5.Visible = true;
                label6.Visible = true;
                if (bilgisayarPuani > oyuncuPuani)
                {
                    label6.Text = "Bilgisayar";
                    oyuncuPuani = 0;
                    bilgisayarPuani = 0;
                    BİLGİSAYAR.ImageLocation = null;
                    OYUNCU.ImageLocation = null;
                    bilgisayarSecimi = null;
                    oyuncuSecimi = null;
                }
                else if (oyuncuPuani> bilgisayarPuani) 
                {
                    label6.Text = "Oyuncu";
                    oyuncuPuani = 0;
                    bilgisayarPuani = 0;
                    BİLGİSAYAR.ImageLocation = null;
                    OYUNCU.ImageLocation = null;
                    bilgisayarSecimi = null;
                    oyuncuSecimi = null;
                }
                
            }

        }

        private void BİLGİSAYAR_Click(object sender, EventArgs e)
        {

        }
    }
}
