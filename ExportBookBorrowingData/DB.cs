using ExportBookBorrowingData.EntitiyModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBookBorrowingData
{
    public class DB
    {
        private readonly string str = @"Data Source=.;Initial Catalog=Librarydb;Integrated Security=SSPI; ";
        private SqlConnection con;
        
        public DB()
        {
           
        }
        public List<Student> ReadStudentData()
        {
            List<Student> students = new List<Student>();
            string sql = "select *from student";
            con = new SqlConnection(str);
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                foreach (DataRow dataRow in dt.Rows)
                {
                    students.Add(new Student
                    {
                        Class = dataRow["Class"].ToString(),
                        Name = dataRow["Name"].ToString(),
                    });
                }
            }
            con.Dispose();
            con.Close();
            return students;
        }
        public List<Teacher> ReadTeacherData()
        {
            List<Teacher> teachers = new List<Teacher>();
            string sql = "select *from teacher";
            con = new SqlConnection(str);
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                foreach (DataRow dataRow in dt.Rows)
                {
                    teachers.Add(new Teacher
                    {
                        Department = dataRow["Department"].ToString(),
                        Name = dataRow["Name"].ToString(),
                    });
                }
            }
            con.Dispose();
            con.Close();
            return teachers;
        }

        public List<Book> ReadBookData()
        {
            List<Book> books = new List<Book>();
            string sql = "select *from book";
            con = new SqlConnection(str);
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    books.Add(new Book
                    {
                        Author = dataRow["Author"].ToString(),
                        Category = dataRow["Category"].ToString(),
                        Classification = dataRow["Classification"].ToString(),
                        Id = dataRow["Id"].ToString(),
                        ISBN = dataRow["ISBN"].ToString(),
                        Pages = dataRow["Pages"].ToString(),
                        Price = Convert.ToDouble(dataRow["Price"]),
                        Press = dataRow["Press"].ToString(),
                        PublishYear = dataRow["PublishYear"].ToString(),
                        SeriesAuthor = dataRow["SeriesAuthor"].ToString(),
                        SeriesTitle = dataRow["SeriesTitle"].ToString(),
                        Title = dataRow["Title"].ToString(),
                        Version = dataRow["Version"].ToString(),
                    });
                }
            }
            con.Dispose();
            con.Close();
            return books;
        }

    }
}
