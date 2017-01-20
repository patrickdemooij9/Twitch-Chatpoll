using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace TwitchPoll
{
    public partial class MainForm : Form
    {
        private bool _running;

        private Thread _thread;
        private TwitchConnection _connection;

        private List<TextBox> _textBoxes;

        private ObsScreen _obs;

        public MainForm()
        {
            InitializeComponent();

            _textBoxes = new List<TextBox>();
            _thread = new Thread(UpdateLoop);
            _running = false;

            PopulatePanel(2);
        }

        private void BtnNewQuestion_Click(object sender, EventArgs e)
        {
            TxbQuestion.Clear();
            NumAnswers.Value = NumAnswers.Minimum;
            ClearPanel();
        }

        private void NumAnswers_ValueChanged(object sender, EventArgs e)
        {
            PopulatePanel((int)NumAnswers.Value);
        }

        private void ClearPanel()
        {
            PnlQuestions.Controls.Clear();
            _textBoxes.Clear();
        }

        private void PopulatePanel(int amountOfAnswers)
        {
            Panel panel = PnlQuestions;
            ClearPanel();

            int textBoxHeight = 20;
            if (textBoxHeight * amountOfAnswers > panel.Height)
                textBoxHeight = panel.Height / amountOfAnswers;

            for (int i = 0; i < amountOfAnswers; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(0, 0 + textBoxHeight * i);
                textBox.Text = "Answer " + (i + 1);
                textBox.Size = new System.Drawing.Size(panel.Width, textBoxHeight);
                _textBoxes.Add(textBox);
                panel.Controls.Add(textBox);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            BtnConnect.Enabled = false;
            _connection = new TwitchConnection(TxbUsername.Text.ToLower(), TxbAutoKey.Text);
            if (_connection.Connected)
            {
                _thread.Start();

                TxbUsername.Visible = false;
                TxbAutoKey.Visible = false;
                BtnConnect.Visible = false;
                BtnStart.Visible = true;
                BtnStop.Visible = true;
                BtnStop.Enabled = false;
                LblConnected.Text = "Connected!";
            }
            else
                LblConnected.Text = "Can't connect!";
            BtnConnect.Enabled = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            List<string> answerStrings = new List<string>();
            foreach (TextBox textBox in _textBoxes)
            {
                answerStrings.Add(textBox.Text);
            }

            _obs = new ObsScreen(TxbQuestion.Text, answerStrings);
            _obs.Show();
            _running = true;

            BtnStop.Enabled = true;
            BtnStart.Enabled = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _obs.Close();
            _obs = null;

            BtnStop.Enabled = false;
            BtnStart.Enabled = true;
        }

        private void UpdateLoop()
        {
            while (true)
            {
                try {
                    if (_connection != null && _running)
                        UseMessage(_connection.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void UseMessage(string message)
        {
            TwitchMessage chatMessage = FormatMessage(message);
            _obs.AddVote(chatMessage);
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
    }
}
