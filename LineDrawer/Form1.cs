using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDrawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            Point point = new Point(10, 10);
            Brush brush = Brushes.Black;
            FontFamily fontFamily = new FontFamily("Arial");

            Font font = new Font(fontFamily, 20.0f, FontStyle.Bold, GraphicsUnit.Point);

            //e.Graphics.DrawString("u", font, brush, point);
            MessageBox.Show("Point to draw");
        }

        private void DrawingCanvas_Click(object sender, EventArgs e)
        {
            Size canvasSize = DrawingCanvas.Size;

            //MessageBox.Show($"Height: {canvasSize.Height} , Width: { canvasSize.Width}");
        }




        private void DrawingCanvas_Paint(object sender, PaintEventArgs e)
        {

           

            for (int i = 0; i < 100; i++)
            {
                Point point = new Point(i, 100);
                Brush brush = Brushes.Black;
                FontFamily fontFamily = new FontFamily("Arial");

                Font font = new Font(fontFamily, 20.0f, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString(".", font, brush, point);
            }
            

        }

        private void DrawingCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            Size canvasSize = DrawingCanvas.Size;

            MessageBox.Show($"X: {x} , Y: { y} *** Size Height: {canvasSize.Height} , Width: { canvasSize.Width}");

        }
    }
}
