using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF_FROGDEFENSE_APP
{
    class Map
    {

        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool OnMap(Point point)

        {
            return point.X >= 0 && point.X < Width &&
                point.Y >= 0 && point.Y < Height;
        }



    }
}
