using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_5
{
    public partial class Form1 : Form
    {
        string bx, by,heg,dli;
        DinamicArray array = new DinamicArray();
        DinamicsList list = new DinamicsList();
        int proverka;
        int lol, hol;
        int s1, s2, s3, s4, s5, s6, s7, s8;
        TFigure[] figures = new TFigure[28];
        int[] figx = new int[28];
        int[] figy = new int[28];
        int[] figl = new int[28];
        int[] figh = new int[28];
        int sozdat = 0;
        string n;
        Bitmap mbit;
        Graphics gr;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (proverka == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        Clean();
                        for (int t = 0; t < 28; t++)
                        {
                            if (figures[t] is Circle && s1 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + figh[t] > 500)
                                {
                                    figy[t] = 500 - figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figh[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Ellipse && s2 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + figh[t] > 500)
                                {
                                    figy[t] = 500 - figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Kolso && s3 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + figh[t] > 500)
                                {
                                    figy[t] = 500 - figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Liner && s8 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + figh[t] > 500)
                                {
                                    figy[t] = 500 - figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is HardFig && s7 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + figh[t] > 500)
                                {
                                    figy[t] = 500 - figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Rectangle && s6 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + figh[t] > 500)
                                {
                                    figy[t] = 500 - figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Romb && s4 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + 2 * figh[t] > 500)
                                {
                                    figy[t] = 500 - 2 * figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Trapeze && s5 == 1)
                            {
                                figy[t] = figy[t] + 10;
                                if (figy[t] + figh[t] > 500)
                                {
                                    figy[t] = 500 - figh[t];
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                        }
                        break;
                    case Keys.Up:
                        Clean();
                        for (int t = 0; t < 28; t++)
                        {
                            if (figures[t] is Circle && s1 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Ellipse && s2 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Kolso && s3 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Liner && s8 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is HardFig && s7 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Rectangle && s6 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Romb && s4 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Trapeze && s5 == 1)
                            {
                                figy[t] = figy[t] - 10;
                                if (figy[t] <= 0)
                                {
                                    figy[t] = 0;
                                }
                                else figy[t] = figy[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                        }
                        break;
                    case Keys.Left:
                        Clean();
                        for (int t = 0; t < 28; t++)
                        {
                            if (figures[t] is Circle && s1 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Ellipse && s2 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                                figx[t] = figx[t] - 10;
                            }
                            if (figures[t] is Kolso && s3 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                                figx[t] = figx[t] - 10;
                            }
                            if (figures[t] is Liner && s8 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t] , figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is HardFig && s7 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Rectangle && s6 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Romb && s4 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Trapeze && s5 == 1)
                            {
                                figx[t] = figx[t] - 10;
                                if (figx[t] <= 0)
                                {
                                    figx[t] = 0;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                        }
                        break;
                    case Keys.Right:
                        Clean();
                        for (int t = 0; t < 28; t++)
                        {
                            if (figures[t] is Circle && s1 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (figh[t] + figx[t] > 900)
                                {
                                    figx[t] = 900 - figh[t];
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figh[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Ellipse && s2 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (figl[t] + figx[t] > 900)
                                {
                                    figx[t] = 900 - figl[t];
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Kolso && s3 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (figh[t] + figx[t] > 900)
                                {
                                    figx[t] = 900 - figh[t];
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Liner && s8 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (figl[t] + figx[t] > 900)
                                {
                                    figx[t] = 900 - figl[t];
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is HardFig && s7 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (figl[t] + figx[t] > 900)
                                {
                                    figx[t] = 900 - figl[t];
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Rectangle && s6 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (figl[t] + figx[t] > 900)
                                {
                                    figx[t] = 900 - figl[t];
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Romb && s4 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (2 * figl[t] + figx[t] > 900)
                                {
                                    figx[t] = 900 - 2 * figl[t];
                                }
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                            if (figures[t] is Trapeze && s5 == 1)
                            {
                                figx[t] = figx[t] + 10;
                                if (figl[t] + 100 + figx[t] > 900)
                                {
                                    figx[t] = 900 - figl[t] - 100;
                                }
                                else figx[t] = figx[t];
                                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                                pictureBox1.Image = mbit;
                            }
                        }
                        break;
                }
            }
            else { MessageBox.Show("Создайте фигуры!"); }
        }
        private void Clean()
        {
            for (int t = 0; t < 28; t++)
            {
                figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                pictureBox1.Image = mbit;
                //Graphics gr = Graphics.FromImage(pictureBox1.Image);
                //gr.Clear(Color.White);
                Circle.Cleaning(mbit);
                Ellipse.Cleaning(mbit);
                Kolso.Cleaning(mbit);
                Rectangle.Cleaning(mbit);
                Romb.Cleaning(mbit);
                HardFig.Cleaning(mbit);
                //Trapeze.Cleaning(mbit);
            }
        }
        public Form1()
        {
            InitializeComponent();
            mbit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s1 = 1;
            }
            else
            {
                s1 = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s2 = 1;
            }
            else
            {
                s2 = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s3 = 1;
            }
            else
            {
                s3 = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s4 = 1;
            }
            else
            {
                s4 = 0;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s5 = 1;
            }
            else
            {
                s5 = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s6 = 1;
            }
            else
            {
                s6 = 0;
            }
        }

        private void уничтожитьКонтейнерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(proverka==1)
            {
                for (int t = 0; t < 28; t++)
                {
                    if (figures[t] is Ellipse && s2 == 1)
                    {
                        if (figl[t] >= 500)
                        {
                            MessageBox.Show("Нельзя перевернуть, поскольку не вмещается фигура.");
                        }
                        else
                        {
                            figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                            pictureBox1.Image = mbit;
                            int dl, he;
                            dl = figl[t];
                            he = figh[t];
                            figh[t] = dl;
                            figl[t] = he;
                            if (figl[t] + figx[t] > 900)
                            {
                                figx[t] = 900 - figl[t];
                            }
                            else figx[t] = figx[t];
                            if (figy[t] + figh[t] > 500)
                            {
                                figy[t] = 500 - figh[t];
                            }
                            else figy[t] = figy[t];
                            if(figx[t]<=0)
                            { figx[t] = 0; }
                            if (figy[t] <= 0) figy[t] = 0;
                            
                            if (figy[t] <= 0)
                            {
                                figy[t] = 0;
                            }
                            figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Blue), mbit);
                            pictureBox1.Image = mbit;
                        }
                            figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                            pictureBox1.Image = mbit;
                            figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                            pictureBox1.Image = mbit;
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dli = textBox4.Text;
            try
            { int chislo = Convert.ToInt32(dli); }
            catch
            {
                textBox1.Clear();
            }
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proverka == 1)
            {
                Circle.Cleaning(mbit);
                Ellipse.Cleaning(mbit);
                Kolso.Cleaning(mbit);
                Rectangle.Cleaning(mbit);
                Romb.Cleaning(mbit);
                HardFig.Cleaning(mbit);
                Trapeze.Cleaning(mbit);
                for (int t = 0; t < 28; t++)
                {
                    figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                    pictureBox1.Image = mbit;
                }
                for (int t = 0; t < 28; t++)
                {
                    if (figures[t] is Romb && s4 == 1)
                    {
                        if (figx[t] + 2 * Convert.ToInt32(dli) > 900)
                        {
                            figl[t] = (900 - figx[t]) / 2;
                        }
                        else figl[t] = Convert.ToInt32(dli);
                        if (figy[t] + 2 * Convert.ToInt32(heg) > 500)
                        {
                            figh[t] = (500 - figy[t]) / 2;
                        }
                        else figh[t] = Convert.ToInt32(heg);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Circle && s1 == 1)
                    {
                        int bs, df;
                        if (figx[t] + Convert.ToInt32(heg) > 900)
                        {
                            bs = (900 - figx[t]);
                        }
                        else bs = Convert.ToInt32(heg);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            df = (500 - figy[t]);
                        }
                        else df = Convert.ToInt32(heg);
                        if (bs > df) figh[t] = df;
                        else figh[t] = bs;
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Ellipse && s2 == 1)
                    {
                        if (figx[t] + Convert.ToInt32(dli) > 900)
                        {
                            figl[t] = (900 - figx[t]);
                        }
                        else figl[t] = Convert.ToInt32(dli);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            figh[t] = (500 - figy[t]);
                        }
                        else figh[t] = Convert.ToInt32(heg);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Kolso && s3 == 1)
                    {
                        int bs, df;
                        if (figx[t] + Convert.ToInt32(heg) > 900)
                        {
                            bs = (900 - figx[t]);
                        }
                        else bs = Convert.ToInt32(heg);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            df = (500 - figy[t]);
                        }
                        else df = Convert.ToInt32(heg);
                        if (bs > df) figh[t] = df;
                        else figh[t] = bs;
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Rectangle && s6 == 1)
                    {
                        if (figx[t] + Convert.ToInt32(dli) > 900)
                        {
                            figl[t] = (900 - figx[t]);
                        }
                        else figl[t] = Convert.ToInt32(dli);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            figh[t] = (500 - figy[t]);
                        }
                        else figh[t] = Convert.ToInt32(heg);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is HardFig && s7 == 1)
                    {
                        if (figx[t] + Convert.ToInt32(dli) > 900)
                        {
                            figl[t] = (900 - figx[t]);
                        }
                        else figl[t] = Convert.ToInt32(dli);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            figh[t] = (500 - figy[t]);
                        }
                        else figh[t] = Convert.ToInt32(heg);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Rectangle && s6 == 1)
                    {
                        if (figx[t] + Convert.ToInt32(dli) > 900)
                        {
                            figl[t] = (900 - figx[t] );
                        }
                        else figl[t] = Convert.ToInt32(dli);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            figh[t] = (500 - figy[t]);
                        }
                        else figh[t] = Convert.ToInt32(heg);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Trapeze && s5 == 1)
                    {
                        if (figx[t] + Convert.ToInt32(dli)+100 > 900)
                        {
                            figl[t] = (900 - figx[t]-100);
                        }
                        else figl[t] = Convert.ToInt32(dli);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            figh[t] = (500 - figy[t]);
                        }
                        else figh[t] = Convert.ToInt32(heg);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Liner && s8 == 1)
                    {
                        if (figx[t] + 100 + Convert.ToInt32(dli) > 900)
                        {
                            figl[t] = (900 - figx[t] - 100);
                        }
                        else figl[t] = Convert.ToInt32(dli);
                        if (figy[t] + Convert.ToInt32(heg) > 500)
                        {
                            figh[t] = (500 - figy[t]);
                        }
                        else figh[t] = Convert.ToInt32(heg);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    //for(t=0;t<28;t++)
                    //{
                    //    figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                    //    pictureBox1.Image = mbit;
                    //}
                }
                
            }
            else MessageBox.Show("Создайте.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            heg = textBox3.Text;
            try
            { int chislo = Convert.ToInt32(heg); }
            catch
            {
                textBox3.Clear();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s7 = 1;
            }
            else
            {
                s7 = 0;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                s8 = 1;
            }
            else
            {
                s8 = 0;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proverka = 1;
            Random random = new Random();
            for (int t = 0; t < 28; t++)
            {
                int aq = random.Next(1, 9);
                int dlina = random.Next(10, 100);
                int xx = random.Next(1, 800);
                int yy = random.Next(1, 400);
                int height = random.Next(10, 100);
                switch (aq)
                {
                    case 1:
                        figures[t] = new Circle(new TPoint(xx, yy), height, new Pen(Color.Bisque), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    case 2:
                        figures[t] = new Rectangle(new TPoint(xx, yy), dlina, height, new Pen(Color.DarkMagenta), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    case 3:
                        figures[t] = new Kolso(new TPoint(xx, yy), height, new Pen(Color.DimGray), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    case 4:
                        figures[t] = new Liner(new TPoint(xx, yy), xx + dlina, yy + height, new Pen(Color.Coral), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    case 5:
                        figures[t] = new HardFig(new TPoint(xx, yy), dlina, height, new Pen(Color.DarkGreen), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    case 6:
                        figures[t] = new Ellipse(new TPoint(xx, yy), dlina, height, new Pen(Color.DarkBlue), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    case 7:
                        figures[t] = new Romb(new TPoint(xx, yy), dlina, height, new Pen(Color.DarkGray), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    case 8:
                        figures[t] = new Trapeze(new TPoint(xx, yy), dlina, height, new Pen(Color.DarkGray), mbit);
                        figx[t] = xx;
                        figy[t] = yy;
                        figh[t] = height;
                        figl[t] = dlina;
                        break;
                    default:
                        break;
                }
            }
            MessageBox.Show("Контейнер создан!/n x= "+ pictureBox1.Width+" / n y = "+pictureBox1.Height);
        }

        private void стеретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proverka == 1)
            {
                Circle.Cleaning(mbit);
                Ellipse.Cleaning(mbit);
                Kolso.Cleaning(mbit);
                Rectangle.Cleaning(mbit);
                Romb.Cleaning(mbit);
                HardFig.Cleaning(mbit);
                Trapeze.Cleaning(mbit);
                for (int t = 0; t < 2; t++)
                {
                    figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                    pictureBox1.Image = mbit;
                }
            }
            else { MessageBox.Show("Создайте элементы."); }
        }

        private void уничтожитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proverka == 1)
            {
                Graphics gr = Graphics.FromImage(pictureBox1.Image);
                gr.Clear(Color.White);
                Circle.Cleaning(mbit);
                Ellipse.Cleaning(mbit);
                Kolso.Cleaning(mbit);
                Rectangle.Cleaning(mbit);
                Romb.Cleaning(mbit);
                HardFig.Cleaning(mbit);
                Trapeze.Cleaning(mbit);
                for (int t = 0; t < 28; t++)
                {
                    figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                    pictureBox1.Image = mbit;
                    figures[t] = null;
                    proverka = 0;
                }
                MessageBox.Show("Контейнер уничтожен!");
            }
            else { MessageBox.Show("Создайте элементы."); }
        }

        private void переместитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proverka == 1)
            {
                Graphics gr = Graphics.FromImage(pictureBox1.Image);
                gr.Clear(Color.White);
                Circle.Cleaning(mbit);
                Ellipse.Cleaning(mbit);
                Kolso.Cleaning(mbit);
                Rectangle.Cleaning(mbit);
                Romb.Cleaning(mbit);
                HardFig.Cleaning(mbit);
                Trapeze.Cleaning(mbit);
                for (int t = 0; t < 2; t++)
                {
                    figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                    pictureBox1.Image = mbit;
                }
                for (int t = 0; t < 28; t++)
                {
                    if (figures[t] is Romb)
                    {
                        if (2 * figl[t] + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - 2 * figl[t];
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + 2 * figh[t] > 500)
                        {
                            figy[t] = 500 - 2 * figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Rectangle)
                    {
                        if (figl[t] + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - figl[t];
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + figh[t] > 500)
                        {
                            figy[t] = 500 - figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Trapeze)
                    {
                        if (figl[t]+100 + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - figl[t]-100;
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + figh[t] > 500)
                        {
                            figy[t] = 500 - figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is HardFig)
                    {
                        if (figl[t] + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - figl[t];
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + figh[t] > 500)
                        {
                            figy[t] = 500 - figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Liner)
                    {
                        if (figl[t] + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - figl[t];
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + figh[t] > 500)
                        {
                            figy[t] = 500 - figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Circle)
                    {
                        if (figh[t] + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - figh[t];
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + figh[t] > 500)
                        {
                            figy[t] = 500 - figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figh[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Ellipse)
                    {
                        if (figl[t] + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - figl[t];
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + figh[t] > 500)
                        {
                            figy[t] = 500 - figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figh[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                    if (figures[t] is Kolso)
                    {
                        if (figh[t] + Convert.ToInt32(bx) > 900)
                        {
                            figx[t] = 900 - figh[t];
                        }
                        else figx[t] = Convert.ToInt32(bx);
                        if (Convert.ToInt32(by) + figh[t] > 500)
                        {
                            figy[t] = 500 - figh[t];
                        }
                        else figy[t] = Convert.ToInt32(by);
                        figures[t].Show(new TPoint(figx[t], figy[t]), figh[t], figh[t], new Pen(Color.Green), mbit);
                        pictureBox1.Image = mbit;
                    }
                }
            }
            else { MessageBox.Show("Создайте элементы."); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            by = textBox2.Text;
            try
            { int chislo = Convert.ToInt32(by); }
            catch
            { textBox2.Clear(); }
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proverka == 1)
            {
                Circle.Cleaning(mbit);
                Ellipse.Cleaning(mbit);
                Kolso.Cleaning(mbit);
                Rectangle.Cleaning(mbit);
                Romb.Cleaning(mbit);
                HardFig.Cleaning(mbit);
                Trapeze.Cleaning(mbit);
                for (int t = 0; t < 28; t++)
                {
                    figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.White), mbit);
                    pictureBox1.Image = mbit;
                }
                for (int t = 0; t < 28; t++)
                {
                    figures[t].Show(new TPoint(figx[t], figy[t]), figl[t], figh[t], new Pen(Color.Green), mbit);
                    pictureBox1.Image = mbit;
                }
            }
            else { MessageBox.Show("Создайте элементы."); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bx = textBox1.Text;
            try
            { int chislo = Convert.ToInt32(bx); }
            catch
            { textBox1.Clear(); }
        }
    }
}