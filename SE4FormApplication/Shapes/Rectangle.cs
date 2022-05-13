﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE4FormApplication.Shapes
{
    class Rectangle : Shape
    {
        int width, height;
        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }


        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillRectangle(b, x, y, width, height);
            g.DrawRectangle(p, x, y, width, height);
        }
    }
}

