using System;
using System.Data.SqlClient;

namespace SqlInsertdata
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yerbolat\source\repos\SqlInsertdata\SqlInsertdata\Database2.mdf;Integrated Security=True";
            int age = 23;
            string name = "T',10);INSERT INTO Users (Name, Age) VALUES('H";
            string sqlExpression = "Insert into Users (Name, Age) Values (@name, @age)";
            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlParameter nameParam = new SqlParameter("@name", name);
                command.Parameters.Add(nameParam);

                SqlParameter ageParam = new SqlParameter("@age", age);
                command.Parameters.Add(ageParam);

                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number); // 1
            }
        }
    }
}
