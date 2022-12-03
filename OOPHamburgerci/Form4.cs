using OOPHamburgerci.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPHamburgerci
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzmeGeliri=0;
            int satisAdedi = 0;
            foreach (Siparis siparis  in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (EkstraMalzeme ekstra in siparis.EkstraMalzemeleri)
                {
                    ekstraMalzmeGeliri += ekstra.EkstraFiyat;
                }
                satisAdedi += siparis.Adedi;
                lblTumSiparisler.Items.Add(siparis);
            }
            lblCiro.Text = ciro.ToString("C2");
            lblEksMalGel.Text = ekstraMalzmeGeliri.ToString("C2");
            lblTopSipSay.Text = lblTumSiparisler.Items.Count.ToString();
            lblSatUrSay.Text = satisAdedi.ToString();
        }
    }
}
