namespace MyFirstCsharp
{
    partial class Chap12_IF_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap12_IF_Test));
            this.label1 = new System.Windows.Forms.Label();
            this.txt25C = new System.Windows.Forms.TextBox();
            this.btn25 = new System.Windows.Forms.Button();
            this.txt8B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력 받을 값";
            // 
            // txt25C
            // 
            this.txt25C.Location = new System.Drawing.Point(639, 35);
            this.txt25C.Name = "txt25C";
            this.txt25C.Size = new System.Drawing.Size(100, 21);
            this.txt25C.TabIndex = 1;
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(639, 62);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(123, 23);
            this.btn25.TabIndex = 2;
            this.btn25.Text = "2, 5 공배수 확인";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // txt8B
            // 
            this.txt8B.Location = new System.Drawing.Point(639, 118);
            this.txt8B.Name = "txt8B";
            this.txt8B.Size = new System.Drawing.Size(100, 21);
            this.txt8B.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "8의 배수 일 경우 값과의 곱";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(639, 173);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(100, 21);
            this.txtCC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 144);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Chap12_IF_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt8B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.txt25C);
            this.Controls.Add(this.label1);
            this.Name = "Chap12_IF_Test";
            this.Text = "분기문 IF 테스트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt25C;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.TextBox txt8B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}