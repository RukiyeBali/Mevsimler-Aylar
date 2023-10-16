using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mevsim_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbMevsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim=cmbMevsimler.SelectedIndex;

            if (secim==0)
            {
                lstAylar.Items.Clear();
                lstAylar.Items.Add("Mart");
                lstAylar.Items.Add("Nisan");
                lstAylar.Items.Add("Mayıs");
            }
            else if(secim==1)
            {
                lstAylar.Items.Clear();
                lstAylar.Items.Add("Haziran");
                lstAylar.Items.Add("Temmuz");
                lstAylar.Items.Add("Ağustos");
            }
            else if (secim == 2)
            {
                lstAylar.Items.Clear();
                lstAylar.Items.Add("Eylül");
                lstAylar.Items.Add("Ekim");
                lstAylar.Items.Add("Kasım");
            }
            else
            {
                lstAylar.Items.Clear ();
                lstAylar.Items.Add("Aralık");
                lstAylar.Items.Add("Ocak");
                lstAylar.Items.Add("Şubat");
            }
        }

        private void cmbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim=cmbAylar.SelectedIndex;

            if(secim==2 || secim==3 || secim == 4) //Mart Nisan Mayıs
            {
                lblMevsim.Text = "İlkbahar";
            }
            else if(secim==5 || secim==6|| secim == 7) //Haziran Temmuz Ağustos
            {
                lblMevsim.Text = "Yaz";
            }
            else if(secim==8 || secim==9|| secim == 10) //Eylül Ekim Kasım
            {
                lblMevsim.Text = "Sonbahar";
            }
            else  //Diğer geri kalan durumlar
            {
                lblMevsim.Text = "Kış";
            }


        }
    }
}
