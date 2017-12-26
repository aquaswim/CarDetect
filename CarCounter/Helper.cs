using System;
using System.Drawing;
using Emgu.CV.Structure;
using System.Collections.Generic;

namespace CarCounter
{
    public static class Helper
    {
        /// <summary>
        /// Get The center point of Rectangle
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Point RectToPoint(Rectangle rect)
        {
            Point centerPoint = rect.Location;
            centerPoint.X += rect.Width / 2;
            centerPoint.Y += rect.Height / 2;
            return centerPoint;
        }
        /// <summary>
        /// Get rectangle area
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static int RectArea(Rectangle rect)
        {
            return rect.Width * rect.Height;
        }

        /// <summary>
        /// Check if point intersect horizontal line
        /// </summary>
        /// <param name="p">Point to check</param>
        /// <param name="line">Horizontal line</param>
        /// <returns></returns>
        public static bool PointIntersectLine(Point p, LineSegment2D line,int threshold,bool horizontal=true)
        {
            if (horizontal)
            {
                int left = Math.Min(line.P1.X, line.P2.X);
                int right = Math.Max(line.P1.X, line.P2.X);
                if (p.X > left && p.X < right)
                {
                    Console.WriteLine($"{line.P1.Y},{line.P2.Y}\t=> {p.Y}");
                    return (Math.Abs(line.P1.Y-p.Y)<threshold);
                }
            }
            else
            {
                int top = Math.Min(line.P1.Y, line.P2.Y);
                int bottom = Math.Max(line.P1.Y, line.P2.Y);
                if (p.Y > top && p.X < bottom)
                {
                    return p.X == line.P1.X;
                }
            }
            return false;
        }

        public static int GetPointDistance(Point p1,Point p2)
        {
            return (int)Math.Sqrt(Math.Pow(p1.X-p2.X,2) + Math.Pow(p1.Y-p2.Y,2));
        }
        
        public static bool AlreadyDetected(Rectangle detectedRect,List<DetectedItem> listDetected,uint nowFrame,uint min=3)
        {
            Point mid = RectToPoint(detectedRect);
            foreach(DetectedItem item in listDetected)
            {
                if (item.Rect.Contains(mid))
                {
                    if (Math.Abs(nowFrame - item.AtFrame) > min)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
