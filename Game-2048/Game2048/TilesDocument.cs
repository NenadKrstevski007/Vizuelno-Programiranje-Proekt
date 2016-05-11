using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public class TilesDocument
    {
        public Tile [,] tiles;
        public int Score;
        private static readonly int SPACE = 25;
        private int Width;
        private int Height;
        public TilesDocument(int width,int height)
        {
            Width = width;
            Height = height;
            Score = 0;
            tiles = new Tile [4,4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    Point point = new Point((80+10)*j+SPACE,(80+10)*i+SPACE);
                    Tile tile = new Tile(0, point);
                    tiles[i,j] = tile;
                }
            generateRandom();
            
        }

        public void Draw(Graphics g)
        {
           

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    tiles[i, j].Draw(g);
                }
        }

        public bool generateRandom()
        {
            Random random = new Random();
            int i = random.Next(0, 4);
            int j = random.Next(0, 4);
            if (!hasEmptyTile())
                return false;
            while (tiles[i, j].Value != 0)
            {
                i = random.Next(0, 4);
                j = random.Next(0, 4);
            }
            int number = random.Next(1, 100);
            int value = 0;
            if (number < 70)
                value = 2;
            else value = 4;
            tiles[i, j].addValue(value);
            return true;
        }

        private void moveAllLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tiles[i, j].isEmpty() && !tiles[i, j + 1].isEmpty())
                    {
                        int value = tiles[i, j+1].Value;
                        tiles[i, j].addValue(value);
                        tiles[i, j + 1].clearValue();
                    }
                }
            }
        }

        public void moveLeft()
        {
            moveAllLeft();
            moveAllLeft();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tiles[i, j].Value == tiles[i, j + 1].Value)
                    {
                        int value = tiles[i, j].Value;
                        tiles[i, j].addValue(value);
                        tiles[i, j + 1].clearValue();
                        Score += value * 2;
                    }
                }
            }
            moveAllLeft();
        }


        private void moveAllRight()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 3; j > 0; j--)
                {
                    if (tiles[i, j].isEmpty() && !tiles[i, j-1].isEmpty())
                    {
                        int value = tiles[i, j-1].Value;
                        tiles[i, j].addValue(value);
                        tiles[i, j-1].clearValue();
                    }
                }
            }
        }


        public void moveRight()
        {
            moveAllRight();
            moveAllRight();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j > 0; j--)
                {
                    if (tiles[i, j].Value == tiles[i, j - 1].Value)
                    {
                        int value = tiles[i, j - 1].Value;
                        tiles[i, j].addValue(value);
                        tiles[i, j - 1].clearValue();
                        Score += value * 2;
                    }
                }
            }
            moveAllRight();
        }


        private void moveAllUp()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (tiles[i, j].isEmpty() && !tiles[i+1,j].isEmpty())
                    {
                        int value = tiles[i+1, j ].Value;
                        tiles[i, j].addValue(value);
                        tiles[i+1, j ].clearValue();
                    }
                }
            }
        }

        public void moveUp()
        {
            moveAllUp();
            moveAllUp();
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (tiles[i, j].Value == tiles[i+1, j ].Value)
                    {
                        int value = tiles[i, j].Value;
                        tiles[i, j].addValue(value);
                        tiles[i+1, j].clearValue();
                        Score += value * 2;
                    }
                }
            }
            moveAllUp();
        }


        private void moveAllDown()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i > 0; i--)
                {
                    if (tiles[i, j].isEmpty() && !tiles[i-1, j ].isEmpty())
                    {
                        int value = tiles[i-1, j].Value;
                        tiles[i, j].addValue(value);
                        tiles[i-1, j].clearValue();

                    }
                }
            }
        }


        public void moveDown()
        {
            moveAllDown();
            moveAllDown();
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i > 0; i--)
                {
                    if (tiles[i, j].Value == tiles[i-1, j].Value)
                    {
                        int value = tiles[i-1, j].Value;
                        tiles[i, j].addValue(value);
                        tiles[i-1, j].clearValue();
                        Score += value * 2;
                    }
                }
            }
            moveAllDown();
        }


        public bool hasEmptyTile()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (tiles[i, j].Value == 0)
                        return true;
            return false;
        }

        public bool hasWin()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tiles[i, j].Value == 2048)
                        return true;
                }
            }
            return false;
        }
        public bool theEnd()
        {
           
            for(int i = 0; i < 4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    if (i==0 && j > 0)
                    {
                        if (tiles[i, j - 1].Value == tiles[i, j].Value) return false;
                        if (tiles[i + 1, j].Value == tiles[i, j].Value) return false;
                    }
                    else if (i == 0 && j < 3)
                    {
                        if (tiles[i, j + 1].Value == tiles[i, j].Value) return false;
                        if (tiles[i + 1, j].Value == tiles[i, j].Value) return false;
                    }
                    if (i == 3 && j > 0)
                    {
                        if (tiles[i, j - 1].Value == tiles[i, j].Value) return false;
                        if (tiles[i - 1, j].Value == tiles[i, j].Value) return false;
                    }
                    else if (i == 3 && j < 3)
                    {
                        if (tiles[i, j + 1].Value == tiles[i, j].Value) return false;
                        if (tiles[i - 1, j].Value == tiles[i, j].Value) return false;
                    }
                    if (i == 1)
                    {
                        if(j > 0)
                        {
                            if (tiles[i, j-1].Value == tiles[i, j].Value) return false;
                            if (tiles[i + 1, j].Value == tiles[i, j].Value) return false;
                        }else if (j < 3)
                        {
                            if (tiles[i, j + 1].Value == tiles[i, j].Value) return false;
                            if (tiles[i + 1, j].Value == tiles[i, j].Value) return false;
                        }
                    }
                    if (i == 2)
                    {
                        if (j > 0)
                        {
                            if (tiles[i, j - 1].Value == tiles[i, j].Value) return false;
                            
                        }
                        else if (j < 3)
                        {
                            if (tiles[i, j + 1].Value == tiles[i, j].Value) return false;
                           
                        }
                    }

                }
            }
            return true;
        }       
                  
    }
}
