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
using System.Reflection.Emit;

namespace KutuphaneUygulamasi
{
    public partial class uyelerForm : Form
    {
        public uyelerForm()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane2024.db;Version=3;");

        private void uyelerForm_Load(object sender, EventArgs e)
        {
            uyeleriListele();
        }

        private void uyeleriListele()
        {
            baglanti.Open();
            string sql = "select * from uyeler";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "uyeler");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "uyeler";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // kaydet

            if (textBox1.Text == "")
            {
                MessageBox.Show("Kimlik No girmezsiniz...\n" + "Uyarı");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into uyeler (kimlik, adSoyad, mail, telefon, aciklama) " +
                    "values (@k1, @k2, @k3, @k4, @k5)";
                komut.Parameters.AddWithValue("@k1", textBox1.Text);
                komut.Parameters.AddWithValue("@k2", textBox2.Text);
                komut.Parameters.AddWithValue("@k3", textBox3.Text);
                komut.Parameters.AddWithValue("@k4", textBox4.Text);
                komut.Parameters.AddWithValue("@k5", textBox5.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                uyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Eklenemedi!\n" + ex.Message.ToString());
            }
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // yeni kayıt
            DialogResult c = MessageBox.Show("Girdileri Temizlesin mi?", "Bilgi", MessageBoxButtons.YesNo);
            if (c == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // seçilen
            label6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // güncelle
            if (label6.Text == "")
            {
                MessageBox.Show("Önce Kayıt Seçin...", "Uyarı");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kimlik No girmezsiniz...\n" + "Uyarı");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "update uyeler set kimlik=@k1, adSoyad=@k2, mail=@k3, " +
                    "telefon=@k4, aciklama=@k5 where id=@id";
                komut.Parameters.AddWithValue("@k1", textBox1.Text);
                komut.Parameters.AddWithValue("@k2", textBox2.Text);
                komut.Parameters.AddWithValue("@k3", textBox3.Text);
                komut.Parameters.AddWithValue("@k4", textBox4.Text);
                komut.Parameters.AddWithValue("@k5", textBox5.Text);
                komut.Parameters.AddWithValue("@id", label6.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                uyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Güncellenemedi...\n" + ex.Message.ToString());
            }
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // sil
            if (label6.Text == "")
            {
                MessageBox.Show("Önce Kayıt Seçin...", "Uyarı");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from uyeler where id=" + int.Parse(label6.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                uyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Silinemedi...\n" + ex.Message.ToString());
            }
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
