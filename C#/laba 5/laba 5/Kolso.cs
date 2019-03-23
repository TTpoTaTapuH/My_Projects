using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class Kolso:TCircle
    {
        public int R = 0;
        public int lol, hol;
        private TPoint point;
        Graphics circle;
        static Graphics graf;
        public Kolso() { }
        public Kolso(TPoint point, int r, Pen pen, Bitmap mbit)
        {
            this.point = point;
            hol = r;
        }

        static Kolso()
        {
            //MessageBox.Show("Кольцо создан!");
        }
        ~Kolso() { }
        public static void Cleaning(Bitmap mbit)
        {
            graf = Graphics.FromImage(mbit);
            graf.Clear(Color.White);
            graf.Dispose();
        }
        public override void Show(TPoint point, int lol, int hol, Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.DrawEllipse(pen, point.paramX, point.paramY, hol, hol);
            circle.DrawEllipse(pen, point.paramX + hol / 4, point.paramY + hol / 4, hol / 2, hol / 2);
            circle.Dispose();
        }
        public void Cleear(Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.Clear(Color.White);
        }
    }
}
