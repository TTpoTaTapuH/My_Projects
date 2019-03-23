using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba_5
{
    class HardFig:Ugolnik
    {
        private TPoint point;
        public int lol, hol;
        Graphics circle;
        static Graphics graf;
        public HardFig() { }
        static HardFig()
        {
            //MessageBox.Show("Кольцо создан!");
        }
        public HardFig(TPoint point, int r1, int rr1, Pen pen, Bitmap mbit)
        {
            this.point = point;
            lol = r1;
            hol = rr1;
        }
        ~HardFig() { }
        public static void Cleaning(Bitmap mbit)
        {
            graf = Graphics.FromImage(mbit);
            graf.Clear(Color.White);
            graf.Dispose();
        }
        public override void Show(TPoint point5, int lol, int hol, Pen pen, Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.DrawEllipse(pen, point.paramX, point.paramY, lol, hol);
            circle.DrawEllipse(pen, point.paramX + (lol / 4), point.paramY + (hol / 4), lol / 2, hol / 2);
            circle.DrawEllipse(pen, point.paramX + (lol / 2), point.paramY + (hol / 2), lol / 4, hol / 4);
            circle.DrawEllipse(pen, point.paramX + (lol / 4), point.paramY + (hol / 2), lol / 4, hol / 4);
            circle.DrawEllipse(pen, point.paramX + (lol / 2), point.paramY + (hol / 4), lol / 4, hol / 4);
            circle.DrawEllipse(pen, point.paramX + (lol / 4), point.paramY + (hol / 4), lol / 4, hol / 4);
            circle.DrawRectangle(pen, point.paramX, point.paramY, lol, hol);
            circle.DrawRectangle(pen, point.paramX + lol / 2, point.paramY + hol / 2, lol / 2, hol / 2);
            circle.DrawRectangle(pen, point.paramX + lol / 2, point.paramY, lol / 2, hol / 2);
            circle.DrawRectangle(pen, point.paramX, point.paramY + hol / 2, lol / 2, hol / 2);
            circle.DrawRectangle(pen, point.paramX, point.paramY, lol / 2, hol / 2);
            circle.DrawRectangle(pen, point.paramX + lol / 2 - lol / 4 + lol / 8, point.paramY + hol / 2 - hol / 4 + hol / 8, lol / 4, hol / 4);
            circle.Dispose();
        }
        public void Cleear(Bitmap mbit)
        {
            circle = Graphics.FromImage(mbit);
            circle.Clear(Color.White);
        }
    }
}
