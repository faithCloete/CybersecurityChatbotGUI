using System;
using System.Collections.Generic;
using System.Configuration;

using System;
using System.Collections.Generic;

namespace CybersecurityChatbotGUI
{//start namespace

    public class Chats
    {//start class

        //method to return chatbot response
        public string GetResponse(string question)
        {
            //convert message to lowercase
            question = question.ToLower();

            //hey response

            if (question.Contains("hey"))
            {
                return "Hey, how can i help you today?";
            }

            //password response
            if (question.Contains("password"))
            {
                return "In technology, a password is a secret string of characters (letters, numbers, symbols, or spaces) used to authenticate a user's identity and grant access to a system, device, application, or data. To create one, use at least 8 characters with letters, numbers, and symbols.";
            }

            //phishing response
            if (question.Contains("phishing"))
            {
                return "In technology and cybersecurity, phishing is a type of social engineering attack where an attacker impersonates a legitimate person, company, or organization to trick a victim into revealing sensitive information (like passwords, credit card numbers, or personal data) or installing malware. Be careful of emails asking for personal information.";
            }

            //browsing response
            if (question.Contains("browsing"))
            {
                return "Browsing (or web browsing) refers to the act of navigating and accessing information on the World Wide Web using a software application called a web browser (e.g., Chrome, Firefox, Safari, Edge). Only visit secure websites and avoid suspicious links.";
            }

            //general responses
            if (question.Contains("how are you"))
            {
                return "I'm functioning perfectly and ready to help you stay safe online. How are you?";
            }

            if (question.Contains("i'm good thank you"))
            {
                return "How can I help you?";
            }

            if (question.Contains("purpose"))
            {
                return "My purpose is to educate you about cybersecurity awareness.";
            }

            if(question.Contains("ask"))
            {
                return "You can ask me about passwords, phishing, and safe browsing.";
            }

            if (question.Contains("thank you"))
            {
                return "Is there anything I can help you with? Ask me about passwords, phishing, and safe browsing.";
            }

            //default response
            return "I don't understand. Try asking about passwords, phishing, or browsing.";
        }

    }//end class

}//end namespace