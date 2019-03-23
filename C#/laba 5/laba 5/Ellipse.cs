using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class Ellipse:TCircle
    {
        public int lol, hol;
        private TPoint point;
        Graphics circle;
        static Graphics graf;
        public Ellipse() { }
        static Ellipse()
        {
        }
        public Ellipse(TPoint point, int r1, int rr1, Pen pen, Bitmap mbit)
        {
            this.point = point;
            this.lol = r1;
            this.hol = rr1;
        }
        ~Ellipse() { }
        public static void Cleaning(Bitmap mbit)
        {
            graf = Graphics.FromImage(mbit);
            graf.Clear(Color.White);
            graf.Dispose();
        }
        public override void Show(TPoint point, int lol, int hol, Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.DrawEllipse(pen, point.paramX, point.paramY, lol, hol);
            circle.Dispose();
        }
        public void ShowGrad(Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.Clear(Color.White);
            circle = Graphics.FromImage(mbit);
            circle.DrawEllipse(pen, point.paramX, point.paramY, hol, lol);
            circle.Dispose();
        }
        public void Cleear(Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.Clear(Color.White);
        }
    }
}
