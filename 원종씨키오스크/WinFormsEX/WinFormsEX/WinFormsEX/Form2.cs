using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            int width = 150;
            int height = 30;
            int margin = 4;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
                button.Text = "동적생성" + i + "번째";
                button.Width = width;
                button.Height = height;
            }
        }
        //Bitmap bit;
        //protected override void OnLoad(EventArgs e)
        //{
        //    bit = new Bitmap("blackhole.gif");
        //    ImageAnimator.Animate(bit, new EventHandler(this.Form2_Load));
        //    base.OnLoad(e);
        //}
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    ImageAnimator.UpdateFrames();
        //    Graphics g = pictureBox1.CreateGraphics();
        //    g.DrawImage(this.bit, new Point(0, 0));
        //    base.OnPaint(e);
        //}

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            string imagepath = "blackhole.gif";
            pictureBox1.Image = Image.FromFile(imagepath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
