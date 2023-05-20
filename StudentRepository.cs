using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Evaluation_Manager
{
    public class StudentRepository
    {
        private static Student CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int.TryParse(reader["Grade"].ToString(), out int grade);
            var student = new Student {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };
            return student;

        }

        public static Student GetStudent(int id)
        {
            Student student = null;
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM Students WHERE id = {id}");
            if (reader.HasRows) {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return student;
        }

        public static List<Student> GetStudents() {
            List<Student> students = new List<Student>();

            DB.OpenConnection();

            SqlDataReader reader = DB.GetDataReader("SELECT * FROM Students");

            while (reader.Read()){
                Student student = CreateObject(reader);
                students.Add(student);
            }

            reader.Close();
            DB.CloseConnection();
            return students;
        }
    }
}
