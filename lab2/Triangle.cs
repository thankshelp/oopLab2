using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Triangle2D
    {
        private double x1, y1, x2, y2, x3, y3;

        public Triangle2D()
        {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
            x3 = 0;
            y3 = 0;
        }
        public double GetX1()
        {
            return x1;
        }
        public double GetX2()
        {
            return x2;
        }
        public double GetX3()
        {
            return x3;
        }
        public double GetY1()
        {
            return y1;
        }
        public double GetY2()
        {
            return y2;
        }
        public double GetY3()
        {
            return y3;
        }

        public void SetX1(double x1)
        {
            this.x1 = x1;
        }
        public void SetX2(double x2)
        {
            this.x2 = x2;
        }
        public void SetX3(double x3)
        {
            this.x3 = x3;
        }
        public void SetY1(double y1)
        {
            this.y1 = y1;
        }
        public void SetY2(double y2)
        {
            this.y2 = y2;
        }
        public void SetY3(double y3)
        {
            this.y3 = y3;
        }
        public void moveX(double mx)
        {
            this.x1 += mx;
            this.x2 += mx;
            this.x3 += mx;
        }
        public void moveY(double my)
        {
            this.y1 += my;
            this.y2 += my;
            this.y3 += my;
        }
        public double otr(double x1, double x2, double y1, double y2)
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return length;
        }
        public double TriPerimetr(double a, double b, double c)
        {
            double P = a + b + c;

            return P;
        }
        public double TriArea(double P, double a, double b, double c)
        {
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return S;
        }
     
    }
}
