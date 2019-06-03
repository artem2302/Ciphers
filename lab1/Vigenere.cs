using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Vigenere : Form
    {
        String alphabet, initStr, key, encryptedStr;
        public Vigenere()
        {
            InitializeComponent();
            openFileDialog1.FileName = "Document"; 
            openFileDialog1.DefaultExt = ".txt"; 
            openFileDialog1.Filter = "Text documents (.txt)|*.txt";
            alphabet = "";
            initStr = "";
            key = "";
        }

        private void btnLoadAlphabet_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                alphabet = sr.ReadToEnd();
                MessageBox.Show("Alphabet loaded!"+alphabet);
                sr.Close();
            }
        }

        private void Vigenere_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnFileToEncode_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                initStr = sr.ReadToEnd();
                MessageBox.Show("Text loaded!" + initStr);
                sr.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void btnKeyFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                key = sr.ReadToEnd();
                MessageBox.Show("Text loaded!" + key);
                sr.Close();
            }
        }
        private String doVigenere(String from, String to, bool encrypt)
        {
            if (alphabet == "" ||  initStr == "" || key == "")
            {
                MessageBox.Show("Lacking input files");
                return null;
            }
            String res = "";
            
            for (int i = 0; i<from.Length; ++i)
            {
                int index = 0;
                if (encrypt)
                {
                    index = (alphabet.IndexOf(from[i]) + alphabet.IndexOf(key[i])) % alphabet.Length;
                }
                else
                {     
                    index =(alphabet.IndexOf(from[i]) - alphabet.IndexOf(key[i])) % alphabet.Length;
                    if (index < 0) index += alphabet.Length;
                }
                char c = alphabet.ElementAt(index);
                res += c;
            }

            return res;
        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            while (key.Length < initStr.Length)
                key += key;           
        
            if (radioButton1.Checked)
                encryptedStr = doVigenere(initStr, encryptedStr, true);
            else
                encryptedStr = doVigenere(initStr, encryptedStr, false);

            //  MessageBox.Show(encryptedStr);
            if (encryptedStr == null) return;
            textBox1.Text = encryptedStr;
            encryptedStr = "";
        }
    }
}
