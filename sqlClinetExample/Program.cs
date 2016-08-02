using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sqlClinetExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string connectionString = null;
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hinakoll\\Downloads\\Samples.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                try
                {
                    conn.Open();
                    Console.WriteLine(" Connection Successful for SQL");
                    //using (SqlCommand command = new SqlCommand("SELECT * from department", conn))
                    //{
                    //    command.ExecuteNonQuery();
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Something went wrong");
                }
            }
            Console.ReadKey();
        }
    }
}
