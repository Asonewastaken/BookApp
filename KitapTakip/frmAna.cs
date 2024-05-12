using System.Text.Json.Serialization;
using System.Text.Json;


namespace KitapTakip
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
            if (File.Exists("kitaplar.dat"))
            {
                //Dosyadan string verileri oku
                string metin = File.ReadAllText("kitaplar.dat");

                //String verileri listeye dönüþtür
                List<Kitap> liste = JsonSerializer.Deserialize<List<Kitap>>(metin);

                //Listeyi diziye dönüþtür ve liste kutusuna ekle
                lstKitaplar.Items.AddRange(liste.ToArray());
            }
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {//Hem ekleme hem güncelleme yapar.
            if (lstKitaplar.SelectedIndex < 0)
            {
                //Yeni Kitap
                Kitap yeniKitap = new Kitap();
                yeniKitap.KitapAdi = txtKitapAdi.Text;
                yeniKitap.Fiyat = Convert.ToDouble(numFiyat.Value);
                yeniKitap.RafNo = txtRafNumarasi.Text;
                lstKitaplar.Items.Add(yeniKitap);
            }
            else
            {
                Kitap eskiKitap = (Kitap)lstKitaplar.Items[lstKitaplar.SelectedIndex];
                eskiKitap.KitapAdi = txtKitapAdi.Text;
                eskiKitap.RafNo = txtRafNumarasi.Text;
                eskiKitap.Fiyat = Convert.ToDouble(numFiyat.Value);

                //Liste kutusunun ilgili satýrýný yenilemek için
                lstKitaplar.Items[lstKitaplar.SelectedIndex] = lstKitaplar.Items[lstKitaplar.SelectedIndex];

            }

            //Ýþlem yapýldýktan sonra textbox'larý temizle.
            txtKitapAdi.Text = "";
            txtRafNumarasi.Text = "";
            numFiyat.Value = 0;
            lstKitaplar.SelectedIndex = -1;
            txtKitapAdi.Focus();

        }

        private void lstKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            //Sadece mouse týklandýðýnda çalýþýyor.
        }
        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = lstKitaplar.SelectedIndex;
            if (indeks >= 0)
            {
                Kitap kitap = (Kitap)lstKitaplar.Items[indeks];
                txtKitapAdi.Text = kitap.KitapAdi;
                txtRafNumarasi.Text = kitap.RafNo;
                numFiyat.Value = Convert.ToDecimal(kitap.Fiyat);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Silinecek kitabý getir
            if (lstKitaplar.SelectedIndex >= 0)
            {
                Kitap kitap = (Kitap)lstKitaplar.Items[lstKitaplar.SelectedIndex];

                //Sor bakalým silmek istediðine emin mi?
                DialogResult cevap = MessageBox.Show($"{kitap.KitapAdi} isimli kitabý silmek istediðinize emin misiniz ?",
                    "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //Kullanýcýnýn cevabý evet mi?
                if (cevap == DialogResult.Yes)
                {
                    lstKitaplar.Items.Remove(kitap);//Kitabý listeden çýkar
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Listbox'ýn elemanarýný List<Kitap> türüne dönüþtürdüm
            var liste = lstKitaplar.Items.Cast<Kitap>().ToList();

            string metin = JsonSerializer.Serialize<List<Kitap>>(liste);

            File.WriteAllText("kitaplar.dat", metin);

            MessageBox.Show($"Kitap kaydedildi.", "Baþarýlý", MessageBoxButtons.OK);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmKitapAra aramaFormu = new frmKitapAra();

            aramaFormu.KitapListesiniGonder(lstKitaplar.Items.Cast<Kitap>().ToList());

            DialogResult cevap = aramaFormu.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Aradýðýnýz Kitap Bulundu");
                lstKitaplar.SelectedIndex = aramaFormu.BulunanIndex;
            }
            else
            {
                if (cevap == DialogResult.No)
                {
                    MessageBox.Show("Aradýðýnýz Kitap Bulunamadý");

                }
            }
        }

        private void btnYeniKitap_Click(object sender, EventArgs e)
        {
            //Kutucuklarý temizle.
            txtKitapAdi.Text = "";
            txtRafNumarasi.Text = "";
            numFiyat.Value = 0;
            lstKitaplar.SelectedIndex = -1;
            txtKitapAdi.Focus(); //Temizledikten sonra kitap adýna focusla.
        }

        private void txtKitapAdi_KeyDown(object sender, KeyEventArgs e)
        {
            //Kitap adýný yazdýktan sonra enter'a bastýðýmda sýradaki olan raf numarasý textbox'ýna git.
            if (e.KeyCode == Keys.Enter)
                txtRafNumarasi.Focus();
        }

        private void txtRafNumarasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numFiyat.Focus();
        }

        private void numFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            //Fiyatý girdikten sonra enter'a bastýðýnda girdiðim verileri listbox'a ekle ve güncelle methodunu
            //ve kaydet metodunu tetikle.
            if (e.KeyCode == Keys.Enter)
                btnEkleGuncelle_Click(this,EventArgs.Empty);
                btnKaydet_Click(this,EventArgs.Empty);
        }
    }
}
