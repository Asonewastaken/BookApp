namespace KitapTakip
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtRafNumarasi = new TextBox();
            label3 = new Label();
            numFiyat = new NumericUpDown();
            label2 = new Label();
            txtKitapAdi = new TextBox();
            label1 = new Label();
            lstKitaplar = new ListBox();
            label4 = new Label();
            btnYeniKitap = new Button();
            btnEkleGuncelle = new Button();
            btnSil = new Button();
            btnAra = new Button();
            btnKaydet = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRafNumarasi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numFiyat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKitapAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Bilgileri";
            // 
            // txtRafNumarasi
            // 
            txtRafNumarasi.Location = new Point(115, 73);
            txtRafNumarasi.Name = "txtRafNumarasi";
            txtRafNumarasi.Size = new Size(212, 27);
            txtRafNumarasi.TabIndex = 2;
            txtRafNumarasi.KeyDown += txtRafNumarasi_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 0;
            label3.Text = "Raf Numarası:";
            // 
            // numFiyat
            // 
            numFiyat.Location = new Point(115, 106);
            numFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numFiyat.Name = "numFiyat";
            numFiyat.Size = new Size(212, 27);
            numFiyat.TabIndex = 3;
            numFiyat.KeyDown += numFiyat_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Kitap Fiyatı:";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(115, 40);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(212, 27);
            txtKitapAdi.TabIndex = 1;
            txtKitapAdi.KeyDown += txtKitapAdi_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı:";
            // 
            // lstKitaplar
            // 
            lstKitaplar.FormattingEnabled = true;
            lstKitaplar.ItemHeight = 20;
            lstKitaplar.Location = new Point(554, 60);
            lstKitaplar.Name = "lstKitaplar";
            lstKitaplar.Size = new Size(314, 364);
            lstKitaplar.TabIndex = 0;
            lstKitaplar.MouseClick += lstKitaplar_MouseClick;
            lstKitaplar.SelectedIndexChanged += lstKitaplar_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(554, 37);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 0;
            label4.Text = "Kitap Listesi";
            // 
            // btnYeniKitap
            // 
            btnYeniKitap.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniKitap.Location = new Point(12, 275);
            btnYeniKitap.Name = "btnYeniKitap";
            btnYeniKitap.Size = new Size(121, 29);
            btnYeniKitap.TabIndex = 1;
            btnYeniKitap.Text = "Yeni Kitap";
            btnYeniKitap.UseVisualStyleBackColor = true;
            btnYeniKitap.Click += btnYeniKitap_Click;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkleGuncelle.Location = new Point(139, 275);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(121, 29);
            btnEkleGuncelle.TabIndex = 2;
            btnEkleGuncelle.Text = "Ekle / Güncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = true;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(393, 276);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(121, 29);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnAra
            // 
            btnAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAra.Location = new Point(266, 276);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(121, 28);
            btnAra.TabIndex = 3;
            btnAra.Text = "Kitap Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(12, 395);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(121, 29);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // frmAna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(btnKaydet);
            Controls.Add(btnAra);
            Controls.Add(btnSil);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(btnYeniKitap);
            Controls.Add(label4);
            Controls.Add(lstKitaplar);
            Controls.Add(groupBox1);
            Name = "frmAna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Takip Formu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRafNumarasi;
        private Label label3;
        private NumericUpDown numFiyat;
        private Label label2;
        private TextBox txtKitapAdi;
        private Label label1;
        private ListBox lstKitaplar;
        private Label label4;
        private Button btnYeniKitap;
        private Button btnEkleGuncelle;
        private Button btnSil;
        private Button btnAra;
        private Button btnKaydet;
    }
}
