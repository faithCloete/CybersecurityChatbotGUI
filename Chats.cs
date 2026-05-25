using System;
using System.Collections.Generic;
using System.Configuration;

using System;
using System.Collections.Generic;
using System.IO;

namespace CybersecurityChatbotGUI
{//start namespace

    public class Chats
    {//start class

        private Dictionary<string, List<string>> responses;
        private Random random = new Random();

        //adding variable for memory
        private string lastTopic = "";

        //method to return chatbot response
        public string GetResponse(string question)
        {//start getResponse method

            //convert message to lowercase
            question = question.ToLower();

            //follow-up responses
            if (question.Contains("tell me more") ||
                question.Contains("another tip") ||
                question.Contains("explain more"))

            {//start of if
                //check if chatbot remembers previous topic
                if (lastTopic != "")
                {//start of if inside if
                    List<string> followUpResponses = responses[lastTopic];

                    int index = random.Next(followUpResponses.Count);

                    return followUpResponses[index];
                }//end of if inside if

                else
                {//start of else
                    return "Please ask about a cybersecurity topic first.";
                }//end of else

            }//end of if

                //loop through keywords
                foreach (string keyword in responses.Keys)
            {//START OF FOREACH
                //check if question contains keyword

                if (question.Contains(keyword))
                {//START OF IF

                    //remember topic
                    lastTopic = keyword;

                    //get list of responses
                    List<string> possibleResponses = responses[keyword];

                    //pick random response
                    int index = random.Next(possibleResponses.Count);

                    return possibleResponses[index];
                }//END OF IF

            }//END OF FOR EACH

           //GENERAL CHATBOT QUESTIONS /RESPONSES
           //hey response
            if (question.Contains("hey"))
            {
                return "Hey, how can i help you today?";
            }
            
            //how are you response
            if (question.Contains("how are you"))
            {
                return "I'm functioning perfectly and ready to help you stay safe online. How are you?";
            }

            //gvreeting
            if (question.Contains("i'm good thank you"))
            {
                return "How can I help you?";
            }

            //purpose response
            if (question.Contains("purpose"))
            {
                return "My purpose is to educate you about cybersecurity awareness.";
            }

            //what can i ask response
            if(question.Contains("ask"))
            {
                return "You can ask me about passwords, phishing, scams, privacy, and safe browsing.";
            }

            if (question.Contains("thank you"))
            {
                return "Is there anything I can help you with? Ask me about passwords, phishing, and safe browsing.";
            }

            //default response
            return "I don't understand. Try asking about passwords, phishing, scams, privacy or browsing.";
        }//end of getResponse method

        public Chats()
        {
            //dictionary storing keywords and multiple responses
            responses = new Dictionary<string, List<string>>();

            //password responses
            responses.Add("password", new List<string>
    {
        "In technology, a password is a secret string of characters (letters, numbers, symbols, or spaces) used to authenticate a user's identity and grant access to a system, device, application, or data. ",
        "Use strong passwords with letters, numbers, and symbols.",
        "Avoid using personal information in your passwords.",
        "Use different passwords for different accounts."
    });

            //phishing responses
            responses.Add("phishing", new List<string>
    {
        "In technology and cybersecurity, phishing is a type of social engineering attack where an attacker impersonates a legitimate person, company, or organization to trick a victim into revealing sensitive information (like passwords, credit card numbers, or personal data) or installing malware.",
        "Be cautious of emails asking for personal information.",
        "Scammers often pretend to be trusted companies.",
        "Never click suspicious links from unknown senders."
    });

            //browsing responses
            responses.Add("browsing", new List<string>
            {
                "al information.\");\r\n answers.Add(\"browsing: Browsing (or web browsing) refers to the act of navigating and accessing information on the World Wide Web using a software application called a web browser (e.g., Chrome, Firefox, Safari, Edge). Only visit secure websites and avoid suspicious links."
            });

            //privacy responses
            responses.Add("privacy", new List<string>
    {
        "Review your account privacy settings regularly.",
        "Avoid sharing sensitive information online.",
        "Enable two-factor authentication for better security."
    });

            //scam responses
            responses.Add("scam", new List<string>
    {
        "Online scams often create urgency to trick users.",
        "Never send money to unknown people online.",
        "Be careful of fake giveaways and prizes."
    });
        }

    }//end class

}//end namespace