﻿namespace MyFirstCsharp
{
    partial class Chap10_NullMange
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
            this.btnHasValue = new System.Windows.Forms.Button();
            this.btnNullable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasValue
            // 
            this.btnHasValue.Location = new System.Drawing.Point(713, 12);
            this.btnHasValue.Name = "btnHasValue";
            this.btnHasValue.Size = new System.Drawing.Size(75, 23);
            this.btnHasValue.TabIndex = 0;
            this.btnHasValue.Text = "HasValue";
            this.btnHasValue.UseVisualStyleBackColor = true;
            this.btnHasValue.Click += new System.EventHandler(this.btnHasValue_Click);
            // 
            // btnNullable
            // 
            this.btnNullable.Location = new System.Drawing.Point(713, 41);
            this.btnNullable.Name = "btnNullable";
            this.btnNullable.Size = new System.Drawing.Size(75, 23);
            this.btnNullable.TabIndex = 1;
            this.btnNullable.Text = "null 병합 연사자";
            this.btnNullable.UseVisualStyleBackColor = true;
            this.btnNullable.Click += new System.EventHandler(this.btnNullable_Click);
            // 
            // Chap10_NullMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNullable);
            this.Controls.Add(this.btnHasValue);
            this.Name = "Chap10_NullMange";
            this.Text = "Null 다루기";
            this.Load += new System.EventHandler(this.Chap10_NullMange_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHasValue;
        private System.Windows.Forms.Button btnNullable;
    }
}