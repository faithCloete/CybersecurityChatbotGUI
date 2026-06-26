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

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskItem task = new TaskItem();

            task.Title = txtTaskTitle.Text;
            task.Description = txtDescription.Text;
            task.ReminderDate = dtpReminder.Value;
            task.IsCompleted = false;

            TaskRepository repository = new TaskRepository();

            repository.AddTask(task);

            MessageBox.Show("Task added successfully!");

            txtTaskTitle.Clear();
            txtDescription.Clear();
        }
        

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
            if (string.IsNullOrWhiteSpace(userMessage))
            {//START OF IF
                MessageBox.Show("Please enter a message.");
                return;
            }//END OF IF

            //display user message
            rtbChat.AppendText("You: " + userMessage + Environment.NewLine);

            //temporary bot response
            string botResponse = chatbot.GetResponse(userMessage);
            rtbChat.AppendText("Cybersecurity Bot: " + botResponse + Environment.NewLine + Environment.NewLine); //extra line for readability

            //clear textbox after sending
            txtUserInput.Clear();

            //auto scroll chat
            rtbChat.SelectionStart = rtbChat.Text.Length;
            rtbChat.ScrollToCaret();
        }//END OF btnSend_Click METHOD

        

        //enter key support
        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();

                e.SuppressKeyPress = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }//END OF CLASS
}//END OF NAMESPACE
