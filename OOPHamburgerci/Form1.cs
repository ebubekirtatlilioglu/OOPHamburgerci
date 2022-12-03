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
            new Menu{MenuAdi="k�fte burger",MenuFiyati=52.25M},
        };
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAd�="ket�ap",EkstraFiyat=1.00M},
            new EkstraMalzeme{EkstraAd�="mayonez",EkstraFiyat=1.00M},
            new EkstraMalzeme{EkstraAd�="ranch sos",EkstraFiyat=1.50M},
            new EkstraMalzeme{EkstraAd�="barbek� sos",EkstraFiyat=1.50M},

        };


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenulr.Items.Add(item);//tostring() metodu ovrrid edildi�i i�in ... menu �eklinde ekleneck
            }
            foreach (EkstraMalzeme item in ekstralar)
            {
                flpEktraMlazemler.Controls.Add(new CheckBox() { Text = item.EkstraAd�, Tag = item,Width=Convert.ToInt32(flpEktraMlazemler.Width*0.5)});
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item);//e�er form a��ld���nda tamamlanmam�� (mevcut) sipari� varsa listboxa ekle
            }
            rdoKucuk.Checked = true;//a��l��ta k���k s�ili gelsin
            cmbMenulr.SelectedIndex = 0;//a��l��ta ilk elman se�ili gelsin
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
            return toplaTutar;//herhangi bir yerde metodu �a��rd���m�zda geriye de�er d�nd�rs�n diye.d�n�� tipi decimal ayarland�
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
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag);//flp nin kontrollerinden her birinin tag propeertysinde tutulan ekstramalzeme nesnesinin bir kopyas�n� ald�k ve sipari� nesnsinde olu�turdu�umuz ekstramalzemeller listesine ekledik.
                }
            }
            yeniSiparis.Adedi = Convert.ToInt32(nmrAdt.Value);
            yeniSiparis.Hesapla();//eklenen yeni sipari�in tutar�n� ilgili classtaki metot ile hessapl�yoruz
            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            //tumSiparisler.Add(yeniSiparis);
            TutarHesapla();//ilgili labeelde toplam tutar yazs�n diye hesaplad�k
            Metodlar.Temizle(this.Controls);
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("toplam sipari� tutar�:" + TutarHesapla().ToString("C2") + "\n sat�n alma i�lemini onayl�yor musununz?", "sipari� bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                tumSiparisler.AddRange(mevcutSiparisler);//sipari� tamamlan�nca mvcut sipari�lri t�m sipari�lere ekliyoruz
                lbxSiparisler.Items.Clear();//listbozu tmizle
                mevcutSiparisler.Clear();//ge�ici olarak tuttu�umuz bu listyi de temizliyoruz.
                TutarHesapla();//label deki tutar d�erini yeniden  hesapla. tutar tl 0.00 olacakt�r. ��nk� listboxta hsaplanacak bir de�er kalmad��� i�in
                MessageBox.Show("sipari� tamamland�");

            }
            else
            {
                MessageBox.Show("i�lem iptal edildi.");
            }
        }
    }
}