namespace KitapTakip
{
    partial class frmKitapAra
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
            label1 = new Label();
            txtKitapAdi = new TextBox();
            btnBul = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(303, 28);
            label1.TabIndex = 0;
            label1.Text = "Aradığınız Kitabın İsmini Yazınız:";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtKitapAdi.Location = new Point(321, 71);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(213, 34);
            txtKitapAdi.TabIndex = 1;
            txtKitapAdi.KeyDown += txtKitapAdi_KeyDown;
            // 
            // btnBul
            // 
            btnBul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBul.Location = new Point(230, 136);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(103, 39);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // frmKitapAra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 214);
            Controls.Add(btnBul);
            Controls.Add(txtKitapAdi);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmKitapAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Ara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKitapAdi;
        private Button btnBul;
    }
}