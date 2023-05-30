using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEX
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            RadioButton radio4 = new RadioButton();
            RadioButton radio5 = new RadioButton();

            radio4.Text = "오이";
            radio5.Text = "배추";

            radio5.Location = new Point(10, 100);
            radio4.Location = new Point(10, 130);

            Controls.Add(radio5);
            Controls.Add(radio4);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radio4);
            groupBox1.Controls.Add(radio5);



        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    foreach(var item in Controls)
                    {
                    if(item is RadioButton)
                    {
                        RadioButton radiobutton = (RadioButton)item;
                        if(radiobutton.Checked)
                    {
                        MessageBox.Show(radiobutton.Text);
                    }
                    
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
