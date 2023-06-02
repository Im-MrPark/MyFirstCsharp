namespace MyFirstCsharp
{
    partial class Chap16_Loop_For
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
            this.btnForsum = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.txt99D = new System.Windows.Forms.TextBox();
            this.btn99D = new System.Windows.Forms.Button();
            this.btnImut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForsum
            // 
            this.btnForsum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForsum.Location = new System.Drawing.Point(0, 0);
            this.btnForsum.Name = "btnForsum";
            this.btnForsum.Size = new System.Drawing.Size(800, 100);
            this.btnForsum.TabIndex = 0;
            this.btnForsum.Text = "1 부터 100까지 더하기";
            this.btnForsum.UseVisualStyleBackColor = true;
            this.btnForsum.Click += new System.EventHandler(this.btnForsum_Click);
            // 
            // btnAS
            // 
            this.btnAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAS.Location = new System.Drawing.Point(0, 100);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(800, 103);
            this.btnAS.TabIndex = 1;
            this.btnAS.Text = "배열 값 더하기";
            this.btnAS.UseVisualStyleBackColor = true;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
            // 
            // txt99D
            // 
            this.txt99D.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt99D.Location = new System.Drawing.Point(0, 203);
            this.txt99D.Multiline = true;
            this.txt99D.Name = "txt99D";
            this.txt99D.Size = new System.Drawing.Size(800, 42);
            this.txt99D.TabIndex = 2;
            // 
            // btn99D
            // 
            this.btn99D.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn99D.Location = new System.Drawing.Point(0, 245);
            this.btn99D.Name = "btn99D";
            this.btn99D.Size = new System.Drawing.Size(800, 49);
            this.btn99D.TabIndex = 3;
            this.btn99D.Text = "구구단표현";
            this.btn99D.UseVisualStyleBackColor = true;
            this.btn99D.Click += new System.EventHandler(this.btn99D_Click);
            // 
            // btnImut
            // 
            this.btnImut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImut.Location = new System.Drawing.Point(0, 294);
            this.btnImut.Name = "btnImut";
            this.btnImut.Size = new System.Drawing.Size(800, 49);
            this.btnImut.TabIndex = 4;
            this.btnImut.Text = "Immutable";
            this.btnImut.UseVisualStyleBackColor = true;
            this.btnImut.Click += new System.EventHandler(this.btnImut_Click);
            // 
            // Chap16_Loop_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImut);
            this.Controls.Add(this.btn99D);
            this.Controls.Add(this.txt99D);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.btnForsum);
            this.Name = "Chap16_Loop_For";
            this.Text = "반복문 for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForsum;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.TextBox txt99D;
        private System.Windows.Forms.Button btn99D;
        private System.Windows.Forms.Button btnImut;
    }
}