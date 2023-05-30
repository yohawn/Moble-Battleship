using kiosk.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form1 : Form
    {

        private Control control = null;
        private KioskRepository repository = new KioskRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void hamburger_Click(object sender, EventArgs e)
        {
            if (control != null) panel2.Controls.Remove(control);
            control = new HambergerForm(added, price, counter);
            panel2.Controls.Add(control);
        }

        private void side_Click(object sender, EventArgs e)
        {
            if (control != null) panel2.Controls.Remove(control);
            control = new SideForm(added, price, counter);
            panel2.Controls.Add(control);
        }

        private void drinks_Click(object sender, EventArgs e)
        {
            if (control != null) panel2.Controls.Remove(control);
            control = new DrinksForm(added, price, counter);
            panel2.Controls.Add(control);
        }
        private void bill_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {price.Text.Replace("가격 : ", "")}원 입니다");

            String str1 = $"str1 : ko[{getString("str1")}], en[{getString("en", "str1")}]";
            String str2 = $"str2 : ko[{getString("str2")}], en[{getString("en", "str2")}]";
            String msg = str1 + "\n\n" + str2;
            MessageBox.Show(msg);
        }
        private void reset_Click(object sender, EventArgs e)
        {
            repository.Reset();
            string str = "";
            added.Text = "";
            repository.SelectOrders().ForEach(menu =>
            {
                str += $"{menu.ToString()}\r\n";
            });
            added.Text = str;
            price.Text = $"가격 : {repository.Billing()}";
            counter.Text = $"수량 : {repository.CountingMenu()}";
        }

        public static string sLanguage = "ko";
        public static string getString(string name)
        {
            return getString(sLanguage, name);
        }
        public static string getString(string code, string name)
        {
            if (code.Equals("en"))
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                return Properties.StringLib.ResourceManager.GetString(name);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ko-KR");
                return Properties.StringLib.ResourceManager.GetString(name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
