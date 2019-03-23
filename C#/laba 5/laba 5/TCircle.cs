using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class TCircle:TFigure
    {
        public int r, r1;
        public TCircle(TPoint point)
        {
            paramPoint = point;
        }
        public override void Show(TPoint point, int lol, int hol, Pen pen, Bitmap mbit)
        {

        }
        public TCircle()
        {

        }
    }
}
