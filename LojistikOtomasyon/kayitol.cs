using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LojistikOtomasyon
{
    public partial class kayitol : Form
    {
        MySqlConnection connection = new MySqlConnection();
        void connect()
        {
            connection = new MySqlConnection("Server = localhost; Database = eglojistik; Uid = root; Pwd = '166455';");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        void add()
        {
            connect();
            try
            {
                //(silinecek)string ekle_sorgu = "insert into personel(personelAdi,personelSoyadi,personelUnvani,personelTelNo,personelEposta,personelSifre) values ('" + txt_kayit_ad.Text + "','" + txt_kayit_soyad.Text + "','" + cmb_kayit_unvan.SelectedItem + "','" + txt_kayit_telefon.Text + "','" + txt_kayit_mail.Text + "','" + txt_kayit_sifre.Text + "')";
                MySqlCommand komut = new MySqlCommand("insert into personel(personelAdi,personelSoyadi,personelUnvani,personelTelNo,personelEposta,personelSifre) values ('" + txt_kayit_ad.Text + "','" + txt_kayit_soyad.Text + "','" + cmb_kayit_unvan.SelectedItem + "','" + txt_kayit_telefon.Text + "','" + txt_kayit_mail.Text + "','" + txt_kayit_sifre.Text + "')", connection);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                giris girisForm = new giris();
                girisForm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public kayitol()
        {
            InitializeComponent();
        }

        private void txt_kayıt_id_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kayit_id.Clear();
            if (txt_kayit_sifre.Text=="")
            {
                txt_kayit_sifre.Text = "Şifre";
            }
            if (txt_kayit_soyad.Text == "")
            {
                txt_kayit_soyad.Text = "Soyad";
            }
            if (txt_kayit_telefon.Text == "")
            {
                txt_kayit_telefon.Text = "Telefon";
            }
            if (txt_kayit_mail.Text == "")
            {
                txt_kayit_mail.Text = "E-Posta";
            }
            if (txt_kayit_ad.Text == "")
            {
                txt_kayit_ad.Text = "Ad";
            }
        }

        private void chk_sifrekontrol_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sifrekontrol.Checked)
            {
                txt_kayit_sifre.PasswordChar = '\0';
            }
            else
            {
                txt_kayit_sifre.PasswordChar = '*';

            }
        }

        private void kayitol_Load(object sender, EventArgs e)
        {    
            txt_kayit_sifre.PasswordChar = '*';
        }

        private void txt_kayıt_ad_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kayit_ad.Clear();
            if (txt_kayit_sifre.Text == "")
            {
                txt_kayit_sifre.Text = "Şifre";
            }
            if (txt_kayit_soyad.Text == "")
            {
                txt_kayit_soyad.Text = "Soyad";
            }
            if (txt_kayit_telefon.Text == "")
            {
                txt_kayit_telefon.Text = "Telefon";
            }
            if (txt_kayit_mail.Text == "")
            {
                txt_kayit_mail.Text = "E-Posta";
            }
            if (txt_kayit_id.Text == "")
            {
                txt_kayit_id.Text = "Personel ID";
            }
        }

        private void txt_kayıt_soyad_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kayit_soyad.Clear();
            if (txt_kayit_sifre.Text == "")
            {
                txt_kayit_sifre.Text = "Şifre";
            }
            if (txt_kayit_id.Text == "")
            {
                txt_kayit_id.Text = "Personel ID";
            }
            if (txt_kayit_telefon.Text == "")
            {
                txt_kayit_telefon.Text = "Telefon";
            }
            if (txt_kayit_mail.Text == "")
            {
                txt_kayit_mail.Text = "E-Posta";
            }
            if (txt_kayit_ad.Text == "")
            {
                txt_kayit_ad.Text = "Ad";
            }
        }

        private void txt_kayıt_mail_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kayit_mail.Clear();
            if (txt_kayit_sifre.Text == "")
            {
                txt_kayit_sifre.Text = "Şifre";
            }
            if (txt_kayit_soyad.Text == "")
            {
                txt_kayit_soyad.Text = "Soyad";
            }
            if (txt_kayit_telefon.Text == "")
            {
                txt_kayit_telefon.Text = "Telefon";
            }
            if (txt_kayit_id.Text == "")
            {
                txt_kayit_id.Text = "Personel ID";
            }
            if (txt_kayit_ad.Text == "")
            {
                txt_kayit_ad.Text = "Ad";
            }
        }

        private void txt_kayıt_telefon_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kayit_telefon.Clear();
            if (txt_kayit_sifre.Text == "")
            {
                txt_kayit_sifre.Text = "Şifre";
            }
            if (txt_kayit_soyad.Text == "")
            {
                txt_kayit_soyad.Text = "Soyad";
            }
            if (txt_kayit_id.Text == "")
            {
                txt_kayit_id.Text = "Personel ID";
            }
            if (txt_kayit_mail.Text == "")
            {
                txt_kayit_mail.Text = "E-Posta";
            }
            if (txt_kayit_ad.Text == "")
            {
                txt_kayit_ad.Text = "Ad";
            }
        }

        private void txt_kayıt_sifre_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kayit_sifre.Clear();
            if (txt_kayit_id.Text == "")
            {
                txt_kayit_id.Text = "Personel ID";
            }
            if (txt_kayit_soyad.Text == "")
            {
                txt_kayit_soyad.Text = "Soyad";
            }
            if (txt_kayit_telefon.Text == "")
            {
                txt_kayit_telefon.Text = "Telefon";
            }
            if (txt_kayit_mail.Text == "")
            {
                txt_kayit_mail.Text = "E-Posta";
            }
            if (txt_kayit_ad.Text == "")
            {
                txt_kayit_ad.Text = "Ad";
            }
        }

        private void txt_kayıt_id_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_kayıt_kaydet_Click(object sender, EventArgs e)
        {
            add();
        }

        private void kayitol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
