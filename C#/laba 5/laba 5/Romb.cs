using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class Romb:Ugolnik
    {
        private TPoint point;
        public int lol, hol;
        Graphics circle;
        static Graphics graf;
        public Romb() { }
        static Romb()
        {
        }
        public Romb(TPoint point, int r1, int rr1, Pen pen, Bitmap mbit)
        {
            this.point = point;
            this.lol = r1;
            this.hol = rr1;
        }
        ~Romb() { }
        public static void Cleaning(Bitmap mbit)
        {
            graf = Graphics.FromImage(mbit);
            graf.Clear(Color.White);
            graf.Dispose();
        }
        public override void Show(TPoint point, int lol, int hol, Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            Point point1 = new Point(point.paramX, point.paramY + hol);
            Point point2 = new Point(point.paramX + lol, point.paramY);
            Point point3 = new Point(point.paramX + 2 * lol, point.paramY + hol);
            Point point4 = new Point(point.paramX + lol, point.paramY + 2 * hol);
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
            Point point1 = new Point(point.paramX, point.paramY + hol);
            Point point2 = new Point(point.paramX + lol, point.paramY);
            Point point3 = new Point(point.paramX + 2 * lol, point.paramY + hol);
            Point point4 = new Point(point.paramX + lol, point.paramY + 2 * hol);
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
