namespace MyFirstCsharp
{
    partial class Chap08_StringSplit
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
            this.lblTItle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLengh = new System.Windows.Forms.TextBox();
            this.btnLengh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnSS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTItle
            // 
            this.lblTItle.AutoSize = true;
            this.lblTItle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTItle.Location = new System.Drawing.Point(267, 125);
            this.lblTItle.Name = "lblTItle";
            this.lblTItle.Size = new System.Drawing.Size(272, 25);
            this.lblTItle.TabIndex = 0;
            this.lblTItle.Text = "ABCDEFG/HIJKLMN/OPQRSTU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "문자열 보간";
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(6, 31);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(77, 23);
            this.btnIP.TabIndex = 0;
            this.btnIP.Text = "$";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLengh);
            this.groupBox2.Controls.Add(this.btnLengh);
            this.groupBox2.Location = new System.Drawing.Point(313, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "lengh()";
            // 
            // txtLengh
            // 
            this.txtLengh.Location = new System.Drawing.Point(6, 20);
            this.txtLengh.Name = "txtLengh";
            this.txtLengh.Size = new System.Drawing.Size(77, 21);
            this.txtLengh.TabIndex = 1;
            // 
            // btnLengh
            // 
            this.btnLengh.Location = new System.Drawing.Point(6, 47);
            this.btnLengh.Name = "btnLengh";
            this.btnLengh.Size = new System.Drawing.Size(77, 23);
            this.btnLengh.TabIndex = 0;
            this.btnLengh.Text = "길이";
            this.btnLengh.UseVisualStyleBackColor = true;
            this.btnLengh.Click += new System.EventHandler(this.btnLengh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSplit);
            this.groupBox3.Location = new System.Drawing.Point(107, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split()";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(62, 44);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(77, 23);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "slit1!";
            this.btnSplit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSS);
            this.groupBox4.Controls.Add(this.txtCount);
            this.groupBox4.Controls.Add(this.txtIndex);
            this.groupBox4.Location = new System.Drawing.Point(408, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Substring";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(6, 20);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 21);
            this.txtIndex.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(6, 47);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 21);
            this.txtCount.TabIndex = 1;
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(13, 74);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(75, 23);
            this.btnSS.TabIndex = 2;
            this.btnSS.Text = "SS";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // Chap08_StringSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTItle);
            this.Name = "Chap08_StringSplit";
            this.Text = "문자나누기";
            this.Load += new System.EventHandler(this.Chap08_StringSplit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTItle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLengh;
        private System.Windows.Forms.Button btnLengh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtIndex;
    }
}