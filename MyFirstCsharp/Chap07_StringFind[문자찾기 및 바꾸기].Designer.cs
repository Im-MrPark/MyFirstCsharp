namespace MyFirstCsharp
{
    partial class Chap07_StringFind
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
            this.lblTite = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndexof = new System.Windows.Forms.Button();
            this.txtIndexof = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCt = new System.Windows.Forms.Button();
            this.txtLastIndex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSW = new System.Windows.Forms.Button();
            this.txtSW = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEW = new System.Windows.Forms.Button();
            this.txtEW = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnR = new System.Windows.Forms.Button();
            this.txtBR = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTite
            // 
            this.lblTite.AutoSize = true;
            this.lblTite.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTite.Location = new System.Drawing.Point(14, 9);
            this.lblTite.Name = "lblTite";
            this.lblTite.Size = new System.Drawing.Size(1054, 25);
            this.lblTite.TabIndex = 0;
            this.lblTite.Text = "동해 물과 백두산이 마르고 닳도록 하느님이 보우하사 우리나라 만세 무궁화 삼천리 화려 강산 대한 사람, 대한으로 길이 보전하세";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIndexof);
            this.groupBox1.Controls.Add(this.txtIndexof);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index of()";
            // 
            // btnIndexof
            // 
            this.btnIndexof.Location = new System.Drawing.Point(7, 47);
            this.btnIndexof.Name = "btnIndexof";
            this.btnIndexof.Size = new System.Drawing.Size(462, 50);
            this.btnIndexof.TabIndex = 1;
            this.btnIndexof.Text = "찾기";
            this.btnIndexof.UseVisualStyleBackColor = true;
            this.btnIndexof.Click += new System.EventHandler(this.btnIndexof_Click);
            // 
            // txtIndexof
            // 
            this.txtIndexof.Location = new System.Drawing.Point(7, 20);
            this.txtIndexof.Name = "txtIndexof";
            this.txtIndexof.Size = new System.Drawing.Size(462, 21);
            this.txtIndexof.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCt);
            this.groupBox2.Controls.Add(this.txtLastIndex);
            this.groupBox2.Location = new System.Drawing.Point(523, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LastIndex of()";
            // 
            // btnCt
            // 
            this.btnCt.Location = new System.Drawing.Point(7, 47);
            this.btnCt.Name = "btnCt";
            this.btnCt.Size = new System.Drawing.Size(462, 50);
            this.btnCt.TabIndex = 1;
            this.btnCt.Text = "찾기";
            this.btnCt.UseVisualStyleBackColor = true;
            this.btnCt.Click += new System.EventHandler(this.btnLastIndex_Click);
            // 
            // txtLastIndex
            // 
            this.txtLastIndex.Location = new System.Drawing.Point(7, 20);
            this.txtLastIndex.Name = "txtLastIndex";
            this.txtLastIndex.Size = new System.Drawing.Size(462, 21);
            this.txtLastIndex.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSW);
            this.groupBox3.Controls.Add(this.txtSW);
            this.groupBox3.Location = new System.Drawing.Point(12, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 105);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StartWith()";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnSW
            // 
            this.btnSW.Location = new System.Drawing.Point(7, 47);
            this.btnSW.Name = "btnSW";
            this.btnSW.Size = new System.Drawing.Size(462, 50);
            this.btnSW.TabIndex = 1;
            this.btnSW.Text = "판단하기";
            this.btnSW.UseVisualStyleBackColor = true;
            this.btnSW.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // txtSW
            // 
            this.txtSW.Location = new System.Drawing.Point(7, 20);
            this.txtSW.Name = "txtSW";
            this.txtSW.Size = new System.Drawing.Size(462, 21);
            this.txtSW.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEW);
            this.groupBox4.Controls.Add(this.txtEW);
            this.groupBox4.Location = new System.Drawing.Point(523, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EndWith()";
            // 
            // btnEW
            // 
            this.btnEW.Location = new System.Drawing.Point(7, 47);
            this.btnEW.Name = "btnEW";
            this.btnEW.Size = new System.Drawing.Size(462, 50);
            this.btnEW.TabIndex = 1;
            this.btnEW.Text = "판단하기";
            this.btnEW.UseVisualStyleBackColor = true;
            this.btnEW.Click += new System.EventHandler(this.btnEW_Click);
            // 
            // txtEW
            // 
            this.txtEW.Location = new System.Drawing.Point(7, 20);
            this.txtEW.Name = "txtEW";
            this.txtEW.Size = new System.Drawing.Size(462, 21);
            this.txtEW.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.txtCt);
            this.groupBox5.Location = new System.Drawing.Point(12, 389);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(475, 105);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contains()";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "판단하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCt
            // 
            this.txtCt.Location = new System.Drawing.Point(7, 20);
            this.txtCt.Name = "txtCt";
            this.txtCt.Size = new System.Drawing.Size(462, 21);
            this.txtCt.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtAR);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnR);
            this.groupBox6.Controls.Add(this.txtBR);
            this.groupBox6.Location = new System.Drawing.Point(523, 389);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(691, 105);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Replace()";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "변경후 문자열";
            // 
            // txtAR
            // 
            this.txtAR.Location = new System.Drawing.Point(449, 20);
            this.txtAR.Name = "txtAR";
            this.txtAR.Size = new System.Drawing.Size(207, 21);
            this.txtAR.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "변경전 문자열";
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(7, 47);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(207, 50);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "판단하기";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // txtBR
            // 
            this.txtBR.Location = new System.Drawing.Point(100, 20);
            this.txtBR.Name = "txtBR";
            this.txtBR.Size = new System.Drawing.Size(207, 21);
            this.txtBR.TabIndex = 0;
            // 
            // Chap07_StringFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 629);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTite);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Chap07_StringFind";
            this.Text = "문자열 찾기 및 바꾸기";
            this.Load += new System.EventHandler(this.Chap07_StringFind_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIndexof;
        private System.Windows.Forms.TextBox txtIndexof;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCt;
        private System.Windows.Forms.TextBox txtLastIndex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSW;
        private System.Windows.Forms.TextBox txtSW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEW;
        private System.Windows.Forms.TextBox txtEW;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.TextBox txtBR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAR;
    }
}