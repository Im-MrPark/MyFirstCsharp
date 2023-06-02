namespace MyFirstCsharp
{
    partial class Chap09_StringManage_Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1181, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(17, 37);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(228, 71);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "OOO -> 본인 이름 변경\r\n*라벨 Text 직접 변경해서 표현\r\n";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(17, 114);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(228, 71);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "\"S/W\" 위치 찾고 메세지박스로 표현\r\n*구현은 in line 으로\r\n";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(17, 191);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(228, 71);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "시작 단어와 마지막 단어 각각 1자씩 \r\n메세지로 표현";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(251, 37);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(272, 71);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "타이틀 문자열의 앞, 뒤에 \"-DT-\" 문자열 삽입";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(251, 114);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(272, 71);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "DIG~NING만 소문자로 변경\r\n위 문자는 고정\r\n";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(251, 191);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(272, 71);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "타이틀의 문자열의 모든 공백 없애기\r\n라벨 Text에 직접 표현";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // Chap09_StringManage_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 450);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap09_StringManage_Test";
            this.Text = "문자열 나누기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
    }
}