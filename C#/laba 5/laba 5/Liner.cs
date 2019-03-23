using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class Liner:TFigure
    {
        public int lol, hol;
        private TPoint point;
        Graphics liner;
        public Liner() { }
        public Liner(TPoint point, int xx1, int yy1, Pen pen, Bitmap mbit)
        {
            this.point = point;
            lol = xx1;
            hol = yy1;
        }
        ~Liner() { }
        public override void Show(TPoint point5, int lol, int hol, Pen pen, Bitmap mbit)
        {
            liner = Graphics.FromImage(mbit);
            liner.DrawLine(pen, point.paramX, point.paramY, point.paramX+lol, point.paramY+hol);
            liner.Dispose();
        }
        public void Cleear(Bitmap mbit)
        {
            liner = Graphics.FromImage(mbit);
            liner.Clear(Color.White);
        }
    }
}
