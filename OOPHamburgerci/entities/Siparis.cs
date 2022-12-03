using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerci.entities
{
    public class Siparis
    {
        public Menu SeciliMenusu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeleri { get; set; }
        public BoyutEnum Boyut { get; set; }
        public int Adedi { get; set; }
        public decimal ToplamTutar { get; set; }
        public void Hesapla()//bir menu siparişi hesabı
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.MenuFiyati;
            switch (Boyut)
            {
                
                case BoyutEnum.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case BoyutEnum.Buyuk:
                    ToplamTutar += ToplamTutar * 0.20M;
                    break;
               
            }
            ToplamTutar *= Adedi;
            foreach (EkstraMalzeme item in EkstraMalzemeleri)
            {
                ToplamTutar += item.EkstraFiyat;
            }
            
        }
        public override string ToString()//listboxa yazdıracağımız stringin formatını beelirliyoruz
        {
            if (EkstraMalzemeleri.Count<1)
            {
                return String.Format("{0} Menu x {1} adet, {2} boy, toplam: {3}", SeciliMenusu.MenuAdi, Adedi, Boyut.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (EkstraMalzeme item in EkstraMalzemeleri)
                {
                    ekstraMalzemeler+=item.EkstraAdı+",";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');//en sondaki virgülü temizledik
                return String.Format("{0} Menu x {1} adet, {2} boy,( {3}), toplam: {4}", SeciliMenusu.MenuAdi, Adedi, Boyut.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
