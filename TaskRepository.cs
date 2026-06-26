using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CybersecurityChatbotGUI
{
    public class TaskRepository
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        //add task to database
        public void AddTask(TaskItem task)
        {
            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query =
                    @"INSERT INTO Tasks
                    (Title, Description, ReminderDate, IsCompleted)
                    VALUES
                    (@Title, @Description, @ReminderDate, @IsCompleted)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@ReminderDate", task.ReminderDate);
                cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);

                cmd.ExecuteNonQuery();
            }
        }
        

        public List<TaskItem> GetAllTasks()
    {//START OF METHOD
        List<TaskItem> tasks = new List<TaskItem>();

        using (MySqlConnection conn = dbHelper.GetConnection())
        {
            conn.Open();

            string query = "SELECT * FROM Tasks";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TaskItem task = new TaskItem();

                task.TaskID = Convert.ToInt32(reader["TaskID"]);
                task.Title = reader["Title"].ToString();
                task.Description = reader["Description"].ToString();

                if (reader["ReminderDate"] != DBNull.Value)
                {
                    task.ReminderDate =
                        Convert.ToDateTime(reader["ReminderDate"]);
                }

                task.IsCompleted =
                    Convert.ToBoolean(reader["IsCompleted"]);

                tasks.Add(task);
            }
        }

        return tasks;
    }//END OF METHOD

        public void CompleteTask(int taskID)
        {
            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query =
                    "UPDATE Tasks SET IsCompleted = TRUE WHERE TaskID = @TaskID";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TaskID", taskID);

                cmd.ExecuteNonQuery();
            }
        }//END OF METHOD

        public void DeleteTask(int taskID)
        {
            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query =
                    "DELETE FROM Tasks WHERE TaskID = @TaskID";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TaskID", taskID);

                cmd.ExecuteNonQuery();
            }
        }//END OF METHOD
    }
}