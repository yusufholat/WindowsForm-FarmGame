using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndpprojje
{
    public partial class FormHayvanCiftligi : Form
    {

        Tavuk tavuk = new Tavuk();
        Ordek ordek = new Ordek();
        Inek inek = new Inek();
        Keci keci = new Keci();
      

        public FormHayvanCiftligi()
        {
            InitializeComponent();
        }

        private void FormHayvanCiftligi_Load(object sender, EventArgs e)
        {
            //form yüklendiğinde kurucularda oluşan enerji değerleri progressbar ve text değerlerine atanıyor
            progressBarTavuk.Value = tavuk.Enerji;
            progressBarOrdek.Value = ordek.Enerji;
            progressBarInek.Value = inek.Enerji;
            progressBarKeci.Value = keci.Enerji;

            lblTavukLive.Text = tavuk.YasiyorMuText;
            lblOrdekLive.Text = ordek.YasiyorMuText;
            lblInekLive.Text = inek.YasiyorMuText;
            lblKeciLive.Text = keci.YasiyorMuText;

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            Oyun.saniye++;

            //timer içinde değişen değerler ilgili alanlara yazılıyor
            labelSaniye.Text = Convert.ToString(Oyun.saniye + " SN");
            lblTavYumDegeri.Text = Convert.ToString(tavuk.YumurtaSayisi + " ADET");
            lblOrdYumDegeri.Text = Convert.ToString(ordek.YumurtaSayisi + " ADET");
            lblInekSutuDegeri.Text = Convert.ToString(inek.SutMiktari + " KG");
            lblKeciSutuDegeri.Text = Convert.ToString(keci.SutMiktari + " KG");
            lblTl.Text = Convert.ToString(Oyun.toplamKazanc + " TL");

            //oyunusürükle fonksiyonu nesnelerin kontrolünü sağlar
            Oyun.OyunuSurukle(tavuk, ordek, inek, keci);

            progressBarTavuk.Value = tavuk.Enerji;
            progressBarOrdek.Value = ordek.Enerji;
            progressBarInek.Value = inek.Enerji;
            progressBarKeci.Value = keci.Enerji;

            lblTavukLive.Text = tavuk.YasiyorMuText;
            lblOrdekLive.Text = ordek.YasiyorMuText;
            lblInekLive.Text = inek.YasiyorMuText;
            lblKeciLive.Text = keci.YasiyorMuText;
        }


        private void buttonYemVerTavuk_Click(object sender, EventArgs e)
        {
            //tavuk yaşadığı sürece YemVer fonksiyonu çalışacak
            tavuk.YemVer();
        }

        private void buttonYemVerOrdek_Click(object sender, EventArgs e)
        {
            //ordek yaşadığı sürece YemVer fonksiyonu çalışacak
            ordek.YemVer();
        }

        private void buttonYemVerInek_Click(object sender, EventArgs e)
        {
            //inek yaşadığı sürece YemVer fonksiyonu çalışacak
            inek.YemVer();
        }

        private void buttonYemVerKeci_Click(object sender, EventArgs e)
        {
            //keci yaşadığı sürece YemVer fonksiyonu çalışacak
            keci.YemVer();
        }


        private void buttonTavYumSat_Click(object sender, EventArgs e)
        {
            //yumurtalarıSat fonksiyonu toplamkazanca ekleniyor ve ilgili alanlara değerler yazılıyor
            Oyun.toplamKazanc += tavuk.YumurtalariSat();
            lblTavYumDegeri.Text = Convert.ToString(tavuk.YumurtaSayisi + " ADET");
            lblTl.Text = Convert.ToString(Oyun.toplamKazanc + " TL");
        }

        private void buttonOrdYumSat_Click(object sender, EventArgs e)
        {
            Oyun.toplamKazanc += ordek.YumurtalariSat();
            lblOrdYumDegeri.Text = Convert.ToString(ordek.YumurtaSayisi + " ADET");
            lblTl.Text = Convert.ToString(Oyun.toplamKazanc + " TL");
        }

        private void buttonInekSutuSat_Click(object sender, EventArgs e)
        {
            Oyun.toplamKazanc += inek.SutleriSat();
            lblInekSutuDegeri.Text = Convert.ToString(inek.SutMiktari + " KG");
            lblTl.Text = Convert.ToString(Oyun.toplamKazanc + " TL");
        }

        private void buttonKeciSutuSat_Click(object sender, EventArgs e)
        {
            Oyun.toplamKazanc += keci.SutleriSat();
            lblKeciSutuDegeri.Text = Convert.ToString(keci.SutMiktari + " KG");
            lblTl.Text = Convert.ToString(Oyun.toplamKazanc + " TL");
        }
    }
}
