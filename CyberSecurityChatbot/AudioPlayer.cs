
using System.Media;

namespace CyberSecurityChatbot
{
    internal class AudioPlayer
    {
        public void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Greeting.wav");
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Audio error: " +  ex.Message);

            }
        }
    }
}
