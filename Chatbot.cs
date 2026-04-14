
namespace CyberSecurityChatbot
{
    internal class Chatbot
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm just a bot, but im here to help!";

            if (input.Contains("purpose"))
                return "My purpose isnto help you stay safe online.";

            if (input.Contains("password"))
                return "Use strong passwords with letters, numbers, and symbols.";

            if (input.Contains("phishing"))
                return "Phishing is a scam where attackers trick you into giving personal information.";

            return "I don't understand that. Try asking about cybersecurity.";


        }
    }

}
