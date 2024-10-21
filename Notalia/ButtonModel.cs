﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notalia
{
    //This class is for the Button Models of the HomePage
    public class ButtonModel
    {
        public string Text { get; set; }
        public string HexColor { get; set; }

        public Color BackgroundColor
        {
            get
            {
                return Color.FromArgb(HexColor); // Converts the hex string to a Color
            }
        }
    }
}
