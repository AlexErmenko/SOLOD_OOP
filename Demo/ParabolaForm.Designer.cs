﻿
namespace Demo
{
    partial class ParabolaForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.ValueCTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueBTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueATb = new System.Windows.Forms.TextBox();
            this.calulateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "C";
            // 
            // ValueCTb
            // 
            this.ValueCTb.Location = new System.Drawing.Point(85, 121);
            this.ValueCTb.Name = "ValueCTb";
            this.ValueCTb.Size = new System.Drawing.Size(100, 20);
            this.ValueCTb.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "B";
            // 
            // ValueBTb
            // 
            this.ValueBTb.Location = new System.Drawing.Point(85, 80);
            this.ValueBTb.Name = "ValueBTb";
            this.ValueBTb.Size = new System.Drawing.Size(100, 20);
            this.ValueBTb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // ValueATb
            // 
            this.ValueATb.Location = new System.Drawing.Point(85, 29);
            this.ValueATb.Name = "ValueATb";
            this.ValueATb.Size = new System.Drawing.Size(100, 20);
            this.ValueATb.TabIndex = 8;
            // 
            // calulateBtn
            // 
            this.calulateBtn.Location = new System.Drawing.Point(32, 202);
            this.calulateBtn.Name = "calulateBtn";
            this.calulateBtn.Size = new System.Drawing.Size(75, 23);
            this.calulateBtn.TabIndex = 14;
            this.calulateBtn.Text = "button1";
            this.calulateBtn.UseVisualStyleBackColor = true;
            this.calulateBtn.Click += new System.EventHandler(this.calulateBtn_Click);
            // 
            // ParabolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calulateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValueCTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValueBTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueATb);
            this.Name = "ParabolaForm";
            this.Text = "ParabolaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValueCTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValueBTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValueATb;
        private System.Windows.Forms.Button calulateBtn;
    }
}