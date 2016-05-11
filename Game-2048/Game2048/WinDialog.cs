using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class WinDialog : Form
    {
        private string timeElapsed;
        private string score;
        public DialogResult resault;
        public WinDialog(string time,string s)
        {
            InitializeComponent();
            this.timeElapsed = time;
            lblTime.Text = "Time: "+timeElapsed;

            this.score = s;
            lblScore.Text = "Score: " + score;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            resault = DialogResult.Yes;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            resault = DialogResult.No;
            this.Close();

        }

       
    }
}
