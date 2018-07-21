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
            int h = 280;
            int k = 160;
            int r = 80;
            int numberOfPoints = 40;
            double theta_intervals_in_radians = (2 * Math.PI) / numberOfPoints;


            List<CirclePointLocation> clockLocations = circleLogic.ComputeClockHourMinutePoints(h, k, r);

            //List<PointLocation> locations = circleLogic.ComputePointsForCirclePlot(h, k, r, theta_intervals_in_radians);

            //for (int i = 0; i < locations.Count; i++)
            //{

            //    Point point = new Point((int)(locations[i].X), (int)locations[i].Y);
            //    Brush brush = Brushes.Black;
            //    FontFamily fontFamily = new FontFamily("Arial");

            //    Font font = new Font(fontFamily, 20.0f, FontStyle.Bold, GraphicsUnit.Point);
            //    e.Graphics.DrawString(".", font, brush, point);
            //}
            Point origin = new Point(h, k);
            Brush originBrush = Brushes.Purple;
            FontFamily originFontFamily = new FontFamily("Arial");

            Font originFont = new Font(originFontFamily, 20.0f, FontStyle.Bold, GraphicsUnit.Point);
            e.Graphics.DrawString(@".", originFont, originBrush, origin);
            for (int i = 0; i < clockLocations.Count; i++)
            {
                if (clockLocations[i].IsHourHand)
                {
                    Point point = new Point((int)(clockLocations[i].X), (int)clockLocations[i].Y);
                    Brush brush = Brushes.Red;
                    FontFamily fontFamily = new FontFamily("Arial");

                    Font font = new Font(fontFamily, 20.0f, FontStyle.Bold, GraphicsUnit.Point);
                    e.Graphics.DrawString(@".", font, brush, point);
                }
                else
                {
                    Point point = new Point((int)(clockLocations[i].X), (int)clockLocations[i].Y);
                    Brush brush = Brushes.Black;
                    FontFamily fontFamily = new FontFamily("Arial");

                    Font font = new Font(fontFamily, 20.0f, FontStyle.Bold, GraphicsUnit.Point);
                    e.Graphics.DrawString(".", font, brush, point);
                }

            }

        }
    }
}
