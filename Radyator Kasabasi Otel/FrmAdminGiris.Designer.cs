namespace Radyator_Kasabasi_Otel
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            label1 = new Label();
            label2 = new Label();
            TxtKullaniciAdi = new TextBox();
            TxtSifre = new TextBox();
            BtnGirisYap = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 20);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 87);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.BackColor = Color.FromArgb(255, 224, 192);
            TxtKullaniciAdi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtKullaniciAdi.Location = new Point(285, 18);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(176, 30);
            TxtKullaniciAdi.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = Color.FromArgb(255, 224, 192);
            TxtSifre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSifre.Location = new Point(285, 87);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(176, 30);
            TxtSifre.TabIndex = 3;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.FromArgb(224, 224, 224);
            BtnGirisYap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGirisYap.Location = new Point(318, 141);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(117, 37);
            BtnGirisYap.TabIndex = 4;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(112, 492);
            label3.Name = "label3";
            label3.Size = new Size(624, 46);
            label3.TabIndex = 5;
            label3.Text = "Radyatör Kasabası Oteline Hoş Geldiniz";
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(757, 561);
            Controls.Add(label3);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Admin Giriş";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtKullaniciAdi;
        private TextBox TxtSifre;
        private Button BtnGirisYap;
        private Label label3;
    }
}