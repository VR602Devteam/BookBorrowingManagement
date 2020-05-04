using ExportBookBorrowingData.EntitiyModels;
using ExportBookBorrowingData.ExportData.VM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExportBookBorrowingData
{
    public class ExportBorrowingData
    {
        public List<StudentBorrowing> StudentBorrowings { get; set; } = new List<StudentBorrowing>();
        public List<TeacherBorrowing> TeacherBorrowings { get; set; } = new List<TeacherBorrowing>();
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Book> NoBorrowingBooks { get; set; } = new List<Book>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ExportBorrowingData()
        {
            DB dB = new DB();
            Students = dB.ReadStudentData();
            Books = dB.ReadBookData();
            Teachers = dB.ReadTeacherData();


            NoBorrowingBooks = Books;
            var sBorrow = StudentBorrowings.Where(x => x.ReturnDate == string.Empty).ToList();
            var tBorrow = TeacherBorrowings.Where(x => x.ReturnDate == string.Empty).ToList();
            foreach (var item in sBorrow)
            {
                var borrowingBook = NoBorrowingBooks.SingleOrDefault(x => x.Id == item.BookId);
                NoBorrowingBooks.Remove(borrowingBook);
            }
            foreach (var item in tBorrow)
            {
                var borrowingBook = NoBorrowingBooks.SingleOrDefault(x => x.Id == item.BookId);
                NoBorrowingBooks.Remove(borrowingBook);
            }

        }



        public void ExprotStudentBorrowingData(int count, int leftday, int rightday, float leftRange, float rightRange)
        {
            var books = NoBorrowingBooks;
            var students = Students;
            var random = new Random();

            for (var i = 0; i < count; i++)
            {
                var day = random.Next(leftday, rightday);
                var studentRange = GetRandomNumber(leftRange, rightRange, 2);
                var studentIndex = Convert.ToInt32(studentRange * Students.Count);
                var student = students[studentIndex];
                var book = books[random.Next(0, books.Count)];
                books.Remove(book);
                var studentBorrowing = new StudentBorrowing
                {
                    Id = i + 1,
                    SerialNumber = "",
                    BookId = book.Id,
                    Author = book.Author,
                    Category = book.Category,
                    Class = student.Class,
                    Name = student.Name,
                    ISBN = book.ISBN,
                    Price = book.Price,
                    Version = book.Version,
                    PublishYear = book.PublishYear,
                    Title = book.Title,
                    SeriesTitle = book.SeriesTitle,
                    Remarks = "",
                };

                if (random.NextDouble() < 0.4)
                {
                    var BorrowDate = DateConstraint.RandomDate(DateTime.Parse("2018-12-28"), DateTime.Parse("2019-12-31"));
                    var returndate = BorrowDate.AddDays(day);
                    studentBorrowing.IsDiscard = "否";//是否丢失
                    studentBorrowing.IsOverdue = "否";//是否逾期
                    studentBorrowing.BorrowBookDay = day + "";
                    studentBorrowing.BorrowDate = BorrowDate.ToString("yyyy-MM-dd");

                    if (!DateConstraint.IsValidDate(returndate))
                    {
                        while (!DateConstraint.IsValidDate(returndate))
                        {
                            returndate = returndate.AddDays(2);
                        }
                    }
                    studentBorrowing.ReturnDate = returndate.ToString("yyyy-MM-dd");

                }
                else
                {
                    var BorrowDate = DateConstraint.RandomDate(DateTime.Parse("2018-12-28"), DateTime.Parse("2019-12-31"));
                    var returndate = BorrowDate.AddDays(day);
                    studentBorrowing.IsDiscard = "否";//是否丢失
                    studentBorrowing.IsOverdue = "是";//是否逾期
                    studentBorrowing.BorrowBookDay = day + "";
                    studentBorrowing.BorrowDate = BorrowDate.ToString("yyyy-MM-dd");
                }
                StudentBorrowings.Add(studentBorrowing);

            }
            var dt = ListToDataTable(StudentBorrowings);
            dt.Columns["Class"].ColumnName = "班级班级（专业-年级-班）";
            var path = System.IO.Directory.GetCurrentDirectory();
            ExportExcelFile.ExportFile($"{path}\\学生图书借阅登记表.xlsx", dt, "柳州市第二职业技术学校学生图书借阅登记表", "学生图书借阅登记表");
        }
        public void ExprotTeacherBorrowing(int count, int leftday, int rightday, float leftRange, float rightRange)
        {
            var books = NoBorrowingBooks;
            var teachers = Teachers;
            var random = new Random();

            for (var i = 0; i < count*100; i++)
            {
                var day = random.Next(leftday, rightday);
                var teacherRange = GetRandomNumber(leftRange, rightRange, 2);
                var teacherIndex = Convert.ToInt32(teacherRange * Teachers.Count);
                var teacher = teachers[teacherIndex];
                var book = books[random.Next(0, books.Count)];
                books.Remove(book);
                var teachersBorrowing = new TeacherBorrowing
                {
                    Id = i + 1,
                    SerialNumber = "",
                    BookId = book.Id,
                    Author = book.Author,
                    Category = book.Category,
                    Department= teacher.Department,
                    Name = teacher.Name,
                    ISBN = book.ISBN,
                    Price = book.Price,
                    Version = book.Version,
                    PublishYear = book.PublishYear,
                    Title = book.Title,
                    SeriesTitle = book.SeriesTitle,
                    Remarks = "",
                };

                if (random.NextDouble() < 0.4)
                {
                    var BorrowDate = DateConstraint.RandomDate(DateTime.Parse("2018-12-28"), DateTime.Parse("2019-12-31"));
                    var returndate = BorrowDate.AddDays(day);
                    teachersBorrowing.IsDiscard = "否";//是否丢失
                    teachersBorrowing.IsOverdue = "否";//是否逾期
                    teachersBorrowing.BorrowBookDay = day + "";
                    teachersBorrowing.BorrowDate = BorrowDate.ToString("yyyy-MM-dd");

                    if (!DateConstraint.IsValidDate(returndate))
                    {
                        while (!DateConstraint.IsValidDate(returndate))
                        {
                            returndate = returndate.AddDays(2);
                        }
                    }
                    teachersBorrowing.ReturnDate = returndate.ToString("yyyy-MM-dd");

                }
                else
                {
                    var BorrowDate = DateConstraint.RandomDate(DateTime.Parse("2018-12-28"), DateTime.Parse("2019-12-31"));
                    var returndate = BorrowDate.AddDays(day);
                    teachersBorrowing.IsDiscard = "否";//是否丢失
                    teachersBorrowing.IsOverdue = "是";//是否逾期
                    teachersBorrowing.BorrowBookDay = day + "";
                    teachersBorrowing.BorrowDate = BorrowDate.ToString("yyyy-MM-dd");
                }
                TeacherBorrowings.Add(teachersBorrowing);

            }
            var dt = ListToDataTable(TeacherBorrowings);
            dt.Columns["Department"].ColumnName = "部门";
            var path = System.IO.Directory.GetCurrentDirectory();
            ExportExcelFile.ExportFile($"{path}\\教师图书借阅登记表.xlsx", dt, "柳州市第二职业技术学校学生图书借阅登记表", "教师图书借阅登记表");
        }
        private void ExportExcelData()
        {

        }



        public double GetRandomNumber(double minimum, double maximum, int Len)   //Len小数点保留位数
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, Len);
        }
        public static DataTable ListToDataTable<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                return new DataTable();
            }
            //获取T下所有的属性
            Type entityType = list[0].GetType();
            PropertyInfo[] entityProperties = entityType.GetProperties();

            DataTable dt = new DataTable();
            for (int i = 0; i < entityProperties.Length; i++)
            {
                dt.Columns.Add(entityProperties[i].Name);
            }
            foreach (var item in list)
            {
                if (item.GetType() != entityType)
                {
                    throw new Exception("要转换集合元素类型不一致！");
                }
                //创建一个用于放所有属性值的数组
                object[] entityValues = new object[entityProperties.Length];
                for (int i = 0; i < entityProperties.Length; i++)
                {
                    entityValues[i] = entityProperties[i].GetValue(item, null);
                }
                dt.Rows.Add(entityValues);
            }
            dt.Columns["Id"].SetOrdinal(0);
            dt.Columns["Id"].ColumnName = "序号";
            dt.Columns["SerialNumber"].ColumnName = "结束流水号";
            dt.Columns["Name"].ColumnName = "借阅人";
            dt.Columns["BookId"].ColumnName = "图书条码";
            dt.Columns["Title"].ColumnName = "图书名称";
            dt.Columns["Author"].ColumnName = "作者";
            dt.Columns["SeriesTitle"].ColumnName = "丛书名";
            dt.Columns["Price"].ColumnName = "图书价格";
            dt.Columns["ISBN"].ColumnName = "ISBN";
            dt.Columns["PublishYear"].ColumnName = "出版时间";
            dt.Columns["Version"].ColumnName = "版次";
            dt.Columns["BorrowDate"].ColumnName = "借出日期";
            dt.Columns["ReturnDate"].ColumnName = "归还日期";
            dt.Columns["BorrowBookDay"].ColumnName = "借书天数";
            dt.Columns["IsOverdue"].ColumnName = "是否逾期";
            dt.Columns["IsDiscard"].ColumnName = "是否丢失";
            dt.Columns["CompensationAmount"].ColumnName = "赔偿金额";
            dt.Columns["Category"].ColumnName = "中图大类";
            dt.Columns["Remarks"].ColumnName = "备注";
            return dt;
        }

    }

}
