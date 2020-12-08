
namespace Demo
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ValueATb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hyperbolaRb = new System.Windows.Forms.RadioButton();
            this.ElipsRb = new System.Windows.Forms.RadioButton();
            this.parabolaRb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueBTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueCTb = new System.Windows.Forms.TextBox();
            this.calulateBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // ValueATb
            // 
            this.ValueATb.Location = new System.Drawing.Point(263, 32);
            this.ValueATb.Name = "ValueATb";
            this.ValueATb.Size = new System.Drawing.Size(100, 20);
            this.ValueATb.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parabolaRb);
            this.groupBox1.Controls.Add(this.ElipsRb);
            this.groupBox1.Controls.Add(this.hyperbolaRb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите вид уравнение";
            // 
            // hyperbolaRb
            // 
            this.hyperbolaRb.AutoSize = true;
            this.hyperbolaRb.Checked = true;
            this.hyperbolaRb.Location = new System.Drawing.Point(20, 37);
            this.hyperbolaRb.Name = "hyperbolaRb";
            this.hyperbolaRb.Size = new System.Drawing.Size(79, 17);
            this.hyperbolaRb.TabIndex = 0;
            this.hyperbolaRb.TabStop = true;
            this.hyperbolaRb.Text = "Гипербола";
            this.hyperbolaRb.UseVisualStyleBackColor = true;
            this.hyperbolaRb.CheckedChanged += new System.EventHandler(this.hyperbolaRb_CheckedChanged);
            // 
            // ElipsRb
            // 
            this.ElipsRb.AutoSize = true;
            this.ElipsRb.Location = new System.Drawing.Point(20, 74);
            this.ElipsRb.Name = "ElipsRb";
            this.ElipsRb.Size = new System.Drawing.Size(56, 17);
            this.ElipsRb.TabIndex = 1;
            this.ElipsRb.TabStop = true;
            this.ElipsRb.Text = "Элипс";
            this.ElipsRb.UseVisualStyleBackColor = true;
            // 
            // parabolaRb
            // 
            this.parabolaRb.AutoSize = true;
            this.parabolaRb.Location = new System.Drawing.Point(20, 97);
            this.parabolaRb.Name = "parabolaRb";
            this.parabolaRb.Size = new System.Drawing.Size(75, 17);
            this.parabolaRb.TabIndex = 2;
            this.parabolaRb.Text = "Парабола";
            this.parabolaRb.UseVisualStyleBackColor = true;
            this.parabolaRb.CheckedChanged += new System.EventHandler(this.parabolaRb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // ValueBTb
            // 
            this.ValueBTb.Location = new System.Drawing.Point(263, 83);
            this.ValueBTb.Name = "ValueBTb";
            this.ValueBTb.Size = new System.Drawing.Size(100, 20);
            this.ValueBTb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C";
            // 
            // ValueCTb
            // 
            this.ValueCTb.Location = new System.Drawing.Point(263, 124);
            this.ValueCTb.Name = "ValueCTb";
            this.ValueCTb.Size = new System.Drawing.Size(100, 20);
            this.ValueCTb.TabIndex = 6;
            // 
            // calulateBtn
            // 
            this.calulateBtn.Location = new System.Drawing.Point(458, 131);
            this.calulateBtn.Name = "calulateBtn";
            this.calulateBtn.Size = new System.Drawing.Size(75, 23);
            this.calulateBtn.TabIndex = 10;
            this.calulateBtn.Text = "button1";
            this.calulateBtn.UseVisualStyleBackColor = true;
            this.calulateBtn.Click += new System.EventHandler(this.calulateBtn_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Уравнение";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "A";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "B";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "C";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Min";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Max";
            this.Column8.Name = "Column8";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.calulateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValueCTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValueBTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ValueATb);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Основная форма";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ValueATb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton parabolaRb;
        private System.Windows.Forms.RadioButton ElipsRb;
        private System.Windows.Forms.RadioButton hyperbolaRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValueBTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValueCTb;
        private System.Windows.Forms.Button calulateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}