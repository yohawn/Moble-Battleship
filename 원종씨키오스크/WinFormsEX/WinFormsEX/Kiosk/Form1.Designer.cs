namespace Kiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            added = new System.Windows.Forms.TextBox();
            counter = new System.Windows.Forms.Label();
            price = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            panel = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // added
            // 
            added.Location = new System.Drawing.Point(12, 235);
            added.Multiline = true;
            added.Name = "added";
            added.Size = new System.Drawing.Size(170, 176);
            added.TabIndex = 1;
            // 
            // counter
            // 
            counter.AutoSize = true;
            counter.Location = new System.Drawing.Point(207, 396);
            counter.Name = "counter";
            counter.Size = new System.Drawing.Size(34, 15);
            counter.TabIndex = 2;
            counter.Text = "수량:";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new System.Drawing.Point(342, 396);
            price.Name = "price";
            price.Size = new System.Drawing.Size(38, 15);
            price.TabIndex = 3;
            price.Text = "가격 :";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(524, 396);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "계산";
            button4.UseVisualStyleBackColor = true;
            button4.Click += bill_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(646, 393);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "리셋";
            button5.UseVisualStyleBackColor = true;
            button5.Click += reset_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(25, 25);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "햄버거";
            button1.UseVisualStyleBackColor = true;
            button1.Click += hamburger_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(25, 84);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "사이드";
            button2.UseVisualStyleBackColor = true;
            button2.Click += side_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(25, 147);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "음료";
            button3.UseVisualStyleBackColor = true;
            button3.Click += drinks_Click;
            // 
            // panel
            // 
            panel.Controls.Add(button3);
            panel.Controls.Add(button2);
            panel.Controls.Add(button1);
            panel.Location = new System.Drawing.Point(12, 12);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(170, 217);
            panel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new System.Drawing.Point(207, 12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(562, 362);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 715);
            Controls.Add(panel2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(price);
            Controls.Add(counter);
            Controls.Add(added);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox added;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
    }
}
