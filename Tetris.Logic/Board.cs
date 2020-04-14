using System;

namespace Tetris.Logic
{
    public class Board
    {
        private Color[,] pieces;

        public Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public Color[,] Pieces { get; }

        public Color this[int x, int y]
        {
            get
            {
                return pieces[x, y];
            }
        }

        public Color this[Location location]
        {
            get
            {
                return this[location.X, location.Y];
            }
        }

        public bool IsOpenSpace(Location location)
        {
            if (location.X < 0 || location.X >= this.Width)
            {
                return false;
            }

            if (location.Y < 0 || location.Y >= this.Height)
            {
                return false;
            }

            return this[location] == Color.None;
        }

        public bool IsOpenSpace(int x, int y)
        {
            return IsOpenSpace(new Location { X = x, Y = y });
        }
    }
}
