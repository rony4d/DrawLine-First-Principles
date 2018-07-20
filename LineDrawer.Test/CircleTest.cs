using CirclePlot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void ShouldComputePointsForCircle()
        {
            CircleLogic circle = new CircleLogic();

            // number of points to plot 16
            // value of theta(t) intervals in radians = (2*Math.PI)/16
            // assume unit circle, r = 1
            // h = 200, k = 200
            int h = 200;
            int k = 200;
            int r = 1;
            int numberOfPoints = 16;
            double theta_intervals_in_radians = (2 * Math.PI) / numberOfPoints;
            List<PointLocation> locations = circle.ComputePointsForCirclePlot(h, k, r, theta_intervals_in_radians);      

            string locationPoints = JsonConvert.SerializeObject(locations);

        }
    }
}
