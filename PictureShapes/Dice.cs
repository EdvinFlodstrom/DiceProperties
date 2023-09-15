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
            grayBackground.MoveHorizontal(30);
            grayBackground.MoveVertical(-20);

            whiteBackground = new Square();
            whiteBackground.ChangeColor("white");
            whiteBackground.ChangeSize(250);
            whiteBackground.MoveHorizontal(55);
            whiteBackground.MoveVertical(5);
          
            int index = 0;
            foreach (Circle item in dots)
            {
                dots[index] = CreateCircle();
                index++;                
            }

            dots[0].MoveHorizontal(105);
            dots[0].MoveVertical(275);

            dots[1].MoveHorizontal(25);
            dots[1].MoveVertical(195);

            dots[2].MoveHorizontal(185);
            dots[2].MoveVertical(355);

            dots[3].MoveHorizontal(25);
            dots[3].MoveVertical(355);

            dots[4].MoveHorizontal(185);
            dots[4].MoveVertical(195);

            dots[5].MoveHorizontal(25);
            dots[5].MoveVertical(275);

            dots[6].MoveHorizontal(185);
            dots[6].MoveVertical(275);
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
