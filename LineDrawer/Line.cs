using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    public class Line
    {
        /******
         * UGO'S ALGORITHM FOR DRAWING A LINE USING MIDPOINTS
         * Given the coordinates of two points to draw the line between the points
         * 1. We need to find the slope(change in y / change in x)
         * 2. We need to find the midpoints between the two coordinates
         * 3. We continue to find midpoints from the initial midpoint to the first corordinate
         * 4. We also continue to find midpoints from the initial midpoint to the second corordinate
         * 5. The midpoints will act as our points that we eventually form the line
         * 6. The precision/finess of the line depends on the number of midpoints, the more the midpoints the cleaner the line
         * 
         * N.B I thought I could just pick any random factor to act as interval between the points
         * but i realized that the slope was changing for some point. But using the midpoints equation,
         * the slopes will always remain the same
         * 
         * Midpoint between two points P(x1,y1),Q(x2,y2) 
         * M = (x1 + x2)/2 , (y1 + y2)/2
         * 
         * THE SECOND AND EASIER METHOD 
         * 1. Find the y-intercept c and  get corresponding values of y given different values of x
         * *****/

        /// <summary>
        /// Let us assume we are on the positive side of the cart
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="rateOfChangeOfX"></param>
        public List<PointLocation> ComputePointsForLine(float x1, float y1, float x2, float y2,float rateOfChangeOfX)
        {
            //Find slope and y intercept

            List<PointLocation> pointLocations = new List<PointLocation>();

            float xChange = Math.Abs(x2 - x1);
            float yChange = Math.Abs(y2 - y1);
            float slope = yChange / xChange;    //  m = (y2-y1)/(x2-x1)
            float yIntercept = y1 - (slope * x1); // y = mx + c

            //add initial points first before iterating

            pointLocations.Add(new PointLocation() { X = x1, Y = y1, Slope = slope, YIntercept = yIntercept });

            for (float i = x1; i <= x2; i = i+rateOfChangeOfX)
            {
                //i is the current value of x at any point considering the rate of change of x

                PointLocation point = new PointLocation();

                float y_i = (slope * i) + yIntercept; // y_i is the value of y at the current position of x;  y = mx + c

                point.X = i;
                point.Y = y_i;
                point.Slope = slope;
                point.YIntercept = yIntercept;
                pointLocations.Add(point);

            }

            return pointLocations;
        }
    }
}
