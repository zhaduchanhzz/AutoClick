namespace AutoClick
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.n10 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.n1000 = new System.Windows.Forms.NumericUpDown();
            this.n100 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTypeClick = new System.Windows.Forms.ComboBox();
            this.cbxMouse = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nCount = new System.Windows.Forms.NumericUpDown();
            this.chkCount = new System.Windows.Forms.CheckBox();
            this.chkRecord = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.n10)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n1000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n100)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // n10
            // 
            this.n10.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.n10.Location = new System.Drawing.Point(272, 56);
            this.n10.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.n10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n10.Name = "n10";
            this.n10.ReadOnly = true;
            this.n10.Size = new System.Drawing.Size(34, 20);
            this.n10.TabIndex = 2;
            this.n10.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n10.ValueChanged += new System.EventHandler(this.n10_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.n1000);
            this.panel1.Controls.Add(this.n100);
            this.panel1.Controls.Add(this.n10);
            this.panel1.Location = new System.Drawing.Point(13, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 132);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Interval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "1/1000s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "1/100s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "1/10s";
            // 
            // n1000
            // 
            this.n1000.Location = new System.Drawing.Point(73, 56);
            this.n1000.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.n1000.Name = "n1000";
            this.n1000.ReadOnly = true;
            this.n1000.Size = new System.Drawing.Size(34, 20);
            this.n1000.TabIndex = 4;
            this.n1000.ValueChanged += new System.EventHandler(this.n1000_ValueChanged);
            // 
            // n100
            // 
            this.n100.Location = new System.Drawing.Point(172, 56);
            this.n100.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.n100.Name = "n100";
            this.n100.ReadOnly = true;
            this.n100.Size = new System.Drawing.Size(34, 20);
            this.n100.TabIndex = 3;
            this.n100.ValueChanged += new System.EventHandler(this.n100_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxTypeClick);
            this.panel2.Controls.Add(this.cbxMouse);
            this.panel2.Location = new System.Drawing.Point(13, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 100);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clicktype";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mouse";
            // 
            // cbxTypeClick
            // 
            this.cbxTypeClick.FormattingEnabled = true;
            this.cbxTypeClick.Location = new System.Drawing.Point(98, 58);
            this.cbxTypeClick.Name = "cbxTypeClick";
            this.cbxTypeClick.Size = new System.Drawing.Size(69, 21);
            this.cbxTypeClick.TabIndex = 1;
            this.cbxTypeClick.SelectedIndexChanged += new System.EventHandler(this.cbxTypeClick_SelectedIndexChanged);
            // 
            // cbxMouse
            // 
            this.cbxMouse.FormattingEnabled = true;
            this.cbxMouse.Location = new System.Drawing.Point(98, 18);
            this.cbxMouse.Name = "cbxMouse";
            this.cbxMouse.Size = new System.Drawing.Size(69, 21);
            this.cbxMouse.TabIndex = 0;
            this.cbxMouse.SelectedIndexChanged += new System.EventHandler(this.cbxMouse_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.nCount);
            this.panel3.Controls.Add(this.chkCount);
            this.panel3.Location = new System.Drawing.Point(249, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 100);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "(Clicks)";
            // 
            // nCount
            // 
            this.nCount.Location = new System.Drawing.Point(32, 54);
            this.nCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCount.Name = "nCount";
            this.nCount.Size = new System.Drawing.Size(54, 20);
            this.nCount.TabIndex = 1;
            this.nCount.ValueChanged += new System.EventHandler(this.nCount_ValueChanged);
            // 
            // chkCount
            // 
            this.chkCount.AutoSize = true;
            this.chkCount.Location = new System.Drawing.Point(32, 21);
            this.chkCount.Name = "chkCount";
            this.chkCount.Size = new System.Drawing.Size(54, 17);
            this.chkCount.TabIndex = 0;
            this.chkCount.Text = "Count";
            this.chkCount.UseVisualStyleBackColor = true;
            this.chkCount.CheckedChanged += new System.EventHandler(this.chkCount_CheckedChanged);
            // 
            // chkRecord
            // 
            this.chkRecord.AutoSize = true;
            this.chkRecord.Location = new System.Drawing.Point(61, 65);
            this.chkRecord.Name = "chkRecord";
            this.chkRecord.Size = new System.Drawing.Size(112, 17);
            this.chkRecord.TabIndex = 6;
            this.chkRecord.Text = "click by Recorded";
            this.chkRecord.UseVisualStyleBackColor = true;
            this.chkRecord.CheckedChanged += new System.EventHandler(this.chkRecord_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 61);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.chkRecord);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(2, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 412);
            this.panel4.TabIndex = 10;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 418);
            this.Controls.Add(this.panel4);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(421, 457);
            this.MinimumSize = new System.Drawing.Size(421, 457);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.n10)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n1000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n100)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown n10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown n1000;
        private System.Windows.Forms.NumericUpDown n100;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTypeClick;
        private System.Windows.Forms.ComboBox cbxMouse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nCount;
        private System.Windows.Forms.CheckBox chkCount;
        private System.Windows.Forms.CheckBox chkRecord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

