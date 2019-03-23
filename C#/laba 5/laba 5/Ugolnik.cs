using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class Ugolnik:TFigure
    {
        public int r, r1;
        public Ugolnik(TPoint point)
        {
            paramPoint = point;
        }
        public override void Show(TPoint point5, int lol, int hol, Pen pen, Bitmap mbit)
        {

        }
        public Ugolnik()
        {

        }
    }
}
