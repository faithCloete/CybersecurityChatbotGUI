using System;

// a class that represents a task before we start saving anything to MySQL

namespace CybersecurityChatbotGUI
{
    public class TaskItem
    {
        //primary key from database
        public int TaskID { get; set; }

        //task title
        public string Title { get; set; }

        //task description
        public string Description { get; set; }

        //optional reminder date
        public DateTime? ReminderDate { get; set; }

        //completion status
        public bool IsCompleted { get; set; }
    }
}
