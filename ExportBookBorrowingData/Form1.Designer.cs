namespace ExportBookBorrowingData
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.teacher_groupBox = new System.Windows.Forms.GroupBox();
            this.stu_groupBox = new System.Windows.Forms.GroupBox();
            this.teacher_text_startBetween = new System.Windows.Forms.TextBox();
            this.teacher_text_endBetween = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_text_endDay = new System.Windows.Forms.TextBox();
            this.teacher_text_repeatTimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_btu_BrrowingBuilder = new System.Windows.Forms.Button();
            this.stu_btu_BrrowingBuilder = new System.Windows.Forms.Button();
            this.stu_text_records = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stu_text_endDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stu_text_endBetween = new System.Windows.Forms.TextBox();
            this.stu_text_startBetween = new System.Windows.Forms.TextBox();
            this.prompt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.teacher_btu_clear = new System.Windows.Forms.Button();
            this.stu_btu_clear = new System.Windows.Forms.Button();
            this.teacher_text_startDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.stu_text_stratDay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.teacher_groupBox.SuspendLayout();
            this.stu_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacher_groupBox
            // 
            this.teacher_groupBox.Controls.Add(this.label10);
            this.teacher_groupBox.Controls.Add(this.teacher_text_startDay);
            this.teacher_groupBox.Controls.Add(this.teacher_btu_clear);
            this.teacher_groupBox.Controls.Add(this.teacher_btu_BrrowingBuilder);
            this.teacher_groupBox.Controls.Add(this.teacher_text_repeatTimes);
            this.teacher_groupBox.Controls.Add(this.label4);
            this.teacher_groupBox.Controls.Add(this.teacher_text_endDay);
            this.teacher_groupBox.Controls.Add(this.label3);
            this.teacher_groupBox.Controls.Add(this.label2);
            this.teacher_groupBox.Controls.Add(this.label1);
            this.teacher_groupBox.Controls.Add(this.teacher_text_endBetween);
            this.teacher_groupBox.Controls.Add(this.teacher_text_startBetween);
            this.teacher_groupBox.Location = new System.Drawing.Point(12, 12);
            this.teacher_groupBox.Name = "teacher_groupBox";
            this.teacher_groupBox.Size = new System.Drawing.Size(262, 186);
            this.teacher_groupBox.TabIndex = 0;
            this.teacher_groupBox.TabStop = false;
            this.teacher_groupBox.Text = "教师生成记录";
            // 
            // stu_groupBox
            // 
            this.stu_groupBox.Controls.Add(this.label11);
            this.stu_groupBox.Controls.Add(this.stu_text_stratDay);
            this.stu_groupBox.Controls.Add(this.stu_btu_clear);
            this.stu_groupBox.Controls.Add(this.stu_btu_BrrowingBuilder);
            this.stu_groupBox.Controls.Add(this.stu_text_records);
            this.stu_groupBox.Controls.Add(this.stu_text_startBetween);
            this.stu_groupBox.Controls.Add(this.label5);
            this.stu_groupBox.Controls.Add(this.stu_text_endBetween);
            this.stu_groupBox.Controls.Add(this.stu_text_endDay);
            this.stu_groupBox.Controls.Add(this.label8);
            this.stu_groupBox.Controls.Add(this.label6);
            this.stu_groupBox.Controls.Add(this.label7);
            this.stu_groupBox.Location = new System.Drawing.Point(280, 12);
            this.stu_groupBox.Name = "stu_groupBox";
            this.stu_groupBox.Size = new System.Drawing.Size(262, 186);
            this.stu_groupBox.TabIndex = 1;
            this.stu_groupBox.TabStop = false;
            this.stu_groupBox.Text = "学生生成记录";
            // 
            // teacher_text_startBetween
            // 
            this.teacher_text_startBetween.Location = new System.Drawing.Point(103, 34);
            this.teacher_text_startBetween.MaxLength = 3;
            this.teacher_text_startBetween.Name = "teacher_text_startBetween";
            this.teacher_text_startBetween.Size = new System.Drawing.Size(49, 21);
            this.teacher_text_startBetween.TabIndex = 0;
            this.teacher_text_startBetween.Text = "5";
            // 
            // teacher_text_endBetween
            // 
            this.teacher_text_endBetween.Location = new System.Drawing.Point(175, 34);
            this.teacher_text_endBetween.MaxLength = 3;
            this.teacher_text_endBetween.Name = "teacher_text_endBetween";
            this.teacher_text_endBetween.Size = new System.Drawing.Size(49, 21);
            this.teacher_text_endBetween.TabIndex = 1;
            this.teacher_text_endBetween.Text = "35";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "随机抽取范围：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "借还随机天数：";
            // 
            // teacher_text_endDay
            // 
            this.teacher_text_endDay.Location = new System.Drawing.Point(175, 71);
            this.teacher_text_endDay.MaxLength = 4;
            this.teacher_text_endDay.Name = "teacher_text_endDay";
            this.teacher_text_endDay.Size = new System.Drawing.Size(49, 21);
            this.teacher_text_endDay.TabIndex = 3;
            this.teacher_text_endDay.Text = "62";
            // 
            // teacher_text_repeatTimes
            // 
            this.teacher_text_repeatTimes.Location = new System.Drawing.Point(103, 106);
            this.teacher_text_repeatTimes.MaxLength = 8;
            this.teacher_text_repeatTimes.Name = "teacher_text_repeatTimes";
            this.teacher_text_repeatTimes.Size = new System.Drawing.Size(49, 21);
            this.teacher_text_repeatTimes.TabIndex = 4;
            this.teacher_text_repeatTimes.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "重复次数：";
            // 
            // teacher_btu_BrrowingBuilder
            // 
            this.teacher_btu_BrrowingBuilder.Location = new System.Drawing.Point(103, 144);
            this.teacher_btu_BrrowingBuilder.Name = "teacher_btu_BrrowingBuilder";
            this.teacher_btu_BrrowingBuilder.Size = new System.Drawing.Size(66, 30);
            this.teacher_btu_BrrowingBuilder.TabIndex = 5;
            this.teacher_btu_BrrowingBuilder.Text = "生成";
            this.teacher_btu_BrrowingBuilder.UseVisualStyleBackColor = true;
            this.teacher_btu_BrrowingBuilder.Click += new System.EventHandler(this.teacher_btu_BrrowingBuilder_Click);
            // 
            // stu_btu_BrrowingBuilder
            // 
            this.stu_btu_BrrowingBuilder.Location = new System.Drawing.Point(103, 144);
            this.stu_btu_BrrowingBuilder.Name = "stu_btu_BrrowingBuilder";
            this.stu_btu_BrrowingBuilder.Size = new System.Drawing.Size(66, 30);
            this.stu_btu_BrrowingBuilder.TabIndex = 12;
            this.stu_btu_BrrowingBuilder.Text = "生成";
            this.stu_btu_BrrowingBuilder.UseVisualStyleBackColor = true;
            this.stu_btu_BrrowingBuilder.Click += new System.EventHandler(this.stu_btu_BrrowingBuilder_Click);
            // 
            // stu_text_records
            // 
            this.stu_text_records.Location = new System.Drawing.Point(103, 106);
            this.stu_text_records.MaxLength = 8;
            this.stu_text_records.Name = "stu_text_records";
            this.stu_text_records.Size = new System.Drawing.Size(49, 21);
            this.stu_text_records.TabIndex = 11;
            this.stu_text_records.Text = "2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "记录条数：";
            // 
            // stu_text_endDay
            // 
            this.stu_text_endDay.Location = new System.Drawing.Point(175, 71);
            this.stu_text_endDay.MaxLength = 4;
            this.stu_text_endDay.Name = "stu_text_endDay";
            this.stu_text_endDay.Size = new System.Drawing.Size(49, 21);
            this.stu_text_endDay.TabIndex = 10;
            this.stu_text_endDay.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "借还随机天数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "~";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "随机抽取范围：";
            // 
            // stu_text_endBetween
            // 
            this.stu_text_endBetween.Location = new System.Drawing.Point(175, 34);
            this.stu_text_endBetween.MaxLength = 3;
            this.stu_text_endBetween.Name = "stu_text_endBetween";
            this.stu_text_endBetween.Size = new System.Drawing.Size(49, 21);
            this.stu_text_endBetween.TabIndex = 8;
            this.stu_text_endBetween.Text = "10";
            // 
            // stu_text_startBetween
            // 
            this.stu_text_startBetween.Location = new System.Drawing.Point(103, 34);
            this.stu_text_startBetween.MaxLength = 3;
            this.stu_text_startBetween.Name = "stu_text_startBetween";
            this.stu_text_startBetween.Size = new System.Drawing.Size(49, 21);
            this.stu_text_startBetween.TabIndex = 7;
            this.stu_text_startBetween.Text = "5";
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Location = new System.Drawing.Point(13, 205);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(461, 12);
            this.prompt.TabIndex = 2;
            this.prompt.Text = "备注：1、生成的文件会保存在该程序的文件夹中，名为：[Role]图书借阅登记表.xlsx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "2、生成后请保存至其他文件夹，避免数据覆盖";
            // 
            // teacher_btu_clear
            // 
            this.teacher_btu_clear.Location = new System.Drawing.Point(175, 144);
            this.teacher_btu_clear.Name = "teacher_btu_clear";
            this.teacher_btu_clear.Size = new System.Drawing.Size(66, 30);
            this.teacher_btu_clear.TabIndex = 6;
            this.teacher_btu_clear.Text = "清空";
            this.teacher_btu_clear.UseVisualStyleBackColor = true;
            this.teacher_btu_clear.Click += new System.EventHandler(this.teacher_btu_clear_Click);
            // 
            // stu_btu_clear
            // 
            this.stu_btu_clear.Location = new System.Drawing.Point(175, 144);
            this.stu_btu_clear.Name = "stu_btu_clear";
            this.stu_btu_clear.Size = new System.Drawing.Size(66, 30);
            this.stu_btu_clear.TabIndex = 13;
            this.stu_btu_clear.Text = "清空";
            this.stu_btu_clear.UseVisualStyleBackColor = true;
            this.stu_btu_clear.Click += new System.EventHandler(this.stu_btu_clear_Click);
            // 
            // teacher_text_startDay
            // 
            this.teacher_text_startDay.Location = new System.Drawing.Point(103, 71);
            this.teacher_text_startDay.MaxLength = 4;
            this.teacher_text_startDay.Name = "teacher_text_startDay";
            this.teacher_text_startDay.Size = new System.Drawing.Size(49, 21);
            this.teacher_text_startDay.TabIndex = 2;
            this.teacher_text_startDay.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "~";
            // 
            // stu_text_stratDay
            // 
            this.stu_text_stratDay.Location = new System.Drawing.Point(103, 71);
            this.stu_text_stratDay.MaxLength = 4;
            this.stu_text_stratDay.Name = "stu_text_stratDay";
            this.stu_text_stratDay.Size = new System.Drawing.Size(49, 21);
            this.stu_text_stratDay.TabIndex = 9;
            this.stu_text_stratDay.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 240);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.stu_groupBox);
            this.Controls.Add(this.teacher_groupBox);
            this.Name = "Form1";
            this.Text = "借阅记录生成器";
            this.teacher_groupBox.ResumeLayout(false);
            this.teacher_groupBox.PerformLayout();
            this.stu_groupBox.ResumeLayout(false);
            this.stu_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox teacher_groupBox;
        private System.Windows.Forms.TextBox teacher_text_repeatTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_text_endDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacher_text_endBetween;
        private System.Windows.Forms.TextBox teacher_text_startBetween;
        private System.Windows.Forms.GroupBox stu_groupBox;
        private System.Windows.Forms.Button teacher_btu_BrrowingBuilder;
        private System.Windows.Forms.Button stu_btu_BrrowingBuilder;
        private System.Windows.Forms.TextBox stu_text_records;
        private System.Windows.Forms.TextBox stu_text_startBetween;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stu_text_endBetween;
        private System.Windows.Forms.TextBox stu_text_endDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button teacher_btu_clear;
        private System.Windows.Forms.Button stu_btu_clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox teacher_text_startDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stu_text_stratDay;
    }
}

