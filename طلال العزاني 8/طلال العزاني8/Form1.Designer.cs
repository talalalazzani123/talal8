namespace المحاضرة_الثامنة
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
            this.txtall_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cut_btn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textall_length = new System.Windows.Forms.TextBox();
            this.txtselect_length = new System.Windows.Forms.TextBox();
            this.txtnum_word = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtedite = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearsh = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.txtcopypast = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.listBoxchar = new System.Windows.Forms.ListBox();
            this.listBoxword = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtall_text
            // 
            this.txtall_text.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtall_text.Location = new System.Drawing.Point(5, 10);
            this.txtall_text.Multiline = true;
            this.txtall_text.Name = "txtall_text";
            this.txtall_text.Size = new System.Drawing.Size(1088, 109);
            this.txtall_text.TabIndex = 0;
            this.txtall_text.Text = "من اهم استخدامات لغة السي شارب برمجة تطبيقات سطح المكتب وبرمجة تطبيقات الهواتف ال" +
    "ذكية وصناعة الالعاب";
            this.txtall_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtall_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(950, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "طول النص كامل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "طول النص المحدد";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "عدد الكلمات";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "حذف النص المحدد";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(349, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "إلغاء التحديد";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(221, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 35);
            this.button6.TabIndex = 6;
            this.button6.Text = "نسخ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cut_btn
            // 
            this.cut_btn.Location = new System.Drawing.Point(112, 124);
            this.cut_btn.Name = "cut_btn";
            this.cut_btn.Size = new System.Drawing.Size(88, 35);
            this.cut_btn.TabIndex = 7;
            this.cut_btn.Text = "قص";
            this.cut_btn.UseVisualStyleBackColor = true;
            this.cut_btn.Click += new System.EventHandler(this.cut_btn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 122);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 35);
            this.button8.TabIndex = 8;
            this.button8.Text = "تنظيف";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textall_length
            // 
            this.textall_length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textall_length.Location = new System.Drawing.Point(950, 165);
            this.textall_length.Multiline = true;
            this.textall_length.Name = "textall_length";
            this.textall_length.Size = new System.Drawing.Size(143, 30);
            this.textall_length.TabIndex = 9;
            // 
            // txtselect_length
            // 
            this.txtselect_length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtselect_length.Location = new System.Drawing.Point(801, 165);
            this.txtselect_length.Multiline = true;
            this.txtselect_length.Name = "txtselect_length";
            this.txtselect_length.Size = new System.Drawing.Size(143, 30);
            this.txtselect_length.TabIndex = 10;
            // 
            // txtnum_word
            // 
            this.txtnum_word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum_word.Location = new System.Drawing.Point(675, 165);
            this.txtnum_word.Multiline = true;
            this.txtnum_word.Name = "txtnum_word";
            this.txtnum_word.Size = new System.Drawing.Size(120, 30);
            this.txtnum_word.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(349, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(306, 35);
            this.button9.TabIndex = 12;
            this.button9.Text = "طول النص كامل بدون فراغات";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(23, 166);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(306, 35);
            this.button10.TabIndex = 13;
            this.button10.Text = "طول النص المحدد بدون فراغات";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtedite);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Location = new System.Drawing.Point(600, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(473, 152);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "استبدال";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "النص الجديد";
            // 
            // txtedite
            // 
            this.txtedite.Location = new System.Drawing.Point(153, 59);
            this.txtedite.Multiline = true;
            this.txtedite.Name = "txtedite";
            this.txtedite.Size = new System.Drawing.Size(177, 32);
            this.txtedite.TabIndex = 18;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(187, 97);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 35);
            this.button11.TabIndex = 17;
            this.button11.Text = "استبدال";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtsearsh);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Location = new System.Drawing.Point(41, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(521, 152);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بحث";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "النص المراد البحث عنه";
            // 
            // txtsearsh
            // 
            this.txtsearsh.Location = new System.Drawing.Point(223, 59);
            this.txtsearsh.Multiline = true;
            this.txtsearsh.Name = "txtsearsh";
            this.txtsearsh.Size = new System.Drawing.Size(257, 32);
            this.txtsearsh.TabIndex = 17;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(27, 97);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 35);
            this.button14.TabIndex = 6;
            this.button14.Text = "بحث عن السابق";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(207, 97);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 35);
            this.button13.TabIndex = 5;
            this.button13.Text = "بحث عن التالي";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(360, 97);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 35);
            this.button12.TabIndex = 4;
            this.button12.Text = "بحث";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // txtcopypast
            // 
            this.txtcopypast.Location = new System.Drawing.Point(632, 407);
            this.txtcopypast.Multiline = true;
            this.txtcopypast.Name = "txtcopypast";
            this.txtcopypast.Size = new System.Drawing.Size(441, 226);
            this.txtcopypast.TabIndex = 17;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(953, 366);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 35);
            this.button15.TabIndex = 18;
            this.button15.Text = "لصق";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(632, 366);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 35);
            this.button16.TabIndex = 19;
            this.button16.Text = "تراجع";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(368, 395);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(165, 35);
            this.button17.TabIndex = 20;
            this.button17.Text = "عرض";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(53, 389);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(165, 35);
            this.button18.TabIndex = 21;
            this.button18.Text = "عرض";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // listBoxchar
            // 
            this.listBoxchar.FormattingEnabled = true;
            this.listBoxchar.ItemHeight = 19;
            this.listBoxchar.Items.AddRange(new object[] {
            ""});
            this.listBoxchar.Location = new System.Drawing.Point(368, 436);
            this.listBoxchar.Name = "listBoxchar";
            this.listBoxchar.Size = new System.Drawing.Size(165, 194);
            this.listBoxchar.TabIndex = 22;
            // 
            // listBoxword
            // 
            this.listBoxword.FormattingEnabled = true;
            this.listBoxword.ItemHeight = 19;
            this.listBoxword.Items.AddRange(new object[] {
            ""});
            this.listBoxword.Location = new System.Drawing.Point(53, 430);
            this.listBoxword.Name = "listBoxword";
            this.listBoxword.Size = new System.Drawing.Size(165, 194);
            this.listBoxword.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "احرف الكلمة المحددة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "كلمات الجملة المحددة";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxword);
            this.Controls.Add(this.listBoxchar);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.txtcopypast);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txtnum_word);
            this.Controls.Add(this.txtselect_length);
            this.Controls.Add(this.textall_length);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.cut_btn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtall_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtall_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button cut_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textall_length;
        private System.Windows.Forms.TextBox txtselect_length;
        private System.Windows.Forms.TextBox txtnum_word;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtedite;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearsh;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox txtcopypast;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ListBox listBoxchar;
        private System.Windows.Forms.ListBox listBoxword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

