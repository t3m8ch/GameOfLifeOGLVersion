using System;

namespace GameOfLifeOpenGLVersion
{
    public class Color
    {
        public float Red { get; set; }
        public float Green { get; set; }
        public float Blue { get; set; }

        public Color(float red, float green, float blue)
        {
            if (red > 1 && red < 0)
                throw new ArgumentException($"Красный цвет не может быть больше 1 или меньше 0",
                    nameof(red));

            if (green > 1 && green < 0)
                throw new ArgumentException($"Зелёный цвет не может быть больше 1 или меньше 0",
                    nameof(green));

            if (blue > 1 && blue < 0)
                throw new ArgumentException($"Синий цвет не может быть больше 1 или меньше 0",
                    nameof(blue));

            Red = red;
            Green = green;
            Blue = blue;
        }

        internal void Deconstruct(out float red, out float green, out float blue)
        {
            red = Red;
            green = Green;
            blue = Blue;
        }
    }
}
