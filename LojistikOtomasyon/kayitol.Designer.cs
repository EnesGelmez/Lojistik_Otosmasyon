namespace LojistikOtomasyon
{
    partial class kayitol
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_kayit_id = new System.Windows.Forms.TextBox();
            this.txt_kayit_ad = new System.Windows.Forms.TextBox();
            this.txt_kayit_soyad = new System.Windows.Forms.TextBox();
            this.txt_kayit_mail = new System.Windows.Forms.TextBox();
            this.txt_kayit_telefon = new System.Windows.Forms.TextBox();
            this.txt_kayit_sifre = new System.Windows.Forms.TextBox();
            this.btn_kayıt_geri = new System.Windows.Forms.Button();
            this.btn_kayıt_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_kayit_unvan = new System.Windows.Forms.ComboBox();
            this.chk_sifrekontrol = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LojistikOtomasyon.Resource1.son00000000;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_kayit_id
            // 
            this.txt_kayit_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_kayit_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kayit_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayit_id.Location = new System.Drawing.Point(103, 93);
            this.txt_kayit_id.Name = "txt_kayit_id";
            this.txt_kayit_id.Size = new System.Drawing.Size(162, 22);
            this.txt_kayit_id.TabIndex = 1;
            this.txt_kayit_id.Text = "Personel ID";
            this.txt_kayit_id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_kayıt_id_MouseClick);
            this.txt_kayit_id.CursorChanged += new System.EventHandler(this.txt_kayıt_id_CursorChanged);
            // 
            // txt_kayit_ad
            // 
            this.txt_kayit_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_kayit_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kayit_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayit_ad.Location = new System.Drawing.Point(103, 132);
            this.txt_kayit_ad.Name = "txt_kayit_ad";
            this.txt_kayit_ad.Size = new System.Drawing.Size(162, 22);
            this.txt_kayit_ad.TabIndex = 1;
            this.txt_kayit_ad.Text = "Ad";
            this.txt_kayit_ad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_kayıt_ad_MouseClick);
            // 
            // txt_kayit_soyad
            // 
            this.txt_kayit_soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_kayit_soyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kayit_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayit_soyad.Location = new System.Drawing.Point(103, 171);
            this.txt_kayit_soyad.Name = "txt_kayit_soyad";
            this.txt_kayit_soyad.Size = new System.Drawing.Size(162, 22);
            this.txt_kayit_soyad.TabIndex = 1;
            this.txt_kayit_soyad.Text = "Soyad";
            this.txt_kayit_soyad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_kayıt_soyad_MouseClick);
            // 
            // txt_kayit_mail
            // 
            this.txt_kayit_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_kayit_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kayit_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayit_mail.Location = new System.Drawing.Point(103, 249);
            this.txt_kayit_mail.Name = "txt_kayit_mail";
            this.txt_kayit_mail.Size = new System.Drawing.Size(162, 22);
            this.txt_kayit_mail.TabIndex = 1;
            this.txt_kayit_mail.Text = "E-Posta";
            this.txt_kayit_mail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_kayıt_mail_MouseClick);
            // 
            // txt_kayit_telefon
            // 
            this.txt_kayit_telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_kayit_telefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kayit_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayit_telefon.Location = new System.Drawing.Point(103, 288);
            this.txt_kayit_telefon.Name = "txt_kayit_telefon";
            this.txt_kayit_telefon.Size = new System.Drawing.Size(162, 22);
            this.txt_kayit_telefon.TabIndex = 1;
            this.txt_kayit_telefon.Text = "Telefon";
            this.txt_kayit_telefon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_kayıt_telefon_MouseClick);
            // 
            // txt_kayit_sifre
            // 
            this.txt_kayit_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_kayit_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kayit_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayit_sifre.Location = new System.Drawing.Point(103, 327);
            this.txt_kayit_sifre.Name = "txt_kayit_sifre";
            this.txt_kayit_sifre.Size = new System.Drawing.Size(162, 22);
            this.txt_kayit_sifre.TabIndex = 1;
            this.txt_kayit_sifre.Text = "Şifre";
            this.txt_kayit_sifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_kayıt_sifre_MouseClick);
            // 
            // btn_kayıt_geri
            // 
            this.btn_kayıt_geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.btn_kayıt_geri.FlatAppearance.BorderSize = 0;
            this.btn_kayıt_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayıt_geri.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt_geri.ForeColor = System.Drawing.Color.White;
            this.btn_kayıt_geri.Location = new System.Drawing.Point(12, 377);
            this.btn_kayıt_geri.Name = "btn_kayıt_geri";
            this.btn_kayıt_geri.Size = new System.Drawing.Size(115, 43);
            this.btn_kayıt_geri.TabIndex = 2;
            this.btn_kayıt_geri.Text = "GERİ";
            this.btn_kayıt_geri.UseVisualStyleBackColor = false;
            // 
            // btn_kayıt_kaydet
            // 
            this.btn_kayıt_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.btn_kayıt_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kayıt_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayıt_kaydet.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kayıt_kaydet.Location = new System.Drawing.Point(138, 377);
            this.btn_kayıt_kaydet.Name = "btn_kayıt_kaydet";
            this.btn_kayıt_kaydet.Size = new System.Drawing.Size(115, 43);
            this.btn_kayıt_kaydet.TabIndex = 2;
            this.btn_kayıt_kaydet.Text = "KAYDET";
            this.btn_kayıt_kaydet.UseVisualStyleBackColor = false;
            this.btn_kayıt_kaydet.Click += new System.EventHandler(this.btn_kayıt_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "EG Lojistik";
            // 
            // cmb_kayit_unvan
            // 
            this.cmb_kayit_unvan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.cmb_kayit_unvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kayit_unvan.FormattingEnabled = true;
            this.cmb_kayit_unvan.Items.AddRange(new object[] {
            "Müdür",
            "Soför",
            "Temizlik Görevlisi",
            "Depocu"});
            this.cmb_kayit_unvan.Location = new System.Drawing.Point(97, 206);
            this.cmb_kayit_unvan.Name = "cmb_kayit_unvan";
            this.cmb_kayit_unvan.Size = new System.Drawing.Size(167, 32);
            this.cmb_kayit_unvan.TabIndex = 4;
            // 
            // chk_sifrekontrol
            // 
            this.chk_sifrekontrol.AutoSize = true;
            this.chk_sifrekontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.chk_sifrekontrol.Location = new System.Drawing.Point(249, 333);
            this.chk_sifrekontrol.Name = "chk_sifrekontrol";
            this.chk_sifrekontrol.Size = new System.Drawing.Size(15, 14);
            this.chk_sifrekontrol.TabIndex = 11;
            this.chk_sifrekontrol.UseVisualStyleBackColor = false;
            this.chk_sifrekontrol.CheckedChanged += new System.EventHandler(this.chk_sifrekontrol_CheckedChanged);
            // 
            // kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(265, 441);
            this.Controls.Add(this.chk_sifrekontrol);
            this.Controls.Add(this.cmb_kayit_unvan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayıt_kaydet);
            this.Controls.Add(this.btn_kayıt_geri);
            this.Controls.Add(this.txt_kayit_sifre);
            this.Controls.Add(this.txt_kayit_telefon);
            this.Controls.Add(this.txt_kayit_mail);
            this.Controls.Add(this.txt_kayit_soyad);
            this.Controls.Add(this.txt_kayit_ad);
            this.Controls.Add(this.txt_kayit_id);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kayitol";
            this.Text = "EG LOJİSTİK/Kayıt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kayitol_FormClosing);
            this.Load += new System.EventHandler(this.kayitol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_kayit_id;
        private System.Windows.Forms.TextBox txt_kayit_ad;
        private System.Windows.Forms.TextBox txt_kayit_soyad;
        private System.Windows.Forms.TextBox txt_kayit_mail;
        private System.Windows.Forms.TextBox txt_kayit_telefon;
        private System.Windows.Forms.TextBox txt_kayit_sifre;
        private System.Windows.Forms.Button btn_kayıt_geri;
        private System.Windows.Forms.Button btn_kayıt_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_kayit_unvan;
        private System.Windows.Forms.CheckBox chk_sifrekontrol;
    }
}