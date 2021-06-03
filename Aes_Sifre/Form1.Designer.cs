namespace Aes_Sifre
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_sifrele = new System.Windows.Forms.RichTextBox();
            this.txt_sifrecoz = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_huffman = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dosyasec = new System.Windows.Forms.Button();
            this.girilenmetin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_sifrele
            // 
            this.txt_sifrele.Location = new System.Drawing.Point(24, 98);
            this.txt_sifrele.Name = "txt_sifrele";
            this.txt_sifrele.Size = new System.Drawing.Size(226, 146);
            this.txt_sifrele.TabIndex = 0;
            this.txt_sifrele.Text = "";
            this.txt_sifrele.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txt_sifrecoz
            // 
            this.txt_sifrecoz.Location = new System.Drawing.Point(256, 98);
            this.txt_sifrecoz.Name = "txt_sifrecoz";
            this.txt_sifrecoz.Size = new System.Drawing.Size(225, 137);
            this.txt_sifrecoz.TabIndex = 1;
            this.txt_sifrecoz.Text = "";
            this.txt_sifrecoz.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Şifrele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "ŞifreÇöz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gizli Metin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Huffman";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_huffman
            // 
            this.txt_huffman.Location = new System.Drawing.Point(516, 98);
            this.txt_huffman.Name = "txt_huffman";
            this.txt_huffman.Size = new System.Drawing.Size(258, 146);
            this.txt_huffman.TabIndex = 10;
            this.txt_huffman.Text = "";
            this.txt_huffman.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyasec
            // 
            this.dosyasec.Location = new System.Drawing.Point(557, 9);
            this.dosyasec.Name = "dosyasec";
            this.dosyasec.Size = new System.Drawing.Size(78, 31);
            this.dosyasec.TabIndex = 12;
            this.dosyasec.Text = "Dosya Seç";
            this.dosyasec.UseVisualStyleBackColor = true;
            this.dosyasec.Click += new System.EventHandler(this.dosyasec_Click);
            // 
            // girilenmetin
            // 
            this.girilenmetin.Location = new System.Drawing.Point(89, 9);
            this.girilenmetin.Name = "girilenmetin";
            this.girilenmetin.Size = new System.Drawing.Size(419, 43);
            this.girilenmetin.TabIndex = 13;
            this.girilenmetin.Text = "";
            this.girilenmetin.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girilenmetin);
            this.Controls.Add(this.dosyasec);
            this.Controls.Add(this.txt_huffman);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_sifrecoz);
            this.Controls.Add(this.txt_sifrele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_sifrele;
        private System.Windows.Forms.RichTextBox txt_sifrecoz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt_huffman;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button dosyasec;
        private System.Windows.Forms.RichTextBox girilenmetin;
    }
}

