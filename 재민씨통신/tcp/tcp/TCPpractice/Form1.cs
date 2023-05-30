using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
//using System.Net.Sockets.TcpClient;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Globalization;
//using System.Xml.Schema;
//using System.Runtime.Remoting.Channels;

namespace TCPpractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = Fillip();
           
            Random random = new Random();  //렌덤 으로 정하는 코드
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sendmapdata[i, j] = random.Next(0, 2);
                    textBox3.Text += sendmapdata[i, j] + "/";
                }
            }

        }
        StreamReader streamReader1;
        StreamWriter streamWriter1;
        int thismode = 0;
        TcpClient tcpClient1 = new TcpClient();  //새로운 클라이언트 입성

        int[,] sendmapdata = new int[2,2];  //2X2행력
        string enemymapdata;
        int[,] enemyfielddata = new int[2, 2];

        private void button1_Click(object sender, EventArgs e)//연결하기 버튼클릭
        {
            Thread thread1 = new Thread(connect); //thread 객체 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨
            thread1.IsBackground = true; //Form이 종료되면  thread1 도 종료
            thread1.Start(); //thread1 시작 
        }
        string Fillip()//? //자기 ip불러오는거
        {
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());

            string ipadress = "";

            foreach (var address in localip)   //foreach 문
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipadress = address.ToString();
                }
            }
            return ipadress;
        }

        //TCP/IP 네트워크 통신코드
        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            //TcpClient tcpClient1 = new TcpClient();  // TcpClient 객체 생성
            TcpListener tcpListener1 = new TcpListener(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
            if (thismode == 0) //서버로 접속
            {
                //TcpListener tcpListener1 = new TcpListener(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text)); // 서버 객체 생성 및 IP주소와 Port번호를 할당
                tcpListener1.Start();  // 서버 시작
                writeRichBox("서버 준비...클라이언트 기다리는 중...");

                tcpClient1 = tcpListener1.AcceptTcpClient(); // 클라이언트 접속 확인
                writeRichBox("클라이언트 연결됨...");
            }
            else if (thismode == 1) //클라이언트로 접속
            {
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));  // IP주소와 Port번호를 할당
                tcpClient1.Connect(ipEnd);  // 서버에 연결 요청
                writeRichBox("서버 연결됨...");
            }
            streamReader1 = new StreamReader(tcpClient1.GetStream());  // 읽기 스트림 연결
            streamWriter1 = new StreamWriter(tcpClient1.GetStream());  // 쓰기 스트림 연결
            streamWriter1.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..

            while (tcpClient1.Connected)  // 클라이언트가 연결되어 있는 동안
            {
                string receiveData1 = streamReader1.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장
                writeRichBox(receiveData1); // 데이타를 수신창에 쓰기
            }
        }

        private void writeRichBox(string text)
        {
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText(text + " / "); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함. / 슬래쉬
            //richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.ScrollToCaret(); });  // 스크롤을 젤 밑으로.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sendData1 = textBox3.Text;  // testBox3 의 내용을 sendData1 변수에 저장
            streamWriter1.WriteLine(sendData1);  // 스트림라이터를 통해 데이타를 전송
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (thismode == 0)
            {
                thismode = 1;
                button3.Text = "손님";  //클라이언트
            }
            else if (thismode == 1)
            {
                thismode = 0;
                button3.Text = "주인";  //주인 
            }
        }
        private void Disconnect()
        {
            tcpClient1.Close();
        }
        
        private void Reconnect()
        {
            TcpClient newclient = new TcpClient();
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));  // IP주소와 Port번호를 할당
            newclient.Connect(ipEnd);  // 서버에 연결 요청
            tcpClient1= newclient;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //    this.Close();
            //} 
            if (thismode == 1)
            {
                if (tcpClient1 != null && tcpClient1 != null)
                {
                    tcpClient1.Dispose();
                }
            }
        }

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (thismode == 1)
        //    {
        //        //Server.client.Close();
        //        Server.client.Dispose();
        //        Server.client = null;

        //        //Server.listener.Stop();
        //        Server.listener = null;

        //        Environment.Exit(1);
        //    }
        //}
    }
}