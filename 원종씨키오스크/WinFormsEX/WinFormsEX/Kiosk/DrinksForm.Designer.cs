﻿namespace Kiosk
{
    partial class DrinksForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.coke = new System.Windows.Forms.RadioButton();
            this.zecoke = new System.Windows.Forms.RadioButton();
            this.sider = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // coke
            // 
            this.coke.AutoSize = true;
            this.coke.Location = new System.Drawing.Point(103, 215);
            this.coke.Name = "coke";
            this.coke.Size = new System.Drawing.Size(73, 19);
            this.coke.TabIndex = 0;
            this.coke.TabStop = true;
            this.coke.Text = "코카콜라";
            this.coke.UseVisualStyleBackColor = true;
            // 
            // zecoke
            // 
            this.zecoke.AutoSize = true;
            this.zecoke.Location = new System.Drawing.Point(235, 215);
            this.zecoke.Name = "zecoke";
            this.zecoke.Size = new System.Drawing.Size(73, 19);
            this.zecoke.TabIndex = 1;
            this.zecoke.TabStop = true;
            this.zecoke.Text = "제로콜라";
            this.zecoke.UseVisualStyleBackColor = true;
            // 
            // sider
            // 
            this.sider.AutoSize = true;
            this.sider.Location = new System.Drawing.Point(365, 215);
            this.sider.Name = "sider";
            this.sider.Size = new System.Drawing.Size(61, 19);
            this.sider.TabIndex = 2;
            this.sider.TabStop = true;
            this.sider.Text = "사이다";
            this.sider.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 250);
            this.textBox1.TabIndex = 3;
            // 
            // DrinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sider);
            this.Controls.Add(this.zecoke);
            this.Controls.Add(this.coke);
            this.Controls.Add(this.textBox1);
            this.Name = "DrinksForm";
            this.Size = new System.Drawing.Size(533, 422);
            this.Load += new System.EventHandler(this.DrinksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton coke;
        private System.Windows.Forms.RadioButton zecoke;
        private System.Windows.Forms.RadioButton sider;
        private System.Windows.Forms.TextBox textBox1;
    }
}
