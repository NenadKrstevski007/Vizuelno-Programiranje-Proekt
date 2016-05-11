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
    public partial class GameOverDialog : Form
    { 
        public DialogResult resault;
        private string score;
        public GameOverDialog(string s)
        {
            InitializeComponent();
            score = s;
            lblScore.Text = "Score: " + score;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            resault = DialogResult.No;
            this.Close();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            resault = DialogResult.Yes;
            this.Close();
        }
    }
}
