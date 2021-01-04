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
    public partial class EkstraMalzeme : Form
    {
        public EkstraMalzeme()
        {
            InitializeComponent();
        }

        List<Ekstra> ekstralar = new List<Ekstra>();

        

        public void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            Ekstra ekstra = new Ekstra();

            ekstra.Adi = txtEkstra.Text;
            ekstra.Fiyat = nudEkstraFiyat.Value;
            ekstralar.Add(ekstra);

        }

        
    }
}
