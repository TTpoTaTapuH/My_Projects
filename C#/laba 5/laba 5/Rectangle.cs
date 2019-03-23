using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace laba_5
{
    class Rectangle:Ugolnik
    {
        private int l = 0;
        private int h = 0;
        public int lol, hol;
        private TPoint point;
        Graphics rectangle;
        static Graphics graf;
        public Rectangle() { }
        public Rectangle(TPoint point, int l1, int h1, Pen pen, Bitmap mbit)
        {
            this.point = point;
            lol = l1;
            hol = h1;
        }
        public override void Show(TPoint point5, int lol, int hol, Pen pen, Bitmap mbit)
        {
            rectangle = Graphics.FromImage(mbit);
            rectangle.DrawRectangle(pen, point.paramX, point.paramY, lol, hol);
            rectangle.Dispose();
        }
        ~Rectangle() { }
        public static void Cleaning(Bitmap mbit)
        {
            graf = Graphics.FromImage(mbit);
            graf.Clear(Color.White);
            graf.Dispose();
        }
        public void Cleear(Bitmap mbit)
        {
            rectangle = Graphics.FromImage(mbit);
            rectangle.Clear(Color.White);
        }
    }
}
