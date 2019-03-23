using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class TFigure
    {
        private TPoint point;
        public TPoint paramPoint
        {
            get { return point; }
            set { point = value; }
        }
        public virtual void Show(TPoint point, int lol, int hol, Pen pen, Bitmap mbit) { }
        public void MoveTO(TPoint point, Pen pen, Bitmap mbit, int r, int rr)
        {
            paramPoint = point;
            Show(point, r, rr, pen, mbit);
        }
    }
}
