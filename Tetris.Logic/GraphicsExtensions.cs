using Tetris.Logic;

namespace Tetris.Graphics
{
    public static class GraphicsExtensions
    {
        public static void Draw(this IGraphics graphics, Board board)
        {
            for (int x = 0; x < board.Width; x++)
            {
                for (int y = 0; y < board.Height; y++)
                {
                    graphics.Draw(new Location { X = x, Y = y }, board.Pieces[x, y]);
                }
            }
        }
    }
}
