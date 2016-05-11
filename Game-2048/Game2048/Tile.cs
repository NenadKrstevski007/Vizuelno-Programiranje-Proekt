using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
   public class Tile
    {
        public int Value { get; set; }
        public Color Color { get; set; } 
        public Point Position { get; set; }
        public static readonly int WIDTH = 80;
        public static readonly int HEIGTH = 80;

        public Tile(int value, Point position)
        {
            this.Value = value;
            this.Position = position;
            setColor(value);
        }

        public void setColor(int value)
        {
            switch (value)
            {
                case 0: Color = ColorTranslator.FromHtml("#BFB9BD");
                    break;
                case 2: Color = ColorTranslator.FromHtml("#FFC8DB");
                    break;
                case 4: Color = ColorTranslator.FromHtml("#EB8FAC");
                    break;
                case 8: Color = ColorTranslator.FromHtml("#8791BF");
                    break;
                case 16: Color = ColorTranslator.FromHtml("#CE467B");
                    break;
                case 32: Color = ColorTranslator.FromHtml("#994680");
                    break; 
                case 64: Color = ColorTranslator.FromHtml("#3b6ba5");
                    break;
                case 128: Color = ColorTranslator.FromHtml("#5883a3");
                    break;
                case 256: Color = ColorTranslator.FromHtml("#545AA7");
                    break;
                case 512: Color = ColorTranslator.FromHtml("#4E5180");
                    break;
                case 1024: Color = ColorTranslator.FromHtml("#4c4176");
                    break;
                case 2048: Color = ColorTranslator.FromHtml("#5A7E8F");
                    break;
                default: Color = Color.Beige;
                    break;
            }
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            Rectangle rectangle = new Rectangle(Position.X, Position.Y, WIDTH, HEIGTH);
            g.FillRectangle(brush, rectangle);
            brush.Dispose();

            brush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 16);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            if (Value != 0)
            {
                g.DrawString(Value.ToString(), font, brush, rectangle, stringFormat);
                brush.Dispose();
            }
        }

        public bool Equals(Tile t)
        {
            if (t.Value == this.Value)
                return true;
            return false;
        }

        public void addValue(int value)
        {
            Value += value;
            setColor(Value);
        }
        public void clearValue()
        {
            Value = 0;
            setColor(Value);
        }
        public bool isEmpty()
        {
            return Value == 0;
        }
    }
}
