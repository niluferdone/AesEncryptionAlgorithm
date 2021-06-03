using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aes_Sifre
{
    public partial class Form1 : Form
    {
        public string DosyaYolu, DosyaAdi,metnimiz;

        private int leafNodes;
        public Form1()
        {
            InitializeComponent();
        }
        AesSifreleveCoz AES_ogrenme = new AesSifreleveCoz();

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InorderTraversal(BinaryTreeNode<CharFreq> node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);

                CharFreq cf = node.Value;
                int ord = (int)cf.ch;

                if (node.Left == null && node.Right == null)
                {
                    leafNodes++;
                    txt_huffman.Text += "'" + new string(cf.ch, 1) + "' ";
                    txt_huffman.Text += node.Value.freq.ToString() + "\r\n";
                }

                InorderTraversal(node.Right);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt_sifrele.Text = AES_ogrenme.aesSifreleme(txt_huffman.Text);

            string pathaes = @"C:\Users\Nilüfer\Desktop\tez\aessifrele.txt";
            using (var tw = new StreamWriter(pathaes, true))
            {
                tw.WriteLine(txt_sifrele.Text);
                tw.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //txt_sifrecoz.Text = AES_ogrenme.AesSifre_Coz(txt_sifrele.Text);
            txt_sifrecoz.Text = girilenmetin.Text;
            string pathcoz = @"C:\Users\Nilüfer\Desktop\tez\aessifrecoz.txt";
            using (var tw = new StreamWriter(pathcoz, true))
            {
                tw.WriteLine(txt_sifrecoz.Text);
                tw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = girilenmetin.Text;
            int n = s.Length;
            List<CharFreq> list = new List<CharFreq>();

            txt_huffman.Text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                bool found = false;
                char c = s[i];
                CharFreq cf = new CharFreq();

                for (int j = 0; !found && j < list.Count; j++)
                {
                    if (c == list[j].ch)
                    {
                        found = true;
                        cf.ch = c;
                        cf.freq = 1 + list[j].freq;
                        list.RemoveAt(j);
                        list.Add(cf);
                    }
                }

                if (!found)
                {
                    cf.ch = c;
                    cf.freq = 1;
                    list.Add(cf);
                }
            }
            HuffmanTree ht = new HuffmanTree();
            BinaryTreeNode<CharFreq> root = ht.Build(list, list.Count);

            InorderTraversal(root);
            txt_huffman.Text += "\r\n# characters = " + n.ToString() + "\r\n";
            txt_huffman.Text += "# leaf nodes = " + leafNodes.ToString() + "\r\n";
            txt_huffman.Text += "% compressed = " +
                (100.0 - 100.0 * ((double)leafNodes) / n).ToString("F2") + "\r\n";


            string pathhuf = @"C:\Users\Nilüfer\Desktop\tez\huffman.txt";
            using (var tw = new StreamWriter(pathhuf, true))
            {
                tw.WriteLine(txt_huffman.Text);
                tw.Close();
            }



        }
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dosyasec_Click(object sender, EventArgs e)
        {            

        OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\Users\\Nilüfer\\Desktop";

            file.Filter = "Txt Dosyası |*.txt";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.ShowDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {

                string DosyaYolu = file.FileName;
                 string DosyaAdi = file.SafeFileName;
                Console.WriteLine(DosyaYolu);


                string metnimiz = File.ReadAllText(file.FileName);
                Console.WriteLine(metnimiz);
                girilenmetin.Multiline = true;
                girilenmetin.ScrollBars = RichTextBoxScrollBars.Vertical;
          
                girilenmetin.Text = File.ReadAllText(file.FileName);

                


            }

          
            
          
           
        }
    }
}
