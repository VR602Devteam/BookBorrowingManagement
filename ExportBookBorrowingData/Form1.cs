using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportBookBorrowingData
{
    public partial class Form1 : Form
    {
        ExportBorrowingData exportBorrowingData;
        public Form1()
        {
            InitializeComponent();

            exportBorrowingData = new ExportBorrowingData();
        }

        private void teacher_btu_clear_Click(object sender, EventArgs e)
        {
            teacher_text_startBetween.Text = string.Empty;
            teacher_text_endBetween.Text = string.Empty;
            teacher_text_endDay.Text = string.Empty;
            teacher_text_repeatTimes.Text = string.Empty;
            teacher_text_startDay.Text = string.Empty;
        }

        private void stu_btu_clear_Click(object sender, EventArgs e)
        {
            stu_text_endBetween.Text = string.Empty;
            stu_text_startBetween.Text = string.Empty;
            stu_text_records.Text = string.Empty;
            stu_text_endDay.Text = string.Empty;
            stu_text_stratDay.Text = string.Empty;
        }

        private void stu_btu_BrrowingBuilder_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(stu_text_stratDay.Text) >= int.Parse(stu_text_endDay.Text) || int.Parse(stu_text_stratDay.Text) <= 0 || int.Parse(stu_text_endDay.Text) > 100)
                {
                    MessageBox.Show("借还天数必须是小于关系且大于0", "提示", MessageBoxButtons.OK);
                }
                else if (int.Parse(stu_text_startBetween.Text) > int.Parse(stu_text_endBetween.Text) || int.Parse(stu_text_startBetween.Text) <= 0)
                {
                    MessageBox.Show("抽取范围必须是小于关系且大于0", "提示", MessageBoxButtons.OK);
                }
                else if (int.Parse(stu_text_records.Text) < 10)
                {
                    MessageBox.Show("记录条数必须大于10", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    var count = int.Parse(stu_text_records.Text);
                    var leftDay = int.Parse(stu_text_stratDay.Text);
                    var rightDay = int.Parse(stu_text_endDay.Text);
                    float leftRange = float.Parse(stu_text_startBetween.Text) / 100;
                    float rightRange = float.Parse(stu_text_endBetween.Text) / 100;
                    exportBorrowingData.ExprotStudentBorrowingData(count, leftDay, rightDay, leftRange, rightRange);
                    MessageBox.Show("生成成功！", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "，请输入正整数", "提示", MessageBoxButtons.OK);
            }
        }

        private void teacher_btu_BrrowingBuilder_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(teacher_text_startDay.Text) >= int.Parse(teacher_text_endDay.Text) || int.Parse(teacher_text_startDay.Text) <= 0 || int.Parse(teacher_text_endDay.Text) > 100)
                {
                    MessageBox.Show("借还天数必须是小于关系且大于0", "提示", MessageBoxButtons.OK);
                }
                else if (int.Parse(teacher_text_startBetween.Text) > int.Parse(teacher_text_endBetween.Text) || int.Parse(teacher_text_startBetween.Text) <= 0)
                {
                    MessageBox.Show("抽取范围必须是小于关系且大于0", "提示", MessageBoxButtons.OK);
                }
                else if (int.Parse(teacher_text_repeatTimes.Text) <= 0)
                {
                    MessageBox.Show("重复次数必须大于0", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    var count = int.Parse(teacher_text_repeatTimes.Text);
                    var leftDay = int.Parse(teacher_text_startBetween.Text);
                    var rightDay = int.Parse(teacher_text_endDay.Text);
                    float leftRange = float.Parse(teacher_text_startBetween.Text) / 100;
                    float rightRange = float.Parse(teacher_text_endBetween.Text) / 100;
                    exportBorrowingData.ExprotTeacherBorrowing(count, leftDay, rightDay, leftRange, rightRange);
                    MessageBox.Show("生成成功！", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "，请输入正整数", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
