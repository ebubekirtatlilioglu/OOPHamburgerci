using OOPHamburgerci.entities;

namespace OOPHamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler=new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi="big king",MenuFiyati=50.75M},
            new Menu{MenuAdi="whooper jr.",MenuFiyati=45.50M},
            new Menu{MenuAdi="king chicken",MenuFiyati=37.75M},
            new Menu{MenuAdi="chickeen royale",MenuFiyati=42.00M},
            new Menu{MenuAdi="köfte burger",MenuFiyati=52.25M},
        };
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAdý="ketçap",EkstraFiyat=1.00M},
            new EkstraMalzeme{EkstraAdý="mayonez",EkstraFiyat=1.00M},
            new EkstraMalzeme{EkstraAdý="ranch sos",EkstraFiyat=1.50M},
            new EkstraMalzeme{EkstraAdý="barbekü sos",EkstraFiyat=1.50M},

        };


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenulr.Items.Add(item);//tostring() metodu ovrrid edildiði için ... menu þeklinde ekleneck
            }
            foreach (EkstraMalzeme item in ekstralar)
            {
                flpEktraMlazemler.Controls.Add(new CheckBox() { Text = item.EkstraAdý, Tag = item,Width=Convert.ToInt32(flpEktraMlazemler.Width*0.5)});
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item);//eðer form açýldýðýnda tamamlanmamýþ (mevcut) sipariþ varsa listboxa ekle
            }
            rdoKucuk.Checked = true;//açýlýþta küçük sçili gelsin
            cmbMenulr.SelectedIndex = 0;//açýlýþta ilk elman seçili gelsin
            TutarHesapla();
        }

        private decimal TutarHesapla()
        {
            decimal toplaTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplaTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplaTutar.ToString("C2");
            return toplaTutar;//herhangi bir yerde metodu çaðýrdýðýmýzda geriye deðer döndürsün diye.dönüþ tipi decimal ayarlandý
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu = (Menu)cmbMenulr.SelectedItem;
            if (rdoKucuk.Checked)//true ise
            {
                yeniSiparis.Boyut = BoyutEnum.Kucuk;
            }
            else if (rdoOrta.Checked)
            {
                yeniSiparis.Boyut = BoyutEnum.Orta;
            }
            else
            {
                yeniSiparis.Boyut = BoyutEnum.Buyuk;
            }
            yeniSiparis.EkstraMalzemeleri = new List<EkstraMalzeme>();
            foreach (CheckBox kontrol in flpEktraMlazemler.Controls)
            {
                if (kontrol.Checked)
                {
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag);//flp nin kontrollerinden her birinin tag propeertysinde tutulan ekstramalzeme nesnesinin bir kopyasýný aldýk ve sipariþ nesnsinde oluþturduðumuz ekstramalzemeller listesine ekledik.
                }
            }
            yeniSiparis.Adedi = Convert.ToInt32(nmrAdt.Value);
            yeniSiparis.Hesapla();//eklenen yeni sipariþin tutarýný ilgili classtaki metot ile hessaplýyoruz
            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            //tumSiparisler.Add(yeniSiparis);
            TutarHesapla();//ilgili labeelde toplam tutar yazsýn diye hesapladýk
            Metodlar.Temizle(this.Controls);
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("toplam sipariþ tutarý:" + TutarHesapla().ToString("C2") + "\n satýn alma iþlemini onaylýyor musununz?", "sipariþ bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                tumSiparisler.AddRange(mevcutSiparisler);//sipariþ tamamlanýnca mvcut sipariþlri tüm sipariþlere ekliyoruz
                lbxSiparisler.Items.Clear();//listbozu tmizle
                mevcutSiparisler.Clear();//geçici olarak tuttuðumuz bu listyi de temizliyoruz.
                TutarHesapla();//label deki tutar dðerini yeniden  hesapla. tutar tl 0.00 olacaktýr. çünkü listboxta hsaplanacak bir deðer kalmadýðý için
                MessageBox.Show("sipariþ tamamlandý");

            }
            else
            {
                MessageBox.Show("iþlem iptal edildi.");
            }
        }
    }
}