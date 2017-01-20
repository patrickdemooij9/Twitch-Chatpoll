using System;
using System.Windows.Forms;

namespace TwitchPoll
{
    public partial class AnswerItem : UserControl
    {

        public string Answer { get; private set; }

        public AnswerItem()
        {
            InitializeComponent();
        }

        public AnswerItem(int number, string answer)
        {
            InitializeComponent();
            Answer = answer;

            LblNumber.Text = number.ToString();
            LblAnswer.Text = Answer;
            LblAmount.Text = "0%";
        }

        public void UpdateAmount(int number)
        {
            Action updateLabel = () => LblAmount.Text = number + "%";
            LblAmount.Invoke(updateLabel);

            Action updateProgess = () => PBAmount.Value = number;
            PBAmount.Invoke(updateProgess);
        }
    }
}
