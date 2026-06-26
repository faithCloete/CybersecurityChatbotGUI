using System;
using System.Collections.Generic;

namespace CybersecurityChatbotGUI
{
    public static class ActivityLog
    {
        //stores recent chatbot actions
        public static List<string> Logs = new List<string>();

        public static void AddLog(string action)
        {
            string logEntry =
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                + " - "
                + action;

            Logs.Add(logEntry);
        }
    }
}