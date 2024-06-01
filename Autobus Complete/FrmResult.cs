using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace Autobus_Complete
{
    public partial class FrmResult : Form
    {
        public FrmResult(int points, int rounds)
        {
            int agp = 40 * rounds;
            double dp = ((double)points / (double)agp);
            int percentage = (int)(dp * 100.0);

            InitializeComponent();
            lblPoints.Text = points.ToString();
            lblGamePoints.Text = agp.ToString();
            lblPercentage.Text = percentage.ToString() + "%";
        }
    }
}
