namespace KutuphaneUygulamasi
{
    partial class KitapTuruForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 222);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(281, 150);
            button1.Name = "button1";
            button1.Size = new Size(81, 30);
            button1.TabIndex = 1;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 2;
            label1.Text = "Tür Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 3;
            label2.Text = "Açıklama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 58);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 86);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(107, 150);
            button2.Name = "button2";
            button2.Size = new Size(81, 30);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(20, 150);
            button3.Name = "button3";
            button3.Size = new Size(81, 30);
            button3.TabIndex = 7;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(194, 150);
            button4.Name = "button4";
            button4.Size = new Size(81, 30);
            button4.TabIndex = 8;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 38);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 9;
            // 
            // KitapTuruForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 420);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "KitapTuruForm";
            Text = "KitapTuruForm";
            Load += KitapTuruForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}