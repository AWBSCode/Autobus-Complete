using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Autobus_Complete
{
    public partial class FrmGame : Form
    {
        private const int PointsPerCorrectAnswer = 10;
        private int rounds;
        private int mainRndTime;
        private int rndTime;
        private int currentRnd = 1;
        private int points = 0;
        private char letter = 'A';
        private string chosenLetter = "";

        public FrmGame(int rounds, int rndTime)
        {
            InitializeComponent();
            this.rounds = rounds;
            this.rndTime = rndTime * 60;
            this.mainRndTime = rndTime * 60;
            GetLetterRandomly();
            WriteTime();
        }

        private void WriteTime()
        {
            int minutes = rndTime / 60;
            int remainingSeconds = rndTime % 60;

            string mins = minutes.ToString("D2");
            string secs = remainingSeconds.ToString("D2");

            lblTimer.Text = $"{mins}:{secs}";
        }

        private void GetLetterRandomly()
        {
            Random rd = new Random();
            letter = (char)rd.Next(65, 91); // ASCII codes for A-Z
            lblLetter.Text = $"Letter {letter}";

            if (IsLetterChosenBefore())
            {
                GetLetterRandomly();
            } else
            {
                chosenLetter += letter;
            }
        }

        private bool IsLetterChosenBefore()
        {
            if (chosenLetter.Contains(letter))
                return true;
             
            return false;
        }

        private void btnCompleteRound_Click(object sender, EventArgs e)
        {
            CheckTextBoxes();

            if (currentRnd == rounds)
            {
                ShowResults();
            }
            else
            {
                ResetRound();
            }
        }

        private void CheckTextBoxes()
        {
            TextBox[] textBoxes = { tbPerson, tbAnimal, tbPlant, tbCountry };

            foreach (var tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text)) continue;

                if (Char.ToUpper(tb.Text[0]) != letter) continue;
                else
                {
                    UpdatePoints();
                }
            }
        }

        private void UpdatePoints(int updateValue = PointsPerCorrectAnswer)
        {
            points += updateValue;
            lblPoints.Text = $"{points} Points";
        }

        private void ShowResults()
        {
            this.Hide();
            FrmResult frmResult = new FrmResult(points, rounds);
            frmResult.Closed += (s, args) => this.Close();
            frmResult.Show();
        }

        private void ResetRound()
        {
            currentRnd++;
            lblRound.Text = $"Round #{currentRnd}";

            TextBox[] textBoxes = { tbPerson, tbAnimal, tbPlant, tbCountry };
            foreach (var tb in textBoxes)
            {
                tb.Text = "";
                errorProvider1.SetError(tb, "");
            }
            GetLetterRandomly();
            rndTime = mainRndTime;
            WriteTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rndTime--;

            if (rndTime <= 0)
            {
                btnRoundComplete.PerformClick();
            }
            else
            {
                WriteTime();
            }
        }
    }
}
