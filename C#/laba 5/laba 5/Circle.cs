using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class Circle:TCircle
    {
        public int R = 0;
        public int lol, hol;
        private TPoint point;
        Graphics circle;
        static Graphics graf;
        public Circle() { }
        static Circle() { }
        public Circle(TPoint point, int r1, Pen pen, Bitmap mbit)
        {
            this.point = point;
            hol = r1;
        }
        public override void Show(TPoint point, int lol, int hol, Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.DrawEllipse(pen, point.paramX, point.paramY, hol, hol);
            circle.Dispose();
        }
        ~Circle() { }
        public static void Cleaning(Bitmap mbit)
        {
            graf = Graphics.FromImage(mbit);
            graf.Clear(Color.White);
            graf.Dispose();
        }

        public void Cleear(Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.Clear(Color.White);
        }
    }
}
