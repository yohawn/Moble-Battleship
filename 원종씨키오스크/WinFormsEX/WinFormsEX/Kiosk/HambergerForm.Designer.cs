namespace Kiosk
{
    partial class HambergerForm
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
            bulgogi = new System.Windows.Forms.RadioButton();
            doublebulgogi = new System.Windows.Forms.RadioButton();
            cheese = new System.Windows.Forms.RadioButton();
            doublecheese = new System.Windows.Forms.RadioButton();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // bulgogi
            // 
            bulgogi.AutoSize = true;
            bulgogi.Location = new System.Drawing.Point(287, 226);
            bulgogi.Name = "bulgogi";
            bulgogi.Size = new System.Drawing.Size(61, 19);
            bulgogi.TabIndex = 0;
            bulgogi.TabStop = true;
            bulgogi.Text = "불고기";
            bulgogi.UseVisualStyleBackColor = true;
            bulgogi.CheckedChanged += bulgogi_CheckedChanged;
            // 
            // doublebulgogi
            // 
            doublebulgogi.AutoSize = true;
            doublebulgogi.Location = new System.Drawing.Point(86, 226);
            doublebulgogi.Name = "doublebulgogi";
            doublebulgogi.Size = new System.Drawing.Size(89, 19);
            doublebulgogi.TabIndex = 1;
            doublebulgogi.TabStop = true;
            doublebulgogi.Text = "더블 불고기";
            doublebulgogi.UseVisualStyleBackColor = true;
            doublebulgogi.CheckedChanged += doublebulgogi_CheckedChanged;
            // 
            // cheese
            // 
            cheese.AutoSize = true;
            cheese.Location = new System.Drawing.Point(211, 226);
            cheese.Name = "cheese";
            cheese.Size = new System.Drawing.Size(49, 19);
            cheese.TabIndex = 2;
            cheese.TabStop = true;
            cheese.Text = "치즈";
            cheese.UseVisualStyleBackColor = true;
            cheese.CheckedChanged += cheese_CheckedChanged;
            // 
            // doublecheese
            // 
            doublecheese.AutoSize = true;
            doublecheese.Location = new System.Drawing.Point(378, 226);
            doublecheese.Name = "doublecheese";
            doublecheese.Size = new System.Drawing.Size(77, 19);
            doublecheese.TabIndex = 3;
            doublecheese.TabStop = true;
            doublecheese.Text = "더블 치즈";
            doublecheese.UseVisualStyleBackColor = true;
            doublecheese.CheckedChanged += doublecheese_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Window;
            textBox1.Location = new System.Drawing.Point(50, 75);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(450, 250);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // HambergerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(doublecheese);
            Controls.Add(cheese);
            Controls.Add(doublebulgogi);
            Controls.Add(bulgogi);
            Controls.Add(textBox1);
            Name = "HambergerForm";
            Size = new System.Drawing.Size(621, 578);
            Load += HambergerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton bulgogi;
        private System.Windows.Forms.RadioButton doublebulgogi;
        private System.Windows.Forms.RadioButton cheese;
        private System.Windows.Forms.RadioButton doublecheese;
        private System.Windows.Forms.TextBox textBox1;
    }
}
