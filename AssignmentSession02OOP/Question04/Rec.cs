using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession02OOP.Question04
{
     struct Rec
    {
        #region Attributes 
        private double width;
        private double height;
        public double area;

        #endregion
        #region Constructor
        public Rec(double Width, double Height)
        {
            width = Width;
            height = Height;
        }

        #endregion
        #region 


        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value is  Not Falid");

                else
                    width = value;

            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    Console.WriteLine(" Value is Not Falid");

                else
                    height = value;
            }
        }
        // Area -> ReadOnly No-Change 
        public double Area
        {
            get
            {
                area = width * height;
                return area;
            }
        }

        #endregion
        #region Methods
        // Object Member Method 
        public  void DisplayArea()
        {
            Console.WriteLine($"Area={Area}");
        }
        #endregion
    }
}
