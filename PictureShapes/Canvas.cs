using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureShapes
{
    public partial class Canvas : UserControl
    {
        private List<Shape> shapes;
        private static Canvas self;

        public Canvas()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            self = this;
            
        }
        public static Canvas Self
        {
            get
            {
                return self;
            }
        }

        private void Canvas_Load(object sender, EventArgs e)
        {
            Invalidate();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
            //Shape s = new Circle();
            //s.Draw(e.Graphics);
        }
        /// <summary>
        /// Draw the specified shape on top of the other shapes.
        /// </summary>
        /// <param name="shape"></param>
        public void Draw(Shape shape)
        {
            // remove shape if it is already in the list shapes
            shapes.Remove(shape);
            // add the shape to the end of the list
            shapes.Add(shape);
            // repaint the screen
            Refresh();
        }
        /// <summary>
        /// Remove all shapes from the canvas.
        /// </summary>
        public void Clear()
        {
            shapes = new List<Shape>();
        }
    }
}
