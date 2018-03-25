using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    public class Texture
    {
        public Texture(int id, int width, int height)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
        }

        public int Id { get; private set; }

        public int Width { get; private set; }

        public int Height { get; private set; }
    }
}
