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
using System.Data.SQLite;

namespace KutuphaneUygulamasi
{
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane2024.db;Version=3;");

        public void tumunuListele()
        {
            baglanti.Open();
            string sql = "select * from kitaplar";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "turler");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            int i = 0;
            foreach (string x in alanlarEtiketleri)
            {
                dataGridView1.Columns[i].HeaderText = x;
                i++;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kitapListele_Load(object sender, EventArgs e)
        {
            tumunuListele();
            comboBox1.SelectedIndex = 1;
        }
        string[] alanlar = { "id", "kitapAd", "yazar", "tur", "icindekiler", "yer", "durum" };
        string[] alanlarEtiketleri = { "id", "Kitap Adı", "Yazarı", "Türü", "İçindekiler", "Yeri", "Durumu", "Resmi" };

        private void button1_Click(object sender, EventArgs e)
        {
            string arananAlan = alanlar[comboBox1.SelectedIndex];
            string arananVeri = textBox1.Text;
            AraListele(arananAlan, arananVeri);
        }

        private void AraListele(string aAlan, string aVeri)
        {
            baglanti.Open();
            string sql = "select * from kitaplar where " + aAlan + " like '" + aVeri + "%'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "turler");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            int i = 0;
            foreach (string x in alanlarEtiketleri)
            {
                dataGridView1.Columns[i].HeaderText = x;
                i++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label3.Text == "") return;
            kitapDuzenleForm frm_6 = new kitapDuzenleForm(label3.Text,"kitapListele");
            frm_6.MdiParent = this.MdiParent;
            frm_6.Show();

        }
    }
}
