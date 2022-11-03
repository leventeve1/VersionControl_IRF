﻿using hatodik_beadando.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hatodik_beadando.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }

        public Present(Color colorRibbon, Color colorBox)
        {
            RibbonColor = new SolidBrush(colorRibbon);
            BoxColor = new SolidBrush(colorBox);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
        }
    }
}
