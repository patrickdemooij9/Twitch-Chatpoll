using System.IO;
using System.Net.Sockets;

namespace TwitchPoll
{
    class TwitchConnection
    {
        public bool Connected;

        private TcpClient _tcpClient;
        private StreamReader _inputStream;
        private StreamWriter _outputStream;

        public TwitchConnection(string userName, string password)
        {
            Connected = false;
            _tcpClient = new TcpClient("irc.chat.twitch.tv", 6667);
            _inputStream = new StreamReader(_tcpClient.GetStream());
            _outputStream = new StreamWriter(_tcpClient.GetStream());

            _outputStream.WriteLine("PASS " + password);
            _outputStream.WriteLine("NICK " + userName);
            _outputStream.WriteLine("JOIN #" + userName);
            _outputStream.Flush();

            string response = ReadLine();
            if (response != null && response.Equals(":tmi.twitch.tv 001 " + userName + " :Welcome, GLHF!"))
                Connected = true;
        }

        public void Pong()
        {
            _outputStream.WriteLine("PONG :tmi.twitch.tv");
            _outputStream.Flush();
        }

        public string ReadLine()
        {
            return _inputStream.ReadLine();
        }
    }
}
