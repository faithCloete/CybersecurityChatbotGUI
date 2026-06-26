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

       //QUIZ VARIABLES
        private List<QuizQuestion> questions = new List<QuizQuestion>();

        private int currentQuestionIndex = 0;

        private int score = 0;
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskItem task = new TaskItem();

            task.Title = txtTaskTitle.Text;
            task.Description = txtDescription.Text;
            task.ReminderDate = dtpReminder.Value;
            task.IsCompleted = false;

            TaskRepository repository = new TaskRepository();

            repository.AddTask(task);

            ActivityLog.AddLog("Task added: " + task.Title);

            LoadActivityLog();

            MessageBox.Show("Task added successfully!");

            txtTaskTitle.Clear();
            txtDescription.Clear();

            LoadTasks();
        }
        

        public MainForm()
        {//START OF MAINFORM METHOD
            InitializeComponent();

            voice.Voice();

            LoadTasks();

            //CALLING
            LoadQuizQuestions();

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

            ProcessNLP(userMessage);


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

        private void LoadTasks()
        {
            TaskRepository repository = new TaskRepository();

            dgvTasks.DataSource = null;
            dgvTasks.DataSource = repository.GetAllTasks();
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {//START OF METHOD
            if (dgvTasks.SelectedRows.Count > 0)
            {
                int taskID = Convert.ToInt32(
                    dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

                TaskRepository repository = new TaskRepository();

                repository.CompleteTask(taskID);

                ActivityLog.AddLog("Task completed. ID: " + taskID);

                LoadActivityLog();

                MessageBox.Show("Task marked as completed!");

                LoadTasks();
            }
            else
            {
                MessageBox.Show("Please select a task.");
            }
        }//END OF METHOD

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                int taskID = Convert.ToInt32(
                    dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

                TaskRepository repository = new TaskRepository();

                repository.DeleteTask(taskID);

                ActivityLog.AddLog("Task deleted. ID: " + taskID);

                LoadActivityLog();

                MessageBox.Show("Task deleted successfully!");

                LoadTasks();
            }
            else
            {
                MessageBox.Show("Please select a task.");
            }
        }//END OF METHOD

        private void LoadActivityLog()
        {//START OF METHOD
            lstActivityLog.Items.Clear();

            int startIndex = Math.Max(0, ActivityLog.Logs.Count - 10);

            for (int i = startIndex; i < ActivityLog.Logs.Count; i++)
            {
                lstActivityLog.Items.Add(ActivityLog.Logs[i]);
            }
        }//END OF METHOD

        private void LoadQuizQuestions()
        {
            questions.Add(new QuizQuestion
            {
                Question = "What should you do if you receive an email asking for your password?",
                OptionA = "Reply with your password",
                OptionB = "Delete the email",
                OptionC = "Report it as phishing",
                OptionD = "Ignore it",
                CorrectAnswer = "C",
                Explanation = "Reporting phishing emails helps prevent scams."
            });

            questions.Add(new QuizQuestion
            {
                Question = "A strong password should contain:",
                OptionA = "Only your name",
                OptionB = "Letters, numbers and symbols",
                OptionC = "Only numbers",
                OptionD = "Your birthdate",
                CorrectAnswer = "B",
                Explanation = "Strong passwords use a mixture of characters."
            });

            questions.Add(new QuizQuestion
            {
                Question = "True or False: It is safe to use the same password everywhere.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "B",
                Explanation = "Using unique passwords reduces risk."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What does 2FA stand for?",
                OptionA = "Two-Factor Authentication",
                OptionB = "Two File Access",
                OptionC = "Two Fast Accounts",
                OptionD = "Transfer File Access",
                CorrectAnswer = "A",
                Explanation = "2FA adds an extra security layer."
            });

            questions.Add(new QuizQuestion
            {
                Question = "Which website is usually safer?",
                OptionA = "http://example.com",
                OptionB = "https://example.com",
                OptionC = "Both are identical",
                OptionD = "Neither",
                CorrectAnswer = "B",
                Explanation = "HTTPS encrypts communication."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What is phishing?",
                OptionA = "A fishing hobby",
                OptionB = "A social engineering attack",
                OptionC = "A browser",
                OptionD = "An antivirus",
                CorrectAnswer = "B",
                Explanation = "Phishing tricks users into revealing information."
            });

            questions.Add(new QuizQuestion
            {
                Question = "You should update software because:",
                OptionA = "Updates fix security vulnerabilities",
                OptionB = "It changes icons",
                OptionC = "It deletes viruses automatically",
                OptionD = "No reason",
                CorrectAnswer = "A",
                Explanation = "Updates often patch security flaws."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What should you do before clicking a link?",
                OptionA = "Click immediately",
                OptionB = "Check where it leads",
                OptionC = "Forward it",
                OptionD = "Ignore everything",
                CorrectAnswer = "B",
                Explanation = "Always verify links before opening them."
            });

            questions.Add(new QuizQuestion
            {
                Question = "True or False: Public Wi-Fi is always secure.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "B",
                Explanation = "Public Wi-Fi can expose your data."
            });

            questions.Add(new QuizQuestion
            {
                Question = "Which of these is personal information?",
                OptionA = "Password",
                OptionB = "ID Number",
                OptionC = "Bank Details",
                OptionD = "All of the above",
                CorrectAnswer = "D",
                Explanation = "All of these should be protected."
            });
        }//END OF METHOD

        private void DisplayQuestion()
        {
            QuizQuestion q = questions[currentQuestionIndex];

            lblQuestion.Text = q.Question;

            rbOptionA.Text = q.OptionA;
            rbOptionB.Text = q.OptionB;
            rbOptionC.Text = q.OptionC;
            rbOptionD.Text = q.OptionD;

            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;
        }//END OF METHOD

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            score = 0;

            lblScore.Text = "Score: 0";

            DisplayQuestion();

            ActivityLog.AddLog("Quiz started");

            LoadActivityLog();
        }//END OF METHOD

        //CHECKING ANSWERS
        private string GetSelectedAnswer()
        {
            if (rbOptionA.Checked) return "A";
            if (rbOptionB.Checked) return "B";
            if (rbOptionC.Checked) return "C";
            if (rbOptionD.Checked) return "D";

            return "";
        }//END OF METHOD

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            string selectedAnswer = GetSelectedAnswer();

            if (selectedAnswer == "")
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            QuizQuestion currentQuestion = questions[currentQuestionIndex];

            if (selectedAnswer == currentQuestion.CorrectAnswer)
            {
                score++;

                MessageBox.Show(
                    "Correct!\n\n" +
                    currentQuestion.Explanation);
            }
            else
            {
                MessageBox.Show(
                    "Incorrect.\n\n" +
                    currentQuestion.Explanation);
            }

            lblScore.Text = "Score: " + score;

            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                ShowFinalScore();
            }
        }//END OF METHOD

        //FINAL SCORE METHOD
        private void ShowFinalScore()
        {
            string feedback;

            if (score >= 8)
            {
                feedback = "Great job! You're a cybersecurity pro!";
            }
            else if (score >= 5)
            {
                feedback = "Good work! You have solid cybersecurity knowledge.";
            }
            else
            {
                feedback = "Keep learning to stay safe online!";
            }

            MessageBox.Show(
                "Quiz Complete!\n\n" +
                "Final Score: " + score + "/" + questions.Count +
                "\n\n" + feedback);

            ActivityLog.AddLog(
                "Quiz completed. Score: " +
                score +
                "/" +
                questions.Count);

            LoadActivityLog();
        }//end of method

        //NLP METHOD
        private void ProcessNLP(string userInput)
        {
            string input = userInput.ToLower();

            if (input.Contains("activity log") ||
    input.Contains("what have you done for me") ||
    input.Contains("show log"))
            {
                rtbChat.AppendText(
                    "Cybersecurity Bot: Here are my recent actions:" +
                    Environment.NewLine);

                int startIndex =
                    Math.Max(0, ActivityLog.Logs.Count - 10);

                for (int i = startIndex; i < ActivityLog.Logs.Count; i++)
                {
                    rtbChat.AppendText(
                        ActivityLog.Logs[i] +
                        Environment.NewLine);
                }

                rtbChat.AppendText(Environment.NewLine);

                return;
            }

            if (input.Contains("task") ||
                input.Contains("remind") ||
                input.Contains("reminder"))
            {
                rtbChat.AppendText(
                    "Cybersecurity Bot: I can help you manage cybersecurity tasks. Use the task section to add one." +
                    Environment.NewLine + Environment.NewLine);

                ActivityLog.AddLog("NLP recognised task-related request");
                LoadActivityLog();

                return;
            }

            if (input.Contains("quiz") ||
                input.Contains("game") ||
                input.Contains("test"))
            {
                rtbChat.AppendText(
                    "Cybersecurity Bot: Ready to test your cybersecurity knowledge? Click Start Quiz." +
                    Environment.NewLine + Environment.NewLine);

                ActivityLog.AddLog("NLP recognised quiz request");
                LoadActivityLog();

                return;
            }

            if (input.Contains("password"))
            {
                rtbChat.AppendText(
                    "Cybersecurity Bot: Use strong passwords with letters, numbers and symbols." +
                    Environment.NewLine + Environment.NewLine);

                ActivityLog.AddLog("NLP recognised password topic");
                LoadActivityLog();

                return;
            }

            if (input.Contains("phishing"))
            {
                rtbChat.AppendText(
                    "Cybersecurity Bot: Be careful of suspicious emails asking for personal information." +
                    Environment.NewLine + Environment.NewLine);

                ActivityLog.AddLog("NLP recognised phishing topic");
                LoadActivityLog();

                return;
            }

            if (input.Contains("privacy"))
            {
                rtbChat.AppendText(
                    "Cybersecurity Bot: Regularly review privacy settings on your online accounts." +
                    Environment.NewLine + Environment.NewLine);

                ActivityLog.AddLog("NLP recognised privacy topic");
                LoadActivityLog();

                return;
            }

            string botResponse = chatbot.GetResponse(userInput);

            rtbChat.AppendText(
                "Cybersecurity Bot: " +
                botResponse +
                Environment.NewLine +
                Environment.NewLine);
        }//END OF METHOD

    }//END OF CLASS
}//END OF NAMESPACE
