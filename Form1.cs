/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI:2.ÖDEV
**				ÖĞRENCİ ADI:SONGÜL BAYER
**				ÖĞRENCİ NUMARASI:B191210065
**              DERSİN ALINDIĞI GRUP:1-C
****************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label X = new Label();// YENİ LABEL TEXTBOX VE LİSTBOX OLUŞUTURULMASI SAĞLANACAK.
        Label Y = new Label();
        Label TOPLAMLAR = new Label();
        ListBox carpanlarX = new ListBox();
        ListBox carpanlarY = new ListBox();
        TextBox XcarpanlarToplamı = new TextBox();
        TextBox YcarpanlarToplamı = new TextBox();
        Point konum = new Point();//OLUŞTURULAN LABEL TEXTBOX VE LİSTBOX İÇİN KONUM BELİRLENECEK.
        private void button1_Click(object sender, EventArgs e)
        {

            carpanlarX.Items.Clear();//YENİ X VE Y DEĞERİ GİRDİĞİMİZDE LİSTBOXLARI TEMİZLEYECEK.
            carpanlarY.Items.Clear();
            this.Size = new System.Drawing.Size(587, 443);//BAŞTA KÜÇÜK OLAN FORM EKRANININ BÜYÜMESİ İÇİN OLUŞTURULDU.

            konum.X = 270;//X LABELİ İÇİN KONUM VE İSİM BELİRLENDİ.
            konum.Y = 10;
            X.Text = "X";
            X.Location = konum;




            konum.X = 430;//Y LABELİ İÇİN KONUM VE İSİM BELİRLENDİ.
            konum.Y = 10;
            Y.Text = "Y";
            Y.Location = konum;

            konum.X = 230;//OLUŞTURULAN LİSTBOXLAR İÇİN KONUM VE BOYUT BELİRLENDİ.
            konum.Y = 51;
            carpanlarX.Location = konum;
            carpanlarX.Size = new System.Drawing.Size(120, 164);

            konum.X = 371;
            konum.Y = 51;
            carpanlarY.Location = konum;
            carpanlarY.Size = new System.Drawing.Size(120, 164);

            konum.X = 230;//OLUŞTURULAN TEXTBOXLAR İÇİN KONUM VE BOYUT BELİRLENDİ.
            konum.Y = 230;
            XcarpanlarToplamı.Location = konum;
            XcarpanlarToplamı.Size = new System.Drawing.Size(128, 22);

            konum.X = 371;
            konum.Y = 230;
            YcarpanlarToplamı.Location = konum;
            YcarpanlarToplamı.Size = new System.Drawing.Size(120, 22);


            konum.X = 150;//OLUŞTURULAN LABEL İÇİN İSİM VE KONUM BELİRLENDİ.
            konum.Y = 233;
            TOPLAMLAR.Text = "TOPLAMLAR";
            TOPLAMLAR.Location = konum;

            this.Controls.Add(X);//LABELLER TEXTBOXLAR VE LİSTBOXLARIN ARKADAŞ MI BUTONUNA BASILDIKTAN SONRA FORMA EKLENMESİ YAPILDI. 
            this.Controls.Add(Y);
            this.Controls.Add(XcarpanlarToplamı);
            this.Controls.Add(YcarpanlarToplamı);
            this.Controls.Add(TOPLAMLAR);
            this.Controls.Add(carpanlarX);
            this.Controls.Add(carpanlarY);

            int sayi1 = Convert.ToInt32(textBox1.Text);//UYGUN DÖNÜŞÜMLER YAPILDI.
            int sayi2 = Convert.ToInt32(textBox2.Text);

            for(int i=1;i<sayi1;i++)//GİRİLEN X SAYISININ ÇARPANLARI BULUNUP LİSTBOXA HER BİR ÇARPAN YAZDIRILDI.
            {
                if(sayi1%i==0)
                {
                    carpanlarX.Items.Add(i);
                }
            }
            for(int j=1;j<sayi2;j++)//GİRİLEN Y SAYISININ ÇARPANLARI BULUNUP LİSTBOXA HER BİR ÇARPANI YAZILDI.
            {
                if(sayi2%j==0)
                {
                    carpanlarY.Items.Add(j);
                }
            }
            double toplam1 = 0;//GİRİLEN X SAYISININ ÇARPANLARI TOPLAMI HESAPLANIP YAZDIRILDI.
            for(int a=0;a<carpanlarX.Items.Count;a++)
            {
                toplam1 += Convert.ToInt32(carpanlarX.Items[a]);
            }
            XcarpanlarToplamı.Text = toplam1.ToString();
            double toplam2 = 0;//GİRİLEN Y SAYISININ ÇARPANLARI TOPLAMI HESAPLANIP YAZDIRILDI.
            for(int b=0;b<carpanlarY.Items.Count;b++)
            {
                toplam2 += Convert.ToInt32(carpanlarY.Items[b]);
            }
            YcarpanlarToplamı.Text = toplam2.ToString();

            






        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//KULLANICININ İŞLEMİ BİTTİKTEN SONRA SON BUTONUNA BASARAK FORMDAN AYRILMASI SAĞLANDI.
            Application.Exit();
        }
    }
}
