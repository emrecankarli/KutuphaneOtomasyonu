namespace KutuphaneUygulamasi
{
    partial class kitapListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 149);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 115);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 6;
            label4.Text = "Seçilen Kitap İd:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 115);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 61);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 4;
            label2.Text = "Aranan Veri";
            // 
            // button1
            // 
            button1.Location = new Point(488, 27);
            button1.Name = "button1";
            button1.Size = new Size(105, 56);
            button1.TabIndex = 3;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 2;
            label1.Text = "Aranacak Alan";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(130, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 25);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "id", "Kitap Adı", "Yazarı", "Türü", "İçindekiler", "Yeri", "Durum" });
            comboBox1.Location = new Point(130, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(352, 25);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(724, 301);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem, silToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(181, 70);
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(180, 22);
            düzenleToolStripMenuItem.Text = "Düzenle";
            düzenleToolStripMenuItem.Click += düzenleToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(180, 22);
            silToolStripMenuItem.Text = "Sil";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // kitapListele
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(724, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "kitapListele";
            Text = "kitapListele";
            Load += kitapListele_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}