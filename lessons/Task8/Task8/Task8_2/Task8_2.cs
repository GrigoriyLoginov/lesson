using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    #region RectangleRealization
    public class Rectangle : IFigure
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double Area()
        {
            return 2 * (ASide + BSide);
        }

        public double Perimetr()
        {
            return ASide + BSide;
        }
    }
    #endregion
    #region TriangleRealization
    public class Triangle : IFigure
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }
        public double Area()
        {
            double p = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }

        public double Perimetr()
        {
            return ASide + BSide + CSide;
        }
    }
    #endregion
    #region CircleRealization
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
    #endregion
    #region SquareRealization
    public class Square : IFigure
    {
        public double Side { get; set; }
        public double Area()
        {
            return Side * Side;
        }

        public double Perimetr()
        {
            return 4 * Side;
        }
    }
    #endregion
}
