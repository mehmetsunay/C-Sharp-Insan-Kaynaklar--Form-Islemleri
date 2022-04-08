using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersleri_2
{
    public partial class FrmPersonelTakip : Form
    {
        public FrmPersonelTakip()
        {
            InitializeComponent();
        }

        int index = 0;
        string[] calisanlar;
        int[] maaslar;


        private void btn_ollist_Click(object sender, EventArgs e)
        {
            calisanlar = new string[] { "Yeşim", "Behzat", "Murat", "Hakan", "Sibel" };
            maaslar = new int[] { 4900, 4800, 6100, 5500, 6200 };

            for(int i =0;i<calisanlar.Length;i++)
            {
                listBox1.Items.Add(calisanlar[i] + "\t" + maaslar[i]);

            }


        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string aranan = txt_personel.Text;
            bool bulundu = false;
            
            for(int i=0; i<calisanlar.Length;i++)

            {
                if(aranan==calisanlar[i])

                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;


                }

            }

            if(bulundu)
            {
                MessageBox.Show("Çalışan Bulundu");

            }

            else
            {

                MessageBox.Show("Çalışan Bulunamadı");

            }




        }

        private void btn_pergoster_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = " Toplam Personel Sayısı :" + calisanlar.Length;
        }

        private void btn_endskmaas_Click(object sender, EventArgs e)
        {

            int dusuk = maaslar[0];
            
            for(int i=0;i<maaslar.Length;i++)

            {
                if(dusuk>maaslar[i])

                {

                    dusuk = maaslar[i];

                }


            }

            lbl_sonuc.Text = "EN DÜŞÜK MAAŞ:" + dusuk;


        }

        private void btn_enykskmaasper_Click(object sender, EventArgs e)
        {
            int yuksek = maaslar[0];
            int yuksekIndex = 0;
            for (int i=0; i<maaslar.Length;i++)
            {
                if(yuksek<maaslar[i])
                {
                    yuksek = maaslar[i];
                    yuksekIndex = i;

                }
            }

            lbl_sonuc.Text = "EN YÜKSEK MAAŞ ALAN :" + calisanlar[yuksekIndex];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maaslar.Length; i++)

            {
                if (maaslar[i] < 6000)

                {
                    listBox1.Items.Add(calisanlar[i] + ">>" + maaslar[i]);

                }



            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_besbinyedibin_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for(int i =0;i<maaslar.Length;i++)

            {
                if(maaslar[i]>=5000 && maaslar[i]<=7000)
                {
                    sayac++;
                }

                lbl_sonuc.Text = "5000 - 7000 ARASI MAAŞ ALANLARIN SAYISI :" + sayac;


            }
        }

        private void btn_toplam_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                toplam += maaslar[i];

            }
            lbl_sonuc.Text = "Toplam Ödenen : " + toplam;
        }

        private void btn_ucuncueleman_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            maaslar[2] += 500;
            for (int i = 0; i < calisanlar.Length; i++)
            {
                listBox1.Items.Add(calisanlar[i] + "\t" + maaslar[i]);
            }
        }

        private void btn_sonpersonel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
