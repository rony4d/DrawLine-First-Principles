using LineDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirclePlot
{
    public partial class FormCirclePlot : Form
    {
        public FormCirclePlot()
        {
            InitializeComponent();
        }

        private void DrawingCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            Size canvasSize = CirclePlotCanvas.Size;

            MessageBox.Show($"X: {x} , Y: { y} *** Size Height: {canvasSize.Height} , Width: { canvasSize.Width}");
        }

        private void CircleDrawingCanvasPaint(object sender, PaintEventArgs e)
        {

            CircleLogic circleLogic = new CircleLogic();
            int h = 200;
            int k = 200;
            int r = 50;
            int numberOfPoints = 16;
            double theta_intervals_in_radians = (2 * Math.PI) / numberOfPoints;
            List<PointLocation> locations = circleLogic.ComputePointsForCirclePlot(h, k, r, theta_intervals_in_radians);


            for (int i = 0; i < locations.Count; i++)
            {
                Point point = new Point((int)(locations[i].X), (int)locations[i].Y);
                Brush brush = Brushes.Black;
                FontFamily fontFamily = new FontFamily("Arial");

                Font font = new Font(fontFamily, 20.0f, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString(".", font, brush, point);
            }



        }
    }
}
