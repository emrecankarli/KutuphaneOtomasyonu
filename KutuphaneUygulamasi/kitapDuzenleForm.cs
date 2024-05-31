using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneUygulamasi
{
    public partial class kitapDuzenleForm : Form
    {
        string secilenKitapid = "";
        string gelinenForm = "";
        public kitapDuzenleForm(string x, string gForm)
        {
            InitializeComponent();
            secilenKitapid = x;
            gelinenForm = gForm;
        }

        bool resimyuklendi = false;

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaAd = openFileDialog1.SafeFileName;
                string kaynakYoluAdi = openFileDialog1.FileName;

                string uzanti = Path.GetExtension(openFileDialog1.FileName);
                string yeniAd = dosyaAd;
                string hedefYolAd = resimyolu + yeniAd;

                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    yeniAd = textBox1.Text + "_" + textBox2.Text + uzanti;
                    hedefYolAd = resimyolu + yeniAd;
                }
                textBox6.Text = yeniAd;
                File.Copy(kaynakYoluAdi, hedefYolAd, true);
                if (File.Exists(hedefYolAd) == true)
                    pictureBox1.Image = Image.FromFile(hedefYolAd);
                resimyuklendi = true;
            }
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane2024.db;Version=3;");
        string resimyolu = System.Windows.Forms.Application.StartupPath + @"\resimler\";

        private void turler()
        {
            comboBox1.Items.Clear();
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "select turAdi from turler";
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
            baglanti.Close();
            comboBox1.SelectedIndex = 0;
        }
        private void kitapDuzenleForm_Load(object sender, EventArgs e)
        {
            label7.Text = secilenKitapid;
            turler();
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "select * from kitaplar where id=" + int.Parse(label7.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["kitapAd"].ToString();
                string tur = dr["tur"].ToString();
                int i = comboBox1.FindStringExact(tur);
                comboBox1.SelectedIndex = i;
                textBox2.Text = dr["yazar"].ToString();
                textBox3.Text = dr["icindekiler"].ToString();
                textBox4.Text = dr["yer"].ToString();
                string yer = dr["durum"].ToString();
                i = comboBox2.FindStringExact(yer);
                comboBox2.SelectedIndex = i;
                textBox6.Text = dr["resim"].ToString();
                if (textBox6.Text != "")
                {
                    string resimyolad = resimyolu + textBox6.Text;
                    pictureBox1.Image = Image.FromFile(resimyolad);
                }
            }
            dr.Close();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") return;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string sql = "update kitaplar set kitapAd=@t1,yazar=@t2,tur=@c1,icindekiler=@t3,yer=@t4,durum=@c2,resim=@t6 where id=" + int.Parse(label7.Text);
                SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@t1", textBox1.Text);
                komut.Parameters.AddWithValue("@t2", textBox2.Text);
                komut.Parameters.AddWithValue("@t3", textBox3.Text);
                komut.Parameters.AddWithValue("@t4", textBox4.Text);
                if (resimyuklendi)
                    komut.Parameters.AddWithValue("@t6", textBox6.Text);
                else
                    komut.Parameters.AddWithValue("@t6", "");
                komut.Parameters.AddWithValue("@c1", comboBox1.Text);
                komut.Parameters.AddWithValue("@c2", comboBox2.Text);
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
            //MessageBox.Show("Kitap Güncellendi ...", "Bilgi");
            if (gelinenForm == "kitapListele")
                ((kitapListele)Application.OpenForms["kitapListele"]).tumunuListele();
            this.Hide();
        }
    }
}
