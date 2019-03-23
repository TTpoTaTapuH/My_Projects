using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class Trapeze:Ugolnik
    {
        public int R, RR, w;
        private TPoint point;
        public int lol, hol;
        Graphics circle;
        static Graphics graf;
        public Trapeze() { }
        static Trapeze()
        {
        }
        public Trapeze(TPoint point, int r1, int rr1, Pen pen, Bitmap mbit)
        {
            this.point = point;
            this.lol = r1;
            this.hol = rr1;
        }
        ~Trapeze() { }
        public static void Cleaning(Bitmap mbit)
        {
            graf = Graphics.FromImage(mbit);
            graf.Clear(Color.White);
            graf.Dispose();
        }
        public override void Show(TPoint point, int lol, int hol, Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            int nx = point.paramX;
            int ny = point.paramY;
            Point point1 = new Point(nx, ny);
            Point point2 = new Point(nx, ny + hol);
            Point point3 = new Point(nx + lol+100, ny + hol);
            Point point4 = new Point(nx + lol, ny);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4
             };
            circle.DrawPolygon(pen, curvePoints);
            circle.Dispose();
        }
        public void ShowGrad(Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.Clear(Color.White);
            circle = Graphics.FromImage(mbit);
            int nx = point.paramX;
            int ny = point.paramY;
            Point point1 = new Point(nx, ny);
            Point point2 = new Point(nx, ny + RR);
            Point point3 = new Point(nx + R + R / 4, ny + RR);
            Point point4 = new Point(nx + R, ny);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4
             };
            circle.DrawPolygon(pen, curvePoints);
            circle.Dispose();
        }
        public void Cleear(Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.Clear(Color.White);
        }
    }
}
