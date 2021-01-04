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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        

        public void SiparisOlustur_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Adi = cmbMenu.SelectedItem.ToString();
            cmbMenu.Items.Add(menu);

            CheckBox chk = new CheckBox();
            chk.Text=ek
            flwEkstra




            //CheckBox chk = new CheckBox();
            //chk.Text = "Ketçap";
            //CheckBox chk2 = new CheckBox();
            //chk.Text = "Mayonez";
            //CheckBox chk3 = new CheckBox();
            //chk.Text = "Hardal";
            //CheckBox chk4 = new CheckBox();
            //chk.Text = "Acı Sos";
            //Ekstra ekstra = new Ekstra();
            //flwEkstra.Controls.Add(chk);
            //flwEkstra.Controls.Add(chk2);
            //flwEkstra.Controls.Add(chk3);
            //flwEkstra.Controls.Add(chk4);
        }
    }
}
