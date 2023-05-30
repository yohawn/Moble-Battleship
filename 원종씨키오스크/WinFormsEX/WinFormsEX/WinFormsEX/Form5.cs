using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsEX
{
  
    public partial class Form5 : Form
    {

        private bool opFlag = false;
        private bool memFlag = false;

        public Form5()
        {
            InitializeComponent();
            txtResult.Text = "0";

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        
        // 연산된 값
        double result = 0;
        // 현재 진행중인 연산을 나타내기 위해
        char op = '0'; // +, -, *, /
        // 메모리
        double memory = 0;

        // 0~9
        private void btnNumber_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (txtResult.Text == "0" || opFlag == true || memFlag == true)
            {
                txtResult.Text = btn.Text;
                opFlag = false;
                memFlag = false;
            }
            else
                txtResult.Text = txtResult.Text + btn.Text;


            double v = Double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);
        }

        // 소수점 처리
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";
        }

        // 3자리마다 쉼표 삽입   
        private static string commaProcedure(double v, string s)
        {
            int pos = 0;
            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');	// 소수점 아래 자리수 + 1
              if (pos == 1)   // 맨 뒤에 소수점이 있으면 그대로 리턴
                    return s;
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;
        }

        // MC memory clear 저장된 메모리 지움
        private void button1_Click(object sender, EventArgs e)
        {
            memory = 0;
            memFlag = true;
        }

        // MR memory recall 저장된 메모리 읽어옴
        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(memory);
            memFlag = true;
        }

        // MS memory save 메모리 저장
        private void button3_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(txtResult.Text);
            memFlag = true;
        }

        // M+ memory + 메모리에 저장된 수에서 현재 화면에 있는 수 더함
        private void button4_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtResult.Text);
            memory += num;
            memFlag = true;
        }

        //M- memory - 메모리에 저장된 수에서 현재 화면에 있는 수 뺌
        private void button5_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtResult.Text);
            memory -= num;
            memFlag = true;
        }

        // <-- backspace
        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }

        // CE clear entry 마지막 입력을 지운다 (계산 후 결과값에서 누르면 C나 AC와 같은 결과)
        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            if (op == '0')
            {
                opFlag = true;
            }
        }

        // C clear 모든 계산을 지운다
        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            result = 0;
            opFlag = true;
        }

        // ±
        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(Convert.ToDouble(txtResult.Text) * -1);
        }

        // √
        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(txtResult.Text), 0.5));
        }

        // %
        private void button15_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(Convert.ToDouble(txtResult.Text) / 100);
        }

        // 1/x
        private void button20_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtResult.Text);
            num = 1 / num;
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);
        }

        // /
        private void button14_Click(object sender, EventArgs e)
        {
            // 텍스트를 double형의 숫자로 변환
            double num = Convert.ToDouble(txtResult.Text);
            // 이전에 기록된 연산이 있다면 수행
            if (op == '0')
            {
                result = num;
                double v = Double.Parse(txtResult.Text);
                txtResult.Text = commaProcedure(v, txtResult.Text);
                opFlag = true;
            }
            else
            {
                button28_Click(sender, e); // = 수행
            }
            op = '/';
        }

        // *
        private void button19_Click(object sender, EventArgs e)
        {
            // 텍스트를 double형의 숫자로 변환
            double num = Convert.ToDouble(txtResult.Text);
            // 이전에 기록된 연산이 있다면 수행
            if (op == '0')
            {
                result = num;
               
                double v = Double.Parse(txtResult.Text);
                txtResult.Text = commaProcedure(v, txtResult.Text);
                opFlag = true;
            }
            else
            {
                button28_Click(sender, e); // = 수행
            }
            op = '*';
        }

        // -
        private void button24_Click(object sender, EventArgs e)
        {
            // 텍스트를 double형의 숫자로 변환
            double num = Convert.ToDouble(txtResult.Text);
            // 이전에 기록된 연산이 있다면 수행
            if (op == '0')
            {
                result = num;
                
                double v = Double.Parse(txtResult.Text);
                txtResult.Text = commaProcedure(v, txtResult.Text);
                opFlag = true;
            }
            else
            {
                button28_Click(sender, e); // = 수행
            }
            op = '-';
        }

        // +
        private void button26_Click(object sender, EventArgs e)
        {
            // 텍스트를 double형의 숫자로 변환
            double num = Convert.ToDouble(txtResult.Text);
            // 이전에 기록된 연산이 있다면 수행
            if (op == '0')
            {
                result = num;
                
                double v = Double.Parse(txtResult.Text);
                txtResult.Text = commaProcedure(v, txtResult.Text);
                opFlag = true;
            }
            else
            {
                button28_Click(sender, e); // = 수행
            }
            op = '+';
        }

        // =
        private void button28_Click(object sender, EventArgs e)
        {
            // 텍스트를 double형의 숫자로 변환
            double num = Convert.ToDouble(txtResult.Text);
            // 연산을 수행
            switch (op)
            {
                case '+':
                    result += num;
                    break;
                case '-':
                    result -= num;
                    break;
                case '*':
                    result *= num;
                    break;
                case '/':
                    result /= num;
                    break;
            }
            txtResult.Text = Convert.ToString(result);
            opFlag = true;
            op = '0';


            double v = Double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);

            
        }

        // .
        private void button25_Click(object sender, EventArgs e)
        {
            // 아무것도 입력이 되지 않은 상태에서 소수점 버튼을 누르면
            if (opFlag == true)
            {
                txtResult.Text = "0.";
                opFlag = false;
            }
            else if (txtResult.Text.Contains(".") == false) // 이전에 소수점이 한 번도 사용되지 않았을 경우
            {
                txtResult.Text += ".";
            }
        }

    


    }
}
