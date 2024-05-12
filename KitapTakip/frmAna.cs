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

                //String verileri listeye d�n��t�r
                List<Kitap> liste = JsonSerializer.Deserialize<List<Kitap>>(metin);

                //Listeyi diziye d�n��t�r ve liste kutusuna ekle
                lstKitaplar.Items.AddRange(liste.ToArray());
            }
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {//Hem ekleme hem g�ncelleme yapar.
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

                //Liste kutusunun ilgili sat�r�n� yenilemek i�in
                lstKitaplar.Items[lstKitaplar.SelectedIndex] = lstKitaplar.Items[lstKitaplar.SelectedIndex];

            }

            //��lem yap�ld�ktan sonra textbox'lar� temizle.
            txtKitapAdi.Text = "";
            txtRafNumarasi.Text = "";
            numFiyat.Value = 0;
            lstKitaplar.SelectedIndex = -1;
            txtKitapAdi.Focus();

        }

        private void lstKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            //Sadece mouse t�kland���nda �al���yor.
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
            //Silinecek kitab� getir
            if (lstKitaplar.SelectedIndex >= 0)
            {
                Kitap kitap = (Kitap)lstKitaplar.Items[lstKitaplar.SelectedIndex];

                //Sor bakal�m silmek istedi�ine emin mi?
                DialogResult cevap = MessageBox.Show($"{kitap.KitapAdi} isimli kitab� silmek istedi�inize emin misiniz ?",
                    "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //Kullan�c�n�n cevab� evet mi?
                if (cevap == DialogResult.Yes)
                {
                    lstKitaplar.Items.Remove(kitap);//Kitab� listeden ��kar
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Listbox'�n elemanar�n� List<Kitap> t�r�ne d�n��t�rd�m
            var liste = lstKitaplar.Items.Cast<Kitap>().ToList();

            string metin = JsonSerializer.Serialize<List<Kitap>>(liste);

            File.WriteAllText("kitaplar.dat", metin);

            MessageBox.Show($"Kitap kaydedildi.", "Ba�ar�l�", MessageBoxButtons.OK);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmKitapAra aramaFormu = new frmKitapAra();

            aramaFormu.KitapListesiniGonder(lstKitaplar.Items.Cast<Kitap>().ToList());

            DialogResult cevap = aramaFormu.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Arad���n�z Kitap Bulundu");
                lstKitaplar.SelectedIndex = aramaFormu.BulunanIndex;
            }
            else
            {
                if (cevap == DialogResult.No)
                {
                    MessageBox.Show("Arad���n�z Kitap Bulunamad�");

                }
            }
        }

        private void btnYeniKitap_Click(object sender, EventArgs e)
        {
            //Kutucuklar� temizle.
            txtKitapAdi.Text = "";
            txtRafNumarasi.Text = "";
            numFiyat.Value = 0;
            lstKitaplar.SelectedIndex = -1;
            txtKitapAdi.Focus(); //Temizledikten sonra kitap ad�na focusla.
        }

        private void txtKitapAdi_KeyDown(object sender, KeyEventArgs e)
        {
            //Kitap ad�n� yazd�ktan sonra enter'a bast���mda s�radaki olan raf numaras� textbox'�na git.
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
            //Fiyat� girdikten sonra enter'a bast���nda girdi�im verileri listbox'a ekle ve g�ncelle methodunu
            //ve kaydet metodunu tetikle.
            if (e.KeyCode == Keys.Enter)
                btnEkleGuncelle_Click(this,EventArgs.Empty);
                btnKaydet_Click(this,EventArgs.Empty);
        }
    }
}
