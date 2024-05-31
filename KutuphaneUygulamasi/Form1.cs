using System.Data.SQLite;

namespace KutuphaneUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //giriþ butonu
            //string yol=System.Windows.Forms.Application.StartupPath;

            SQLiteConnection bag = new SQLiteConnection("Data Source=kutuphane2024.db;Version=3;");
            bag.Open();
            string sql = "select * from kullanicilar where kullaniciAdi=@t1 or id=@t1 and sifre=@t2";
            SQLiteCommand komut = new SQLiteCommand(bag);
            komut.CommandText = sql;
            komut.Parameters.AddWithValue("t1", textBox1.Text);
            komut.Parameters.AddWithValue("t2", textBox2.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anaForm aForm = new anaForm();
                aForm.Show();
                this.Hide();
                aForm.toolStripStatusLabel2.Text = dr[1].ToString();
            }
            else
                label3.Text = "Kayýt Yok";

            dr.Close();
            bag.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
