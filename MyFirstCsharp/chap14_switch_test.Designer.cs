namespace MyFirstCsharp
{
    partial class chap14_switch_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chap14_switch_test));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnappleorder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmelonorder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnwatermelonorder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btntotalprice = new System.Windows.Forms.Button();
            this.acount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mcount = new System.Windows.Forms.Label();
            this.wmcount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.acount);
            this.groupBox1.Controls.Add(this.btnappleorder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "2000원 남은 수량";
            // 
            // btnappleorder
            // 
            this.btnappleorder.Location = new System.Drawing.Point(8, 47);
            this.btnappleorder.Name = "btnappleorder";
            this.btnappleorder.Size = new System.Drawing.Size(75, 47);
            this.btnappleorder.TabIndex = 1;
            this.btnappleorder.Text = "사과 주문";
            this.btnappleorder.UseVisualStyleBackColor = true;
            this.btnappleorder.Click += new System.EventHandler(this.btnappleorder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mcount);
            this.groupBox2.Controls.Add(this.btnmelonorder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "참외";
            // 
            // btnmelonorder
            // 
            this.btnmelonorder.Location = new System.Drawing.Point(8, 47);
            this.btnmelonorder.Name = "btnmelonorder";
            this.btnmelonorder.Size = new System.Drawing.Size(75, 47);
            this.btnmelonorder.TabIndex = 1;
            this.btnmelonorder.Text = "참외 주문";
            this.btnmelonorder.UseVisualStyleBackColor = true;
            this.btnmelonorder.Click += new System.EventHandler(this.btnmelonorder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "2500원 남은 수량";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.wmcount);
            this.groupBox3.Controls.Add(this.btnwatermelonorder);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수박";
            // 
            // btnwatermelonorder
            // 
            this.btnwatermelonorder.Location = new System.Drawing.Point(8, 47);
            this.btnwatermelonorder.Name = "btnwatermelonorder";
            this.btnwatermelonorder.Size = new System.Drawing.Size(75, 47);
            this.btnwatermelonorder.TabIndex = 1;
            this.btnwatermelonorder.Text = "수박 주문";
            this.btnwatermelonorder.UseVisualStyleBackColor = true;
            this.btnwatermelonorder.Click += new System.EventHandler(this.btnwatermelonorder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "18000원 남은 수량";
            // 
            // btntotalprice
            // 
            this.btntotalprice.Location = new System.Drawing.Point(259, 118);
            this.btntotalprice.Name = "btntotalprice";
            this.btntotalprice.Size = new System.Drawing.Size(140, 99);
            this.btntotalprice.TabIndex = 3;
            this.btntotalprice.Text = "총 결게 금액";
            this.btntotalprice.UseVisualStyleBackColor = true;
            this.btntotalprice.Click += new System.EventHandler(this.btntotalprice_Click);
            // 
            // acount
            // 
            this.acount.AutoSize = true;
            this.acount.Location = new System.Drawing.Point(109, 17);
            this.acount.Name = "acount";
            this.acount.Size = new System.Drawing.Size(17, 12);
            this.acount.TabIndex = 4;
            this.acount.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "개";
            // 
            // mcount
            // 
            this.mcount.AutoSize = true;
            this.mcount.Location = new System.Drawing.Point(109, 17);
            this.mcount.Name = "mcount";
            this.mcount.Size = new System.Drawing.Size(17, 12);
            this.mcount.TabIndex = 5;
            this.mcount.Text = "10";
            // 
            // wmcount
            // 
            this.wmcount.AutoSize = true;
            this.wmcount.Location = new System.Drawing.Point(109, 17);
            this.wmcount.Name = "wmcount";
            this.wmcount.Size = new System.Drawing.Size(17, 12);
            this.wmcount.TabIndex = 6;
            this.wmcount.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "개";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "개";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(353, 96);
            this.label10.TabIndex = 4;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // chap14_switch_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btntotalprice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "chap14_switch_test";
            this.Text = "chap14_switch_test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnappleorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmelonorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnwatermelonorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntotalprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label acount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mcount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label wmcount;
        private System.Windows.Forms.Label label10;
    }
}