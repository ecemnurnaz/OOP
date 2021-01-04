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

        List<Ekstra> ekstralar = new List<Ekstra>();

        
        public void SiparisOlustur_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            cmbMenu.DataSource = menu.Listele();

            //menu.Fiyat = 10;

            Ekstra ekstra = new Ekstra();
            int i = 0;

            foreach (var item in ekstra.Listele())
            {
                CheckBox chb = new CheckBox();
                chb.Tag = i.ToString();
                chb.Text = ekstra.Adi;
                flwEkstra.Controls.Add(chb);
                i++;
            }
            //for (int i = 0; i < 4; i++)
            //{
                
            //    CheckBox chb = new CheckBox();
            //    chb.Tag = i.ToString();
            //    chb.Text = ekstra.Adi;
            //    flwEkstra.Controls.Add(chb);
            //}
           
            
            

            //for (int i = 0; i < 4; i++)
            //{
                
            //    
            //    if (i==0)
            //    {
            //        chb.Text = "Ketçap";
            //        flwEkstra.Controls.Add(chb);
            //    }
            //    else if (i == 1)
            //    {
            //        chb.Text = "Mayonez";
            //        flwEkstra.Controls.Add(chb);

            //    }
            //    else if(i==2)
            //    {
            //        chb.Text = "Ranch";
            //        flwEkstra.Controls.Add(chb);
            //    }
            //    else
            //    {
            //        chb.Text = "Acı Sos";
            //        flwEkstra.Controls.Add(chb);
            //    }
   
            //}
            
        }
    }
}
