using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rrr = new Random();

        Point2D p = null;// = new Point2D();

        // Ellipse pppp = new Ellipse();

        Ellipse pp;

        Triangle2D t = null;

        Rectangle2D r = null;

        Line ll1;
        Line ll2;
        Line ll3;
        Line ll4;

        public MainWindow()
        {
            InitializeComponent();
            XLine.Minimum = 1;
            XLine.Maximum = 949;
            YLine.Minimum = 1;
            YLine.Maximum = 599;
        }

        public void drawPoint(Point2D ppp)
        {
            field.Children.Clear();

            pp = new Ellipse();


            pp.Stroke = Brushes.Blue;
            pp.StrokeThickness = 5;
            pp.Margin = new Thickness(ppp.Getx(), ppp.Gety(), 0, 0);

            field.Children.Add(pp);
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            p = new Point2D();
            p.SetX(rrr.Next(1, 949));
            p.SetY(rrr.Next(1, 599));
            drawPoint(p);

            XLine.Value = p.Getx();
            YLine.Value = p.Gety();

        }

        private void XLine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (p != null)
            {
                field.Children.Clear();
                double m = e.NewValue - p.Getx();

                p.moveX(m);
                drawPoint(p);
            }
            if (t != null)
            {
                field.Children.Clear();
                double m = e.NewValue - t.GetX2();

                t.moveX(m);

                drawTriangle(t);
            }
            if (r != null)
            {
                field.Children.Clear();
                double m = e.NewValue - r.GetX1();

                r.moveX(m);

                drawRectangle(r);
            }
        }

        private void YLine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (p != null)
            {
                field.Children.Clear();
                double m = e.NewValue - p.Gety();

                p.moveY(m);
                drawPoint(p);
            }
            if (t != null)
            {
                field.Children.Clear();
                double m = e.NewValue - t.GetY1();

                t.moveY(m);

                drawTriangle(t);
            }
            if (r != null)
            {
                field.Children.Clear();
                double m = e.NewValue - r.GetY1();

                r.moveY(m);

                drawRectangle(r);
            }
        }

        private void triangle_Click(object sender, RoutedEventArgs e)
        {
            field.Children.Clear();

            t = new Triangle2D();

            t.SetX1(rrr.Next(1, 949));
            t.SetX2(rrr.Next(1, 949));
            t.SetX3(rrr.Next(1, 949));
            t.SetY1(rrr.Next(1, 599));
            t.SetY2(rrr.Next(1, 599));
            t.SetY3(rrr.Next(1, 599));
            drawTriangle(t);

            XLine.Value = t.GetX1();
            YLine.Value = t.GetY1();

        }
        public void drawTriangle(Triangle2D tt)
        {

            ll1 = new Line();
            ll2 = new Line();
            ll3 = new Line();

            ll1.Stroke = Brushes.Green;
            ll1.StrokeThickness = 5;
            ll2.Stroke = Brushes.Green;
            ll2.StrokeThickness = 5;
            ll3.Stroke = Brushes.Green;
            ll3.StrokeThickness = 5;

            ll3.X2 = ll1.X1 = tt.GetX1();
            ll3.Y2 = ll1.Y1 = tt.GetY1();

            ll2.X1 = ll1.X2 = tt.GetX2();
            ll2.Y1 = ll1.Y2 = tt.GetY2();

            ll2.X2 = ll3.X1 = tt.GetX3();
            ll2.Y2 = ll3.Y1 = tt.GetY3();

            double LineLength1 = tt.otr(tt.GetX1(), tt.GetX2(), tt.GetY1(), tt.GetY2());
            double LineLength2 = tt.otr(tt.GetX2(), tt.GetX3(), tt.GetY2(), tt.GetY3());
            double LineLength3 = tt.otr(tt.GetX3(), tt.GetX1(), tt.GetY3(), tt.GetY1());

            double P = tt.TriPerimetr(LineLength1, LineLength2, LineLength3);

            double S = tt.TriArea(P, LineLength1, LineLength2, LineLength3);

            lb.Text = ("Периметр: " + Math.Round(P) + " Площадь: " + Math.Round(S));

            // ll.Margin = new Thickness(lll.GetX1(), lll.GetX2(), lll.Gety1(), lll.Gety2());

            field.Children.Add(ll1);
            field.Children.Add(ll2);
            field.Children.Add(ll3);

        }

        private void rectangle_Click(object sender, RoutedEventArgs e)
        {
            field.Children.Clear();

            r = new Rectangle2D();

            r.SetX1(rrr.Next(1, 949));
            r.SetX2(rrr.Next(1, 949));
            
            r.SetY1(rrr.Next(1, 599));
            r.SetY2(rrr.Next(1, 599));
            
            drawRectangle(r);

            XLine.Value = r.GetX1();
            YLine.Value = r.GetY1();
        }

        public void drawRectangle(Rectangle2D rr)
        {

            ll1 = new Line();
            ll2 = new Line();
            ll3 = new Line();
            ll4 = new Line();

            ll1.Stroke = Brushes.Green;
            ll1.StrokeThickness = 5;
            ll2.Stroke = Brushes.Green;
            ll2.StrokeThickness = 5;
            ll3.Stroke = Brushes.Green;
            ll3.StrokeThickness = 5;
            ll4.Stroke = Brushes.Green;
            ll4.StrokeThickness = 5;

            ll4.X2 = ll1.X1 = rr.GetX1();
            ll4.Y2 = ll1.Y1 = rr.GetY1();

            ll2.X1 = ll1.X2 = rr.GetX2();
            ll2.Y1 = ll1.Y2 = rr.GetY2();

            ll2.X2 = ll3.X1 = rr.GetX3();
            ll2.Y2 = ll3.Y1 = rr.GetY3();

            ll3.X2 = ll4.X1 = rr.GetX4();
            ll3.Y2 = ll4.Y1 = rr.GetY4();

            double LineLength1 = rr.otr(rr.GetX1(), rr.GetX2(), rr.GetY1(), rr.GetY2());
            double LineLength2 = rr.otr(rr.GetX2(), rr.GetX3(), rr.GetY2(), rr.GetY3());
           

            double P = rr.RecPerimetr(LineLength1, LineLength2);

            double S = rr.RecArea(LineLength1, LineLength2);

            lb.Text = ("Периметр: " + Math.Round(P) + " Площадь: " + Math.Round(S));


            field.Children.Add(ll1);
            field.Children.Add(ll2);
            field.Children.Add(ll3);
            field.Children.Add(ll4);

        }

        private void Zrectangle_Click(object sender, RoutedEventArgs e)
        {
            field.Children.Clear();

            r = new Rectangle2D();

            double x1 = rrr.Next(1, 949);
            double x2 = x1 + double.Parse(w.Text);

            double y1 = rrr.Next(1, 599);
            double y2 = y1 + double.Parse(h.Text);

            r.SetX1(x1);
            r.SetX2(x2);

            r.SetY1(y1);
            r.SetY2(y2);

            drawRectangle(r);

            XLine.Value = r.GetX1();
            YLine.Value = r.GetY1();
        }
    }
}
