using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CiftSayi()
        {

            ulong girilenDeger = Convert.ToUInt64(mGirisDeger.Text);
            ulong girilenDeger2 = Convert.ToUInt64(mGirisDeger2.Text);

            ulong ciftToplam = 0;
            ulong ciftCarpim = 1;
            ulong ciftSayi = girilenDeger;
            
            for (ciftSayi = girilenDeger; ciftSayi <= girilenDeger2; ciftSayi++)
            {
                if (ciftSayi % 2 == 0)
                {
                    listCiftSayilar.Items.Add("" + ciftSayi);
                    ciftToplam += ciftSayi;
                    ciftCarpim *= ciftSayi;
                }
            }
            listCiftSayilar.Items.Add("Çift Sayılar Toplamı:" + ciftToplam);
            listCiftSayilar.Items.Add("Çift Sayılar Çarpımı:" + ciftCarpim);
        }

        private void TekSayi()
        {
            ulong girilenDeger = Convert.ToUInt64(mGirisDeger.Text);
            ulong girilenDeger2 = Convert.ToUInt64(mGirisDeger2.Text);

            ulong tekToplam = 0;
            ulong tekCarpim = 1;

            ulong tekSayi = girilenDeger;

            for (tekSayi = girilenDeger; tekSayi <= girilenDeger2; tekSayi++)
            {
                if (tekSayi % 2 == 1)
                {
                    listTekSayilar.Items.Add("" + tekSayi);
                    tekToplam += tekSayi;
                    tekCarpim *= tekSayi;
                }
            }
            listTekSayilar.Items.Add("Tek Sayılar Toplamı:" + tekToplam);
            listTekSayilar.Items.Add("Tek Sayılar Çarpımı:" + tekCarpim);
        }
        private void AsalSayi()
        {
            ulong girilenDeger = Convert.ToUInt64(mGirisDeger.Text);
            ulong girilenDeger2 = Convert.ToUInt64(mGirisDeger2.Text);

            ulong asalToplam = 0;
            ulong asalCarpim = 1;

            ulong asalSayi = girilenDeger;


            for (asalSayi = girilenDeger; asalSayi <= girilenDeger2; asalSayi++)
            {
                AsalSayiKontrol(asalSayi);

                if (AsalSayiKontrol(asalSayi) == true)
                {
                    listAsalSayilar.Items.Add("" + asalSayi);
                    asalToplam += asalSayi;
                    asalCarpim *= asalSayi;
                }
            }
            listAsalSayilar.Items.Add("Asal Sayılar Toplamı:" + asalToplam);
            listAsalSayilar.Items.Add("Asal Sayılar Çarpımı:" + asalCarpim);
        }

        private void MukemmelSayi()
        {
            int girilenDeger = Convert.ToInt32(mGirisDeger.Text);
            int girilenDeger2 = Convert.ToInt32(mGirisDeger2.Text);

            int mukemmelToplam = 0;
            int mukemmelCarpim = 1;

            int mukemmelSayi = girilenDeger;
            int a = 1;


            for (mukemmelSayi = girilenDeger; mukemmelSayi <= girilenDeger2; mukemmelSayi++)
            {

                MukemmelSayiKontrol(mukemmelSayi);

                int bolenToplam = 0;
                for (a = 1; a <= mukemmelSayi / 2; a++)
                {
                    if (mukemmelSayi % a == 0)
                    {
                        bolenToplam += a;
                    }
                }
                if (bolenToplam == mukemmelSayi)
                {
                    listMükemmelSayilar.Items.Add("" + mukemmelSayi);
                    mukemmelToplam += mukemmelSayi;
                    mukemmelCarpim *= mukemmelSayi;
                }
            }
            listMükemmelSayilar.Items.Add("Mükemmel Sayılar Toplamı:" + mukemmelToplam);
            listMükemmelSayilar.Items.Add("Mükemmel Sayılar Çarpımı:" + mukemmelCarpim);
        }
        private bool AsalSayiKontrol(ulong c)
        {
            if (c == 1)
                return false;

            for (ulong i = 2; i < c; i++)
            {
                if (c % i == 0)
                    return false;
            }
            return true;
        }
        private bool MukemmelSayiKontrol(int d)
        {
            int toplam = 0;
            for (int b = 1; b <= d / 2; b++)
            {
                toplam = toplam + b;

                if (d % b != 0)
                {
                    return false;
                }

                if (toplam != d)
                {
                    return false;
                }

            }
            return true;

        }
        private void GirisDegerleriKontrol(int a, int b)
        {
            if (a > b)
            {
                MessageBox.Show("Girilen ilk değer ikinci değerden büyük olamaz !");
            }
            if (a < 1 || b > 1000)
            {
                MessageBox.Show("Girilen değerler 1-1000 arasında olmalıdır.");
            }
        }
        private void GirisDegerleriKontrolString(string a, string b)
        {
            if (a == "")
            {
                MessageBox.Show("Başlangıç değerini girmediniz !");
            }
            if (b == "")
            {
                MessageBox.Show("Bitiş değerini girmediniz !");
            }
        }
        private void Calistir_Click(object sender, EventArgs e)
        {
            GirisDegerleriKontrolString(mGirisDeger.Text, mGirisDeger2.Text);
            GirisDegerleriKontrol(Convert.ToInt32(mGirisDeger.Text), Convert.ToInt32(mGirisDeger2.Text));

            listTekSayilar.Items.Clear();
            listCiftSayilar.Items.Clear();
            CiftSayi();           
            TekSayi();
            listAsalSayilar.Items.Clear();
            AsalSayi();
            listMükemmelSayilar.Items.Clear();
            MukemmelSayi();
        }
    }
}
