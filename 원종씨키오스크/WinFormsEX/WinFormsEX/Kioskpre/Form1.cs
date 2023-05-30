using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Kioskpre
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int price = 0;
        int counterpython = 0;
        int countercshap = 0;
        int countercpp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            counterpython++;
            Counter.Text = $"수량 : {counter}";
            price += 19800;
            Price.Text = $"가격 : {price}";
            pythonsaurce.Text = $"Python 19800원: {counterpython}개";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            countercshap++;
            Counter.Text = $"수량 : {counter}";
            price += 24300;
            Price.Text = $"가격 : {price}";
            csharpsaurce.Text = $"c# 24300원 :{countercshap}개";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter++;
            countercpp++;
            Counter.Text = $"수량 : {counter}";
            price += 18000;
            Price.Text = $"가격 : {price}";
            cppsaurce.Text = $"c++ 18000원 : {countercpp}개";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pydelete_Click(object sender, EventArgs e)
        {
            if (counterpython > 0)
            {
                counter--;
                counterpython--;
                Counter.Text = $"수량 : {counter}";
                price -= 19800;
                Price.Text = $"가격 : {price}";
                pythonsaurce.Text = $"Python 19800원: {counterpython}개";
            }
            else
                pythonsaurce.Text = "취소 할 수 있는 상품이없습니다.";
        }

        private void csdelete_Click(object sender, EventArgs e)
        {
            if (countercshap > 0)
            {
                counter--;
                countercshap--;
                Counter.Text = $"수량 : {counter}";
                price -= 24300;
                Price.Text = $"가격 : {price}";
                csharpsaurce.Text = $"c# 24300원 :{countercshap}개";
            }
            else
                csharpsaurce.Text = "취소 할 수 있는 상품이없습니다.";
        }

        private void cppdelete_Click(object sender, EventArgs e)
        {
            if (countercpp > 0)
            {
                counter--;
                countercpp--;
                Counter.Text = $"수량 : {counter}";
                price -= 18000;
                Price.Text = $"가격 : {price}";
                cppsaurce.Text = $"c++ 18000원 : {countercpp}개";
            }
            else
                cppsaurce.Text = "취소 할 수 있는 상품이없습니다.";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            counter = 0;
            price = 0;
            counterpython = 0;
            countercshap = 0;
            countercpp = 0;
            pythonsaurce.Text = $"Python 19800원: {counterpython}개";
            cppsaurce.Text = $"c++ 18000원 : {countercpp}개";
            csharpsaurce.Text = $"c# 24300원 :{countercshap}개";
            Price.Text = $"가격 : {price}";
            Counter.Text = $"수량 : {counter}";



        }

        private void bill_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"가격 : {price},수량 : {counter} 결제 하시겠습니까?");
            if (dialog == DialogResult.OK) {
                MessageBox.Show("결제되었습니다.");
                counter = 0;
                price = 0;
                counterpython = 0;
                countercshap = 0;
                countercpp = 0;
                pythonsaurce.Text = $"Python 19800원: {counterpython}개";
                cppsaurce.Text = $"c++ 18000원 : {countercpp}개";
                csharpsaurce.Text = $"c# 24300원 :{countercshap}개";
                Price.Text = $"가격 : {price}";
                Counter.Text = $"수량 : {counter}";
            }
        }
    }
}
