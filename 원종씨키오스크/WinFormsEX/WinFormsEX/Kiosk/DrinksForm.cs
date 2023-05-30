using kiosk.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Kiosk
{
    public partial class DrinksForm : UserControl
    {
        private KioskRepository repository = new KioskRepository();
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        public DrinksForm(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label labe1, System.Windows.Forms.Label label2)
        {
            InitializeComponent();

            this.textbox = textBox;
            this.label1 = labe1;
            this.label2 = label2;

            coke.CheckedChanged += CheckItem;
            zecoke.CheckedChanged += CheckItem;
            sider.CheckedChanged += CheckItem;
        }
        private void CheckItem(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            bool flag = rd.Checked;
            if (flag)
            {
                string str = "";
                textbox.Text = "";
                repository.AddMenu(rd.Text, 5000);
                repository.SelectOrders().ForEach(menu =>
                {
                    str += $"{menu.ToString()}\r\n";
                });
                textbox.Text = str;
                label1.Text = $"가격 : {repository.Billing()}";
                label2.Text = $"수량 : {repository.CountingMenu()}";
            }

        }

        private void DrinksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
