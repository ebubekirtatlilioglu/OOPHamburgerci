namespace OOPHamburgerci
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTumSiparisler = new System.Windows.Forms.ListBox();
            this.ciro = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTopSipSay = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEksMalGel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSatUrSay = new System.Windows.Forms.Label();
            this.ciro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "tüm siparişler";
            // 
            // lblTumSiparisler
            // 
            this.lblTumSiparisler.FormattingEnabled = true;
            this.lblTumSiparisler.HorizontalScrollbar = true;
            this.lblTumSiparisler.ItemHeight = 20;
            this.lblTumSiparisler.Location = new System.Drawing.Point(12, 33);
            this.lblTumSiparisler.Name = "lblTumSiparisler";
            this.lblTumSiparisler.Size = new System.Drawing.Size(226, 364);
            this.lblTumSiparisler.TabIndex = 1;
            // 
            // ciro
            // 
            this.ciro.Controls.Add(this.lblCiro);
            this.ciro.Location = new System.Drawing.Point(259, 33);
            this.ciro.Name = "ciro";
            this.ciro.Size = new System.Drawing.Size(250, 59);
            this.ciro.TabIndex = 2;
            this.ciro.TabStop = false;
            this.ciro.Text = "ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(3, 23);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(36, 20);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTopSipSay);
            this.groupBox2.Location = new System.Drawing.Point(259, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "toplam sipariş sayısı";
            // 
            // lblTopSipSay
            // 
            this.lblTopSipSay.AutoSize = true;
            this.lblTopSipSay.Location = new System.Drawing.Point(3, 23);
            this.lblTopSipSay.Name = "lblTopSipSay";
            this.lblTopSipSay.Size = new System.Drawing.Size(36, 20);
            this.lblTopSipSay.TabIndex = 0;
            this.lblTopSipSay.Text = "0,00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEksMalGel);
            this.groupBox3.Location = new System.Drawing.Point(259, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 79);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ekstra malzeme geliri";
            // 
            // lblEksMalGel
            // 
            this.lblEksMalGel.AutoSize = true;
            this.lblEksMalGel.Location = new System.Drawing.Point(3, 23);
            this.lblEksMalGel.Name = "lblEksMalGel";
            this.lblEksMalGel.Size = new System.Drawing.Size(36, 20);
            this.lblEksMalGel.TabIndex = 0;
            this.lblEksMalGel.Text = "0,00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatUrSay);
            this.groupBox4.Location = new System.Drawing.Point(259, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 62);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "satılan ürün sayısı";
            // 
            // lblSatUrSay
            // 
            this.lblSatUrSay.AutoSize = true;
            this.lblSatUrSay.Location = new System.Drawing.Point(3, 23);
            this.lblSatUrSay.Name = "lblSatUrSay";
            this.lblSatUrSay.Size = new System.Drawing.Size(36, 20);
            this.lblSatUrSay.TabIndex = 0;
            this.lblSatUrSay.Text = "0,00";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ciro);
            this.Controls.Add(this.lblTumSiparisler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ciro.ResumeLayout(false);
            this.ciro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lblTumSiparisler;
        private GroupBox ciro;
        private Label lblCiro;
        private GroupBox groupBox2;
        private Label lblTopSipSay;
        private GroupBox groupBox3;
        private Label lblEksMalGel;
        private GroupBox groupBox4;
        private Label lblSatUrSay;
    }
}