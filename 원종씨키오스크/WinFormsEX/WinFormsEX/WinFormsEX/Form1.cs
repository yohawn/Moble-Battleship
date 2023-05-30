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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyButton.Width = 150;
            MyButton.Height = 50;
            Button button = new Button();
            Controls.Add(button);
            button.Location = new Point(50,50);
            button.Height = 30;
            button.Width = 130;
            button.Text = "2번째 버튼";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyButton.Text = "코드에서 변경:";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
