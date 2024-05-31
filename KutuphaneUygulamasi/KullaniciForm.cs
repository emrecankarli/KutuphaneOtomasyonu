using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi
{
    public partial class KullaniciForm : Form
    {
        public KullaniciForm()
        {
            InitializeComponent();
        }

        public string kim = "";
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane2024.db;Version=3;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Güncelleme yapmak için mevcut şifrenizi girmelisiniz");
                return;
            }
            if (kullaniciVarmi(int.Parse(textBox6.Text), textBox2.Text))
            {
                baglanti.Open();
                int guncellenecekId = int.Parse(textBox6.Text);
                string sql = "update kullanicilar set kullaniciAdi=@ad, sifre=@sifre, mail=@mail, telefon=@tel" + " where id=" + guncellenecekId;
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = sql;
                komut.Parameters.AddWithValue("ad", textBox1.Text);
                string msifre = textBox2.Text;
                string ysifre = textBox3.Text;
                if (ysifre == "") ysifre = msifre;
                komut.Parameters.AddWithValue("sifre", ysifre);
                komut.Parameters.AddWithValue("mail", textBox4.Text);
                komut.Parameters.AddWithValue("tel", textBox5.Text);
                if (msifre!=ysifre || mAd!=textBox2.Text)
                {
                    if (DialogResult.OK == MessageBox.Show("Kullanıcı adı veya şifre değiştiğinde program kapatılacak", "Uyarı", MessageBoxButtons.OKCancel))
                    {
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        Application.Exit();
                    }

                }
                baglanti.Close();
            } else
                MessageBox.Show("Güncelleme yapmak için mevcut şifrenizi doğru girmelisiniz");

        }
        string mAd = "";

        private bool kullaniciVarmi(int a_id, string sifre)
        {
            bool snc = false;
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            string sql = "select * from kullanicilar where id="+a_id+" and sifre='"+sifre+"'";
            komut.CommandText = sql;
            SQLiteDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                snc = true;
            }
            dr.Close();
            baglanti.Close();
            return snc;
        }

        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            bilgileriGetir();
        }

        private void bilgileriGetir()
        {
            if (kim == "") return;
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            string sql = "select * from kullanicilar where kullaniciAdi='" + kim + "'";
            komut.CommandText = sql;
            SQLiteDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox6.Text = dr["id"].ToString();
                textBox1.Text = dr["kullaniciAdi"].ToString();
                //textBox2.Text = dr["sifre"].ToString();
                textBox4.Text = dr["mail"].ToString();
                textBox5.Text = dr["telefon"].ToString();
                mAd = textBox1.Text;
            }
            dr.Close();
            baglanti.Close();
        }
    }
}
