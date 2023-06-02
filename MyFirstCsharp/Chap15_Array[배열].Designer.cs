namespace MyFirstCsharp
{
    partial class Chap15_Array
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
            this.btnAF = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAF
            // 
            this.btnAF.Location = new System.Drawing.Point(12, 12);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(246, 137);
            this.btnAF.TabIndex = 0;
            this.btnAF.Text = "배열함수";
            this.btnAF.UseVisualStyleBackColor = true;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(264, 12);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(244, 137);
            this.btnAC.TabIndex = 1;
            this.btnAC.Text = "사배열복";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // Chap15_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnAF);
            this.Name = "Chap15_Array";
            this.Text = "배열";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAF;
        private System.Windows.Forms.Button btnAC;
    }
}