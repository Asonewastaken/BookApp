using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapTakip
{
    public partial class frmKitapAra : Form
    {
        List<Kitap> KitapListesi;

        public int BulunanIndex { get; set; }
        public frmKitapAra()
        {
            InitializeComponent();
        }

        public void KitapListesiniGonder(List<Kitap> liste)
        {
            KitapListesi = liste;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Kitap kitap in KitapListesi)
            {
                if (kitap.KitapAdi.ToLower().Contains(txtKitapAdi.Text.ToLower())) //ToLower ile büyük küçük harf duyarlılığını hallettim.
                {
                    BulunanIndex = i; //Bulunan indeksi sakla 
                    DialogResult = DialogResult.OK; // Kitabı Buldum
                    return;
                }
                i++;
            }
            DialogResult = DialogResult.No; // Kitabı bulamadım.
        }

        private void txtKitapAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBul_Click(this, EventArgs.Empty);
        }
    }
}
