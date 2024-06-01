using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Autobus_Complete
{
    public partial class FrmGame : Form
    {

        int rounds = 0;
        int mainRndTime = 0;
        int rndTime = 0;
        int currentRnd = 1;
        int points = 0;
        char letter = 'A';

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
            int minutes = (int)(rndTime / 60);
            int remainingSeconds = (int)(rndTime % 60);

            string mins = minutes >= 10 ? minutes.ToString() : '0' + minutes.ToString();
            string secs = remainingSeconds >= 10 ? remainingSeconds.ToString() : '0' + remainingSeconds.ToString();

            lblTimer.Text = $"{mins}:{secs}";
        }

        private void GetLetterRandomly() {
            Random rd = new Random();
            letter = (char)rd.Next(65, 91);
            lblLetter.Text = $"Letter {letter}";
        }

        private void btnCompleteRound_Click(object sender, EventArgs e)
        {
            // get all fields
            System.Windows.Forms.TextBox[] textBoxes = { tbPerson, tbAnimal, tbPlant, tbCountry };

            // check all fields if starts with the letter;
            foreach (var tb in textBoxes)
            {
                if (tb.Text.Length <= 0)
                {
                    continue;
                }

                if (Char.ToUpper(tb.Text[0]) != letter) {
                    tb.Focus();
                    errorProvider1.SetError(tb, $"The word should be started with the letter {letter}");
                    return;
                } else
                {
                    UpdatePoints();
                }
            }

            if (currentRnd == rounds)
            {
                ShowResults();
                return;
            }
            // update current round and reset all the fields
            ResetRound();

        }

        private void UpdatePoints(int updateValue = 10) {
            points += updateValue;
            lblPoints.Text = points.ToString() + " Points";
        }

        private void ShowResults()
        {
            this.Hide();
            Form frmResult = new FrmResult(points, rounds);
            frmResult.Closed += (s, args) => this.Close();
            frmResult.Show();
        }

        private void ResetRound()
        {
            currentRnd++;
            lblRound.Text = $"Round #{currentRnd}";

            System.Windows.Forms.TextBox[] textBoxes = { tbPerson, tbAnimal, tbPlant, tbCountry };
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

            if (rndTime == 0)
            {
                btnRoundComplete.PerformClick();
                return;
            }

            WriteTime();
        }
    }
}
