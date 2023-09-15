using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureShapes
{
    public partial class PictureForm : Form
    {
        private Dice dice;

        public PictureForm()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dice = new Dice();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            canvas.Clear();
            dice.Roll();
        }
    }
}
