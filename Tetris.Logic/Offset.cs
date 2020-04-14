namespace Tetris.Logic
{
    public struct Offset
    {
        public static readonly Offset Zero = new Offset { X = 0, Y = 0 };
        public static readonly Offset Left = new Offset { X = -1, Y = 0 };
        public static readonly Offset Right = new Offset { X = 1, Y = 0 };
        public static readonly Offset Up = new Offset { X = 0, Y = 1 };
        public static readonly Offset Down = new Offset { X = 0, Y = -1 };

        public int X;

        public int Y;

        public static Location operator +(Location location, Offset offset)
        {
            return new Location { X = location.X + offset.X, Y = location.Y + offset.Y };
        }
    }
}
