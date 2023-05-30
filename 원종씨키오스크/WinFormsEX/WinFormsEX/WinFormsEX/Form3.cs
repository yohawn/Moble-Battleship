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



    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            FormClosed += Form3_FormClosed;

            Label label = new Label()
            {
                Text = "글자",
                Location = new Point(10, 10),
            };
            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "글자",
                Location = new Point(10, 50),
            };
            linkLabel.Click += LabelClick;

            Controls.Add(label);
            Controls.Add(linkLabel);


            


            checkBox1.Text = "감자";
            checkBox2.Text = "고구마";
            checkBox3.Text = "토마토";
            

            
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            





        }
       private void LabelClick(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("explorer.exe", "http://naver.com");

}
       


private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            System.Text.StringBuilder messageBoxcs = new System.Text.StringBuilder();
            messageBoxcs.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxcs.AppendLine();
            MessageBox.Show(messageBoxcs.ToString(), "FormClosing Event");

}
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
 
            //textBox1.Text += "-";
            //label1.Text += "-";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //textBox1.Text += "+";
            //label1.Text += "+";
        }

       
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
                elapsedTime++;
                textBox1.Text = elapsedTime + "초 경과";
                label1.Text = elapsedTime + "초 경과";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            foreach(var item in Controls)
            {
                if(item is CheckBox){
                    CheckBox checkBox = (CheckBox)item;
                if(checkBox.Checked){  
                        list.Add(checkBox.Text);
                    }
                }
            }
            MessageBox.Show(string.Join(",", list));
        }
    }
}
