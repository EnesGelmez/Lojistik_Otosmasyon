
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace LojistikOtomasyon
{
    public partial class giris : Form
    {

        public static string userid, password;
        
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command;
        MySqlDataAdapter data_A;
        MySqlDataReader data_R;
        DataTable data_T;
        

        void connect()
        {
            connection = new MySqlConnection("Server = localhost; Database = eglojistik; Uid = root; Pwd = '166455';");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public giris()
        {
            InitializeComponent();
        }

        bool checkPass()
        {

            userid = txt_giris_id.Text;
            password = txt_giris_password.Text;

            command = new MySqlCommand();
            connect();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM personel where personelId='" + userid + "' AND personelSifre='" + password + "'";
            data_R = command.ExecuteReader();
            if (data_R.Read())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre", "EGLOJİSTİK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

        }

        bool userControl()
        {
            connect();
            command = new MySqlCommand("select personelUnvani from personel where personelId='" + txt_giris_id.Text + "'", connection);
            data_A = new MySqlDataAdapter(command);
            data_T = new DataTable();
            data_A.Fill(data_T);

            try
            {
                string a = data_T.Rows[0]["personelUnvani"].ToString();
                if (a == "Müdür" || a == "müdür")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Yetkiniz yok", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bilgilerinizi doğru giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        private void giris_Load(object sender, EventArgs e)
        {
            txt_giris_password.PasswordChar = '*';
        }

        private void chk_sifrekontrol_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sifrekontrol.Checked)
            {
                txt_giris_password.PasswordChar = '\0';
            }
            else
            {
                txt_giris_password.PasswordChar = '*';

            }
        }

        private void txt_giris_id_MouseClick(object sender, MouseEventArgs e)
        {
            txt_giris_id.Clear();
            if (txt_giris_password.Text=="")
            {
                txt_giris_password.Text = "Şifre";
            }
        }

        private void btn_giris_girisyap_Click(object sender, EventArgs e)
        {
            if (checkPass()==true)
            {
                anasayfa giris = new anasayfa();
                giris.Show();
                this.Hide();
            }
        }

        private void btn_giris_kayitol_Click(object sender, EventArgs e)
        {
            if (checkPass()==true && userControl()==true)
            {
                kayitol kayit = new kayitol();
                kayit.Show();
                this.Hide();
            }
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txt_giris_password_MouseClick(object sender, MouseEventArgs e)
        {
            txt_giris_password.Clear();
            if (txt_giris_id.Text == "")
            {
                txt_giris_id.Text = "Personel ID";
            }
        }
    }
}
