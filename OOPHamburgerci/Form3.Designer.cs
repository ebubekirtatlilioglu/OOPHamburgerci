namespace OOPHamburgerci
{
    partial class Form3
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
            this.grpExtraMalzemeEkl = new System.Windows.Forms.GroupBox();
            this.btnExtraMalzemeEkle = new System.Windows.Forms.Button();
            this.nmrEkstFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtEkstAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpExtraMalzemeEkl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpExtraMalzemeEkl
            // 
            this.grpExtraMalzemeEkl.Controls.Add(this.btnExtraMalzemeEkle);
            this.grpExtraMalzemeEkl.Controls.Add(this.nmrEkstFiyati);
            this.grpExtraMalzemeEkl.Controls.Add(this.txtEkstAdi);
            this.grpExtraMalzemeEkl.Controls.Add(this.label2);
            this.grpExtraMalzemeEkl.Controls.Add(this.label1);
            this.grpExtraMalzemeEkl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpExtraMalzemeEkl.Location = new System.Drawing.Point(12, 12);
            this.grpExtraMalzemeEkl.Name = "grpExtraMalzemeEkl";
            this.grpExtraMalzemeEkl.Size = new System.Drawing.Size(366, 213);
            this.grpExtraMalzemeEkl.TabIndex = 1;
            this.grpExtraMalzemeEkl.TabStop = false;
            this.grpExtraMalzemeEkl.Text = "extra malzme ekleme paaneli";
            // 
            // btnExtraMalzemeEkle
            // 
            this.btnExtraMalzemeEkle.Location = new System.Drawing.Point(142, 121);
            this.btnExtraMalzemeEkle.Name = "btnExtraMalzemeEkle";
            this.btnExtraMalzemeEkle.Size = new System.Drawing.Size(211, 54);
            this.btnExtraMalzemeEkle.TabIndex = 4;
            this.btnExtraMalzemeEkle.Text = "extra malzeme ekle";
            this.btnExtraMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnExtraMalzemeEkle.Click += new System.EventHandler(this.btnExtraMalzemeEkle_Click);
            // 
            // nmrEkstFiyati
            // 
            this.nmrEkstFiyati.Location = new System.Drawing.Point(172, 74);
            this.nmrEkstFiyati.Name = "nmrEkstFiyati";
            this.nmrEkstFiyati.Size = new System.Drawing.Size(181, 30);
            this.nmrEkstFiyati.TabIndex = 3;
            // 
            // txtEkstAdi
            // 
            this.txtEkstAdi.Location = new System.Drawing.Point(172, 33);
            this.txtEkstAdi.Name = "txtEkstAdi";
            this.txtEkstAdi.Size = new System.Drawing.Size(181, 30);
            this.txtEkstAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "extra malzme adı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 240);
            this.Controls.Add(this.grpExtraMalzemeEkl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpExtraMalzemeEkl.ResumeLayout(false);
            this.grpExtraMalzemeEkl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpExtraMalzemeEkl;
        private Button btnExtraMalzemeEkle;
        private NumericUpDown nmrEkstFiyati;
        private TextBox txtEkstAdi;
        private Label label2;
        private Label label1;
    }
}