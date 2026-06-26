using MySql.Data.MySqlClient;

namespace CybersecurityChatbotGUI
{
    public class DatabaseHelper
    {
        //connection string
        private string connectionString =
            "server=localhost;database=CybersecurityChatbotDB;uid=root;pwd=F@ithrosemhlangacloete62;";

        //method to get database connection
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}