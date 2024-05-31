using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

        private void bilgilerimiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciForm frm3 = new KullaniciForm();
            frm3.kim = toolStripStatusLabel2.Text;
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void anaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapTuruForm frm4 = new KitapTuruForm();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapEkleForm frm5 = new kitapEkleForm();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void araSilDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapListele frm6 = new kitapListele();
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void düzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uyelerForm frm7 = new uyelerForm();
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void kitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oduncVerAl frm8 = new oduncVerAl();
            frm8.MdiParent = this;
            frm8.Show();
        }
    }
}
