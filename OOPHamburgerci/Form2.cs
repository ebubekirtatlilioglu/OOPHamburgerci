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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            //Menu yeniMenu=new Menu();
            //yeniMenu.MenuAdi = txtMunuAdi.Text;
            //yeniMenu.MenuFiyati = nmrMenuFiyati.Value;
            //Form1.menuler.Add(yeniMenu);

            //üsttekiyle aynı anlama geliyor.
            Form1.menuler.Add(new Menu { MenuAdi = txtMunuAdi.Text, MenuFiyati = nmrMenuFiyati.Value });

            //todo: eklemeden sonra teemizle() metodu çalışsın, ekranı temizlesin
            Metodlar.Temizle(this.Controls);

            MessageBox.Show("menü başarıyla eklendi");
        }
    }
}
