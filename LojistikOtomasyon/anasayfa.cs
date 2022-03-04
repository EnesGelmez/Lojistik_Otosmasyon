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
using System.Globalization;

namespace LojistikOtomasyon
{
    public partial class anasayfa : Form
    {
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command;
        MySqlDataAdapter data_A;
        DataTable data_T;
        DataSet data_S;
        public string userid;
       
        // <MAİN>
        void kullaniciAdi()
        {
            connect();
            command = new MySqlCommand("select personelAdi from personel where personelId='" + userid + "'", connection);
            data_A = new MySqlDataAdapter(command);
            data_T = new DataTable();
            data_A.Fill(data_T);
            string adi = data_T.Rows[0]["personelAdi"].ToString();
            adi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(adi);

            command = new MySqlCommand("select personelSoyAdi from personel where personelId='" + userid + "'", connection);
            data_A = new MySqlDataAdapter(command);
            data_T = new DataTable();
            data_A.Fill(data_T);
            string soyadi = data_T.Rows[0]["personelSoyAdi"].ToString();
            soyadi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyadi);
            label33.Text = adi;
            label35.Text = soyadi;

        }
        bool userControl()
        {
            connect();
            command = new MySqlCommand("select personelUnvani from personel where personelId='" + userid + "'", connection);
            data_A = new MySqlDataAdapter(command);
            data_T = new DataTable();
            data_A.Fill(data_T);
            string a = data_T.Rows[0]["personelUnvani"].ToString();

            if (a == "Müdür" || a == "müdür")
            {
                connection.Close();
                label7.Visible = true;
                txt_anasayfa_personel_sifre.Visible = true;
                chk_anasayfa_personel_sifre.Visible = true;
                connection.Close();
                return true;
                

            }
            else
            {
                MessageBox.Show("Yetkiniz yok", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                connection.Close();
                return false;
                
            }
            

        }
        bool anasayfauserControl()
        {
            connect();
            command = new MySqlCommand("select personelUnvani from personel where personelId='" + this.userid + "'", connection);
            data_A = new MySqlDataAdapter(command);
            data_T = new DataTable();
            data_A.Fill(data_T);
            string a = data_T.Rows[0]["personelUnvani"].ToString();

            if (a == "Müdür" || a == "müdür")
            {
                
                label7.Visible = true;
                txt_anasayfa_personel_sifre.Visible = true;
                chk_anasayfa_personel_sifre.Visible = true;

                return true;
                

            }
            else
            {
                return true;
            }
            
        }
        void connect()
        {
            connection = new MySqlConnection("Server = localhost; Database = eglojistik; Uid = root; Pwd = '166455';");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        // </MAİN>
        //<ANASAYFA>
        void anasayfaAdd()
        {
            connect();
            if (radio_anasayfa_anasayfa_cikis.Checked == true)
            {
                try
                {
                    MySqlCommand komut = new MySqlCommand("insert into aracpersonel(personelId,plaka,firmaId,durum,tarih) values ('" + txt_anasayfa_anasayfa_personelid.Text + "','" + txt_anasayfa_anasayfa_plaka.Text + "','" + txt_anasayfa_anasayfa_firmaid.Text + "','Çıkış','" + DateTime.Now.ToString() + "')", connection);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stokFill(true);
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //"Daha önce bilgilerini girdiğiniz bir stok bilgisi veya tanımlamadığınız urun / firma bulunmaktadır.\n\n-Günceleme yapmak\n-Urun veya firma eklemek\n\nSorunu çözebilir."
                }
            }
            else
            {
                try
                {
                    MySqlCommand komut = new MySqlCommand("insert into aracpersonel(personelId,plaka,firmaId,durum,tarih) values ('" + txt_anasayfa_anasayfa_personelid.Text + "','" + txt_anasayfa_anasayfa_plaka.Text + "','" + txt_anasayfa_anasayfa_firmaid.Text + "','Varış','" + DateTime.Now.ToString() + "')", connection);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stokFill(true);
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //"Daha önce bilgilerini girdiğiniz bir stok bilgisi veya tanımlamadığınız urun / firma bulunmaktadır.\n\n-Günceleme yapmak\n-Urun veya firma eklemek\n\nSorunu çözebilir."
                }
            }
            
            
        }
        void anasayfaFill()
        {
            connect();
            command = new MySqlCommand("select id as Sıra, personelId as Personel_ID ,plaka as Araç_Plakası,firmaId as Firma_ID,durum as Durum,tarih as Tarih from eglojistik.aracpersonel", connection);
            
            data_A = new MySqlDataAdapter(command);
            data_S = new DataSet();
            data_A.Fill(data_S, "aracpersonel");

            dg_anasayfa_anasayfa.DataSource = data_S.Tables["aracpersonel"];
            dg_anasayfa_anasayfa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }
        void anasayfaFillTxt()
        {
            connect();
            try
            {
                txt_anasayfa_anasayfa_id.Text= dg_anasayfa_anasayfa.CurrentRow.Cells[0].FormattedValue.ToString();
                txt_anasayfa_anasayfa_personelid.Text = dg_anasayfa_anasayfa.CurrentRow.Cells[1].FormattedValue.ToString();
                txt_anasayfa_anasayfa_plaka.Text = dg_anasayfa_anasayfa.CurrentRow.Cells[2].FormattedValue.ToString(); 
                txt_anasayfa_anasayfa_firmaid.Text = dg_anasayfa_anasayfa.CurrentRow.Cells[3].FormattedValue.ToString();
                
                lbl_anasayfa_anasayfa_tarih.Text = dg_anasayfa_anasayfa.CurrentRow.Cells[5].FormattedValue.ToString();


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }
        void anasayfaDelete()
        {
            connect();
            command = new MySqlCommand("delete from aracpersonel where id=" + txt_anasayfa_anasayfa_id.Text, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stokFill(true);
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        //</ANASAYFA>

        // <STOK>    
        void stokFill(bool control)
        {
            connect();
            string d = null;
            if (cmb_anasayfa_stok_aramakriteri.SelectedIndex == 0)
            {
                d = "firmaId";
            }
            else
            {
                d = "firmaAdi";
            }
            

            if (control == true)
                command = new MySqlCommand("select urunbilgisi.urunKodu as Urun_Kodu ,urunAdedi as Urun_Adedi,firmalar.firmaId as Firma_ID,firmaAdi as Firma_Adı,firmaTelNo as Firma_Tel_No,firmaAdresi as Firma_Adres from eglojistik.firmalar ,eglojistik.urunbilgisi,eglojistik.stok where stok.firmaId=firmalar.firmaId and urunbilgisi.urunKodu=stok.urunKodu", connection);
            else
            {
                command = new MySqlCommand("select urunbilgisi.urunKodu, urunAdedi, firmalar.firmaId, firmaAdi, firmaTelNo, firmaAdresi from eglojistik.firmalar , eglojistik.urunbilgisi, eglojistik.stok where stok.firmaId = firmalar.firmaId and urunbilgisi.urunKodu = stok.urunKodu and  stok." + d + "  like '%" + txt_anasayfa_stok_aramaanahtari.Text + "%' ", connection);
            }

            data_A = new MySqlDataAdapter(command);
            data_S = new DataSet();
            data_A.Fill(data_S, "stok");

            dg_anasayfa_stok.DataSource = data_S.Tables["stok"];
            dg_anasayfa_stok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }
        void stokAdd()
        {
            connect();
            try
            {                
                MySqlCommand komut = new MySqlCommand("insert into stok(urunKodu,urunAdedi,firmaId) values ('" + txt_anasayfa_stok_urunid.Text + "','" + txt_anasayfa_stok_mevcutmiktar.Text + "','" + txt_anasayfa_stok_firmaid.Text + "')", connection);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stokFill(true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //"Daha önce bilgilerini girdiğiniz bir stok bilgisi veya tanımlamadığınız urun / firma bulunmaktadır.\n\n-Günceleme yapmak\n-Urun veya firma eklemek\n\nSorunu çözebilir."
            }
            connection.Close();
        }
        void stokUpdate()
        {
            connect();
            command = new MySqlCommand("update stok set urunKodu='" + txt_anasayfa_stok_urunid.Text + "',urunAdedi='" + txt_anasayfa_stok_mevcutmiktar.Text + "',firmaId='" + txt_anasayfa_stok_firmaid.Text + "'where urunKodu=" + txt_anasayfa_stok_urunid.Text, connection);
            try
            {
                command.ExecuteNonQuery();
                stokFill(true);
                MessageBox.Show("Güncelleme Başarılı", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }
        void stokFilltxt()
        {
            connect();
            try
            {
                txt_anasayfa_stok_urunid.Text = dg_anasayfa_stok.CurrentRow.Cells[0].FormattedValue.ToString();txt_anasayfa_stok_mevcutmiktar.Text = dg_anasayfa_stok.CurrentRow.Cells[1].FormattedValue.ToString();
                txt_anasayfa_stok_firmaid.Text = dg_anasayfa_stok.CurrentRow.Cells[2].FormattedValue.ToString();
                                

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }
        void stokDelete()
        {
            connect();
            command = new MySqlCommand("delete from stok where urunKodu=" + txt_anasayfa_stok_urunid.Text, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stokFill(true);
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        void stokClearinText()
        {
            txt_anasayfa_stok_urunid.Clear();
            txt_anasayfa_stok_aramaanahtari.Clear();
            txt_anasayfa_stok_mevcutmiktar.Clear();
            txt_anasayfa_stok_firmaid.Clear();
            cmb_anasayfa_stok_aramakriteri.SelectedItem = null;
            btn_anasayfa_stok_ara.Enabled = false;


        }
        // </STOK>

        //<ÜRÜNLER>
        void urunFill(bool control)
        {
            connect();
            string d = null;
            if (cmb_anasayfa_urunler_aramakriteri.SelectedIndex == 0)
            {
                d = "urunKodu";
            }
            else
            {
                d = "firmaId";
            }

            if (control == true)
                command = new MySqlCommand("select * from urunbilgisi", connection);
            else
            {
                command = new MySqlCommand("select * from urunbilgisi where urunbilgisi." + d + "  like '%" + txt_anasayfa_urunler_aramaanahtari.Text + "%' ", connection);
            }


            data_A = new MySqlDataAdapter(command);
            data_S = new DataSet();
            data_A.Fill(data_S, "urunbilgisi");

            dg_anasayfa_urunler.DataSource = data_S.Tables["urunbilgisi"];
            dg_anasayfa_urunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }
        void urunFillText()
        {
            connect();
            try
            {
                txt_anasayfa_urunler_urunkodu.Text = dg_anasayfa_urunler.CurrentRow.Cells[0].FormattedValue.ToString();
                txt_anasayfa_urunler_firmaid.Text = dg_anasayfa_urunler.CurrentRow.Cells[1].FormattedValue.ToString();
                txt_anasayfa_urunler_uruntipi.Text = dg_anasayfa_urunler.CurrentRow.Cells[2].FormattedValue.ToString();
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }
        void urunAdd()
        {
            connect();

            try
            {
                string ilc_ilacekle_sorgu = "insert into urunbilgisi(urunKodu,firmaId,urunTipi) values ('" + txt_anasayfa_urunler_urunkodu.Text + "','" + txt_anasayfa_urunler_firmaid.Text + "','" + txt_anasayfa_urunler_uruntipi.Text + "')";
                MySqlCommand komut = new MySqlCommand(ilc_ilacekle_sorgu, connection);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                urunFill(true);
            }
            catch
            {
                MessageBox.Show("Daha önce girdiğiniz bir ürünün girişini tekrar yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            connection.Close();
        }
        void urunDelete()
        {
            connect();
            command = new MySqlCommand("delete from urunbilgisi where urunKodu=" + txt_anasayfa_urunler_urunkodu.Text, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                urunFill(true);
            }
            catch 
            {
                MessageBox.Show("Daha önce deponuzda bulunan bir ürünün veya hala stoğunuzda bulunan bir ürünün bilgilerini silmeye çalıştınız.\n\n-İlk olarak silmeye çalıştığınız ürün bilgilerinin stok bilgilerini silmeniz sorunu çözebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            connection.Close();
        }
        void urunUpdate()
        {
            connect();
            command = new MySqlCommand("update urunbilgisi set urunKodu='" + txt_anasayfa_urunler_urunkodu.Text + "',urunTipi='" + txt_anasayfa_urunler_uruntipi.Text + "'where urunKodu=" + txt_anasayfa_urunler_urunkodu.Text, connection); ;

            try
            {
                command.ExecuteNonQuery();
                urunFill(true);
                MessageBox.Show("Güncelleme Başarılı", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }
        void uruntxtClear()
        {
            txt_anasayfa_urunler_urunkodu.Clear();
            txt_anasayfa_urunler_firmaid.Clear();
            txt_anasayfa_urunler_uruntipi.Clear();            
            txt_anasayfa_urunler_aramaanahtari.Clear();
            cmb_anasayfa_urunler_aramakriteri.SelectedItem = null;
            
        }
        //</ÜRÜNLER>

        //<FİRMALAR>
        void firmaFill(bool control)
        {
            string d = null;
            if (cmb_anasayfa_firmalar_aramakriteri.SelectedIndex == 0)
            {
                d = "firmaId";
            }
            else
            {
                d = "firmaAdi";
            }
            connect();

            //select ilacbilgi.ilacKodu ,ilacAdi,ilacAdet,ilacfirma.fID,fAdi,fTelNo,fTelNo,fAdres from meeeczaneotomasyonu.ilacfirma ,meeeczaneotomasyonu.ilacbilgi,meeeczaneotomasyonu.stok where stok.fID=ilacfirma.fID and ilacbilgi.ilacKodu=stok.ilacKodu

            if (control == true)
                command = new MySqlCommand("select * from firmalar", connection);
            else
            {
                command = new MySqlCommand("select * from firmalar where  " + d + "  like '%" + txt_anasayfa_firmalar_aramaanahtari.Text + "%' ", connection);
            }

            data_A = new MySqlDataAdapter(command);
            data_S = new DataSet();
            data_A.Fill(data_S, "firmalar");

            dg_anasayfa_firmalar.DataSource = data_S.Tables["firmalar"];
            dg_anasayfa_firmalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }
        void firmaFillText()
        {
            txt_anasayfa_firmalar_firmaid.Text = dg_anasayfa_firmalar.CurrentRow.Cells[0].Value.ToString();
            txt_anasayfa_firmalar_firmaadi.Text = dg_anasayfa_firmalar.CurrentRow.Cells[1].Value.ToString();
            txt_anasayfa_firmalar_firmatelno.Text = dg_anasayfa_firmalar.CurrentRow.Cells[2].Value.ToString();
            txt_anasayfa_firmalar_firmaadresi.Text = dg_anasayfa_firmalar.CurrentRow.Cells[3].Value.ToString();
            txt_anasayfa_firmalar_firmafaxno.Text = dg_anasayfa_firmalar.CurrentRow.Cells[4].Value.ToString();
        }
        void firmaAdd()
        {
            connect();
            try
            {
                MySqlCommand komut = new MySqlCommand("insert into firmalar(firmaAdi,firmaTelNo,firmaAdresi,firmaFaxNo) values ('" +txt_anasayfa_firmalar_firmaadi.Text + "','" + txt_anasayfa_firmalar_firmatelno.Text + "','" + txt_anasayfa_firmalar_firmaadresi.Text + "','" + txt_anasayfa_firmalar_firmafaxno.Text + "')", connection);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firmaFill(true);
            }
            catch (Exception nn)
            {
                MessageBox.Show(nn.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
        }
        void firmaDelete()
        {
            connect();
            command = new MySqlCommand("delete from firmalar where firmaId=" + txt_anasayfa_firmalar_firmaid.Text, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firmaFill(true);
            }
            catch (Exception)
            {
                MessageBox.Show("Daha önceden anlaşmanız olan veya elinizde bu firmaya ait mallarınız var ise firma bilgilerini silemezsiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        void firmaUpdate()
        {
            connect();
            command = new MySqlCommand("update firmalar set firmaAdi='" + txt_anasayfa_firmalar_firmaadi.Text + "',firmaTelNo='" + txt_anasayfa_firmalar_firmatelno.Text + "',firmaAdresi='" + txt_anasayfa_firmalar_firmaadresi.Text + "',firmaFaxNo='" + txt_anasayfa_firmalar_firmafaxno.Text + "'where firmaId=" + txt_anasayfa_firmalar_firmaid.Text, connection); ;
            try
            {
                command.ExecuteNonQuery();
                firmaFill(true);
                MessageBox.Show("Güncelleme Başarılı", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception nn)
            {

                MessageBox.Show(nn.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }
        void firmaTextClear()
        {
            txt_anasayfa_firmalar_firmaid.Clear();
            txt_anasayfa_firmalar_firmaadi.Clear();
            txt_anasayfa_firmalar_firmatelno.Clear();
            txt_anasayfa_firmalar_firmaadresi.Clear();
            txt_anasayfa_firmalar_aramaanahtari.Clear();
            cmb_anasayfa_firmalar_aramakriteri.Text = "";
            btn_anasayfa_firmalar_ara.Enabled = false;
        }
        //</FİRMALAR>

        // <PERSONEL>  
        void personelFilltxt()
        {
            connect();

            txt_anasayfa_personel_personelid.Text = dg_anasayfa_personel.CurrentRow.Cells[0].Value.ToString();
            txt_anasayfa_personel_ad.Text = dg_anasayfa_personel.CurrentRow.Cells[1].Value.ToString();
            txt_anasayfa_personel_soyad.Text = dg_anasayfa_personel.CurrentRow.Cells[2].Value.ToString();
            cmb_anasayfa_personel_unvan.Text = dg_anasayfa_personel.CurrentRow.Cells[3].Value.ToString();
            txt_anasayfa_personel_telno.Text = dg_anasayfa_personel.CurrentRow.Cells[4].Value.ToString();
            txt_anasayfa_personel_eposta.Text = dg_anasayfa_personel.CurrentRow.Cells[5].Value.ToString();


            command = new MySqlCommand("select personelSifre from personel where personelId='" + txt_anasayfa_personel_personelid.Text + "'", connection);
            data_A = new MySqlDataAdapter(command);
            data_T = new DataTable();
            data_A.Fill(data_T);
            try
            {
                string a = data_T.Rows[0]["personelSifre"].ToString();
                txt_anasayfa_personel_sifre.Text = a;
            }
            catch (Exception)
            {

            }

        }
        void personelFill(bool control)
        {
            connect();
            string d = null;
            if (cmb_anasayfa_personel_aramakriteri.SelectedIndex == 0)
            {
                d = "personelAdi";
            }
            else
            {
                d = "personelId";
            }

            if (control == true)
                command = new MySqlCommand("select personelId as Personel_ID , personelAdi as Personel_Adı,personelSoyadi as Personel_Soyadı,personelUnvani as Personel_Unvanı,personelTelNo as Personel_TelNO,personelEposta as Personel_EPosta from personel", connection);

            else
            {
                if (d == "personelId")
                {
                    command = new MySqlCommand("select * from personel where " + d + " ='" + txt_anasayfa_personel_aramaanahtari.Text + "'", connection);

                }
                else
                {
                    command = new MySqlCommand("select * from personel where " + d + " like '%" + txt_anasayfa_personel_aramaanahtari.Text + "%'", connection);
                }

            }



            data_A = new MySqlDataAdapter(command);
            data_S = new DataSet();
            data_A.Fill(data_S, "personel");

            dg_anasayfa_personel.DataSource = data_S.Tables["personel"];
            dg_anasayfa_personel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmb_anasayfa_personel_aramakriteri.Enabled = true;

            connection.Close();
        }
        void personelUpdate()
        {
            connect();
            command = new MySqlCommand("update personel set personelAdi='" + txt_anasayfa_personel_ad.Text + "',personelSoyadi='" + txt_anasayfa_personel_soyad.Text + "',personelUnvani='" + cmb_anasayfa_personel_unvan.SelectedItem + "',personelTelNo='" + txt_anasayfa_personel_telno.Text + "',personelEposta='" + txt_anasayfa_personel_eposta.Text + "',personelSifre='" + txt_anasayfa_personel_sifre.Text + "'where personelId=" + txt_anasayfa_personel_personelid.Text, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
            personelFill(true);
            connection.Close();

        }
        void personelDelete()
        {
            connect();
            command = new MySqlCommand("delete from personel where personelId=" + txt_anasayfa_personel_personelid.Text, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        void personelClearintxt()
        {
            txt_anasayfa_personel_ad.Clear();

            txt_anasayfa_personel_eposta.Clear();
            txt_anasayfa_personel_personelid.Clear();
            txt_anasayfa_personel_sifre.Clear();
            txt_anasayfa_personel_soyad.Clear();
            txt_anasayfa_personel_telno.Clear();
            txt_anasayfa_personel_aramaanahtari.Clear();
            cmb_anasayfa_personel_unvan.Text = "";
            cmb_anasayfa_personel_aramakriteri.Text = "";
        }
        // </PERSONEL>  

        // <ARAC>
        void aracFill(bool control)
        {
            string d = null;
            if (cmb_anasayfa_firmalar_aramakriteri.SelectedIndex == 0)
            {
                d = "plaka";
            }
            else
            {
                d = "aracTipi";
            }
            connect();            

            if (control == true)
                command = new MySqlCommand("select * from araclar", connection);
            else
            {
                command = new MySqlCommand("select * from araclar where  " + d + "  like '%" + txt_anasayfa_arac_aramaanahtari.Text + "%' ", connection);
            }

            data_A = new MySqlDataAdapter(command);
            data_S = new DataSet();
            data_A.Fill(data_S, "araclar");

            dg_anasayfa_araclar.DataSource = data_S.Tables["araclar"];
            dg_anasayfa_araclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }
        void aracFillTxt()
        {
            txt_anasayfa_arac_aracplaka.Text = dg_anasayfa_araclar.CurrentRow.Cells[0].Value.ToString();                       
            txt_anasayfa_arac_aractipi.Text = dg_anasayfa_araclar.CurrentRow.Cells[1].Value.ToString();
        }
        void aracAdd()
        {
            connect();
            try
            {
                MySqlCommand komut = new MySqlCommand("insert into araclar(plaka,aracTipi) values ('" + txt_anasayfa_arac_aracplaka.Text + "','" + txt_anasayfa_arac_aractipi.Text + "')", connection);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firmaFill(true);
            }
            catch (Exception nn)
            {
                MessageBox.Show(nn.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
        }
        void aracDelete()
        {
            connect();
            command = new MySqlCommand("delete from araclar where plaka=" + txt_anasayfa_arac_aracplaka.Text, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }       
        void aracTxtClear()
        {
            txt_anasayfa_arac_aracplaka.Clear();
            txt_anasayfa_arac_aractipi.Clear();
            cmb_anasayfa_arac_aramakriteri.SelectedItem = null;
            txt_anasayfa_arac_aramaanahtari.Clear();
        }
        // </ARAC>


        public anasayfa()
        {
            InitializeComponent();
        }

        private void tmr_anasayfa_Tick(object sender, EventArgs e)
        {
            connect();
            if (connection.State == ConnectionState.Closed)
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.GreenYellow;
            }
            lbl_anasayfa_saat.Text = DateTime.Now.ToLongTimeString();
            lbl_anasayfa_tarih.Text = DateTime.Now.ToLongDateString();



        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            tmr_anasayfa.Interval = 100;
            tmr_anasayfa.Enabled = true;
            radio_anasayfa_anasayfa_cikis.Checked = true;
            this.userid = giris.userid;
            anasayfaFill();
            personelFill(true);
            userControl();
            kullaniciAdi();
            
        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_anasayfa_oturum_Click(object sender, EventArgs e)
        {
            giris kayitForm = new giris();
            kayitForm.Show();
            this.Hide();
        }

        private void btn_anasayfa_personel_Click(object sender, EventArgs e)
        {

            personelFill(true);

            tabControl1.SelectedTab = tabPage5;
        }

        private void btn_anasayfa_personel_yenile_Click(object sender, EventArgs e)
        {
            cmb_anasayfa_personel_aramakriteri.SelectedItem = null;
            txt_anasayfa_personel_aramaanahtari.Enabled = false;
            personelFill(true);
            personelClearintxt();
            btn_anasayfa_firmalar_ara.Enabled = false;
        }

        private void cmb_anasayfa_personel_aramakriteri_TextChanged(object sender, EventArgs e)
        {
            btn_anasayfa_personel_personelara.Enabled = true;
            txt_anasayfa_personel_aramaanahtari.Enabled = true;

            personelFill(false);
        }

        private void btn_anasayfa_personel_personelara_Click(object sender, EventArgs e)
        {
            personelFill(false);
        }

        private void btn_anasayfa_personel_personelguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (userControl() == true)
                {
                    personelUpdate();
                    MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme yapılamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_anasayfa_personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void chk_anasayfa_personel_sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_anasayfa_personel_sifre.Checked)
            {
                txt_anasayfa_personel_sifre.PasswordChar = '\0';
            }
            else
            {
                txt_anasayfa_personel_sifre.PasswordChar = '*';
            }
        }

        private void btn_anasayfa_personel_personelsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (userControl() == true)
                {
                    personelDelete();
                    personelFill(true);
                    MessageBox.Show("Silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Silme işlemi yapılamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anasayfa_sirketler_Click(object sender, EventArgs e)
        {
            firmaFill(true);
            tabControl1.SelectedTab = tabPage4;
        }

        private void btn_anasayfa_alımsatım_Click(object sender, EventArgs e)
        {
            urunFill(true);
            tabControl1.SelectedTab = tabPage3;
        }

        private void btn_anasayfa_stok_Click(object sender, EventArgs e)
        {
            stokFill(true);
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn_anasayfa_anasayfa_Click(object sender, EventArgs e)
        {
            anasayfaFill();
            tabControl1.SelectedTab = tabPage1;
            
        }

        private void btn_anasayfa_firmalar_yenile_Click(object sender, EventArgs e)
        {
            txt_anasayfa_firmalar_aramaanahtari.Enabled = false;
            
            btn_anasayfa_firmalar_ara.Enabled = false;
            cmb_anasayfa_firmalar_aramakriteri.SelectedItem = null;
            firmaFill(true);
            firmaTextClear();
        }

        private void btn_anasayfa_firmalar_ara_Click(object sender, EventArgs e)
        {
            firmaFill(false);
        }

        private void btn_anasayfa_firmalar_ekle_Click(object sender, EventArgs e)
        {
            firmaAdd();
        }

        private void btn_anasayfa_firmalar_sil_Click(object sender, EventArgs e)
        {
            firmaDelete();
        }

        private void btn_anasayfa_firmalar_güncelle_Click(object sender, EventArgs e)
        {
            firmaUpdate();
        }

        

        private void dg_anasayfa_firmalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            firmaFillText();
        }

        private void cmb_anasayfa_firmalar_aramakriteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_anasayfa_firmalar_aramakriteri_TextChanged(object sender, EventArgs e)
        {
            txt_anasayfa_firmalar_aramaanahtari.Enabled = true;  
            
            btn_anasayfa_firmalar_ara.Enabled = true;
            firmaFill(false);
        }

        private void btn_anasayfa_urunler_yenile_Click(object sender, EventArgs e)
        {
            txt_anasayfa_urunler_aramaanahtari.Enabled = false;
            uruntxtClear();
            urunFill(true);
        }

        private void btn_anasayfa_urunler_güncelle_Click(object sender, EventArgs e)
        {
            urunUpdate();
        }

        private void btn_anasayfa_urunler_sil_Click(object sender, EventArgs e)
        {
            urunDelete();
        }

        private void btn_anasayfa_urunler_ara_Click(object sender, EventArgs e)
        {
            urunFill(false);
        }

        private void btn_anasayfa_urunler_ilacekle_Click(object sender, EventArgs e)
        {
            urunAdd();
        }

        private void cmb_anasayfa_urunler_aramakriteri_TextChanged(object sender, EventArgs e)
        {
            txt_anasayfa_urunler_aramaanahtari.Enabled = true;
            btn_anasayfa_urunler_ara.Enabled = true;
        }

        private void dg_anasayfa_urunler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            urunFillText();
        }

        private void btn_ana_stok_mevmik_Click(object sender, EventArgs e)
        {
            stokClearinText();
            stokFill(true);
            
        }

        private void cmb_anasayfa_stok_aramakriteri_TextChanged(object sender, EventArgs e)
        {
            
            btn_anasayfa_stok_ara.Enabled = true;
            txt_anasayfa_stok_aramaanahtari.Enabled = true;
        }

        private void btn_ana_stok_ara_Click(object sender, EventArgs e)
        {
            stokFill(false);
        }

        private void btn_anasayfa_stok_sil_Click(object sender, EventArgs e)
        {
            stokDelete();
        }

        private void btn_anasayfa_stok_guncelle_Click(object sender, EventArgs e)
        {
            stokUpdate();
        }

        private void btn_anasayfa_stok_ekle_Click(object sender, EventArgs e)
        {
            stokAdd();
        }

        private void dg_anasayfa_stok_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            stokFilltxt();
        }

        private void btn_anasayfa_arac_Click(object sender, EventArgs e)
        {
            aracFill(true);
            tabControl1.SelectedTab = tabPage6;
        }

        private void dg_anasayfa_araclar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            aracFillTxt();
        }

        private void dg_anasayfa_personel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            personelFilltxt();
        }

        private void cmb_anasayfa_arac_aramakriteri_TextChanged(object sender, EventArgs e)
        {
            txt_anasayfa_arac_aramaanahtari.Enabled = true;
            btn_anasayfa_arac_aracara.Enabled = true;
        }

        private void btn_anasayfa_arac_yenile_Click(object sender, EventArgs e)
        {
            aracFill(false);
            aracTxtClear();
            txt_anasayfa_arac_aramaanahtari.Enabled = false;
            btn_anasayfa_arac_aracara.Enabled = false;
        }

        private void btn_anasayfa_arac_aracekle_Click(object sender, EventArgs e)
        {
            aracAdd();
            aracFill(false);
        }

        private void btn_anasayfa_arac_aracara_Click(object sender, EventArgs e)
        {
            aracFill(false);
        }

        private void txt_anasayfa_stok_firmaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            anasayfaFill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfaAdd();
            anasayfaFill();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dg_anasayfa_anasayfa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            anasayfaFillTxt();
        }

        private void btn_anasayfa_anasayfa_sil_Click(object sender, EventArgs e)
        {
            anasayfaDelete();
            anasayfaFill();
        }

        

        
        

        

        
    }
}
