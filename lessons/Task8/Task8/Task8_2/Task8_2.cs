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
        private double ASide { get; set; }
        private double BSide { get; set; }
        public double Area()
        {
            return ASide * BSide;
        }

        public double Perimetr()
        {
            return 2 * (ASide + BSide);
        }

        public Rectangle(double ASide, double BSide)
        {
            this.ASide = ASide;
            this.BSide = BSide;
        }
    }
    #endregion
    #region TriangleRealization
    public class Triangle : IFigure
    {
        private double ASide { get; set; }
        private double BSide { get; set; }
        private double CSide { get; set; }
        public double Area()
        {
            double p = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }

        public double Perimetr()
        {
            return ASide + BSide + CSide;
        }

        public Triangle(double ASide, double BSide, double CSide)
        {
            this.ASide = ASide;
            this.BSide = BSide;
            this.CSide = CSide;
        }
    }
    #endregion
    #region CircleRealization
    public class Circle : IFigure
    {
        private double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
    }
    #endregion
    #region SquareRealization
    public class Square : Rectangle
    {
        private double Side { get; set; }
        public new double Area()
        {
            return Side * Side;
        }

        public new double Perimetr()
        {
            return 4 * Side;
        }
        public Square(double Side) : base(Side, Side)
        {
            this.Side = Side;

        }
    }
    #endregion
}
