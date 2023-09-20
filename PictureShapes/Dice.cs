using System;
using System.Diagnostics;

namespace PictureShapes
{
    class Dice
    {
        private static Random numberGenerator = new Random();
        int number;

        private Square grayBackground;
        private Square whiteBackground;

        Circle[] dots = new Circle[7];

        public Dice()
        {
            DrawDice();
        }
        public void Roll()
        {
            grayBackground.MakeVisible();
            whiteBackground.MakeVisible();

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
            grayBackground = new Square();
            grayBackground.ChangeColor("gray");
            grayBackground.ChangeSize(300);
            grayBackground.XPosition += 30;
            grayBackground.YPosition += -20;

            whiteBackground = new Square();
            whiteBackground.ChangeColor("white");
            whiteBackground.ChangeSize(250);
            whiteBackground.XPosition += 55;
            whiteBackground.YPosition += 5;
          
            int index = 0;
            foreach (Circle item in dots)
            {
                dots[index] = CreateCircle();
                index++;                
            }

            dots[0].XPosition += 105;
            dots[0].YPosition += 275;

            dots[1].XPosition += 25;
            dots[1].YPosition += 195;

            dots[2].XPosition += 185;
            dots[2].YPosition += 355;

            dots[3].XPosition += 25;
            dots[3].YPosition += 355;

            dots[4].XPosition += 185;
            dots[4].YPosition += 195;

            dots[5].XPosition += 25;
            dots[5].YPosition += 275;

            dots[6].XPosition += 185;
            dots[6].YPosition += 275;
        }
        private Circle CreateCircle()
        {
            Circle circle = new Circle();
            circle.ChangeColor("red");
            circle.ChangeSize(50);
            return circle;
        }
    }
}
