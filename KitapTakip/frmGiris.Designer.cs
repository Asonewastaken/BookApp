namespace KitapTakip
{
    partial class frmGiris
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
            lblKullaniciAdi = new Label();
            lblParola = new Label();
            txt_KullaniciAdi = new TextBox();
            txt_Parola = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAdi.Location = new Point(110, 77);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(98, 20);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblParola.Location = new Point(152, 110);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(57, 20);
            lblParola.TabIndex = 0;
            lblParola.Text = "Parola:";
            // 
            // txt_KullaniciAdi
            // 
            txt_KullaniciAdi.Location = new Point(211, 74);
            txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            txt_KullaniciAdi.Size = new Size(149, 27);
            txt_KullaniciAdi.TabIndex = 1;
            txt_KullaniciAdi.KeyDown += txt_KullaniciAdi_KeyDown;
            // 
            // txt_Parola
            // 
            txt_Parola.Location = new Point(211, 107);
            txt_Parola.Name = "txt_Parola";
            txt_Parola.PasswordChar = '●';
            txt_Parola.Size = new Size(149, 27);
            txt_Parola.TabIndex = 2;
            txt_Parola.KeyDown += txt_Parola_KeyDown;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(266, 150);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(94, 29);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(496, 253);
            Controls.Add(btnGirisYap);
            Controls.Add(txt_Parola);
            Controls.Add(txt_KullaniciAdi);
            Controls.Add(lblParola);
            Controls.Add(lblKullaniciAdi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGiris";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblParola;
        private TextBox txt_KullaniciAdi;
        private TextBox txt_Parola;
        private Button btnGirisYap;
    }
}