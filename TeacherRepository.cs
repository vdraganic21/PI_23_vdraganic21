using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Evaluation_Manager
{
    public static class TeacherRepository
    {
        public static string Teacher GetTeacher(string username)
        {
            string sql = $" SELECT * FROM Teachers WHERE Username = '{username}'";
            return sql;
        }

        public static string Teacher GetTeacher(int id)
        {
            string sql = $" SELECT * FROM Teachers WHERE Username = '{id}'";
            return sql;
        }

        private static Teacher FetchTeacher(string sql)
        {
            Teacher teacher = new Teacher();

            DB.OpenConnection();

            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM Teachers WHERE id = {id}");
            if (reader.HasRows)
            {
                reader.Read();
                teacher = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return teacher;
        }

        private static Teacher CreateObject(SqlDataReader reader)
        {
            Teacher teacher = new Teacher();

            teacher.Id = Convert.ToInt32(reader["Id"].ToString());
            teacher.FirstName = reader["FirstName"].ToString();
            teacher.LastName = reader["LastName"].ToString();
            teacher.Username = reader["Username"].ToString();
            teacher.Password = reader["Password"].ToString();

            return teacher;
        }
    }
}
