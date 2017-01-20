using System;
using System.Windows.Forms;

namespace TwitchPoll
{
    public partial class InputWindow : Form
    {
        public string Question;
        public int Answers;

        public InputWindow()
        {
            InitializeComponent();
            BtnDone.Enabled = false;
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Question = TxbAnswer.Text;
            Answers = (int) NumAnswers.Value;
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxbAnswer_TextChanged(object sender, EventArgs e)
        {
            BtnDone.Enabled = (TxbAnswer.Text.Length > 0) ? true : false;
        }
    }
}
