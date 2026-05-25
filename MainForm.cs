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
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text;

            //check if textbox is empty
            if (userMessage == "")
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            //display user message
            rtbChat.AppendText("You: " + userMessage + Environment.NewLine);

            //temporary bot response
            rtbChat.AppendText("Cybersecurity Bot: I received your message." + Environment.NewLine + Environment.NewLine);

            //clear textbox after sending
            txtUserInput.Clear();
        }
    }
}
