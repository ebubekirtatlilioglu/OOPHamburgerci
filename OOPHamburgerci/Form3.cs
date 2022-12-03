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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExtraMalzemeEkle_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new EkstraMalzeme { EkstraAdı = txtEkstAdi.Text, EkstraFiyat = nmrEkstFiyati.Value });
            
            Metodlar.Temizle(this.Controls);

            MessageBox.Show("ekstra malzeme başarıyla eklendi");
        }
    
    }
}
