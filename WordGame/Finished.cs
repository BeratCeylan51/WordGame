using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class Finished : Form
    {
        public Finished()
        {
            InitializeComponent();
        }

        public Finished(int check)
        {
            _check = check;
            InitializeComponent();
        }

        private int _check = 1;
        private int totalScore = 100;
        private int timeCount = Game.timeCount;
        private int count = Game.count;
        private void Finished_Load(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["Game"];
            if (form != null)
                form.Close();
            ScoreCalculate();
            lblTimeValue.Text = timeCount.ToString();
            lblNumberOfLetters.Text = count.ToString();
            lblScoreValue.Text = totalScore.ToString();
            if (totalScore > 50)
            {
                gbxResult.BackColor = Color.Lime;
                gbxResult.ForeColor = Color.Black;
                lblState.Text = "Kazandınız n_n";
            }
            else
            {
                gbxResult.BackColor = Color.Red;
                gbxResult.ForeColor = Color.Black;
            }
        }

        private void ScoreCalculate()
        {
            totalScore -= (timeCount * 2);
            if (_check == 1)
                totalScore -= (count * 5);
            else if (_check == 2)
                totalScore -= (count * 7);
            else if (_check == 3)
                totalScore -= (count * 10);
        }
    }
}
