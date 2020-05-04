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
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        private double probability;
        private int day;

        public void ExprotStudentBorrowingData()
        {
            var books = Books;
            var students = Students;

            probability = GetRandomNumber(0.05, 0.1, 2);
            int count = Convert.ToInt32(probability * Students.Count);

            for (var i = 0; i < count; i++)
            {
                day = new Random().Next(1, 10);
                var student = students[new Random().Next(0, students.Count)];
                var book = books[new Random().Next(0, books.Count)];
                books.Remove(book);
                var studentBorrowing = new StudentBorrowing
                {
                    Id = i + 1,
                    SerialNumber = "",
                    Author = book.Author,
                    Category = book.Category,
                    Class = student.Class,
                    Name = student.Name,
                    Classification = book.Classification,
                    ISBN = book.ISBN,
                    Pages = book.Pages,
                    Press = book.Press,
                    Price = book.Price,
                    Version = book.Version,
                    PublishYear = book.PublishYear,
                    Title = book.Title,
                    SeriesTitle = book.SeriesTitle,
                    SeriesAuthor = book.SeriesAuthor,
                    Remarks = "",

                };

                if (new Random().NextDouble() < 0.4)
                {
                    var BorrowDate = DateConstraint.RandomDate(DateTime.Parse("2018-12-28"), DateTime.Parse("2019-12-31"));
                    var returndate = BorrowDate.AddDays(day);
                    studentBorrowing.IsDiscard = "否";//是否丢失
                    studentBorrowing.IsOverdue = "否";//是否逾期
                    studentBorrowing.BorrowBookDay = day + "";
                    studentBorrowing.BorrowDate = BorrowDate.ToString("yyyy-MM-dd");

                    if (!DateConstraint.IsValidDate(returndate))
                    {
                        while (DateConstraint.IsValidDate(returndate))
                        {
                            day = new Random().Next(1, 10);
                            returndate = BorrowDate.AddDays(day);
                        }
                    }
                    studentBorrowing.ReturnDate = returndate.ToString("yyyy-MM-dd");
                }
                StudentBorrowings.Add(studentBorrowing);
            }
            var dt = ListToDataTable(StudentBorrowings);
            var path = System.IO.Directory.GetCurrentDirectory();
            ExportExcelFile.ExportFile($"{path}\\学生图书借阅登记表.xlsx", dt, "柳州市第二职业技术学校学生图书借阅登记表", "学生图书借阅登记表");
        }

        public void ExprotTeacherBorrowing()
        {
            var books = Books;
            var teachers = Teachers;

            probability = GetRandomNumber(0.05, 0.1, 2);
            int count = Convert.ToInt32(probability * Students.Count);

            for (var i = 0; i < count; i++)
            {
                day = new Random().Next(1, 10);
                var teacher = teachers[new Random().Next(0, teachers.Count)];
                var book = books[new Random().Next(0, books.Count)];
                books.Remove(book);
                var teacherBorrowing = new TeacherBorrowing
                {
                    Id = i + 1,
                    SerialNumber = "",
                    Author = book.Author,
                    Category = book.Category,
                    Department = teacher.Department,
                    Name = teacher.Name,
                    Classification = book.Classification,
                    ISBN = book.ISBN,
                    Pages = book.Pages,
                    Press = book.Press,
                    Price = book.Price,
                    Version = book.Version,
                    PublishYear = book.PublishYear,
                    Title = book.Title,
                    SeriesTitle = book.SeriesTitle,
                    SeriesAuthor = book.SeriesAuthor,
                    Remarks = "",

                };

                if (new Random().NextDouble() < 0.4)
                {
                    var BorrowDate = DateConstraint.RandomDate(DateTime.Parse("2018-12-28"), DateTime.Parse("2019-12-31"));
                    var returndate = BorrowDate.AddDays(day);
                    teacherBorrowing.IsDiscard = "否";//是否丢失
                    teacherBorrowing.IsOverdue = "否";//是否逾期
                    teacherBorrowing.BorrowBookDay = day + "";
                    teacherBorrowing.BorrowDate = BorrowDate.ToString("yyyy-MM-dd");

                    if (!DateConstraint.IsValidDate(returndate))
                    {
                        while (DateConstraint.IsValidDate(returndate))
                        {
                            day = new Random().Next(1, 10);
                            returndate = BorrowDate.AddDays(day);
                        }
                    }
                    teacherBorrowing.ReturnDate = returndate.ToString("yyyy-MM-dd");
                }
                TeacherBorrowings.Add(teacherBorrowing);
            }
            var dt = ListToDataTable(TeacherBorrowings);
            ExportExcelFile.ExportFile(@"D:\教师图书借阅登记表 .xlsx", dt, "柳州市第二职业技术学校学生图书借阅登记表", "教师图书借阅登记表 ");
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

            DataTable dt = new DataTable("data");
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
            return dt;
        }

    }

}
