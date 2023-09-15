using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace PictureShapes
{
    /// <summary>
    /// An object of this class represents a Square, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2018 June
    /// </summary>
    class Square : Shape
    {
        private int width;
        private int xPosition;
        private int yPosition;
        private bool isVisible;
        private String color;

        /// <summary>
        /// Constructor used to create a Square object.
        /// </summary>
        public Square()
        {
            width = 50;
            xPosition = 50;
            yPosition = 200;
            color = "magenta";
            isVisible = false;
        }

        /// <summary>
        /// Metod used by the class Canvas to draw the Square on the canvas.
        /// </summary>
        /// <param name="g">The Grapics object to draw on.</param>
        public void Draw(Graphics g)
        {
            if (isVisible)
            {
                Color color = TranslateStringToColor(this.color);
                g.FillRectangle(new SolidBrush(color), xPosition, yPosition, width, width);
            }
        }

        /// <summary>
        /// Show the Square on the canvas.
        /// </summary>
        public void MakeVisible()
        {
            isVisible = true;
            Draw();
        }

        /// <summary>
        /// Make the Square invisible.
        /// </summary>
        public void MakeInVisible()
        {
            isVisible = false;
            Draw();
        }

        /// <summary>
        /// Change the color of the Square. 
        /// </summary>
        /// <param name="color">The name of the new color as a string. 
        /// Available colors are: "red", "green", "blue", "yellow", "magenta", "cyan", "black", and "white".
        /// </param>
        public void ChangeColor(String color)
        {
            this.color = color;
            Draw();
        }

        /// <summary>
        /// Change the size of the Square.
        /// </summary>
        /// <param name="size">The new size in pixels.</param>
        public void ChangeSize(int size)
        {
            if (size > 0)
            {
                width = size;
            }
            Draw();
        }

 

        /// <summary>
        /// Move the Square horizontally.
        /// </summary>
        /// <param name="distance">The distance to move the Square to the right.</param>
        public void MoveHorizontal(int distance)
        {
            xPosition = xPosition + distance;
            Draw();
        }

        /// <summary>
        /// Move the Square vertically.
        /// </summary>
        /// <param name="distance">The distance to move the Square down.</param>
        public void MoveVertical(int distance)
        {
            yPosition = yPosition + distance;
            Draw();
        }

        // Redraw the Square on the canvas. Make changes visible.
        private void Draw()
        {
            //Canvas canvas = Canvas.GetCanvas();
            Canvas canvas = Canvas.Self;
            canvas.Draw(this);

        }
        // Translate a color from a string to an object of the class Color.
        // Returns the color object.
        private Color TranslateStringToColor(String color)
        {
            if (color.Equals("red"))
            {
                return Color.Red;
            }
            if (color.Equals("green"))
            {
                return Color.Green;
            }
            if (color.Equals("blue"))
            {
                return Color.Blue;
            }
            if (color.Equals("magenta"))
            {
                return Color.Magenta;
            }
            if (color.Equals("cyan"))
            {
                return Color.Cyan;
            }
            if (color.Equals("yellow"))
            {
                return Color.Yellow;
            }
            if (color.Equals("white"))
            {
                return Color.White;
            }
            if (color.Equals("gray"))
            {
                return Color.LightGray;
            }
            if (color.Equals("black"))
            {
                return Color.Black;
            }
            return Color.Brown;
        }
    }
}