using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cypher
{
    public partial class Form1 : Form
    {
        ReversalCipher ett = new ReversalCipher();

        CeasarChipher två = new CeasarChipher(1);
        
        
        public Form1()
        {
            InitializeComponent();
        }



        private void Encrypt_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;
            if (count == 1)
            {
                Encrypt.Enabled = false;
            }
            textBox1.Text = två.Encrypt(textBox1.Text);


      
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;
            if (count == 1)
            {
                Decrypt.Enabled = false;
            }
            textBox1.Text = två.Decrypt(textBox1.Text);
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
