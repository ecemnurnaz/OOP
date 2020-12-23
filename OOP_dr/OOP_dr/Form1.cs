using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_dr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Siir siir = new Siir();
        Roman roman = new Roman();
        Sosyoloji sosyoloji = new Sosyoloji();
        OrganizeSuc organizeSuc = new OrganizeSuc();
        TurkTarihi turkTarihi = new TurkTarihi();
        DunyaTarihi dunyaTarihi = new DunyaTarihi();

        List<Kitap> edebiEserler = new List<Kitap>();


        private void Form1_Load(object sender, EventArgs e)
        {
            siir.KitapAdi = "Büyük Saat";
            siir.YazarAdi = "Turgut Uyar";
            siir.BasimYili = 1990;
            siir.YayinEvi = "Can Yayınevi";
            siir.KapakTuru = "Karton Kapak";
            siir.fiyat = 25;

            roman.YazarAdi = "Daniel Keyes";
            roman.KitapAdi = "Algernon'a Çiçekler";
            roman.BasimYili = 1975;
            roman.YayinEvi = "İş Bankası";
            roman.KapakTuru = "İnce Kapak";
            roman.fiyat = 15;

            sosyoloji.KitapAdi = "Bu Ülke";
            sosyoloji.YazarAdi = "Cemil Meriç";
            sosyoloji.BasimYili = 1975;
            sosyoloji.YayinEvi = "Yapıkredi Yayınları";
            sosyoloji.KapakTuru = "İnce Kapak";
            sosyoloji.fiyat = 20;

            organizeSuc.KitapAdi = "El Kaide'nin Sırları";
            organizeSuc.YazarAdi = "Faik Bulut";
            organizeSuc.BasimYili =2018;
            organizeSuc.YayinEvi = "Cumhuriyet Yayınevi";
            organizeSuc.KapakTuru = "Karton Kapak";
            organizeSuc.fiyat =27;

            turkTarihi.KitapAdi = "Atatürk ve Demokratik Türkiye";
            turkTarihi.YazarAdi = "Halil İnancık";
            turkTarihi.BasimYili = 1980;
            turkTarihi.YayinEvi = "asdsds";
            turkTarihi.KapakTuru = "İnce Kapak";
            turkTarihi.fiyat = 30;


            edebiEserler.Add(siir);
            edebiEserler.Add(roman);
            edebiEserler.Add(sosyoloji);
            edebiEserler.Add(organizeSuc);
            edebiEserler.Add(turkTarihi);


            foreach (Edebiyat edebiEser in edebiEserler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = edebiEser.KitapAdi;
                lvi.SubItems.Add(edebiEser.YazarAdi);
                lvi.SubItems.Add(edebiEser.YayinEvi);
                lvi.SubItems.Add(edebiEser.KapakTuru);
                lvi.SubItems.Add(edebiEser.BasimYili.ToString());
                lvi.SubItems.Add(edebiEser.fiyat.ToString());

                lvwKitaplar.Items.Add(lvi);


            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
