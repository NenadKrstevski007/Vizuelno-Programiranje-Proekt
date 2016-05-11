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
    public partial class Form1 : Form
    {
        private Timer timer;
        private int time;
        private TilesDocument tilesDoc;
        public Form1()
        {
            InitializeComponent();
            tilesDoc = new TilesDocument(Width,Height);
            DoubleBuffered = true;
            time = 0;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            this.Text = "Game 2048";
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect1, rect2;
            rect1 = new Rectangle(0, 0, 400, 440);
            rect2 = new Rectangle(400, 0, 200, 440);
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkGray), rect1);
            e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#5A7E8F")), rect2);

            Rectangle scoreRect = new Rectangle(420, 100, 150, 30);
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkGray), scoreRect);

            Rectangle timeRect = new Rectangle(420, 250, 150, 30);
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkGray), timeRect);

            Brush brush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 16, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("Score:", font, brush, new Point(420, 75));

            e.Graphics.DrawString(tilesDoc.Score.ToString(), font, brush, scoreRect,stringFormat);

            e.Graphics.DrawString("Time:", font, brush, new Point(420, 225));

            string timeElapsed = updateTime();
            e.Graphics.DrawString(timeElapsed, font, brush, timeRect, stringFormat);
            brush.Dispose();
            tilesDoc.Draw(e.Graphics);
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            bool canGenerate=true;
            if (e.KeyCode == Keys.Right)
            {
                tilesDoc.moveRight();
              //  Invalidate();
                canGenerate=tilesDoc.generateRandom();
                Invalidate();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tilesDoc.moveLeft();
              //  Invalidate();
               canGenerate= tilesDoc.generateRandom();
                Invalidate();
            }
            else if (e.KeyCode == Keys.Up)
            {
                tilesDoc.moveUp();
              //  Invalidate();
                canGenerate=tilesDoc.generateRandom();
                Invalidate();
            }
            else if (e.KeyCode == Keys.Down)
            {
                tilesDoc.moveDown();
             //   Invalidate();
                canGenerate=tilesDoc.generateRandom();
                Invalidate();
            }
            if (!canGenerate)
                end();
            if (tilesDoc.hasWin())
                winner();
        }

        private void end()
        {
            if (tilesDoc.theEnd()) gameOver();
           

        }
        private void gameOver() {
            timer.Stop();
            GameOverDialog gameOver = new GameOverDialog();
            this.Opacity = 10;
            gameOver.ShowDialog();
            if (gameOver.resault == DialogResult.Yes)
            {
                Form1 newGame = new Form1();
                newGame.Show();
                newGame.FormClosing += (obj, args) => { this.Close(); };
                // this.Close();
                this.Hide();
            }
            if (gameOver.resault == DialogResult.No)
            {
                this.Close();
            }
        }

        private void winner()
        {
            timer.Stop();
            WinDialog winDialog = new WinDialog();
            this.Opacity = 10;
            winDialog.ShowDialog();
            if (winDialog.resault == DialogResult.Yes)
            {
                Form1 newGame = new Form1();
                newGame.Show();
                newGame.FormClosing += (obj, args) => { this.Close(); };
                // this.Close();
                this.Hide();
            }
            if (winDialog.resault == DialogResult.No)
            {
                this.Close();
            }
        }

        private string updateTime()
        {
            int min = time / 60;
            int sec = time % 60;
            string timeSpend=Text = string.Format("{0:00}:{1:00}", min, sec);     
            return timeSpend;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ++time;
            Invalidate();
        }

        
    }
}
