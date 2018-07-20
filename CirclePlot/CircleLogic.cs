using LineDrawer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePlot
{
    public class CircleLogic
    {
        /// <summary>
        /// Circle Plot Algorithm
        /// 1. Using parametric equation of a circle 
        ///    x = h + rcos(t)
        ///    y = k + rsin(t)
        ///    where t is theter:- angle subtended by the point at the center of the circle
        ///    NOTE: t is in radians
        ///    h is the center cordinate of the circle on the x-axis
        ///    k is the center cordinate of the circle on the y asxis
        ///    r is the radius of the circle
        /// 2. Assume h,k and r
        /// 3. Select an change or step for t
        /// 4. Applying the above will provide corresponding x and y cordinates
        /// </summary>
        /// <param name="x_center_cordinate"></param>
        /// <param name="y_center_cordinate"></param>
        /// <param name="radius"></param>
        /// <param name="thetaIntervalRadians"> thetaIntervalRadians = (2*Math.PI)/(No of points you need)</param>
        /// <returns></returns>
        public List<PointLocation> ComputePointsForCirclePlot(int x_center_cordinate,int y_center_cordinate,int radius,double thetaIntervalRadians)
        {
            int h = x_center_cordinate;
            int k = y_center_cordinate;
            int r = radius;
            double theta_step = thetaIntervalRadians;
            double pi = Math.PI;
            int x_scale = 10;
            int y_scale = 10;
            List<PointLocation> pointLocations = new List<PointLocation>();
            for (double theta = 0; theta < (2*pi); theta += theta_step)
            {
                PointLocation pointLocation = new PointLocation();
                double x = h + (r * Math.Cos(theta));
                double y = k + (r * Math.Sin(theta));
                pointLocation.X = (float)x;
                pointLocation.Y = (float)y ;
                pointLocations.Add(pointLocation);
            }
            return pointLocations;

        }
    }
}
