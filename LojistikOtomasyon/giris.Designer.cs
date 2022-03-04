namespace LojistikOtomasyon
{
    partial class giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_giris_id = new System.Windows.Forms.TextBox();
            this.txt_giris_password = new System.Windows.Forms.TextBox();
            this.btn_giris_girisyap = new System.Windows.Forms.Button();
            this.btn_giris_kayitol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_sifrekontrol = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "EG Lojistik";
            // 
            // txt_giris_id
            // 
            this.txt_giris_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_giris_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_giris_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_giris_id.Location = new System.Drawing.Point(98, 190);
            this.txt_giris_id.Name = "txt_giris_id";
            this.txt_giris_id.Size = new System.Drawing.Size(167, 28);
            this.txt_giris_id.TabIndex = 2;
            this.txt_giris_id.Text = "Personel ID";
            this.txt_giris_id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_giris_id_MouseClick);
            // 
            // txt_giris_password
            // 
            this.txt_giris_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txt_giris_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_giris_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_giris_password.Location = new System.Drawing.Point(98, 250);
            this.txt_giris_password.Name = "txt_giris_password";
            this.txt_giris_password.Size = new System.Drawing.Size(167, 28);
            this.txt_giris_password.TabIndex = 2;
            this.txt_giris_password.Text = "Şifre";
            this.txt_giris_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_giris_password_MouseClick);
            // 
            // btn_giris_girisyap
            // 
            this.btn_giris_girisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.btn_giris_girisyap.FlatAppearance.BorderSize = 0;
            this.btn_giris_girisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris_girisyap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris_girisyap.ForeColor = System.Drawing.Color.White;
            this.btn_giris_girisyap.Location = new System.Drawing.Point(98, 308);
            this.btn_giris_girisyap.Name = "btn_giris_girisyap";
            this.btn_giris_girisyap.Size = new System.Drawing.Size(152, 40);
            this.btn_giris_girisyap.TabIndex = 3;
            this.btn_giris_girisyap.Text = "GİRİŞ YAP";
            this.btn_giris_girisyap.UseVisualStyleBackColor = false;
            this.btn_giris_girisyap.Click += new System.EventHandler(this.btn_giris_girisyap_Click);
            // 
            // btn_giris_kayitol
            // 
            this.btn_giris_kayitol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.btn_giris_kayitol.FlatAppearance.BorderSize = 0;
            this.btn_giris_kayitol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris_kayitol.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris_kayitol.ForeColor = System.Drawing.Color.White;
            this.btn_giris_kayitol.Location = new System.Drawing.Point(98, 369);
            this.btn_giris_kayitol.Name = "btn_giris_kayitol";
            this.btn_giris_kayitol.Size = new System.Drawing.Size(152, 40);
            this.btn_giris_kayitol.TabIndex = 3;
            this.btn_giris_kayitol.Text = "KAYIT OL";
            this.btn_giris_kayitol.UseVisualStyleBackColor = false;
            this.btn_giris_kayitol.Click += new System.EventHandler(this.btn_giris_kayitol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LojistikOtomasyon.Resource1.arkaplan0000;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chk_sifrekontrol
            // 
            this.chk_sifrekontrol.AutoSize = true;
            this.chk_sifrekontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.chk_sifrekontrol.Location = new System.Drawing.Point(248, 258);
            this.chk_sifrekontrol.Name = "chk_sifrekontrol";
            this.chk_sifrekontrol.Size = new System.Drawing.Size(15, 14);
            this.chk_sifrekontrol.TabIndex = 5;
            this.chk_sifrekontrol.UseVisualStyleBackColor = false;
            this.chk_sifrekontrol.CheckedChanged += new System.EventHandler(this.chk_sifrekontrol_CheckedChanged);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(265, 438);
            this.Controls.Add(this.chk_sifrekontrol);
            this.Controls.Add(this.btn_giris_kayitol);
            this.Controls.Add(this.btn_giris_girisyap);
            this.Controls.Add(this.txt_giris_password);
            this.Controls.Add(this.txt_giris_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "giris";
            this.Text = "EG LOJİSTİK/Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.giris_FormClosing);
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_giris_id;
        private System.Windows.Forms.TextBox txt_giris_password;
        private System.Windows.Forms.Button btn_giris_girisyap;
        private System.Windows.Forms.Button btn_giris_kayitol;
        private System.Windows.Forms.CheckBox chk_sifrekontrol;
    }
}

