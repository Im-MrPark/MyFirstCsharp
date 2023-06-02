namespace MyFirstCsharp
{
    partial class Chap11_BranchingStatement
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
            this.btnIF = new System.Windows.Forms.Button();
            this.txtIF = new System.Windows.Forms.TextBox();
            this.btnInIF = new System.Windows.Forms.Button();
            this.btnelseIF = new System.Windows.Forms.Button();
            this.btnAndIF = new System.Windows.Forms.Button();
            this.btnOrIF = new System.Windows.Forms.Button();
            this.btnBoolIF = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnhj = new System.Windows.Forms.Button();
            this.btnTO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 39);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(178, 75);
            this.btnIF.TabIndex = 0;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // txtIF
            // 
            this.txtIF.Location = new System.Drawing.Point(12, 12);
            this.txtIF.Name = "txtIF";
            this.txtIF.Size = new System.Drawing.Size(178, 21);
            this.txtIF.TabIndex = 1;
            // 
            // btnInIF
            // 
            this.btnInIF.Location = new System.Drawing.Point(196, 39);
            this.btnInIF.Name = "btnInIF";
            this.btnInIF.Size = new System.Drawing.Size(178, 75);
            this.btnInIF.TabIndex = 2;
            this.btnInIF.Text = "In IF";
            this.btnInIF.UseVisualStyleBackColor = true;
            this.btnInIF.Click += new System.EventHandler(this.btnInIF_Click);
            // 
            // btnelseIF
            // 
            this.btnelseIF.Location = new System.Drawing.Point(380, 39);
            this.btnelseIF.Name = "btnelseIF";
            this.btnelseIF.Size = new System.Drawing.Size(178, 75);
            this.btnelseIF.TabIndex = 3;
            this.btnelseIF.Text = "else IF";
            this.btnelseIF.UseVisualStyleBackColor = true;
            this.btnelseIF.Click += new System.EventHandler(this.btnelseIF_Click);
            // 
            // btnAndIF
            // 
            this.btnAndIF.Location = new System.Drawing.Point(12, 120);
            this.btnAndIF.Name = "btnAndIF";
            this.btnAndIF.Size = new System.Drawing.Size(178, 75);
            this.btnAndIF.TabIndex = 4;
            this.btnAndIF.Text = "And IF";
            this.btnAndIF.UseVisualStyleBackColor = true;
            this.btnAndIF.Click += new System.EventHandler(this.btnAndIF_Click);
            // 
            // btnOrIF
            // 
            this.btnOrIF.Location = new System.Drawing.Point(196, 120);
            this.btnOrIF.Name = "btnOrIF";
            this.btnOrIF.Size = new System.Drawing.Size(178, 75);
            this.btnOrIF.TabIndex = 5;
            this.btnOrIF.Text = "Or IF";
            this.btnOrIF.UseVisualStyleBackColor = true;
            this.btnOrIF.Click += new System.EventHandler(this.btnOrIF_Click);
            // 
            // btnBoolIF
            // 
            this.btnBoolIF.Location = new System.Drawing.Point(380, 120);
            this.btnBoolIF.Name = "btnBoolIF";
            this.btnBoolIF.Size = new System.Drawing.Size(178, 75);
            this.btnBoolIF.TabIndex = 6;
            this.btnBoolIF.Text = "Bool IF";
            this.btnBoolIF.UseVisualStyleBackColor = true;
            this.btnBoolIF.Click += new System.EventHandler(this.btnBoolIF_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(12, 201);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(178, 77);
            this.btnPM.TabIndex = 7;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnhj
            // 
            this.btnhj.Location = new System.Drawing.Point(196, 201);
            this.btnhj.Name = "btnhj";
            this.btnhj.Size = new System.Drawing.Size(178, 77);
            this.btnhj.TabIndex = 8;
            this.btnhj.Text = "홀/짝 판단";
            this.btnhj.UseVisualStyleBackColor = true;
            this.btnhj.Click += new System.EventHandler(this.btnhj_Click);
            // 
            // btnTO
            // 
            this.btnTO.Location = new System.Drawing.Point(380, 201);
            this.btnTO.Name = "btnTO";
            this.btnTO.Size = new System.Drawing.Size(178, 77);
            this.btnTO.TabIndex = 9;
            this.btnTO.Text = "상황 연산자";
            this.btnTO.UseVisualStyleBackColor = true;
            this.btnTO.Click += new System.EventHandler(this.btnTO_Click);
            // 
            // Chap11_BranchingStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btnTO);
            this.Controls.Add(this.btnhj);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnBoolIF);
            this.Controls.Add(this.btnOrIF);
            this.Controls.Add(this.btnAndIF);
            this.Controls.Add(this.btnelseIF);
            this.Controls.Add(this.btnInIF);
            this.Controls.Add(this.txtIF);
            this.Controls.Add(this.btnIF);
            this.Name = "Chap11_BranchingStatement";
            this.Text = "분기문 학습하기";
            this.Load += new System.EventHandler(this.Chap11_BranchingStatement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.TextBox txtIF;
        private System.Windows.Forms.Button btnInIF;
        private System.Windows.Forms.Button btnelseIF;
        private System.Windows.Forms.Button btnAndIF;
        private System.Windows.Forms.Button btnOrIF;
        private System.Windows.Forms.Button btnBoolIF;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnhj;
        private System.Windows.Forms.Button btnTO;
    }
}