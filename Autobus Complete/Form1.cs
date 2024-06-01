using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autobus_Complete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenNewAndCloseCurrent()
        {
            this.Hide();
            Form game = new FrmGame((int)numRounds.Value, (int)numTime.Value);
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenNewAndCloseCurrent();
        }
    }
}
