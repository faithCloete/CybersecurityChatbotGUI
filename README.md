# Cybersecurity Awareness Chatbot - Part 2

## Overview

The Cybersecurity Awareness Chatbot is a C# application developed to educate South African citizens about online safety and cybersecurity threats. The chatbot simulates interactive conversations with users and provides guidance on common cybersecurity topics such as phishing, password safety, scams, privacy, and safe browsing.

Part 2 expands the original console application into a Windows Forms GUI application with additional intelligent features such as:

* Keyword recognition
* Randomised responses
* Conversation flow
* Memory and recall
* Sentiment detection
* Voice greeting integration

The chatbot was developed using object-orientated programming principles and organised into multiple classes for readability and maintainability.

---

# Features

## GUI Interface

* Windows Forms graphical user interface
* User-friendly chat layout
* Colour formatting and structured interface
* Cybersecurity logo integration

## Voice Greeting

* WAV audio greeting plays when the application launches
* Uses the `System.Media.SoundPlayer` class

## Keyword Recognition

The chatbot recognises cybersecurity-related topics such as:

* Passwords
* Phishing
* Privacy
* Scams
* Safe browsing

The chatbot responds with relevant cybersecurity guidance based on detected keywords.

## Random Responses

The chatbot uses lists and random selection to provide different responses for repeated cybersecurity topics, making interactions more natural and engaging.

## Conversation Flow

The chatbot remembers the current discussion topic and supports follow-up requests such as:

* "Tell me more"
* "Another tip"
* "Explain more"

## Memory and Recall

The chatbot can remember user interests and personalise future responses.

Example:

* User: "I like privacy."
* Chatbot remembers this preference and refers to it later in conversation.

## Sentiment Detection

The chatbot detects simple sentiments such as:

* Worried
* Frustrated
* Confused
* Curious

The chatbot adjusts its responses to provide encouragement and cybersecurity advice automatically.

## Error Handling

* Prevents empty user input
* Handles unknown questions gracefully
* Prevents application crashes from invalid input

---

# Technologies Used

* C#
* Windows Forms (WinForms)
* .NET Framework
* Visual Studio
* GitHub
* GitHub Actions (CI)

---

# Project Structure

## Main Classes

### Program.cs

Handles application startup and launches the GUI.

### MainForm.cs

Controls the GUI interaction and user communication.

### Chats.cs

Contains chatbot logic including:

* Keyword recognition
* Random responses
* Sentiment detection
* Memory recall
* Conversation flow

### VoicePrompt.cs

Handles audio greeting playback.

### GreetAndName.cs

Contains greeting and branding functionality from Part 1.

---

# How to Run the Application

1. Clone the repository:

```bash
git clone [YOUR_GITHUB_LINK]
```

2. Open the solution file in Visual Studio.

3. Ensure the WAV audio file is included in the project.

4. Build and run the application.

---

# GitHub and Version Control

This project uses GitHub for version control with meaningful commits throughout development.

GitHub Actions was implemented for Continuous Integration (CI) to ensure successful builds and project validation.

---

# Releases

Two GitHub releases/tags were created:

* v1.0 - Part 1 Complete
* v2.0 - Part 2 Complete

---

# Author

Faith Mhlanga

---

# Purpose of the Project

This chatbot was developed as part of a cybersecurity awareness initiative to educate users about online safety practices and common cyber threats affecting South African citizens.
