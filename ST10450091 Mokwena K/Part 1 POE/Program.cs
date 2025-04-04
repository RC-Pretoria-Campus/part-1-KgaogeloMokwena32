
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

class CybersecurityAwarenessBot
{
    static void Main(string[] args)
    {
        // ASCII Art for the Cybersecurity Awareness bot called MokCyberSecure
        string logo = @"
           ╔═══════════════════════════════════════════════════╗
           ║                                                   ║
           ║              MokCyberSecure  [MCS]                ║
           ║           Cybersecurity  Assistant bot            ║
           ║                                                   ║
           ║         M   M   CCCCC  SSSSSS                     ║
           ║         M M M   C      S                          ║
           ║         M   M   C      SSSSSS                     ║
           ║         M   M   C           S                     ║
           ║         M   M   C           S                     ║
           ║         M   M   CCCCC  SSSSSS                     ║
           ║                                                   ║
           ║                                                   ║
           ╚═══════════════════════════════════════════════════╝
       
        ";

        // Initialize Speech Synthesizer
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        synthesizer.SelectVoice("Microsoft Zira Desktop");

        // Display the logo and introduction
        Console.WriteLine(logo);
        synthesizer.Speak("Welcome to the MokCyberSecure Cybersecurity Awareness Bot!");
        Console.WriteLine("Welcome to the MokCyberSecure Cybersecurity Awareness Bot!");
        synthesizer.Speak("Please enter your name:");
        Console.WriteLine("Please enter your name:");

        // User Interaction
        string userName = Console.ReadLine();
        synthesizer.Speak($"Hello, {userName}! I'm here to help you stay safe online.");
        Console.WriteLine($"Hello, {userName}! I'm here to help you stay safe online.");
        Console.WriteLine("How can I help you?");
        synthesizer.Speak("How can I help you?");

        // Dictionary for responses
        Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "how are you?", "I'm just a MokCyber bot, but I'm here to assist you!" },
            { "what's your purpose?", "My purpose is to educate you and others about cybersecurity and make sure you're safe." },
            { "password safety", "Use strong passwords and change them regularly if possible. Avoid using your name or date of birth, as these can be easily cracked." },
            { "phishing", "Be cautious with emails and links from unknown sources, as they may be phishing attempts trying to steal your personal information." },
            { "safe browsing", "Always check the URL and use secure connections. Make sure you use a trustworthy and updated browser while browsing the internet." }
        };

        // Main interaction loop
        while (true)
        {
            // Automated questions that you can ask
            Console.WriteLine("\nHere are some topics you can ask about:");
            Console.WriteLine("How are you?");
            Console.WriteLine("What's your purpose?");
            Console.WriteLine("Password safety");
            Console.WriteLine("Phishing");
            Console.WriteLine("Safe browsing");
            Console.WriteLine("Type 'exit' to quit.");

            string userInput = Console.ReadLine().ToLower();

            // Input Validation
            if (string.IsNullOrEmpty(userInput))
            {
                // Set text color to red for error output
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I didn’t understand that. Could you please rephrase?");
                synthesizer.Speak("I didn’t understand that. Could you please rephrase?");
                Console.ResetColor(); // Reset to default color
                continue;
            }

            // Basic Response System using the dictionary
            if (userInput == "exit")
            {
                synthesizer.Speak("Thank you for chatting with me! You can reach out anytime you need help. Stay safe online!");
                Console.WriteLine("Thank you for chatting with me! You can reach out anytime you need help. Stay safe online!");
                return; // Exit the application
            }

            if (responses.ContainsKey(userInput))
            {
                // Set text color to blue for answers
                Console.ForegroundColor = ConsoleColor.Blue;
                // Underlining the response
                Console.WriteLine("\n" + new string('-', 50)); // Border for neatness and highlighting the answer
                synthesizer.Speak(responses[userInput]);
                Console.WriteLine(responses[userInput]);
                Console.WriteLine(new string('-', 50)); // Border for neatness and highlighting the answer
                Console.ResetColor(); // Reset to default color
            }
            else
            {
                // Set text color to red for error output
                Console.ForegroundColor = ConsoleColor.Red;
                synthesizer.Speak("I didn’t understand that. Could you please rephrase?");
                Console.WriteLine("I didn’t understand that. Could you please rephrase?");
                Console.ResetColor(); // Reset to default color
            }
        }
    }
}