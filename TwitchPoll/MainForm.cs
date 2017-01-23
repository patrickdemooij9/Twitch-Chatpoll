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
        private volatile bool _running;
        private volatile bool _threadRunning;

        private Thread _thread;
        private TwitchConnection _connection;

        private List<TextBox> _textBoxes;

        private ObsScreen _obs;

        public MainForm()
        {
            InitializeComponent();

            _textBoxes = new List<TextBox>();
            _threadRunning = true;
            _thread = new Thread(UpdateLoop);
            
            _running = false;
            
            PopulatePanel(2, false);
        }

        #region Events
        private void BtnNewQuestion_Click(object sender, EventArgs e)
        {
            TxbQuestion.Clear();
            NumAnswers.Value = NumAnswers.Minimum;
            PopulatePanel((int)NumAnswers.Value, true);
        }

        private void NumAnswers_ValueChanged(object sender, EventArgs e)
        {
            PopulatePanel((int)NumAnswers.Value, false);
        }     

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_connection != null)
                _connection.Stop();
            _threadRunning = false;
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
                BtnUpdate.Visible = true;
                BtnStop.Enabled = false;
                BtnUpdate.Enabled = false;
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
            BtnUpdate.Enabled = true;
            BtnStart.Enabled = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            StopObs();
            _threadRunning = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            List<string> answerStrings = new List<string>();
            foreach (TextBox textBox in _textBoxes)
            {
                answerStrings.Add(textBox.Text);
            }

            _obs.Update(TxbQuestion.Text, answerStrings);
        }
        #endregion

        #region Other methods
        private void PopulatePanel(int amountOfAnswers, bool fullClear)
        {
            Panel panel = PnlQuestions;
            PnlQuestions.Controls.Clear();

            int textBoxHeight = 20;
            if (textBoxHeight * amountOfAnswers > panel.Height)
                textBoxHeight = panel.Height / amountOfAnswers;

            List<TextBox> newList = new List<TextBox>();
            for (int i = 0; i < amountOfAnswers; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(0, 0 + textBoxHeight * i);
                textBox.Text = "Answer " + (i + 1);
                textBox.Size = new System.Drawing.Size(panel.Width, textBoxHeight);

                if (!fullClear && _textBoxes.Count > i && _textBoxes[i] != null)
                    textBox.Text = _textBoxes[i].Text;
                newList.Add(textBox);
                panel.Controls.Add(textBox);
            }

            _textBoxes = newList;
        }

        private void StopObs()
        {
            _obs.Close();
            _obs = null;
            _running = false;

            BtnStop.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnStart.Enabled = true;
        }

        private void UpdateLoop()
        {
            while (_threadRunning)
            {
                try {
                    if (_connection != null && _running)
                    {
                        TwitchMessage message = _connection.ReadLine();
                        _obs.AddVote(message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }
        #endregion
    }
}
