using System;
using System.Windows.Forms;
using System.Drawing;


namespace simplewinform
{

    class MessageFilter :IMessageFilter
    {
    public bool PreFilterMessage(ref Message m){
                if (m.Msg == 0x0F || m.Msg == 0xA0 || m.Msg == 0x200 || m.Msg == 0x113)
                    return false;
                Console.WriteLine($"{m.ToString()}:{m.Msg}");

                if (m.Msg == 0x201)
                    Application.Exit();

                return true;
            }
        }

    internal class Program : System.Windows.Forms.Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X:{e.X},Y :{e.Y}");
            Console.WriteLine($"Button :{e.Button},Clicks:{e.Clicks}");
            Console.WriteLine();        
        }
        //public Program(string title) { this.Text = title; this.MouseDown += new MouseEventHandler(MyMouseHandler); }

        Random rand;
        public Program(){
            rand = new Random();
            this.MouseWheel += new MouseEventHandler(MainBack_MouseWheel);
            this.MouseDown += new MouseEventHandler(MainBack_MouseDown);
        }

        void MainBack_MouseDown(object sender, MouseEventArgs e){
        if(e.Button == MouseButtons.Left){
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255),rand.Next(0, 255));
            }
        else if(e.Button == MouseButtons.Right)
        {       
            if(this.BackgroundImage != null)
            {
                        this.BackgroundImage = null;
                        return;
                    }
                    string file = "C:\\Mb_lwj\\c#\\WinFormsEX\\WinFormsEX\\bin\\Debug\\net6.0-windows\\blue_bird.jpg";
                
                    if (System.IO.File.Exists(file) == false)
                        MessageBox.Show("이미지 파일이 없습니다");
                    else
                        this.BackgroundImage = Image.FromFile(file);

                }


        }
        void MainBack_MouseWheel(object sender, MouseEventArgs e) {
            this.Opacity = (this.Opacity + (e.Delta > 0 ? 0.1 : -0.1))>0.1 ? (this.Opacity + (e.Delta > 0 ? 0.1 : -0.1)) : 0.1;
           
            Console.WriteLine($"Opacity :{this.Opacity}");
        }





        static void Main(string[] args)
        {
            //System.Windows.Forms.Application.Run(new Program());
            //Program form = new Program();
            //form.Click += new EventHandler((sender, EventArgs) => { Console.WriteLine("Closing Window..."); Application.Exit(); });
            //Console.WriteLine("Starting Window Application");
            //Application.Run(form);
            //Console.WriteLine("Exiting Window Applicarion");

            //Application.AddMessageFilter(new MessageFilter());
            //Application.Run(new Program());

            // Application.Run(new Program("Mouse Event Test"));
            //Application.Run(new Program());

            Button button = new Button();
            button.Text = "Click Me";
            button.Left = 100;
            button.Top = 50;

            button.Click += (object sender, EventArgs e) => { MessageBox.Show("딸깍"); };
            Program form = new Program();
            form.Text = "Form & Control";
            form.Height = 150;
            form.Controls.Add(button);
            Application.Run(form);



        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.Load += new System.EventHandler(this.Program_Load);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Font = new System.Drawing.Font("바탕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }
    }
}
