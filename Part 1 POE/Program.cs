using System;
using System.Speech.Synthesis;

class CybersecurityAwarenessBot
{
    static void Main(string[] args)
    {
        // ASCII Art for the Cybersecurity Awareness bot called MokCyberSecure
        string logo = @"

                   [🤖]
                  /-----\
                  | Bot |
                  \-----/  
             MokCyberSecure Bot
        ";

        // Initialize Speech Synthesizer
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        synthesizer.SelectVoice("Microsoft Zira Desktop"); // Choose a voice (you may need to adjust this)

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

        // Dictionary for responses
        Dictionary<string, string> responses = new Dictionary<string, string>
        {
      { "how are you?", "I'm just a MokCyber bot, but I'm here to assist you!" },

      { "what's your purpose?", "My purpose is to educate users about cybersecurity and make sure you're safe." },

      { "password safety", "Use strong passwords and change them regularly if possible, also avoid using your name or date of birth because it's mostly likely to be cracked easily." },

      { "phishing", "Be cautious with emails and links from unknown sources, as they may be phishing attempts trying to steal your personal information. Phishing is when someone pretends" +
      " to be a trusted person or company to trick you into giving away sensitive details like your passwords and card details." },

      { "safe browsing", "Always check the URL and use secure connections to protect your personal information. Also, make sure you use a trustworthy and updated browser " +
      "to stay safe while browsing the internet." }

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
                synthesizer.Speak("I didn’t understand that. Could you please rephrase?");
                Console.WriteLine("I didn’t understand that. Could you please rephrase?");
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
                // Underlining the response
                Console.WriteLine("\n" + new string('-', 50)); //Border for neatness and highlighting the answer
                Console.WriteLine(new string('-', 50)); //Border for neatness and highlighting the answer
                synthesizer.Speak(responses[userInput]);
                Console.WriteLine(responses[userInput]);
            }
            else
            {
                synthesizer.Speak("I didn’t understand that. Could you please rephrase?");
                Console.WriteLine("I didn’t understand that. Could you please rephrase?");
            }
        }
    }
}