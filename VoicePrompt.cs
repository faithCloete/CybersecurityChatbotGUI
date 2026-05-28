using System;
using System.IO;  // Add this for Path and File
using System.Media;

namespace CybersecurityChatbotGUI
{//start of namespace
    public class VoicePrompt
    {//start of class
        //auto path
        string path = AppDomain.CurrentDomain.BaseDirectory;

        public VoicePrompt()
        {//start of constructor
            // REMOVED: Voice() call from constructor - you should call it explicitly
            // This was causing logic issues
        }//end of constructor

        //method to voice greet the user - CHANGED to public so Main can call it
        public void Voice()
        {//start of method

            // IMPROVED path handling - works for Debug, Release, or any folder
            string fullpath = GetAudioDirectory();

            //play the sound
            string joined_path = Path.Combine(fullpath, "greet.wav");  // Using Path.Combine is better

            // Check if file exists before trying to play
            if (!File.Exists(joined_path))
            {
                Console.WriteLine($"Audio file not found: {joined_path}");
                Console.WriteLine($"Looking in directory: {fullpath}");
                return;
            }

            try
            {
                //create an instance for the soundPlayer class
                using (SoundPlayer voice_play = new SoundPlayer(joined_path))  // 'using' ensures proper disposal
                {
                    //Load the audio
                    voice_play.Load();

                    //play till the end
                    voice_play.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound: {ex.Message}");
            }
        }

        // Helper method to get the correct audio directory
        private string GetAudioDirectory()
        {
            // Method 1: Remove bin\Debug\ or bin\Release\ if present
            string cleanedPath = path;

            if (cleanedPath.Contains(@"bin\Debug\"))
            {
                cleanedPath = cleanedPath.Replace(@"bin\Debug\", "");
            }
            else if (cleanedPath.Contains(@"bin\Release\"))
            {
                cleanedPath = cleanedPath.Replace(@"bin\Release\", "");
            }

            // Method 2 (Alternative): Look for Audio folder in project root
            // You can also create an "Audio" folder and put your .wav files there
            string audioPath = Path.Combine(cleanedPath, "Audio");
            if (Directory.Exists(audioPath))
            {
                return audioPath;
            }

            // Fallback to the main directory
            return cleanedPath;
        }
    }//end of class
}//end of namespace