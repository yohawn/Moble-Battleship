namespace Kioskpre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bill = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.python = new System.Windows.Forms.Button();
            this.csharp = new System.Windows.Forms.Button();
            this.cpp = new System.Windows.Forms.Button();
            this.pythonsaurce = new System.Windows.Forms.Label();
            this.csharpsaurce = new System.Windows.Forms.Label();
            this.cppsaurce = new System.Windows.Forms.Label();
            this.pydelete = new System.Windows.Forms.Button();
            this.csdelete = new System.Windows.Forms.Button();
            this.cppdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bill
            // 
            this.bill.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bill.Location = new System.Drawing.Point(908, 562);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(114, 59);
            this.bill.TabIndex = 2;
            this.bill.Text = "결제";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(1028, 562);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(114, 59);
            this.reset.TabIndex = 3;
            this.reset.Text = "리셋";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Counter.Location = new System.Drawing.Point(416, 570);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(77, 37);
            this.Counter.TabIndex = 5;
            this.Counter.Text = "수량:";
            this.Counter.Click += new System.EventHandler(this.label1_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(648, 570);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(77, 37);
            this.Price.TabIndex = 6;
            this.Price.Text = "가격:";
            this.Price.Click += new System.EventHandler(this.label2_Click);
            // 
            // python
            // 
            this.python.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("python.BackgroundImage")));
            this.python.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.python.Location = new System.Drawing.Point(142, 89);
            this.python.Name = "python";
            this.python.Size = new System.Drawing.Size(263, 266);
            this.python.TabIndex = 7;
            this.python.UseVisualStyleBackColor = true;
            this.python.Click += new System.EventHandler(this.button1_Click);
            // 
            // csharp
            // 
            this.csharp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("csharp.BackgroundImage")));
            this.csharp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csharp.Location = new System.Drawing.Point(457, 30);
            this.csharp.Name = "csharp";
            this.csharp.Size = new System.Drawing.Size(330, 398);
            this.csharp.TabIndex = 8;
            this.csharp.UseVisualStyleBackColor = true;
            this.csharp.Click += new System.EventHandler(this.button2_Click);
            // 
            // cpp
            // 
            this.cpp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpp.BackgroundImage")));
            this.cpp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cpp.Location = new System.Drawing.Point(848, 16);
            this.cpp.Name = "cpp";
            this.cpp.Size = new System.Drawing.Size(294, 412);
            this.cpp.TabIndex = 9;
            this.cpp.UseVisualStyleBackColor = true;
            this.cpp.Click += new System.EventHandler(this.button3_Click);
            // 
            // pythonsaurce
            // 
            this.pythonsaurce.AutoSize = true;
            this.pythonsaurce.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pythonsaurce.Location = new System.Drawing.Point(142, 499);
            this.pythonsaurce.Name = "pythonsaurce";
            this.pythonsaurce.Size = new System.Drawing.Size(148, 25);
            this.pythonsaurce.TabIndex = 10;
            this.pythonsaurce.Text = "Python 19800원";
            // 
            // csharpsaurce
            // 
            this.csharpsaurce.AutoSize = true;
            this.csharpsaurce.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csharpsaurce.Location = new System.Drawing.Point(457, 499);
            this.csharpsaurce.Name = "csharpsaurce";
            this.csharpsaurce.Size = new System.Drawing.Size(109, 25);
            this.csharpsaurce.TabIndex = 11;
            this.csharpsaurce.Text = "c# 24300원";
            // 
            // cppsaurce
            // 
            this.cppsaurce.AutoSize = true;
            this.cppsaurce.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cppsaurce.Location = new System.Drawing.Point(848, 499);
            this.cppsaurce.Name = "cppsaurce";
            this.cppsaurce.Size = new System.Drawing.Size(123, 25);
            this.cppsaurce.TabIndex = 12;
            this.cppsaurce.Text = "c++ 18000원";
            // 
            // pydelete
            // 
            this.pydelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pydelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pydelete.Location = new System.Drawing.Point(196, 434);
            this.pydelete.Name = "pydelete";
            this.pydelete.Size = new System.Drawing.Size(110, 45);
            this.pydelete.TabIndex = 13;
            this.pydelete.Text = "취소";
            this.pydelete.UseVisualStyleBackColor = true;
            this.pydelete.Click += new System.EventHandler(this.pydelete_Click);
            // 
            // csdelete
            // 
            this.csdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csdelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csdelete.Location = new System.Drawing.Point(560, 434);
            this.csdelete.Name = "csdelete";
            this.csdelete.Size = new System.Drawing.Size(110, 45);
            this.csdelete.TabIndex = 14;
            this.csdelete.Text = "취소";
            this.csdelete.UseVisualStyleBackColor = true;
            this.csdelete.Click += new System.EventHandler(this.csdelete_Click);
            // 
            // cppdelete
            // 
            this.cppdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cppdelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cppdelete.Location = new System.Drawing.Point(961, 434);
            this.cppdelete.Name = "cppdelete";
            this.cppdelete.Size = new System.Drawing.Size(110, 45);
            this.cppdelete.TabIndex = 15;
            this.cppdelete.Text = "취소";
            this.cppdelete.UseVisualStyleBackColor = true;
            this.cppdelete.Click += new System.EventHandler(this.cppdelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 647);
            this.Controls.Add(this.cppdelete);
            this.Controls.Add(this.csdelete);
            this.Controls.Add(this.pydelete);
            this.Controls.Add(this.cppsaurce);
            this.Controls.Add(this.csharpsaurce);
            this.Controls.Add(this.pythonsaurce);
            this.Controls.Add(this.cpp);
            this.Controls.Add(this.csharp);
            this.Controls.Add(this.python);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.bill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button python;
        private System.Windows.Forms.Button csharp;
        private System.Windows.Forms.Button cpp;
        private System.Windows.Forms.Label pythonsaurce;
        private System.Windows.Forms.Label csharpsaurce;
        private System.Windows.Forms.Label cppsaurce;
        private System.Windows.Forms.Button pydelete;
        private System.Windows.Forms.Button csdelete;
        private System.Windows.Forms.Button cppdelete;
    }
}
