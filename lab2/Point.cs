using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace lab2
{
    public class Point2D
    {
        private double x, y;

        public Point2D()
        {
            x = 0;
            y = 0;
        }
        
        public double Getx()
        {
            return x;
        }
        public double Gety()
        {
            return y;
        }

        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public void moveX(double mx)
        {
            this.x += mx;
        }
        public void moveY(double my)
        {
            this.y += my;
        }


    }
}
