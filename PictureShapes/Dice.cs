using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PictureShapes
{
    class Dice
    {
        private static Random numberGenerator = new Random();
        private int number;

        private int dotSize = 15;
        private int minSize = 2;
        private int size;
        private int xPosition = 350;
        private int yPosition = -150;
        Circle[] dots = new Circle[7];
        Square[] backgrounds = new Square[2];       

        private int Size
        {
            get
            {
                if (dotSize > minSize)
                {
                    return dotSize;
                }
                else
                {
                    return minSize;
                }
            }
            set
            {
                if (value > minSize)
                {
                    dotSize = value;
                }
                else
                {
                    dotSize = minSize;
                }
                size = dotSize * 6;
            }
        }

        private int XPosition
        {
            get
            {                
                return xPosition;                
            }
            set
            {
                xPosition = value;
            }
        }
        private int YPosition
        {
            get
            {
                return yPosition;
            }
            set
            {
                yPosition = value;
            }
        }

        public Dice()
        {
            size = dotSize * 6;
            DrawDice();
            
            foreach (Square item in backgrounds)
            {
                item.XPosition += XPosition;
                item.YPosition -= YPosition;
            }

            foreach (Circle item in dots)
            {                
                item.XPosition += XPosition;
                item.YPosition -= YPosition;
            }
            
        }
        public void Roll()
        {
            backgrounds[0].MakeVisible();
            backgrounds[1].MakeVisible();

            number = numberGenerator.Next(1,7);

            if (!(number % 2 == 0))
            {
                dots[0].MakeVisible();
            }
            if (number >= 2)
            {
                dots[1].MakeVisible();
                dots[2].MakeVisible();
            }
            if (number >= 4)
            {
                dots[3].MakeVisible();
                dots[4].MakeVisible();
            }
            if (number == 6)
            {
                dots[5].MakeVisible();
                dots[6].MakeVisible();
            }        
        }
        public void DrawDice()
        {
            backgrounds[0] = new Square();
            backgrounds[0].ChangeColor("gray");
            backgrounds[0].Width = dotSize * 6;
         
            backgrounds[1] = new Square();
            backgrounds[1].ChangeColor("white");
            backgrounds[1].Width = dotSize * 5;
          
            int index = 0;
            foreach (Circle item in dots)
            {
                dots[index] = CreateCircle();
                index++;                
            }
            
            dots[0].XPosition = Convert.ToInt32(dotSize * 2.1);
            dots[0].YPosition = Convert.ToInt32(dotSize * 5.5);

            dots[1].XPosition = Convert.ToInt32(dotSize * 0.5);
            dots[1].YPosition = Convert.ToInt32(dotSize * 3.9);

            dots[2].XPosition = Convert.ToInt32(dotSize * 3.7);
            dots[2].YPosition = Convert.ToInt32(dotSize * 7.1);

            dots[3].XPosition = Convert.ToInt32(dotSize * 0.5);
            dots[3].YPosition = Convert.ToInt32(dotSize * 7.1);

            dots[4].XPosition = Convert.ToInt32(dotSize * 3.7);
            dots[4].YPosition = Convert.ToInt32(dotSize * 3.9);

            dots[5].XPosition = Convert.ToInt32(dotSize * 0.5);
            dots[5].YPosition = Convert.ToInt32(dotSize * 5.5);

            dots[6].XPosition = Convert.ToInt32(dotSize * 3.7);
            dots[6].YPosition = Convert.ToInt32(dotSize * 5.5);

            backgrounds[0].XPosition = Convert.ToInt32(dotSize * -0.4);
            backgrounds[0].YPosition = Convert.ToInt32(dotSize * 3);

            backgrounds[1].XPosition = Convert.ToInt32(dotSize * 0.15);
            backgrounds[1].YPosition = Convert.ToInt32(dotSize * 3.5);
        }
        private Circle CreateCircle()
        {
            Circle circle = new Circle();
            circle.ChangeColor("red");
            circle.Diameter = dotSize;
            return circle;
        }
    }
}
