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

namespace KutuphaneUygulamasi
{
    public partial class kitapEkleForm : Form
    {
        public kitapEkleForm()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane2024.db; Version=3;");

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") return;
            baglanti.Open();
            string sql = "insert into kitaplar (kitapAd,yazar,tur,icindekiler,yer,durum,resim) " + "values(@t1,@t2,@c1,@t3,@t4,@t5,@t6)";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.AddWithValue("t1", textBox1.Text);
            komut.Parameters.AddWithValue("t2", textBox2.Text);
            komut.Parameters.AddWithValue("t3", textBox3.Text);
            komut.Parameters.AddWithValue("t4", textBox4.Text);
            komut.Parameters.AddWithValue("t5", textBox5.Text);
            if (resimyuklendi)
                komut.Parameters.AddWithValue("t6", textBox6.Text);
            else
                komut.Parameters.AddWithValue("t6", "");
            komut.Parameters.AddWithValue("t6", textBox6.Text);
            komut.Parameters.AddWithValue("c1", comboBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi...", "Bilgi");
        }

        private void kitapEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapTuruForm frmx = new KitapTuruForm();
            frmx.MdiParent = this.MdiParent;
            frmx.Show();

        }

        private void kitapEkleForm_Activated(object sender, EventArgs e)
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

        bool resimyuklendi = false;
        string resimYolu = System.Windows.Forms.Application.StartupPath + @"\resimler\";
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaAd = openFileDialog1.SafeFileName;
                string kaynakYoluAdi = openFileDialog1.FileName;

                string uzanti = Path.GetExtension(openFileDialog1.FileName);
                string yeniAd = dosyaAd;
                string hedefYolAd = resimYolu + yeniAd;

                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    yeniAd = textBox1.Text + "_" + textBox2.Text + uzanti;
                    hedefYolAd = resimYolu + yeniAd;
                }
                textBox6.Text = yeniAd;
                File.Copy(kaynakYoluAdi, hedefYolAd, true);
                if (File.Exists(hedefYolAd) == true)
                    pictureBox1.Image = Image.FromFile(hedefYolAd);
                resimyuklendi = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
