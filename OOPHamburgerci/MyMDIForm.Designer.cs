namespace OOPHamburgerci
{
    partial class MyMDIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsmHamburgerMenu = new System.Windows.Forms.MenuStrip();
            this.tsmSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSipariOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHamburgerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmHamburgerMenu
            // 
            this.tsmHamburgerMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsmHamburgerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYonetimi,
            this.tsmUrunYonetimi});
            this.tsmHamburgerMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmHamburgerMenu.Name = "tsmHamburgerMenu";
            this.tsmHamburgerMenu.Size = new System.Drawing.Size(800, 28);
            this.tsmHamburgerMenu.TabIndex = 0;
            this.tsmHamburgerMenu.Text = "menuStrip1";
            // 
            // tsmSiparisYonetimi
            // 
            this.tsmSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSipariOlustur,
            this.tsmSiparisBilgileri});
            this.tsmSiparisYonetimi.Name = "tsmSiparisYonetimi";
            this.tsmSiparisYonetimi.Size = new System.Drawing.Size(127, 24);
            this.tsmSiparisYonetimi.Text = "sipariş yönetimi";
            // 
            // tsmSipariOlustur
            // 
            this.tsmSipariOlustur.Name = "tsmSipariOlustur";
            this.tsmSipariOlustur.Size = new System.Drawing.Size(189, 26);
            this.tsmSipariOlustur.Text = "sipariş oluştur";
            this.tsmSipariOlustur.Click += new System.EventHandler(this.tsmSipariOlustur_Click);
            // 
            // tsmSiparisBilgileri
            // 
            this.tsmSiparisBilgileri.Name = "tsmSiparisBilgileri";
            this.tsmSiparisBilgileri.Size = new System.Drawing.Size(189, 26);
            this.tsmSiparisBilgileri.Text = "sipariş bilgileri";
            this.tsmSiparisBilgileri.Click += new System.EventHandler(this.tsmSiparisBilgileri_Click);
            // 
            // tsmUrunYonetimi
            // 
            this.tsmUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkle,
            this.tsmEkstraMalzemeEkle});
            this.tsmUrunYonetimi.Name = "tsmUrunYonetimi";
            this.tsmUrunYonetimi.Size = new System.Drawing.Size(106, 24);
            this.tsmUrunYonetimi.Text = "ürün yöntimi";
            // 
            // tsmMenuEkle
            // 
            this.tsmMenuEkle.Name = "tsmMenuEkle";
            this.tsmMenuEkle.Size = new System.Drawing.Size(219, 26);
            this.tsmMenuEkle.Text = "menü ekle";
            this.tsmMenuEkle.Click += new System.EventHandler(this.tsmMenuEkle_Click);
            // 
            // tsmEkstraMalzemeEkle
            // 
            this.tsmEkstraMalzemeEkle.Name = "tsmEkstraMalzemeEkle";
            this.tsmEkstraMalzemeEkle.Size = new System.Drawing.Size(219, 26);
            this.tsmEkstraMalzemeEkle.Text = "ekstra malzme ekle";
            this.tsmEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmEkstraMalzemeEkle_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsmHamburgerMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.tsmHamburgerMenu;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.tsmHamburgerMenu.ResumeLayout(false);
            this.tsmHamburgerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip tsmHamburgerMenu;
        private ToolStripMenuItem tsmSiparisYonetimi;
        private ToolStripMenuItem tsmSipariOlustur;
        private ToolStripMenuItem tsmSiparisBilgileri;
        private ToolStripMenuItem tsmUrunYonetimi;
        private ToolStripMenuItem tsmMenuEkle;
        private ToolStripMenuItem tsmEkstraMalzemeEkle;
    }
}