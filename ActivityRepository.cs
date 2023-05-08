using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager
{
    public static class ActivityRepository
    {
        public static Activity CreateObject(SqlDataReader reader)
        {
            Activity aktivnost = new Activity();

            aktivnost.Id = Convert.ToInt32(reader["Id"].ToString());
            aktivnost.Name = reader["Name"].ToString();
            aktivnost.Description = reader["Description"].ToString();

            int.TryParse(reader["maxPoints"].ToString(), out int maxPoints);
            int.TryParse(reader["minPointsForGrade"].ToString(), out int minPointForGrade);
            int.TryParse(reader["minPointsForSignature"].ToString(), out int minPointsForSignature);

            aktivnost.MaxPoints = maxPoints;
            aktivnost.MinPointsForGrade = minPointForGrade;
            aktivnost.MinPointsForSignature = minPointsForSignature;

            return aktivnost;
        }

        public static Activity GetActivity(int id)
        {
            Activity aktivnost = null;
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM Activity WHERE id = {id}");
            if (reader.HasRows)
            {
                reader.Read();
                aktivnost = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return aktivnost;
        }

        public static List<Activity> GetActivity()
        {
            List<Activity> aktivnosti = new List<Activity>();

            DB.OpenConnection();

            SqlDataReader reader = DB.GetDataReader("SELECT * FROM Activities");

            while (reader.Read())
            {
                Activity aktivnost = CreateObject(reader);
                aktivnosti.Add(aktivnost);
            }

            reader.Close();
            DB.CloseConnection();
            return aktivnosti;
        }
    }
}
