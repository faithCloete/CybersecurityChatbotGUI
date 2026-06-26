namespace CybersecurityChatbotGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Pink;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(452, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cybersecurity Awareness Chatbot";
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.Black;
            this.rtbChat.Font = new System.Drawing.Font("Consolas", 11F);
            this.rtbChat.ForeColor = System.Drawing.Color.White;
            this.rtbChat.Location = new System.Drawing.Point(12, 55);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(452, 189);
            this.rtbChat.TabIndex = 1;
            this.rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(12, 259);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(408, 22);
            this.txtUserInput.TabIndex = 2;
            this.txtUserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserInput_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightPink;
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(426, 259);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 25);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(470, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(70, 44);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(647, 25);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(290, 22);
            this.txtTaskTitle.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(647, 78);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 22);
            this.txtDescription.TabIndex = 9;
            // 
            // dtpReminder
            // 
            this.dtpReminder.Location = new System.Drawing.Point(647, 126);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(290, 22);
            this.dtpReminder.TabIndex = 10;
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTaskTitle.Location = new System.Drawing.Point(553, 33);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(67, 16);
            this.lblTaskTitle.TabIndex = 11;
            this.lblTaskTitle.Text = "Task Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.LightCoral;
            this.lblDescription.Location = new System.Drawing.Point(553, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.ForeColor = System.Drawing.Color.LightCoral;
            this.lblReminder.Location = new System.Drawing.Point(530, 131);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(98, 16);
            this.lblReminder.TabIndex = 13;
            this.lblReminder.Text = "Reminder Date";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(533, 180);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(112, 29);
            this.btnAddTask.TabIndex = 14;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(678, 359);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(119, 32);
            this.btnDeleteTask.TabIndex = 15;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(533, 359);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(139, 32);
            this.btnCompleteTask.TabIndex = 16;
            this.btnCompleteTask.Text = "Mark Complete";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(533, 226);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(404, 114);
            this.dgvTasks.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(990, 654);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.dtpReminder);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cybersecurity Awareness Chatbot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.DataGridView dgvTasks;
    }
}

