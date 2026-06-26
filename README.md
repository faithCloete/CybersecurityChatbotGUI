# Cybersecurity Awareness Chatbot (POE Part 3)

## Overview

The Cybersecurity Awareness Chatbot is a Windows Forms application developed in C# that helps users learn about cybersecurity while managing security-related tasks. The project evolved through three phases and now includes a graphical user interface, cybersecurity task management, a quiz game, NLP-style keyword recognition, activity logging, and MySQL database integration.

## Features

### Cybersecurity Chatbot
The chatbot provides cybersecurity guidance and responds to user questions using keyword recognition and natural language processing techniques.

Topics include:

- Password Security
- Phishing Awareness
- Privacy Protection
- Safe Browsing
- Cybersecurity Best Practices


### Voice Greeting

The application includes a WAV voice greeting that plays when the application starts.


### Task Assistant

Users can manage cybersecurity-related tasks through the GUI.

Functions include:

- Add Tasks
- View Tasks
- Delete Tasks
- Mark Tasks as Completed
- Set Reminder Dates

Example tasks:

- Enable Two-Factor Authentication
- Review Privacy Settings
- Update Passwords


### MySQL Database Integration

All tasks are stored in a MySQL database.

Stored information includes:

- Task ID
- Task Title
- Description
- Reminder Date
- Completion Status


### Cybersecurity Quiz

The application includes an interactive cybersecurity quiz.

Features:

- 10+ Questions
- Multiple Choice Questions
- True/False Questions
- Immediate Feedback
- Explanations for Answers
- Score Tracking
- Final Performance Feedback


### NLP Simulation

The chatbot uses keyword detection and string matching to simulate Natural Language Processing.

Recognised topics include:

- Task Requests
- Reminders
- Quiz Requests
- Password Security
- Phishing
- Privacy

Example:

User:
Can you remind me to update my password?

Chatbot:
I can help you manage cybersecurity tasks.


### Activity Log

The system records important actions performed by the chatbot.

Logged activities include:

- Task Creation
- Task Completion
- Task Deletion
- Quiz Activity
- NLP Interactions

Users can request:

Show Activity Log


or

What have you done for me?

to view recent actions.


## Technologies Used

### Programming Language

- C#

### GUI Framework

- Windows Forms

### Database

- MySQL

### Development Environment

- Visual Studio

### Database Tool

- MySQL Workbench


## Project Structure

### Main Components

| File | Purpose |
|--------|---------|
| MainForm.cs | Main GUI and application logic |
| Chats.cs | Chatbot response handling |
| VoicePrompt.cs | Voice greeting functionality |
| DatabaseHelper.cs | Database connection management |
| TaskRepository.cs | Database task operations |
| TaskItem.cs | Task model |
| QuizQuestion.cs | Quiz question model |
| ActivityLog.cs | Activity log management |
| Program.cs | Application entry point |


## How to Run

### Requirements

- Visual Studio
- .NET Framework
- MySQL Server
- MySQL Workbench
- MySql.Data package

### Steps

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Ensure MySQL Server is running.
4. Create the required database and Tasks table.
5. Update the connection string if necessary.
6. Build the solution.
7. Run the application.


## Database Table

```sql
CREATE TABLE Tasks
(
    TaskID INT PRIMARY KEY AUTO_INCREMENT,
    Title VARCHAR(255),
    Description TEXT,
    ReminderDate DATETIME,
    IsCompleted BOOLEAN
);
```


## Author

Faith Mhlanga - ST10465004


## Version History

### Version 1.0
- Console-based chatbot
- Voice greeting
- Cybersecurity responses

### Version 2.0
- Windows Forms GUI
- Dynamic responses
- Memory features
- Sentiment detection

### Version 3.0
- MySQL task management
- Cybersecurity quiz
- NLP simulation
- Activity logging
- Full POE implementation
