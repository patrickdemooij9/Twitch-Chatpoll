using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TwitchPoll
{
    public partial class ObsScreen : Form
    {
        private int _totalVotes;
        private Dictionary<AnswerItem, int> _answers;
        private List<string> _players;

        public ObsScreen(string question, List<string> answerStrings)
        {
            InitializeComponent();

            LblQuestion.Text = question;

            _answers = new Dictionary<AnswerItem, int>();
            _players = new List<string>();

            Populate(answerStrings);
        }

        private void Populate(List<string> answerStrings)
        {
            Panel panel = PnlAnswers;
            int height = 50;
            if (panel.Height < answerStrings.Count * height)
                height = panel.Height / answerStrings.Count;

            for (int i = 0; i < answerStrings.Count; i++)
            {
                AnswerItem answerItem = new AnswerItem(i + 1, answerStrings[i]);
                answerItem.Location = new Point(0, 0 + height * i);
                _answers.Add(answerItem, 0);
                panel.Controls.Add(answerItem);
            }
        }

        public void AddVote(TwitchMessage chatMessage)
        {
            if (_players.Contains(chatMessage.PlayerName))
                return;

            int number;
            if (int.TryParse(chatMessage.Message, out number))
                AddVote(number, chatMessage.PlayerName);
            else
                AddVote(chatMessage.Message, chatMessage.PlayerName);
        }

        public void AddVote(int number, string playerName)
        {
            if (number > _answers.Count)
                return;

            AnswerItem answer = _answers.ElementAt(number - 1).Key;
            int oldVotes = _answers.ElementAt(number - 1).Value;

            _totalVotes++;
            _answers[answer] = oldVotes + 1;
            _players.Add(playerName);
            UpdateAllAnswers();
        }

        public void AddVote(string answerString, string playerName)
        {
            AnswerItem answer = _answers.Keys.FirstOrDefault(x => x.Answer.Equals(answerString));
            if (answer == null)
                return;

            int oldVotes = _answers[answer];

            _totalVotes++;
            _answers[answer] = oldVotes + 1;
            _players.Add(playerName);
            UpdateAllAnswers();
        }

        private void UpdateAllAnswers()
        {
            foreach (KeyValuePair<AnswerItem, int> answers in _answers)
            {
                double percent =  (double)answers.Value / (double)_totalVotes;
                int percentage = (int)(percent * 100);
                if (percentage > 100)
                    percentage = 100;
                answers.Key.UpdateAmount(percentage);
            }
        }
    }
}
