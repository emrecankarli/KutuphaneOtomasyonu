namespace KutuphaneUygulamasi
{
    partial class kitapEkleForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Yazarı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 101);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 2;
            label3.Text = "Türü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 134);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 3;
            label4.Text = "İçindekiler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 253);
            label5.Name = "label5";
            label5.Size = new Size(30, 17);
            label5.TabIndex = 4;
            label5.Text = "Yeri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 287);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 5;
            label6.Text = "Durum";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 25);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 25);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 25);
            comboBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 130);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 114);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 25);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 281);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(295, 25);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(451, 325);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(98, 25);
            textBox6.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(451, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 207);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(279, 325);
            button1.Name = "button1";
            button1.Size = new Size(142, 49);
            button1.TabIndex = 14;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(451, 31);
            button2.Name = "button2";
            button2.Size = new Size(171, 54);
            button2.TabIndex = 15;
            button2.Text = "Resim Seç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPG Dosya (*.jpg)|*.jpg|PNG Dosya (*.png)|*.png";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("0xProto Nerd Font Propo", 9.749999F, FontStyle.Bold);
            button3.Location = new Point(388, 97);
            button3.Name = "button3";
            button3.Size = new Size(37, 23);
            button3.TabIndex = 16;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(131, 325);
            button4.Name = "button4";
            button4.Size = new Size(142, 49);
            button4.TabIndex = 17;
            button4.Text = "Temizle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // kitapEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 386);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
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
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "kitapEkleForm";
            Text = "kitapEkleForm";
            Activated += kitapEkleForm_Activated;
            Load += kitapEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Button button4;
    }
}