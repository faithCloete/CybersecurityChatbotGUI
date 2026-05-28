using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CybersecurityChatbotGUI
{//START OF NAMESPACE
    public partial class MainForm : Form
    {//START OF CLASS

        //CONNECTING CHATS.CS TO MAINFORM.CS
        Chats chatbot = new Chats();

        //CONNECTING VOICEPROMPT.CS TO MAIFORM.CS
        VoicePrompt voice = new VoicePrompt();

        public MainForm()
        {//START OF MAINFORM METHOD
            InitializeComponent();

            voice.Voice();

            //STARTUP WELCOME MESSAGE
            rtbChat.AppendText("Cybersecurity Bot: Welcome to the Cybersecurity Awareness Assistant." + Environment.NewLine);
            rtbChat.AppendText("Cybersecurity Bot: Ask me about passwords, phishing, scams, or privacy." + Environment.NewLine + Environment.NewLine);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {//START OF btnSend_Click METHOD
            string userMessage = txtUserInput.Text;

            //check if textbox is empty
            if (userMessage == "")
            {//START OF IF
                MessageBox.Show("Please enter a message.");
                return;
            }//END OF IF

            //display user message
            rtbChat.AppendText("You: " + userMessage + Environment.NewLine);

            //temporary bot response
            string botResponse = chatbot.GetResponse(userMessage);
            rtbChat.AppendText("Cybersecurity Bot: " + botResponse + Environment.NewLine);

            //clear textbox after sending
            txtUserInput.Clear();
        }//END OF btnSend_Click METHOD
    }//END OF CLASS
}//END OF NAMESPACE
