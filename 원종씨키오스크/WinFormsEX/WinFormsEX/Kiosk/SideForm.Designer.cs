namespace Kiosk
{
    partial class SideForm
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
            this.frenchfrice = new System.Windows.Forms.CheckBox();
            this.marinaedfrise = new System.Windows.Forms.CheckBox();
            this.applepie = new System.Windows.Forms.CheckBox();
            this.eggtart = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // frenchfrice
            // 
            this.frenchfrice.AutoSize = true;
            this.frenchfrice.Location = new System.Drawing.Point(74, 233);
            this.frenchfrice.Name = "frenchfrice";
            this.frenchfrice.Size = new System.Drawing.Size(78, 19);
            this.frenchfrice.TabIndex = 0;
            this.frenchfrice.Text = "감자 튀김";
            this.frenchfrice.UseVisualStyleBackColor = true;
            // 
            // marinaedfrise
            // 
            this.marinaedfrise.AutoSize = true;
            this.marinaedfrise.Location = new System.Drawing.Point(173, 233);
            this.marinaedfrise.Name = "marinaedfrise";
            this.marinaedfrise.Size = new System.Drawing.Size(98, 19);
            this.marinaedfrise.TabIndex = 1;
            this.marinaedfrise.Text = "양념감자튀김";
            this.marinaedfrise.UseVisualStyleBackColor = true;
            // 
            // applepie
            // 
            this.applepie.AutoSize = true;
            this.applepie.Location = new System.Drawing.Point(289, 233);
            this.applepie.Name = "applepie";
            this.applepie.Size = new System.Drawing.Size(74, 19);
            this.applepie.TabIndex = 2;
            this.applepie.Text = "애플파이";
            this.applepie.UseVisualStyleBackColor = true;
            // 
            // eggtart
            // 
            this.eggtart.AutoSize = true;
            this.eggtart.Location = new System.Drawing.Point(379, 233);
            this.eggtart.Name = "eggtart";
            this.eggtart.Size = new System.Drawing.Size(86, 19);
            this.eggtart.TabIndex = 3;
            this.eggtart.Text = "에그타르트";
            this.eggtart.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 250);
            this.textBox1.TabIndex = 4;
            // 
            // SideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eggtart);
            this.Controls.Add(this.applepie);
            this.Controls.Add(this.marinaedfrise);
            this.Controls.Add(this.frenchfrice);
            this.Controls.Add(this.textBox1);
            this.Name = "SideForm";
            this.Size = new System.Drawing.Size(726, 524);
            this.Load += new System.EventHandler(this.SideForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox frenchfrice;
        private System.Windows.Forms.CheckBox marinaedfrise;
        private System.Windows.Forms.CheckBox applepie;
        private System.Windows.Forms.CheckBox eggtart;
        private System.Windows.Forms.TextBox textBox1;
    }
}
