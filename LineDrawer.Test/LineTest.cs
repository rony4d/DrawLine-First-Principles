using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace LineDrawer.Test
{
    [TestClass]
    public class LineTest
    {
        
        [TestMethod]
        public void ShouldComputePointsForLine()
        {
            Line line = new Line();

            //using the example in the math solution
            // slope = 1.5; y-Intercept = 0.5
            float slope = 1.5f;
            float yIntercept = 0.5f;
            List<PointLocation> locations = line.ComputePointsForLine(1, 2, 5, 8, 0.01f);

            Assert.AreEqual(locations[0].Slope, slope);
            Assert.AreEqual(locations[0].YIntercept, yIntercept);

            string locationPoints = JsonConvert.SerializeObject(locations);

        }
    }
}
