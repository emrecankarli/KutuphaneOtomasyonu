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

namespace KutuphaneUygulamasi
{
    public partial class oduncVerAl : Form
    {
        public oduncVerAl()
        {
            InitializeComponent();
        }

        private void oduncVerAl_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString();
            uyelikIdleriGetir();
            kitapIdleriGetir();
            teslimeEdilmemisKitaplariListele();
        }

        private void teslimeEdilmemisKitaplariListele()
        {
            baglanti.Open();
            string sql = "select * from odunc where AlTar is null";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "odunc");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "odunc";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }

        private void uyelikIdleriGetir()
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "select kimlik from uyeler";
            SQLiteDataReader dr = komut.ExecuteReader();
            AutoCompleteStringCollection src = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                src.Add(dr[0].ToString());
            }
            dr.Close();
            baglanti.Close();
            textBox2.AutoCompleteCustomSource = src;
        }

        private void kitapIdleriGetir()
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "select id from kitaplar";
            SQLiteDataReader dr = komut.ExecuteReader();
            AutoCompleteStringCollection src = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                src.Add(dr[0].ToString());
            }
            dr.Close();
            baglanti.Close();
            textBox1.AutoCompleteCustomSource = src;
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane2024.db;Version=3;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text == null)
            {
                MessageBox.Show("Kitap ID, Kullanıcı Kimlik ve Veriliş Tarihi Girilmelidir...", "Uyarı");
                return;
            }
            int kitapId = int.Parse(textBox1.Text);
            string kimlik = textBox2.Text;
            string kimde = kitapKimde(kitapId);
            if (kimde != "kütüphane")
            {
                MessageBox.Show(textBox1.Text + " nolu kitap kütüphanede değil...", "Uyarı");
                return;
            }
            if (kimde != textBox2.Text)
            {
                MessageBox.Show(textBox1.Text + " nolu kitap " + kimde + " nolu kullanıcıda olduğundan ödünç verilemez...", "Uyarı");
                return;
            }
            string uyeKimlik = uyeVarMiKimlik(textBox2.Text);
            if (uyeKimlik == "")
            {
                MessageBox.Show(textBox2.Text + " nolu üye kayıtlı değil...", "Uyarı");
                return;
            }
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "insert into odunc (KitapId,UyeId,VerTar) values (@b1,@b2,@b3)";
            komut.Parameters.AddWithValue("@b1", textBox1.Text);
            komut.Parameters.AddWithValue("@b2", textBox2.Text);
            komut.Parameters.AddWithValue("@b3", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SQLiteCommand komut2 = new SQLiteCommand(baglanti);
            komut2.CommandText = "update kitaplar set Kimde=@k1 where id=@b1";
            komut2.Parameters.AddWithValue("@k1", textBox2.Text);
            komut2.Parameters.AddWithValue("@b1", textBox1.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            teslimeEdilmemisKitaplariListele();
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
        }

        private string uyeVarMiKimlik(string text)
        {
            string s = "";
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "select kimlik,adSoyad from uyeler where kimlik=" + text;
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                s = dr[0].ToString();
            }
            dr.Close();
            baglanti.Close();
            return s;
        }

        private string kitapKimde(int idd)
        {
            string s = "";
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "select Kimde from kitaplar where id=" + idd;
            SQLiteDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                s = dr[0].ToString();
            }
            dr.Close();
            baglanti.Close();
            return s;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox2.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text == null)
            {
                MessageBox.Show("Kitap ID, Kullanıcı Kimlik ve Teslim Tarihi Girilmelidir...", "Uyarı");
                return;
            }
            int kitapId = int.Parse(textBox1.Text);
            string kimlik = textBox2.Text;
            string kimde = kitapKimde(kitapId);
            if (kimde == "kütüphane")
            {
                MessageBox.Show(textBox1.Text + " nolu kitap kütüphanede...", "Uyarı");
                return;
            }
            if (kimde != textBox2.Text)
            {
                MessageBox.Show(textBox1.Text + " nolu kitap " + kimde + " nolu kullanıcıda olduğundan teslim alınamaz...", "Uyarı");
                return;
            }
            string uyeKimlik = uyeVarMiKimlik(textBox2.Text);
            if (uyeKimlik == "")
            {
                MessageBox.Show(textBox2.Text + " nolu üye kayıtlı değil...", "Uyarı");
                return;
            }
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "update odunc set AlTar=@t1 where KitapId=@b1 and UyeId=@b2";
            komut.Parameters.AddWithValue("@t1", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@b1", textBox1.Text);
            komut.Parameters.AddWithValue("@b2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SQLiteCommand komut2 = new SQLiteCommand(baglanti);
            komut2.CommandText = "update kitaplar set Kimde=@k1 where id=@b1";
            komut2.Parameters.AddWithValue("@k1", "kütüphane");
            komut2.Parameters.AddWithValue("@b1", textBox1.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            teslimeEdilmemisKitaplariListele();
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox2.Text = "";
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
