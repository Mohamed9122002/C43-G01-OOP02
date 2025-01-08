using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession02OOP.Question02
{
     struct Point1
    {
        #region Attributes
        public int X { get; set; }
        public int Y { get; set; }
        #endregion



        #region Method
        public static double CalcDistance(Point1 point1, Point1 point2)
        {
            int dx = point2.X - point1.X;
            int dy = point2.Y - point1.Y;

             // Math .Sqrt Retrun Double 
            return Math.Sqrt(dx * dx + dy * dy);

        }
        #endregion
    }
}
