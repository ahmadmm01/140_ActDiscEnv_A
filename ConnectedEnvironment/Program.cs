using System;
using System.Data.SqlClient;

namespace ActEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = GetConnectionString();
            string query1 = "select * from Pembimbing_Akademik where NIK=333";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); 
                cn.Open();
                using(SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                    {
                        string query2 = "update Pembimbing_Akademik set Keahlian = 'Jaringan' where NIK = 333";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }
                }
            }
            Console.ReadLine();
        }
        private static string GetConnectionString()
        {
            return "data source= DESKTOP-O4TKV14\\AHMADMM; MultipleActiveResultSets=True; database=ProdiTI; User ID= sa; Password=1234";
        }
    }
}
