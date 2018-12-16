using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox1.Text!="")
            {
                int[] sayilar = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    sayilar[i] = i * 5;
                    richTextBox1.Text += sayilar[i] + " ";
                }
                int a = int.Parse(textBox1.Text);
                bool varyok = false;
                for (int j = 0; j < 100; j++)
                {
                    if (a == sayilar[j])
                    {
                        varyok = true;

                    }
                }
                if (varyok = true)
                {
                    MessageBox.Show("bul_un_du._._._");
                }
            }
        }
    }
}
