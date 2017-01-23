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
            _outputStream.Flush();
            JoinChannel(userName);

            string response = ReadLine().PlayerName;
            if (response != null && response.Equals("tmi.twitch.tv 001 " + userName + " "))
                Connected = true;
        }

        public void Stop()
        {
            _tcpClient.GetStream().Close();
            _tcpClient.Close();
        }

        public void JoinChannel(string channelName)
        {
            _outputStream.WriteLine("JOIN #" + channelName);
            _outputStream.Flush();
        }

        public TwitchMessage ReadLine()
        {
            if (_tcpClient.Connected)
            {
                TwitchMessage twitchMessage = FormatMessage(_inputStream.ReadLine());
                if (twitchMessage.Message.Equals("PiNG"))
                    Pong();

                return twitchMessage;
            }
            return null;
        }

        private TwitchMessage FormatMessage(string message)
        {
            string chatMessage = string.Empty;
            string playerName = string.Empty;

            if (message == null)
                return new TwitchMessage(chatMessage, playerName);

            if (message.Split(':') != null && message.Split(':').Length > 2)
            {
                chatMessage = message.Split(':')[2];
                if (message.Split(':')[1].Split('!') != null)
                {
                    playerName = message.Split(':')[1].Split('!')[0];
                }
            }
            return new TwitchMessage(chatMessage, playerName);
        }

        private void Pong()
        {
            _outputStream.WriteLine("PONG :tmi.twitch.tv");
            _outputStream.Flush();
        }
    }
}
