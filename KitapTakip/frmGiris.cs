using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace KitapTakip
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txt_KullaniciAdi.Text == "admin" && txt_Parola.Text == "1234")
            {
               DialogResult = DialogResult.OK;
            }
            else if (txt_KullaniciAdi.Text != "admin" && txt_Parola.Text == "1234")
            {
                MessageBox.Show("Kullanıcı Adı Hatalı");
            }
            else if (txt_Parola.Text != "1234" && txt_KullaniciAdi.Text == "admin")
            {
                MessageBox.Show("Şifre Hatalı");

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Parola Hatalı");
            }
        }

        private void txt_KullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_Parola.Focus();
        }

        private void txt_Parola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap_Click(this,EventArgs.Empty);
        }
    }
}
