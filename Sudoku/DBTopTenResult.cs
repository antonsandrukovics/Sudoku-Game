using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Sudoku
{
    static class DBTopTenResult 
    {
        private static SQLiteConnection connectionDB = new SQLiteConnection("Data Source=TopTenResultDB.db");
        public static void OpenDb(string name, int time, string level)
        {
            connectionDB.Open();
            string sql = $"insert into Result{level}Level (PlayerName, BestTime) values ('{name}', '{GetTimeFromSecund(time)}')";
            SQLiteCommand command = new SQLiteCommand(sql, connectionDB);
            command.ExecuteNonQuery();
            connectionDB.Close();
        }
        private static string GetTimeFromSecund(int time)
        {
            int minut = (time < 60) ? 0 : time / 60;
            double second = (minut < 1) ? time : (time - 60 * minut);
            return second< 10 ? $"{minut}:0{second}" : $"{minut}:{second}";
        }

        public static List<string[]> LoadDataFromDB(string level)
        {
            connectionDB.Open();
            string query = $"SELECT * FROM Result{level}Level ORDER BY ID";
            SQLiteCommand command = new SQLiteCommand(query, connectionDB);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            connectionDB.Close();
            return data;
        }
    }
}
