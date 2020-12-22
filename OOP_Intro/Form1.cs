using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.bagcikliMi = true;
            ayakkabi.fiyat = 500;
            ayakkabi.malzeme = "suni deri";
            ayakkabi.marka = "Nixe";
            ayakkabi.renk = "siyah";
            ayakkabi.tip = "spor";

            //MessageBox.Show(ayakkabi.marka);

            string format = string.Format("Marka:{0} Malzeme:{1} Fiyat:{2}", ayakkabi.marka, ayakkabi.malzeme, ayakkabi.fiyat);
            listBox1.Items.Add(format);
        }
    }
}
