
namespace Demo
{
    partial class HyperbolaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueCTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueBTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueATb = new System.Windows.Forms.TextBox();
            this.parabolaDiff = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calulateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "В меню";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(471, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Текущее уравнение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "C";
            // 
            // ValueCTb
            // 
            this.ValueCTb.Location = new System.Drawing.Point(92, 172);
            this.ValueCTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ValueCTb.Name = "ValueCTb";
            this.ValueCTb.Size = new System.Drawing.Size(175, 22);
            this.ValueCTb.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "B";
            // 
            // ValueBTb
            // 
            this.ValueBTb.Location = new System.Drawing.Point(92, 103);
            this.ValueBTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ValueBTb.Name = "ValueBTb";
            this.ValueBTb.Size = new System.Drawing.Size(175, 22);
            this.ValueBTb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "K";
            // 
            // ValueATb
            // 
            this.ValueATb.Location = new System.Drawing.Point(92, 33);
            this.ValueATb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ValueATb.Name = "ValueATb";
            this.ValueATb.Size = new System.Drawing.Size(175, 22);
            this.ValueATb.TabIndex = 14;
            // 
            // parabolaDiff
            // 
            this.parabolaDiff.AutoSize = true;
            this.parabolaDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parabolaDiff.Location = new System.Drawing.Point(491, 95);
            this.parabolaDiff.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.parabolaDiff.Name = "parabolaDiff";
            this.parabolaDiff.Size = new System.Drawing.Size(74, 24);
            this.parabolaDiff.TabIndex = 24;
            this.parabolaDiff.Text = "y = k / x";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ValueCTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ValueBTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ValueATb);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(299, 207);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коефициенты уравнения";
            // 
            // calulateBtn
            // 
            this.calulateBtn.Location = new System.Drawing.Point(355, 180);
            this.calulateBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.calulateBtn.Name = "calulateBtn";
            this.calulateBtn.Size = new System.Drawing.Size(303, 58);
            this.calulateBtn.TabIndex = 20;
            this.calulateBtn.Text = "Расщитать";
            this.calulateBtn.UseVisualStyleBackColor = true;
            // 
            // HyperbolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parabolaDiff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calulateBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HyperbolaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение уравнения гиперболы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValueCTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValueBTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValueATb;
        private System.Windows.Forms.Label parabolaDiff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calulateBtn;
    }
}