using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }




        public void btnKaydet_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Adi = txtMenu.Text;
            menu.Fiyat = nudFiyat.Value;

            menu.Ekle(menu);




        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}