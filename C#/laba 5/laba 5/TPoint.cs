using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class TPoint
    {
        static int x;
        static int y;

        public int paramX
        {
            get { return x; }
            set
            {
                if (value <= 0)
                    value = 0;
                if (value > 900)
                    value = 900;
                x = value;
            }
        }

        public int paramY
        {
            get { return y; }
            set
            {
                if (value <= 0)
                    value = 0;
                if (value > 500)
                    value = 500;
                y = value;
            }
        }

        public TPoint(int X, int Y)
        {
            paramX = X;
            paramY = Y;
            // MessageBox.Show("Точки созданы.");
        }
        public static int retX()
        {
            return x;
        }
        public static int retY()
        {
            return y;
        }
        public int rettX()
        {
            return x;
        }
        public int rettY()
        {
            return y;
        }
    }
}
