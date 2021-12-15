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
        Samlingsklass allaCiphers;

        Samlingsklass användaCiphers = new Samlingsklass();

        int count = 0;

        /// <summary>
        /// Anger namn och lägger till de olika chifferna i allaCiphers.
        /// </summary>
        public Form1()
        {
            allaCiphers = new Samlingsklass();
            allaCiphers.AddItems(new Rövarspråket("RövarSpråket"));
            allaCiphers.AddItems(new OddAndEvenCipher("OddAndEvenCipher"));
            allaCiphers.AddItems(new CaesarCipher(2, "CaesarCipher2Steps"));
            allaCiphers.AddItems(new ReversalCipher("ReversalCipher"));

            InitializeComponent();
            UpdateList();
            Decrypt.Enabled = false;
        }

        public void UpdateList()
        {
            listBox1.DataSource = allaCiphers.SamladLista;
        }
        private void Encrypt_Click(object sender, EventArgs e)
        {
            textBox1.Text = användaCiphers.Encrypt(textBox1.Text);
            Encrypt.Enabled = false;
            Decrypt.Enabled = true;
            AddCipher.Enabled = false;
            textBox1.ReadOnly = true;
            count++;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            textBox1.Text = användaCiphers.Decrypt(textBox1.Text);
            textBox1.ReadOnly = false;
            Encrypt.Enabled = true;
            Decrypt.Enabled = false;
            AddCipher.Enabled = true;
            count--;
        }

        private void AddCipher_Click(object sender, EventArgs e)
        {            
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    användaCiphers.AddItems((Cipher)(listBox1.SelectedItem));
                    listBox2.Items.Add(listBox1.SelectedItem);
                    
                    Encrypt.Enabled = true;
                    RemoveCipher.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void RemoveCipher_Click(object sender, EventArgs e)
        {
            try
            {
                if(count == 1)
                {
                    textBox1.Text = användaCiphers.Decrypt(textBox1.Text);
                    användaCiphers.RemoveItems((Cipher)listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                    textBox1.Text = användaCiphers.Encrypt(textBox1.Text);
                    Encrypt.Enabled = false;
                    Decrypt.Enabled = true;
                    if(listBox2.Items.Count == 0)
                    {
                        Encrypt.Enabled = true;
                        Decrypt.Enabled = false;
                        AddCipher.Enabled = true;
                        RemoveCipher.Enabled = false;
                        textBox1.ReadOnly = false;
                        count = 0;
                    }
                }
                else
                {
                    användaCiphers.RemoveItems((Cipher)listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
