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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lblTitle.Text = "GAME 2048";
            lblHowToPlay.Text = "How to play:";
            lblExplanation.Text = "Use your arrow keys to move the tiles.\nWhen two tiles with the same number touch,\nthey merge into one!";
            lblMadeBy.Text = "Made by:";
            lblName.Text = "Dajana Ilieva\nNenad Krstevski";
        }

        
    }
}
