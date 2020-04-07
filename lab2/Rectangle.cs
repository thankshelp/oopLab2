using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Rectangle2D
    {
        private double x1, y1, x2, y2, x3, y3, x4, y4;

        public Rectangle2D()
        {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
            x3 = 0;
            y3 = 0;
            x4 = 0;
            y4 = 0;

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
        public double GetX4()
        {
            return x4;
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
        public double GetY4()
        {
            return y4;
        }

        public void SetX1(double x1)
        {
            this.x1 = x1;
            this.x4 = x1;
        }
        public void SetX2(double x2)
        {
            this.x2 = x2;
            this.x3 = x2;
        }
        
       
        public void SetY1(double y1)
        {
            this.y1 = y1;
            this.y2 = y1;
        }
       
        public void SetY2(double y2)
        {
            this.y3 = y2;
            this.y4 = y2;
        }
        public void moveX(double mx)
        {
            this.x1 += mx;
            this.x2 += mx;
            this.x3 += mx;
            this.x4 += mx;
        }
        public void moveY(double my)
        {
            this.y1 += my;
            this.y2 += my;
            this.y3 += my;
            this.y4 += my;
        }
        public double otr(double x1, double x2, double y1, double y2)
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return length;
        }
        public double RecPerimetr(double a, double b)
        {
            double P = 2 * (a + b);
            return P;
        }
        public double RecArea(double a, double b)
        {
            double S = a * b;
            return S;
        }

    }
}
