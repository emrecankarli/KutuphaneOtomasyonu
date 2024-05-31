namespace KutuphaneUygulamasi
{
    partial class kitapDuzenleForm
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("0xProto Nerd Font Propo", 9.749999F, FontStyle.Bold);
            button3.Location = new Point(366, 75);
            button3.Name = "button3";
            button3.Size = new Size(37, 23);
            button3.TabIndex = 34;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(429, 9);
            button2.Name = "button2";
            button2.Size = new Size(171, 54);
            button2.TabIndex = 33;
            button2.Text = "Resim Seç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(263, 303);
            button1.Name = "button1";
            button1.Size = new Size(136, 49);
            button1.TabIndex = 32;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(429, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 207);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(429, 303);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(98, 23);
            textBox6.TabIndex = 30;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 23);
            textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 108);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 114);
            textBox3.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 23);
            comboBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 265);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 23;
            label6.Text = "Durum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 22;
            label5.Text = "Yeri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 21;
            label4.Text = "İçindekiler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 20;
            label3.Text = "Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 19;
            label2.Text = "Yazarı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 18;
            label1.Text = "Kitap Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 320);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 35;
            label7.Text = "label7";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kütüphanede", "Arşivde" });
            comboBox2.Location = new Point(108, 257);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(295, 23);
            comboBox2.TabIndex = 36;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPG Dosya (*.jpg)|*.jpg|PNG Dosya (*.png)|*.png";
            // 
            // kitapDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 370);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "kitapDuzenleForm";
            Text = "kitapDuzenleForm";
            Load += kitapDuzenleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox comboBox2;
        private OpenFileDialog openFileDialog1;
    }
}