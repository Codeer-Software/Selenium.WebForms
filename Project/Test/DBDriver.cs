using System.Data.SqlClient;
using System.IO;
using Test.Properties;

namespace Test
{
    static class DBDriver
    {
        internal static void InitDB()
        {
            var path = Path.GetFullPath("../../../Target/Target/App_Data/Data.mdf");
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                try
                {
                    var sqlDrop = "DROP TABLE Table_Data";
                    using (var command = new SqlCommand(sqlDrop, con))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch { }

                using (var command = new SqlCommand(Resources.Init_Create, con))
                {
                    command.ExecuteNonQuery();
                }
                using (var command = new SqlCommand(Resources.Init_Insert, con))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
