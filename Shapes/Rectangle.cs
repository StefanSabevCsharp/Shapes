using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Interfaces;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        int width;
        int height;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public void Draw()
        {
            DrawLine(Width, '*', '*');

            for (int i = 1; i < Height - 1; ++i)
            {
                DrawLine(Width, '*', ' ');
            }

            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
