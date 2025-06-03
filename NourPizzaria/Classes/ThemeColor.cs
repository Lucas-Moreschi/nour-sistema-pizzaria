using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NourPizzaria.Classes
{
    public static class ThemeColor
    {
        public static Color vermelhoDelicia { get; } = Color.FromArgb(255, 55, 55);
        public static Color amareloQueijo { get; } = Color.FromArgb(247, 220, 111);
        public static Color marromMassa { get; } = Color.FromArgb(150, 75, 0);
        public static Color verdeErvas { get; } = Color.FromArgb(62, 142, 65);
        public static Color brancoLeite { get; } = Color.FromArgb(255, 255, 255);
        public static Color cinzaForno { get; } = Color.FromArgb(245, 245, 245);
        public static Color pretoPimenta { get; } = Color.FromArgb(51, 51, 51);
        public static Color cinzaSal { get; } = Color.FromArgb(102, 102, 102);

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }


}
