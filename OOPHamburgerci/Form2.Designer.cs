namespace OOPHamburgerci
{
    partial class Form2
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
            this.grpMeenuEkle = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMunuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMeenuEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMeenuEkle
            // 
            this.grpMeenuEkle.Controls.Add(this.btnMenuEkle);
            this.grpMeenuEkle.Controls.Add(this.nmrMenuFiyati);
            this.grpMeenuEkle.Controls.Add(this.txtMunuAdi);
            this.grpMeenuEkle.Controls.Add(this.label2);
            this.grpMeenuEkle.Controls.Add(this.label1);
            this.grpMeenuEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMeenuEkle.Location = new System.Drawing.Point(0, 0);
            this.grpMeenuEkle.Name = "grpMeenuEkle";
            this.grpMeenuEkle.Size = new System.Drawing.Size(361, 213);
            this.grpMeenuEkle.TabIndex = 0;
            this.grpMeenuEkle.TabStop = false;
            this.grpMeenuEkle.Text = "menü ekleme paneli";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Location = new System.Drawing.Point(117, 123);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(224, 57);
            this.btnMenuEkle.TabIndex = 4;
            this.btnMenuEkle.Text = "menü ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Location = new System.Drawing.Point(131, 74);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(210, 30);
            this.nmrMenuFiyati.TabIndex = 3;
            // 
            // txtMunuAdi
            // 
            this.txtMunuAdi.Location = new System.Drawing.Point(131, 38);
            this.txtMunuAdi.Name = "txtMunuAdi";
            this.txtMunuAdi.Size = new System.Drawing.Size(210, 30);
            this.txtMunuAdi.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "menü adı:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 222);
            this.Controls.Add(this.grpMeenuEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grpMeenuEkle.ResumeLayout(false);
            this.grpMeenuEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMeenuEkle;
        private Button btnMenuEkle;
        private NumericUpDown nmrMenuFiyati;
        private TextBox txtMunuAdi;
        private Label label2;
        private Label label1;
    }
}