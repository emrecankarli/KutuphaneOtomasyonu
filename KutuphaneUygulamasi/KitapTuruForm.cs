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
using System.Data.SqlClient;

namespace KutuphaneUygulamasi
{
    public partial class KitapTuruForm : Form
    {
        public KitapTuruForm()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane2024.db;Version=3;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select * from turler";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "turler");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void KitapTuruForm_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            baglanti.Open();
            string sql = "insert into turler (turAdi,aciklama) values(@t1,@t2)";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.AddWithValue("t1", textBox1.Text);
            komut.Parameters.AddWithValue("t2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "") return;
            baglanti.Open();
            string sql = "update turler set turAdi=@t1, aciklama=@t2 where id=" + int.Parse(label3.Text);
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.AddWithValue("t1", textBox1.Text);
            komut.Parameters.AddWithValue("t2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            button1.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "") return;
            baglanti.Open();
            string sql = "delete from turler where id=" + int.Parse(label3.Text);
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.AddWithValue("t1", textBox1.Text);
            komut.Parameters.AddWithValue("t2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            button1.PerformClick();
        }
    }
}
